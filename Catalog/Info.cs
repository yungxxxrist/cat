/**
* @file Info.cs
* @author Держин К.В., гр.525а
* @date 27.05.2021
* @brief Курсовая работа
*
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using DetailClasses;

namespace Catalog
{
    public partial class Info : Form
    {
        public Part P { get; set; } //запчасть для отображения на форме

        public Info()
        {
            InitializeComponent();
        }

        private void InfoLoad(object sender, EventArgs e)
        {
            PCountryVal.Text = P.Country;
            MnfVal.Text = P.Manufacturer;
            UnitVal.Text = P.Unit;
            NodeVal.Text = P.Node;
            PartVal.Text = P.Detail;
            VCountryVal.Text = P.Car.Country;
            BrandVal.Text = P.Car.Brand;
            ModelVal.Text = P.Car.Model;
            YearVal.Text = P.Car.Year.ToString();
            CheckInterchange.Checked = P.Interchangeability;
            if (CheckInterchange.Checked)
            {
                foreach (Vehicle v in P.Interchanges.To)
                    InterchangebleVehicles.Items.Add(v.Model);
            }
            PartPic.Image = new Bitmap(P.PicName + ".jpg");
        }
    }
}
