using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
       

            private void Register_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            if(Email.Text.Length ==0)
            {
                string pattren = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (!Regex.IsMatch(Email.Text,pattren))
                {
                    MessageBox.Show("invalide email adderss","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("valide email adderss", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
