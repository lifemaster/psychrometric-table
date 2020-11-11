using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PsychrometricTable
{
    public partial class PsychrometricTableForm : Form
    {
        private Dictionary<int, double> SaturatedWaterVaporElasticityDictionary = new Dictionary<int, double>
        {
            { -10, 2.862 }, { -9, 3.097 }, { -8, 3.348 }, { -7, 3.617 }, { -6, 3.906 },
            { -5, 4.214 }, { -4, 4.544 }, { -3, 4.897 }, { -2, 5.275 }, { -1, 5.677 }, { 0, 6.107 },
            { 1, 6.565 }, { 2, 7.054 }, { 3, 7.574 }, { 4, 8.128 }, { 5, 8.718 },
            { 6, 9.345 }, { 7, 10.012 }, { 8, 10.720 }, { 9, 11.472 }, { 10, 12.771 },
            { 11, 13.118 }, { 12, 14.015 }, { 13, 14.967 }, { 14, 15.975 }, { 15, 17.042 },
            { 16, 18.171 }, { 17, 19.365 }, { 18, 20.628 }, { 19, 21.962 }, { 20, 23.371 },
            { 21, 24.858 }, { 22, 26.428 }, { 23, 28.083 }, { 24, 29.829 }, { 25, 31.668 },
            { 26, 33.606 }, { 27, 35.646 }, { 28, 37.793 }, { 29, 40.052 }, { 30, 42.427 },
            { 31, 44.924 }, { 32, 47.548 }, { 33, 50.303 }, { 34, 53.196 }, { 35, 56.233 },
            { 36, 59.418 }, { 37, 62.758 }, { 38, 66.260 }, { 39, 69.930 }, { 40, 73.773 }
        };

        public PsychrometricTableForm()
        {
            InitializeComponent();

            InitializeDryThermometerComboboxDataSource();
            InitializeWetThermometerComboboxDataSource();
            InitializeAirPressureComboboxDataSource();
        }

        private void InitializeDryThermometerComboboxDataSource()
        {
            List<ComboItem> dryThermometerComboboxDataSource = new List<ComboItem> { };

            for (int i = 0; i <= 40; i++)
            {
                dryThermometerComboboxDataSource.Add(new ComboItem { Value = i, Text = i.ToString() });
            }

            dryThermometerCombobox.DataSource = dryThermometerComboboxDataSource;
            dryThermometerCombobox.SelectedIndex = 20;
            dryThermometerCombobox.DisplayMember = "Text";
            dryThermometerCombobox.ValueMember = "Value";
        }

        private void InitializeWetThermometerComboboxDataSource()
        {
            List<ComboItem> wetThermometerComboboxDataSource = new List<ComboItem> { };
            int dryThermometerValue = Int32.Parse(dryThermometerCombobox.SelectedValue.ToString());

            for (int i = dryThermometerValue; i >= dryThermometerValue - 10; i--)
            {
                wetThermometerComboboxDataSource.Add(new ComboItem { Value = i, Text = i.ToString() });
            }

            wetThermometerCombobox.DataSource = wetThermometerComboboxDataSource;
            wetThermometerCombobox.DisplayMember = "Text";
            wetThermometerCombobox.ValueMember = "Value";
        }

        private void InitializeAirPressureComboboxDataSource()
        {
            List<ComboItem> airPressureComboboxDataSource = new List<ComboItem> { };

            for (int i = 720; i <=790; i++)
            {
                airPressureComboboxDataSource.Add(new ComboItem { Value = i, Text = i.ToString() });
            }

            airPressureCombobox.DataSource = airPressureComboboxDataSource;
            airPressureCombobox.SelectedIndex = 40;
            airPressureCombobox.DisplayMember = "Text";
            airPressureCombobox.ValueMember = "Value";
        }

        private void DryThermometerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(dryThermometerCombobox.SelectedValue.ToString(), out int dryThermometerTemperature))
            {
                return;
            }

            List<ComboItem> wetThermometerComboboxDataSource = new List<ComboItem> { };

            for (int i = dryThermometerTemperature; i >= (dryThermometerTemperature - 10); i--)
            {
                wetThermometerComboboxDataSource.Add(new ComboItem { Value = i, Text = i.ToString() });
            }

            wetThermometerCombobox.DataSource = wetThermometerComboboxDataSource;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int dryTemperature = Int32.Parse(dryThermometerCombobox.SelectedValue.ToString());
            int wetTemperature = Int32.Parse(wetThermometerCombobox.SelectedValue.ToString());
            double airPressure = Int32.Parse(airPressureCombobox.SelectedValue.ToString());

            double saturatedWaterVaporElasticityForWetThermometerValue = this.SaturatedWaterVaporElasticityDictionary[wetTemperature];
            double saturatedWaterVaporElasticityForDryThermometerValue = this.SaturatedWaterVaporElasticityDictionary[dryTemperature];

            double waterVaporPressure = saturatedWaterVaporElasticityForWetThermometerValue - 7.947e-4 * (dryTemperature - wetTemperature) * airPressure * 1.33322;

            double relativeHumidity = (waterVaporPressure / saturatedWaterVaporElasticityForDryThermometerValue) * 100;
            double roudedRelativeHumidity = Math.Round(relativeHumidity * 100) / 100;

            string resultText = $"Относительная влажность воздуха: {roudedRelativeHumidity} %";

            MessageBox.Show(resultText, "Результаты расчета", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
