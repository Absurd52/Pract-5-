namespace Pract
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtNumberOfPresets;
        private System.Windows.Forms.TextBox txtBatteryCapacity;
        private System.Windows.Forms.TextBox txtScreenSize;
        private System.Windows.Forms.TextBox txtScreenResolution;
        private System.Windows.Forms.TextBox txtTypeOfMatrix;
        private System.Windows.Forms.TextBox txtRamSize;
        private System.Windows.Forms.Button btnCreateRAD;
        private System.Windows.Forms.Button btnCreateTV;
        private System.Windows.Forms.Button btnCreateAVT;
        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblNumberOfPresets;
        private System.Windows.Forms.Label lblBatteryCapacity;
        private System.Windows.Forms.Label lblScreenSize;
        private System.Windows.Forms.Label lblScreenResolution;
        private System.Windows.Forms.Label lblTypeOfMatrix;
        private System.Windows.Forms.Label lblRamSize;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtModel = new TextBox();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            txtYear = new TextBox();
            txtNumberOfPresets = new TextBox();
            txtBatteryCapacity = new TextBox();
            txtScreenSize = new TextBox();
            txtScreenResolution = new TextBox();
            txtTypeOfMatrix = new TextBox();
            txtRamSize = new TextBox();
            btnCreateRAD = new Button();
            btnCreateTV = new Button();
            btnCreateAVT = new Button();
            lstDevices = new ListBox();
            lblModel = new Label();
            lblManufacturer = new Label();
            lblPrice = new Label();
            lblYear = new Label();
            lblNumberOfPresets = new Label();
            lblBatteryCapacity = new Label();
            lblScreenSize = new Label();
            lblScreenResolution = new Label();
            lblTypeOfMatrix = new Label();
            lblRamSize = new Label();
            SuspendLayout();
            // 
            // txtModel
            // 
            txtModel.Location = new Point(149, 19);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(200, 23);
            txtModel.TabIndex = 0;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(149, 49);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(200, 23);
            txtManufacturer.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(149, 79);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(149, 109);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(200, 23);
            txtYear.TabIndex = 3;
            // 
            // txtNumberOfPresets
            // 
            txtNumberOfPresets.Location = new Point(149, 139);
            txtNumberOfPresets.Name = "txtNumberOfPresets";
            txtNumberOfPresets.Size = new Size(200, 23);
            txtNumberOfPresets.TabIndex = 4;
            // 
            // txtBatteryCapacity
            // 
            txtBatteryCapacity.Location = new Point(149, 169);
            txtBatteryCapacity.Name = "txtBatteryCapacity";
            txtBatteryCapacity.Size = new Size(200, 23);
            txtBatteryCapacity.TabIndex = 5;
            // 
            // txtScreenSize
            // 
            txtScreenSize.Location = new Point(149, 199);
            txtScreenSize.Name = "txtScreenSize";
            txtScreenSize.Size = new Size(200, 23);
            txtScreenSize.TabIndex = 6;
            // 
            // txtScreenResolution
            // 
            txtScreenResolution.Location = new Point(149, 229);
            txtScreenResolution.Name = "txtScreenResolution";
            txtScreenResolution.Size = new Size(200, 23);
            txtScreenResolution.TabIndex = 7;
            // 
            // txtTypeOfMatrix
            // 
            txtTypeOfMatrix.Location = new Point(149, 259);
            txtTypeOfMatrix.Name = "txtTypeOfMatrix";
            txtTypeOfMatrix.Size = new Size(200, 23);
            txtTypeOfMatrix.TabIndex = 8;
            // 
            // txtRamSize
            // 
            txtRamSize.Location = new Point(149, 289);
            txtRamSize.Name = "txtRamSize";
            txtRamSize.Size = new Size(200, 23);
            txtRamSize.TabIndex = 9;
            // 
            // btnCreateRAD
            // 
            btnCreateRAD.Location = new Point(364, 19);
            btnCreateRAD.Name = "btnCreateRAD";
            btnCreateRAD.Size = new Size(185, 30);
            btnCreateRAD.TabIndex = 10;
            btnCreateRAD.Text = "Создать Радиоприёмник";
            btnCreateRAD.UseVisualStyleBackColor = true;
            btnCreateRAD.Click += btnCreateRAD_Click;
            // 
            // btnCreateTV
            // 
            btnCreateTV.Location = new Point(364, 59);
            btnCreateTV.Name = "btnCreateTV";
            btnCreateTV.Size = new Size(185, 30);
            btnCreateTV.TabIndex = 11;
            btnCreateTV.Text = "Создать Телевизор";
            btnCreateTV.UseVisualStyleBackColor = true;
            btnCreateTV.Click += btnCreateTV_Click;
            // 
            // btnCreateAVT
            // 
            btnCreateAVT.Location = new Point(364, 99);
            btnCreateAVT.Name = "btnCreateAVT";
            btnCreateAVT.Size = new Size(185, 30);
            btnCreateAVT.TabIndex = 12;
            btnCreateAVT.Text = "Создать Аудио-видеотехнику";
            btnCreateAVT.UseVisualStyleBackColor = true;
            btnCreateAVT.Click += btnCreateAVT_Click;
            // 
            // lstDevices
            // 
            lstDevices.FormattingEnabled = true;
            lstDevices.HorizontalScrollbar = true;
            lstDevices.ItemHeight = 15;
            lstDevices.Location = new Point(20, 319);
            lstDevices.Name = "lstDevices";
            lstDevices.Size = new Size(529, 169);
            lstDevices.TabIndex = 14;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(20, 23);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(50, 15);
            lblModel.TabIndex = 15;
            lblModel.Text = "Модель";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(20, 53);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(92, 15);
            lblManufacturer.TabIndex = 16;
            lblManufacturer.Text = "Производитель";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 83);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(35, 15);
            lblPrice.TabIndex = 17;
            lblPrice.Text = "Цена";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(20, 113);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(26, 15);
            lblYear.TabIndex = 18;
            lblYear.Text = "Год";
            // 
            // lblNumberOfPresets
            // 
            lblNumberOfPresets.AutoSize = true;
            lblNumberOfPresets.Location = new Point(20, 143);
            lblNumberOfPresets.Name = "lblNumberOfPresets";
            lblNumberOfPresets.Size = new Size(91, 15);
            lblNumberOfPresets.TabIndex = 19;
            lblNumberOfPresets.Text = "Предустановки";
            // 
            // lblBatteryCapacity
            // 
            lblBatteryCapacity.AutoSize = true;
            lblBatteryCapacity.Location = new Point(20, 173);
            lblBatteryCapacity.Name = "lblBatteryCapacity";
            lblBatteryCapacity.Size = new Size(80, 15);
            lblBatteryCapacity.TabIndex = 20;
            lblBatteryCapacity.Text = "Аккумулятор";
            // 
            // lblScreenSize
            // 
            lblScreenSize.AutoSize = true;
            lblScreenSize.Location = new Point(20, 203);
            lblScreenSize.Name = "lblScreenSize";
            lblScreenSize.Size = new Size(88, 15);
            lblScreenSize.TabIndex = 21;
            lblScreenSize.Text = "Размер экрана";
            // 
            // lblScreenResolution
            // 
            lblScreenResolution.AutoSize = true;
            lblScreenResolution.Location = new Point(20, 233);
            lblScreenResolution.Name = "lblScreenResolution";
            lblScreenResolution.Size = new Size(116, 15);
            lblScreenResolution.TabIndex = 22;
            lblScreenResolution.Text = "Разрешение экрана";
            // 
            // lblTypeOfMatrix
            // 
            lblTypeOfMatrix.AutoSize = true;
            lblTypeOfMatrix.Location = new Point(20, 263);
            lblTypeOfMatrix.Name = "lblTypeOfMatrix";
            lblTypeOfMatrix.Size = new Size(80, 15);
            lblTypeOfMatrix.TabIndex = 23;
            lblTypeOfMatrix.Text = "Тип матрицы";
            // 
            // lblRamSize
            // 
            lblRamSize.AutoSize = true;
            lblRamSize.Location = new Point(20, 293);
            lblRamSize.Name = "lblRamSize";
            lblRamSize.Size = new Size(121, 15);
            lblRamSize.TabIndex = 24;
            lblRamSize.Text = "Оперативная память";
            // 
            // Form1
            // 
            ClientSize = new Size(567, 500);
            Controls.Add(lblRamSize);
            Controls.Add(lblTypeOfMatrix);
            Controls.Add(lblScreenResolution);
            Controls.Add(lblScreenSize);
            Controls.Add(lblBatteryCapacity);
            Controls.Add(lblNumberOfPresets);
            Controls.Add(lblYear);
            Controls.Add(lblPrice);
            Controls.Add(lblManufacturer);
            Controls.Add(lblModel);
            Controls.Add(lstDevices);
            Controls.Add(btnCreateAVT);
            Controls.Add(btnCreateTV);
            Controls.Add(btnCreateRAD);
            Controls.Add(txtRamSize);
            Controls.Add(txtTypeOfMatrix);
            Controls.Add(txtScreenResolution);
            Controls.Add(txtScreenSize);
            Controls.Add(txtBatteryCapacity);
            Controls.Add(txtNumberOfPresets);
            Controls.Add(txtYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtModel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
