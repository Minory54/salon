using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class CodeForm : Form
    {
        

        public CodeForm()
        {
            InitializeComponent();          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            CodeCheck();
        }

        public void CodeCheck() 
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Введите код!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (txtCode.Text == "0000")
                {
                    DataBank.btnState = true;
                    BtnState.mainForm.UpdateBtn();
                    MessageBox.Show("Режим администратора активирован!", "Активация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Введен не верный код!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
