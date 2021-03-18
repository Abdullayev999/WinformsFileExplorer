using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Create : Form
    {
        public string CreatName { get; set; }
        public Create()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                labelError.Visible = true;
            }
            else
            {
                labelError.Visible = false;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                DialogResult = DialogResult.OK;
                CreatName = textBoxName.Text;
                this.Close();
            }
        }
    }
}
