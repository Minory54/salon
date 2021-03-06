namespace BeautySalon
{
    partial class ServiceAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddServ = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtxServCost = new System.Windows.Forms.TextBox();
            this.MiddleLab = new System.Windows.Forms.Label();
            this.txtServDuration = new System.Windows.Forms.TextBox();
            this.LastNameLab = new System.Windows.Forms.Label();
            this.txtServName = new System.Windows.Forms.TextBox();
            this.txtServDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddServPhoto = new System.Windows.Forms.Button();
            this.imgServPhoto = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelServPhoto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgServPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnAddServ);
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 48);
            this.panel1.TabIndex = 1;
            // 
            // btnAddServ
            // 
            this.btnAddServ.BackColor = System.Drawing.Color.White;
            this.btnAddServ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddServ.FlatAppearance.BorderSize = 2;
            this.btnAddServ.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddServ.Location = new System.Drawing.Point(174, 5);
            this.btnAddServ.Name = "btnAddServ";
            this.btnAddServ.Size = new System.Drawing.Size(237, 38);
            this.btnAddServ.TabIndex = 42;
            this.btnAddServ.Text = "Добавить";
            this.btnAddServ.UseVisualStyleBackColor = false;
            this.btnAddServ.Click += new System.EventHandler(this.btnAddServ_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.topPanel.Controls.Add(this.btnBack);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(584, 48);
            this.topPanel.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(497, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(192, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление услуги";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Стоимость:";
            // 
            // txtxServCost
            // 
            this.txtxServCost.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtxServCost.Location = new System.Drawing.Point(12, 149);
            this.txtxServCost.Name = "txtxServCost";
            this.txtxServCost.Size = new System.Drawing.Size(240, 31);
            this.txtxServCost.TabIndex = 27;
            this.txtxServCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MiddleLab
            // 
            this.MiddleLab.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleLab.Location = new System.Drawing.Point(12, 189);
            this.MiddleLab.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.MiddleLab.Name = "MiddleLab";
            this.MiddleLab.Size = new System.Drawing.Size(240, 22);
            this.MiddleLab.TabIndex = 26;
            this.MiddleLab.Text = "Длительность (сек.):";
            // 
            // txtServDuration
            // 
            this.txtServDuration.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServDuration.Location = new System.Drawing.Point(12, 214);
            this.txtServDuration.Name = "txtServDuration";
            this.txtServDuration.Size = new System.Drawing.Size(240, 31);
            this.txtServDuration.TabIndex = 25;
            this.txtServDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastNameLab
            // 
            this.LastNameLab.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLab.Location = new System.Drawing.Point(12, 59);
            this.LastNameLab.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.LastNameLab.Name = "LastNameLab";
            this.LastNameLab.Size = new System.Drawing.Size(240, 22);
            this.LastNameLab.TabIndex = 24;
            this.LastNameLab.Text = "Наименование:";
            // 
            // txtServName
            // 
            this.txtServName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServName.Location = new System.Drawing.Point(12, 84);
            this.txtServName.Name = "txtServName";
            this.txtServName.Size = new System.Drawing.Size(240, 31);
            this.txtServName.TabIndex = 23;
            this.txtServName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtServDescription
            // 
            this.txtServDescription.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServDescription.Location = new System.Drawing.Point(12, 279);
            this.txtServDescription.Name = "txtServDescription";
            this.txtServDescription.Size = new System.Drawing.Size(240, 31);
            this.txtServDescription.TabIndex = 25;
            this.txtServDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Описание:";
            // 
            // txtServDiscount
            // 
            this.txtServDiscount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServDiscount.Location = new System.Drawing.Point(12, 343);
            this.txtServDiscount.Name = "txtServDiscount";
            this.txtServDiscount.Size = new System.Drawing.Size(240, 31);
            this.txtServDiscount.TabIndex = 25;
            this.txtServDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Скидка:";
            // 
            // btnAddServPhoto
            // 
            this.btnAddServPhoto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddServPhoto.Location = new System.Drawing.Point(332, 230);
            this.btnAddServPhoto.Name = "btnAddServPhoto";
            this.btnAddServPhoto.Size = new System.Drawing.Size(240, 32);
            this.btnAddServPhoto.TabIndex = 41;
            this.btnAddServPhoto.Text = "Добавить фото";
            this.btnAddServPhoto.UseVisualStyleBackColor = true;
            this.btnAddServPhoto.Click += new System.EventHandler(this.btnAddServPhoto_Click);
            // 
            // imgServPhoto
            // 
            this.imgServPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgServPhoto.Location = new System.Drawing.Point(332, 84);
            this.imgServPhoto.Name = "imgServPhoto";
            this.imgServPhoto.Size = new System.Drawing.Size(240, 140);
            this.imgServPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgServPhoto.TabIndex = 40;
            this.imgServPhoto.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(332, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Фотография:";
            // 
            // btnDelServPhoto
            // 
            this.btnDelServPhoto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelServPhoto.Location = new System.Drawing.Point(332, 268);
            this.btnDelServPhoto.Name = "btnDelServPhoto";
            this.btnDelServPhoto.Size = new System.Drawing.Size(240, 32);
            this.btnDelServPhoto.TabIndex = 41;
            this.btnDelServPhoto.Text = "Удалить фото";
            this.btnDelServPhoto.UseVisualStyleBackColor = true;
            this.btnDelServPhoto.Click += new System.EventHandler(this.btnDelServPhoto_Click);
            // 
            // ServiceAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelServPhoto);
            this.Controls.Add(this.btnAddServPhoto);
            this.Controls.Add(this.imgServPhoto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtxServCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MiddleLab);
            this.Controls.Add(this.txtServDiscount);
            this.Controls.Add(this.txtServDescription);
            this.Controls.Add(this.txtServDuration);
            this.Controls.Add(this.LastNameLab);
            this.Controls.Add(this.txtServName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServiceAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление услуги";
            this.Load += new System.EventHandler(this.ServiceAddForm_Load);
            this.panel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgServPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtxServCost;
        private System.Windows.Forms.Label MiddleLab;
        private System.Windows.Forms.TextBox txtServDuration;
        private System.Windows.Forms.Label LastNameLab;
        private System.Windows.Forms.TextBox txtServName;
        private System.Windows.Forms.TextBox txtServDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddServ;
        private System.Windows.Forms.Button btnAddServPhoto;
        private System.Windows.Forms.PictureBox imgServPhoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelServPhoto;
    }
}