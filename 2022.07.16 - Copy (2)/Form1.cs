namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private object  a;
        public Form1()
        {
            InitializeComponent();
        }
        
        public void loadform(object Form)
        {
            a = Form;
            if (this.DisplayPanel.Controls.Count > 0)
                this.DisplayPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.DisplayPanel.Controls.Add(f);
            this.DisplayPanel.Tag = f;
            f.Show();


        }
        public void displaypanel(int a)
        {
            //throw new NotImplementedException();

            if (a == 1)
            { 
                panel1.Visible = true; 
            }
               
            else
            {
                panel1.Visible = false;
            }

            
           

        }

       

        public void unloadform(object Form)
        {
            Form f = Form as Form;
            f.Close();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Backbtn.Visible = false;
        }
        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backbtn.Visible = true;
            loadform(new User_Dashboard());
        }

        

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Backbtn.Visible = true;
            loadform(new Home());
        }

        private void PRObtn_Click(object sender, EventArgs e)
        {
            Backbtn.Visible = true;
            loadform(new Profile());
        }

        private void Salbtn_Click(object sender, EventArgs e)
        {
            Backbtn.Visible = true;
            loadform(new Salary());
        }

        private void Reqlbtn_Click(object sender, EventArgs e)
        {  
            Backbtn.Visible = true;
            loadform(new Request_Leave());
        }

        private void WorkCalbtn_Click(object sender, EventArgs e)
        { 
            Backbtn.Visible = true;    
            loadform(new Working_Calender());
        }

        private void RepPbtn_Click(object sender, EventArgs e)
        {   
            Backbtn.Visible = true;
            loadform(new Report_Problem());
        }

        private void Aboutbtn_Click(object sender, EventArgs e)
        {
            Backbtn.Visible = true;
            loadform(new About());
        }

       private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Admingloging_Click(object sender, EventArgs e)
        {
            Backbtn.Visible = true;
            loadform(new AdmingLoging());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Employebtn_Click_1(object sender, EventArgs e)
        {
            Backbtn.Visible = true;
            loadform(new EmployeLoging());
        }

        private void Registerbtn_Click_1(object sender, EventArgs e)
        {
            Backbtn.Visible = true;
            loadform(new Register());
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            unloadform(a);
            Backbtn.Visible = false;
        }

        private void Maxbtn_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Minbtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            //Visible = false;
        }
    }
}