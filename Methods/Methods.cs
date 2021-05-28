/**
* @file Methods.cs
* @author Держин К.В., гр.525а
* @date 27.05.2021
* @brief Курсовая работа
*
*/
using System;
using System.Collections.Generic;
using System.Linq;
using DetailClasses;
using System.IO;
using System.Xml.Serialization;

namespace Methods
{
    public static class FormMethods
    {
        static FormMethods() { }

        public static List<string> FormModelsList(List<Vehicle> list, string brand)
        {
            List<string> Models = new List<string>();
            List<Vehicle> l = list.FindAll(p => p.Brand.Equals(brand, StringComparison.CurrentCultureIgnoreCase));
            foreach (Vehicle v in l)
            {
                Models.Add(v.Model);
            }
            return Models.Distinct().ToList();
        }

        public static List<string> FormPicNameList(List<Part> list)
        {
            List<string> picnames = new List<string>();
            foreach (Part p in list)
            {
                picnames.Add(p.PicName);
            }
            return picnames;
        }
    }

    public static class FindMethods
    {
        static FindMethods() { }

        public static List<Part> FindDetails(List<Part> list, string name)
        {
            return list.FindAll(p => p.Detail.Equals(name, StringComparison.CurrentCultureIgnoreCase));
        }

        public static List<Part> FindDetails(List<Part> list, List<Vehicle> choosed)
        {
            List<Part> l = new List<Part>();
            for (int i = 0; i < choosed.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].Car.Model.Equals(choosed[i].Model) && list[j].Car.Brand.Equals(choosed[i].Brand))
                        l.Add(list[j]);
                }
            }
            return l;
        }

        public static List<Vehicle> FindCars(List<Vehicle> list, string model)
        {
            return list.FindAll(p => p.Model.Equals(model, StringComparison.CurrentCultureIgnoreCase));
        }

        public static List<Vehicle> FindModels(List<Vehicle> list, string brand)
        {
            return list.FindAll(p => p.Brand.Equals(brand, StringComparison.CurrentCultureIgnoreCase));
        }
    }

    public static class XmlMethods
    {
        static XmlMethods() {}

        public static void Deserialize(out List<Part> list)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Part>));
            using (FileStream fs = new FileStream("Parts.xml", FileMode.OpenOrCreate))
            {
                list = (List<Part>)formatter.Deserialize(fs);
            }
        }

        public static void Deserialize(out List<Vehicle> list)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Vehicle>));
            using (FileStream fs = new FileStream("Vehicles.xml", FileMode.OpenOrCreate))
            {
                list = (List<Vehicle>)formatter.Deserialize(fs);
            }
        }

        public static void Serialize(List<Part> list)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Part>));
            using (FileStream fs = new FileStream("Parts.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }


    }
}
