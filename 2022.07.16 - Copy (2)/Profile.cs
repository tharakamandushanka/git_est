using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profilepicture_Click(object sender, EventArgs e)
        {

        }

        private void PhotoUploadbtn_Click(object sender, EventArgs e)
        {

            String photopath;
            byte[] binaryphoto;

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg|*.jpg|jpegs|*.jpegs|png|*.png|GIf|*.Gif|Bitmap|*.Bitmap";
                dialog.Title = "please Select Image";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Profilepicture.Image = new Bitmap(dialog.OpenFile());
                    photopath = dialog.FileName;
                    FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    binaryphoto = br.ReadBytes((int)fs.Length);
                    fs.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occurd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
