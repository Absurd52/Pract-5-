using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace Pract
{
    public partial class Form1 : Form
    {
        private List<AVT> devices = new List<AVT>();
        private List<RAD> rADs = new List<RAD>();
        private List<TV> tVs = new List<TV>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateRAD_Click(object sender, EventArgs e)
        {
            try
            {
                RAD rad = new RAD(
                    model: txtModel.Text,
                    manufacturer: txtManufacturer.Text,
                    price: double.Parse(txtPrice.Text),
                    year: int.Parse(txtYear.Text),
                    numberOfPresets: double.Parse(txtNumberOfPresets.Text),
                    batteryCapacity: int.Parse(txtBatteryCapacity.Text)
                );

                devices.Add(rad);
                ShowDevices();
                MessageBox.Show("Радиоприёмник добавлен успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btnCreateTV_Click(object sender, EventArgs e)
        {
            try
            {
                TV tv = new TV(
                    model: txtModel.Text,
                    manufacturer: txtManufacturer.Text,
                    price: double.Parse(txtPrice.Text),
                    year: int.Parse(txtYear.Text),
                    screenSize: double.Parse(txtScreenSize.Text),
                    screenResolution: txtScreenResolution.Text,
                    typeOfMatrix: txtTypeOfMatrix.Text,
                    ramSize: int.Parse(txtRamSize.Text)
                );

                devices.Add(tv);
                ShowDevices();
                MessageBox.Show("Телевизор добавлен успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btnCreateAVT_Click(object sender, EventArgs e)
        {
            try
            {
                AVT avt = new AVT(
                    model: txtModel.Text,
                    manufacturer: txtManufacturer.Text,
                    price: double.Parse(txtPrice.Text),
                    year: int.Parse(txtYear.Text)
                );

                devices.Add(avt);
                ShowDevices();
                MessageBox.Show("Аудио-видеотехника добавлена успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btnShowDevices_Click(object sender, EventArgs e)
        {
            ShowDevices();
        }

        private void ShowDevices()
        {
            lstDevices.Items.Clear();
            foreach (var device in devices)
            {
                lstDevices.Items.Add(device.ToString());
            }
        }
    }
}
