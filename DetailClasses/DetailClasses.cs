/**
* @file DetailClasses.cs
* @author Держин К.В., гр.525а
* @date 27.05.2021
* @brief Курсовая работа
*
*/
using System.Collections.Generic;

namespace DetailClasses
{
    public class Part
    {
        public Part()
        {

        }

        public Part(string country, string man, string unit, string node, string detail, string picname, bool change, Vehicle veh, Interchange inter)
        {
            Country = country;
            Manufacturer = man;
            Unit = unit;
            Node = node;
            Detail = detail;
            PicName = picname;
            Interchangeability = change;
            Car = veh;
            Interchanges = inter;
        }

        public string Country { get; set; }                 //Страна производитель

        public string Manufacturer { get; set; }            //Производитель

        public string Unit { get; set; }                    //Агрегат детали

        public string Node { get; set; }                    //Узел

        public string Detail { get; set; }                  //Деталь

        public string PicName { get; set; }                 //Название изображения

        public bool Interchangeability { get; set; }        //Наличие взаимозамеямости

        public Vehicle Car { get; set; }                    //Машина

        public Interchange Interchanges { get; set; }       //Взаимозаменяемость

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Part p = (Part)obj;
                if (Country.Equals(p.Country) && Manufacturer.Equals(p.Manufacturer) && Unit.Equals(p.Unit)
                    && Node.Equals(p.Node) && Detail.Equals(p.Detail) && PicName.Equals(p.PicName)
                    && Interchangeability.Equals(p.Interchangeability) && Car.Equals(p.Car) && Interchanges.Equals(p.Interchanges))
                    return true;
                else return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class Vehicle
    {
        public Vehicle() { }

        public Vehicle(string country, string brand, string model, uint year)
        {
            Country = country;
            Brand = brand;
            Model = model;
            Year = year;
        }

        public string Country { get; set; }     //Страна производитель

        public string Brand { get; set; }       //Марка

        public string Model { get; set; }       //Модель

        public uint Year { get; set; }          //Год производства

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Vehicle v = (Vehicle)obj;
                if (Country.Equals(v.Country) && Brand.Equals(v.Brand) && Model.Equals(v.Model) && Year.Equals(v.Year))
                    return true;
                else return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class Interchange
    {
        public Vehicle From { get; set; }

        public List<Vehicle> To { get; set; }

        public Interchange()
        {

        }

        public Interchange(Vehicle from, List<Vehicle> to)
        {
            From = from;
            To = to;
        }

        public void ChangeFrom(Vehicle Item)
        {
            From = Item;
        }

        public void AddTo(Vehicle Item)
        {
            To.Add(Item);
        }

        public void DeleteAt(int index)
        {
            To.RemoveAt(index);
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Interchange i = (Interchange)obj;
                if (From.Equals(i.From))
                    return true;
                else return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
