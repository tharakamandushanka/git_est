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
    public partial class EmployeLoging  :Form

        
    {
        

        public EmployeLoging()
        {
            InitializeComponent();
        }
       

        private void Logbtn_Click(object sender, EventArgs e, Form1 form1)
        {
            string index, password;

           
          
             index = indexTexBox.Text;
             password = PasswordtextBox.Text;

                int val;
            
            if(index == "1234")
            {
                if(password == "12345")
                {
                    val = 1;
                    form1.displaypanel(val);
                     Close();
                }
                 else
                 {
                    MessageBox.Show("cant loging");
                       
                }
            }
            else
             {
                  MessageBox.Show("cant loging");
             }

        }
    }
}
