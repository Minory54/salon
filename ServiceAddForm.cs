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
    public partial class ServiceAddForm : Form
    {

        BeautySalonEntities db = new BeautySalonEntities();
        string expansionImage;

        public ServiceAddForm()
        {
            InitializeComponent();
        }

        public string getFileExtension(string fileName) // Получение типа фотографии
        {
            return fileName.Substring(fileName.LastIndexOf(".") + 1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddServ_Click(object sender, EventArgs e)
        {

            if (txtServName.Text == "")
            {
                MessageBox.Show("Заполните поле Наименование!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtxServCost.Text == "")
            {
                MessageBox.Show("Заполните поле Стоимость!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtServDuration.Text == "")
            {
                MessageBox.Show("Заполните поле Длительность процедуры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(txtServDuration.Text) > 14400)
            {
                MessageBox.Show("Длительность процедуры не может привышать 4 часов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(txtServDuration.Text) < 0) 
            {
                MessageBox.Show("Длительность процедуры не может быть отрицательной", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string filePath;
                if (imgServPhoto.Image != null)
                {
                    filePath = @"" + Guid.NewGuid() + "." + expansionImage;
                    imgServPhoto.Image.Save(filePath);
                }
                else
                    filePath = @"";

                var title = db.Service.FirstOrDefault(a => a.Title == txtServName.Text);
                if (title == null)
                {
                    Service service = new Service
                    {
                        Title = txtServName.Text,
                        Cost = Convert.ToDecimal(txtxServCost.Text),
                        DurationInSeconds = Convert.ToInt32(txtServDuration.Text),
                        Description = txtServDescription.Text,                            
                        Discount = Convert.ToDouble(txtServDiscount.Text),
                        MainImagePath = filePath
                    };
                    service = db.Service.Add(service);
                    db.SaveChanges();
                    BtnState.mainForm.UpdateTable();
                    MessageBox.Show("Добавлена новая услуга!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такая услуга уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void ServiceAddForm_Load(object sender, EventArgs e)
        {
            txtServDiscount.Text = Convert.ToString(0);
        }

        private void btnAddServPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "File JPG|*.jpg|File png|*.png|All file |*.*";
                try
                {
                    if (openFile.ShowDialog(this) == DialogResult.OK)
                    {
                        imgServPhoto.Image = new Bitmap(openFile.FileName);
                        imgServPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                        expansionImage = getFileExtension(openFile.FileName);
                    }
                }
                catch
                {
                    MessageBox.Show("Данный файл не является графическим объектом!");
                }
            }
        }

        private void btnDelServPhoto_Click(object sender, EventArgs e)
        {
            imgServPhoto.Image = null;
        }
    }
}
