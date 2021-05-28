/**
* @file Tests.cs
* @author Держин К.В., гр.525а
* @date 27.05.2021
* @brief Курсовая работа
*
*/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailClasses;
using Methods;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void MODELS_FORMING_TEST()
        {
            //Arrange
            List<Vehicle> v = new List<Vehicle>
            {
                new Vehicle("Страна","Acura","RDX",1990),
                new Vehicle("Страна","Acura","MDX",1990),
                new Vehicle("Страна","Acura","RL",1990),
                new Vehicle("Страна","Renault","Clio",1990),
                new Vehicle("Страна","BMW","X5",1990)
            };
            string brand = "Acura";
            List<string> expected = new List<string> { "RDX", "MDX", "RL" };
            //Act
            List<string> actual = FormMethods.FormModelsList(v, brand);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IMAGES_FORMING_TEST()
        {
            //Arrange
            Vehicle v = new Vehicle("Страна", "Марка", "Модель", 1990);
            List<Part> p = new List<Part>
            {
                new Part("Страна","Производитель","Агрегат","Узел","Деталь", "Поршень", false, v, new Interchange() ),
                new Part("Страна","Производитель","Агрегат","Узел","Деталь", "Ступица", false, v, new Interchange() ),
                new Part("Страна","Производитель","Агрегат","Узел","Деталь", "Сайлентблок", false, v, new Interchange() ),
                new Part("Страна","Производитель","Агрегат","Узел","Деталь", "Поршень", false, v, new Interchange() ),
                new Part("Страна","Производитель","Агрегат","Узел","Деталь", "Ступица", false, v, new Interchange() )
            };
            List<string> expected = new List<string> { "Поршень", "Ступица", "Сайлентблок", "Поршень", "Ступица" };
            //Act
            List<string> actual = FormMethods.FormPicNameList(p);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FIND_DETAILS_BY_NAME_TEST()
        {
            //Arrange
            Vehicle v = new Vehicle("Страна", "Марка", "Модель", 1990);
            List<Part> p = new List<Part>
            {
                new Part("Страна","Производитель","Агрегат","Узел","Поршень", "Картинка", false, v, new Interchange(v,new List<Vehicle>{ v,v}) ),
                new Part("Страна","Производитель","Агрегат","Узел","Ступица", "Картинка", false, v, new Interchange(v,new List<Vehicle>{ v,v}) ),
                new Part("Страна","Производитель","Агрегат","Узел","Сайлентблок", "Картинка", false, v, new Interchange(v,new List<Vehicle>{ v,v}) ),
                new Part("Страна1","Производитель1","Агрегат1","Узел1","Поршень", "Картинка1", false, v, new Interchange(v,new List<Vehicle>{ v,v}) ),
                new Part("Страна2","Производитель2","Агрегат2","Узел2","Поршень", "Картинка2", false, v, new Interchange(v,new List<Vehicle>{ v,v}) )
            };
            string detail = "Поршень";
            List<Part> expected = new List<Part> {
                new Part("Страна","Производитель","Агрегат","Узел","Поршень", "Картинка", false, v, new Interchange(v,new List<Vehicle>{ v,v}) ),
                new Part("Страна1","Производитель1","Агрегат1","Узел1","Поршень", "Картинка1", false, v, new Interchange(v,new List<Vehicle>{ v,v}) ),
                new Part("Страна2","Производитель2","Агрегат2","Узел2","Поршень", "Картинка2", false, v, new Interchange(v,new List<Vehicle>{ v,v}) )
            };
            //Act
            List<Part> actual = FindMethods.FindDetails(p, detail);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FIND_CARS_TEST()
        {
            //Arrange
            List<Vehicle> l = new List<Vehicle>
            {
                new Vehicle("Страна", "Марка", "Модель", 1990),
                new Vehicle("Страна1", "Марка1", "Модель1", 1990),
                new Vehicle("Страна2", "Марка2", "Модель2", 1990),
                new Vehicle("Страна3", "Марка3", "Модель3", 1990),
                new Vehicle("Страна3", "Марка3", "Модель3", 1995),
            };
            string model = "Модель3";
            List<Vehicle> expected = new List<Vehicle>
            { new Vehicle("Страна3", "Марка3", "Модель3", 1990),
              new Vehicle("Страна3", "Марка3", "Модель3", 1995), };
            //Act
            List<Vehicle> actual = FindMethods.FindCars(l, model);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FIND_MODELS_TEST()
        {
            //Arrange
            List<Vehicle> l = new List<Vehicle>
            {
                new Vehicle("Страна", "Марка", "Модель", 1990),
                new Vehicle("Страна1", "Марка1", "Модель1", 1990),
                new Vehicle("Страна2", "Марка3", "Модель2", 1990),
                new Vehicle("Страна3", "Марка3", "Модель3", 1990),
                new Vehicle("Страна4", "Марка3", "Модель4", 1990)
            };
            string brand = "Марка3";
            List<Vehicle> expected = new List<Vehicle>
            {
                new Vehicle("Страна2", "Марка3", "Модель2", 1990),
                new Vehicle("Страна3", "Марка3", "Модель3", 1990),
                new Vehicle("Страна4", "Марка3", "Модель4", 1990)
            };
            //Act
            List<Vehicle> actual = FindMethods.FindModels(l, brand);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
