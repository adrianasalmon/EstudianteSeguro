using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using ApiSecCureStudent.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UtEstudianteSeguro.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetStudent()
        {
            //Arrange
            StudentsController studentsController = new StudentsController();

            //Act
            var ListaEstudiante = studentsController.GetStudents();

            //Assert
            Assert.IsNotNull(ListaEstudiante);
        }
    }
}
