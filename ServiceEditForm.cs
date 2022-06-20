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
    public partial class ServiceEditForm : Form
    {
        BeautySalonEntities db = new BeautySalonEntities();
        Service service;
        string expansionImage;
        bool addPhoto = false;
        int id = 0;

        public ServiceEditForm(int service_id)
        {
            InitializeComponent();
            service = db.Service.Where(p => p.ID == service_id).FirstOrDefault();
            id = service_id;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServiceEditForm_Load(object sender, EventArgs e)
        {
            txtServName.Text = service.Title;
            txtxServCost.Text = Convert.ToString(service.Cost);
            txtServDuration.Text = Convert.ToString(service.DurationInSeconds);
            txtServDescription.Text = Convert.ToString(service.Description);
            txtServDiscount.Text = Convert.ToString(service.Discount);
            try
            {
                imgServPhoto.Image = new Bitmap(service.MainImagePath);
                imgServPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch { }
        }

        public string getFileExtension(string fileName) // Получение типа фотографии
        {
            return fileName.Substring(fileName.LastIndexOf(".") + 1);
        }

        private void btnSaveServ_Click(object sender, EventArgs e)
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
                Service service = db.Service.Where(p => p.ID == id).FirstOrDefault();
                string filePath;
                if (addPhoto)
                {
                    if (imgServPhoto.Image != null)
                    {
                        filePath = @"" + Guid.NewGuid() + "." + expansionImage;
                        imgServPhoto.Image.Save(filePath);
                    }
                    else
                        filePath = @"";
                }
                else filePath = service.MainImagePath;

                var title = db.Service.FirstOrDefault(a => a.Title == txtServName.Text);

                    service.Title = txtServName.Text;
                    service.Cost = Convert.ToDecimal(txtxServCost.Text);
                    service.DurationInSeconds = Convert.ToInt32(txtServDuration.Text);
                    service.Description = txtServDescription.Text;
                    service.Discount = Convert.ToDouble(txtServDiscount.Text);
                    service.MainImagePath = filePath;
            
                    db.SaveChanges();
                    BtnState.mainForm.UpdateTable();
                    MessageBox.Show("Изменения услуги сохранены!", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                   
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
                        addPhoto = true;
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
