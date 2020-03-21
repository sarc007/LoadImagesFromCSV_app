using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadImagesFromCSV_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectSourceFolder_Click(object sender, EventArgs e)
        {
            src_folder.ShowDialog();
            if (src_folder.SelectedPath.Length > 0 || Directory.Exists(txtbox_SourceFolderSelection.Text))
            {
                string[] csv_file_list;
                if (Directory.Exists(txtbox_SourceFolderSelection.Text))
                    csv_file_list =  Directory.GetFiles(txtbox_SourceFolderSelection.Text, "*.csv");
                else
                    csv_file_list = Directory.GetFiles(src_folder.SelectedPath, "*.csv");

                if (csv_file_list.Length > 0) {
                    if (! Directory.Exists(txtbox_SourceFolderSelection.Text))
                        txtbox_SourceFolderSelection.Text = src_folder.SelectedPath.ToString();
                    listBox_csv.Items.Clear();
                    progressBarControl2.Properties.Maximum = csv_file_list.Length;
                    progressBarControl2.Position = 0;
                    foreach (string fname in csv_file_list)
                    {
                        listBox_csv.Items.Add(fname);
                        progressBarControl2.PerformStep();
                    }

                    btnSelectDestinationFolder.Enabled = true;
                    txtbox_DestinationSelectedFolder.Enabled = true;
                    btnSelectSourceFolder.Enabled = false;
                    txtbox_SourceFolderSelection.Enabled = false;
                    progressBarControl2.Position = 0;
                    
                }
                else
                {
                    txtbox_SourceFolderSelection.Enabled = true;
                    txtbox_SourceFolderSelection.Text = "";
                    btnSelectSourceFolder.Enabled = true;
                    btnSelectDestinationFolder.Enabled = false;
                    btn_start_extracting_img_from_csv.Enabled = false;
                    MessageBox.Show("No CSV Files Found In The Folder, Select A Different Folder");
                    progressBarControl2.Position = 0;
                }
           
                
            }
        }

        private void btnSelectDestinationFolder_Click(object sender, EventArgs e)
        {
            dest_folder.ShowDialog();

            if (dest_folder.SelectedPath.Length > 0 || Directory.Exists(txtbox_DestinationSelectedFolder.Text))
            {
                if (! Directory.Exists(txtbox_DestinationSelectedFolder.Text))
                    txtbox_DestinationSelectedFolder.Text = dest_folder.SelectedPath.ToString();
                txtbox_DestinationSelectedFolder.Enabled = false;
                btnSelectSourceFolder.Enabled = false;
                btnSelectDestinationFolder.Enabled = false;
                btn_start_extracting_img_from_csv.Enabled = true;
            }
            else
            {
                txtbox_DestinationSelectedFolder.Text = "";
                txtbox_DestinationSelectedFolder.Enabled = true;
                btnSelectSourceFolder.Enabled = false;
                btnSelectDestinationFolder.Enabled = true;
                btn_start_extracting_img_from_csv.Enabled = false;

            }
        }

        private void btn_start_extracting_img_from_csv_Click(object sender, EventArgs e)
        {
            btn_start_extracting_img_from_csv.Enabled = false;
            string hexImgData;
            progressBarControl2.Properties.Maximum = listBox_csv.Items.Count+1;
            progressBarControl2.Position = 0;
            string savedfilename;
            Int64 i_counter = 1;
            Int64 j_counter = 1;
            listBox_img.Items.Clear();
            this.Refresh();
            progressBarControl2.PerformStep();
            try
            {
                foreach (string sfilepath in listBox_csv.Items)
                {
                    string[] lines = File.ReadAllLines(sfilepath);
                    progressBarControl1.Properties.Maximum = lines.Length;
                    progressBarControl1.Position = 0;
                    foreach (string line in lines)
                    //using (var rd = new StreamReader(sfilepath))
                    {

                        //  while (!rd.EndOfStream)
                        {
                            var splits = line.Split(',');
                            hexImgData = splits[3];
                            if (hexImgData.Length > 0)
                            {
                                Image patternImage;
                                // Call function to Convert the hex data to byte array
                                //byte[] newByte = ToByteArray(hexImgData);
                                byte[] newByte = HexString2Bytes(hexImgData);
                                //string i2Path = "c:\\img.jpg";
                                using (var ms = new MemoryStream(newByte))
                                {
                                    patternImage = new Bitmap(ms);
                                    // File.WriteAllText(i2Path, "empty");
                                    savedfilename = txtbox_DestinationSelectedFolder.Text.Trim()+ "\\veh_img_" + string.Format(String.Format("{0,10:0000000000}", j_counter)) + ".jpg";
                                    patternImage.Save(savedfilename, ImageFormat.Jpeg);
                                }
                                listBox_img.Items.Add(savedfilename);
                                //progressBarControl1.PerformStep();
                                j_counter++;

                            }
                            hexImgData = splits[4];
                            if (hexImgData.Length > 0)
                            {
                                Image patternImage;
                                // Call function to Convert the hex data to byte array
                                //byte[] newByte = ToByteArray(hexImgData);
                                byte[] newByte1 = HexString2Bytes(hexImgData);
                                //string i2Path = "c:\\img.jpg";
                                using (var ms = new MemoryStream(newByte1))
                                {

                                    patternImage = new Bitmap(ms);
                                    // File.WriteAllText(i2Path, "empty");
                                    savedfilename = txtbox_DestinationSelectedFolder.Text.Trim() + "\\lpn_img_" + string.Format(String.Format("{0,10:0000000000}", i_counter)) + ".jpg";
                                    patternImage.Save(savedfilename, ImageFormat.Jpeg);
                                }
                                listBox_img.Items.Add(savedfilename);
                                i_counter++;


                            }
                            this.listBox_img.Refresh();
                            this.Refresh();
                            progressBarControl1.PerformStep();


                        }
                        
                    }
                    this.Refresh();
                    progressBarControl2.PerformStep();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                txtbox_SourceFolderSelection.Enabled = true;
                txtbox_DestinationSelectedFolder.Enabled = false;
                btnSelectSourceFolder.Enabled = true;
                btnSelectDestinationFolder.Enabled = false;
                btn_start_extracting_img_from_csv.Enabled = false;
                progressBarControl2.Position = 0;
                progressBarControl1.Position = 0;
            }

        }
        public static byte[] ToByteArray(String HexString)
        {
            int NumberChars = HexString.Length;

            byte[] bytes = new byte[NumberChars / 2];

            for (int i = 0; i < NumberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(HexString.Substring(i, 2), 16);
            }
            return bytes;
        }
        private static byte[] HexString2Bytes(string hexString)
        {
            int bytesCount = (hexString.Length) / 2;
            byte[] bytes = new byte[bytesCount];
            for (int x = 0; x < bytesCount; ++x)
            {
                bytes[x] = Convert.ToByte(hexString.Substring(x * 2, 2), 16);
            }

            return bytes;
        }

        private static string Bytes2HexString(byte[] buffer)
        {
            var hex = new StringBuilder(buffer.Length * 2);
            foreach (byte b in buffer)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }
    }
}
