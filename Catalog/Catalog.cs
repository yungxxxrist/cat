/**
* @file Catalog.cs
* @author Держин К.В., гр.525а
* @date 27.05.2021
* @brief Курсовая работа
*
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Methods;
using DetailClasses;

namespace Catalog
{
    public partial class Catalog : Form
    {
        List<Part> Collection = new List<Part>();           //каталог всех запчастей

        List<Part> ChoosedParts = new List<Part>();         //запчасти для выбранного авто

        List<Vehicle> AllVehicles = new List<Vehicle>();    //все доступные машины

        List<Vehicle> ChoosedCars = new List<Vehicle>();    //выбранные пользователем машины

        public Catalog()
        {
            InitializeComponent();
        }

        private List<Bitmap> FormImages(List<string> list)
        {
            List<Bitmap> images = new List<Bitmap>();
            foreach(string item in list)
            {
                images.Add(new Bitmap(item + ".jpg"));
            }
            return images;
        }

        private void PartsChooseNodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text != "Двигатель" && e.Node.Text != "Трансмиссия" && e.Node.Text != "Подвеска")
            {
                ChoosedParts = FindMethods.FindDetails(Collection, ChoosedCars);
                ChoosedParts = FindMethods.FindDetails(ChoosedParts, e.Node.Text);
                AddItemsToCatalog(FindMethods.FindDetails(ChoosedParts, e.Node.Text));
            }

        }

        private void AddItemsToInterList(List<Part> list)
        {
            InterPartsList.Rows.Clear();
            foreach (Part p in list)
               if (p.Interchangeability)
                    for (int i = 0; i < p.Interchanges.To.Count; i++) 
                        InterPartsList.Rows.Add(p.Unit, p.Node, p.Detail, p.Interchanges.From.Brand + " " 
                            + p.Interchanges.From.Model, p.Interchanges.To[i].Brand + " " + p.Interchanges.To[i].Model);
        }

        private void AddItemsToCatalog(List<Part> list)
        {
            View.Clear();
            imageList2.Images.Clear();
            imageList2.Images.AddRange(FormImages(FormMethods.FormPicNameList(list)).ToArray());
            View.SmallImageList = imageList2;
            for (int i = 0; i < list.Count; i++)
            {
                View.Items.Add(new ListViewItem(list[i].Detail, i));
            }
        }

        private void ViewItemActivate(object sender, EventArgs e)
        {
            ListView l = (ListView)sender;
            Info f = new Info();
            f.P = ChoosedParts[l.FocusedItem.Index];
            f.ShowDialog();
        }

        private void FindDetailTextChanged(object sender, EventArgs e)
        {
            ChoosedParts = FindMethods.FindDetails(Collection, ChoosedCars);
            ChoosedParts = FindMethods.FindDetails(ChoosedParts, FindDetail.Text);
            AddItemsToCatalog(FindMethods.FindDetails(ChoosedParts, FindDetail.Text));
        }

        private void CarClick(object sender, EventArgs e)
        {
            ChoosedParts = FindMethods.FindDetails(Collection, ChoosedCars);
            AddItemsToInterList(ChoosedParts);
            Pages.TabPages[1].Text = "Список взаимозаменяемых деталей для " + ChoosedCars[0].Brand + " " + ChoosedCars[0].Model;
            FindDetail.Enabled = true;
            PartsChoose.Enabled = true;
            ChoosseCarButton.Enabled = false;
            CarModels.Enabled = false;
        }

        private void InitializeBrands(List<Vehicle> list)
        {
            foreach (Vehicle v in list)
            {
                if(!CarBrands.Items.Contains(v.Brand))
                    CarBrands.Items.Add(v.Brand);
            }
        }

        private void CatalogLoad(object sender, EventArgs e)
        {
            try
            {
                XmlMethods.Deserialize(out Collection);
                XmlMethods.Deserialize(out AllVehicles);
                ChoosedParts = new List<Part>(Collection);
                InitializeBrands(AllVehicles);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void CarBrandsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarBrands.SelectedIndex != -1)
            {
                View.Items.Clear();
                PartsChoose.Enabled = false;
                FindDetail.Enabled = false;
                ChoosseCarButton.Enabled = false;
                CarModels.Items.Clear();
                string s = CarBrands.SelectedItem.ToString();
                CarModels.Items.AddRange(FormMethods.FormModelsList(AllVehicles, s).ToArray());
                ChoosedCars = FindMethods.FindModels(AllVehicles, s);
                CarModels.Enabled = true;
            }
        }

        private void CarModelsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarBrands.SelectedIndex != -1)
            {
                string s = CarModels.SelectedItem.ToString();
                ChoosedCars = FindMethods.FindCars(ChoosedCars, s);
                ChoosseCarButton.Enabled = true;
            }
        }

        private void ManualButtonClick(object sender, EventArgs e)
        {
            Manual f = new Manual();
            f.ShowDialog();
        }
    }
}
