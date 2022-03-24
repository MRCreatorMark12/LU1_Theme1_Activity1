using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ice1.Forms;

namespace Ice1
{
    public delegate void d_ParsedMessage(string message);
    public partial class Form1 : Form
    {
        private F_Response nextForm = new F_Response();
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            
        }



        Form1 f1;

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            f1 = this;
            nextForm.ParseMe(f1);
            nextForm.Show();
        }

        public void GetResponse(string message)
        {
            if (message != null || message == String.Empty)
                return;

            this.lbl_Answer.Text = message.ToString();
          
        }

        public void funData(string message)
        {
            this.lbl_Answer.Text = message;
        }
    }
}
