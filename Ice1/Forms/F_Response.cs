using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ice1.Forms
{
    public partial class F_Response : Form
    {

        Form1 f1;
        public F_Response()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
           
        }

        public void ParseMe(Form1 parsedBy)
        {
            f1 = parsedBy;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_MyInput.Text == String.Empty)
                return;

            if (f1 == null)
                return;

            d_ParsedMessage message = new d_ParsedMessage(f1.funData);
            message(this.tb_MyInput.Text.ToString());


        }

       
    }
}
