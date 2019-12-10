using FarmaMed.API.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;

namespace FarmaMed.Tests
{
    [TestClass]
    public class SintomaUnitTest
    {
        [TestMethod]
        public void Adicionar_Sintoma()
        {


            var data = JsonConvert.SerializeObject(
                    new SintomaViewModel
                    {
                        Descricao = "Dor na Nuca",
                    });

            var _httpClient = new HttpClient();
            var response = _httpClient.PostAsync("https://localhost:44362/api/sintomas",
                new StringContent(data, Encoding.UTF8, "application/json")).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);

        }

        [TestMethod]
        public void Recuperar_Todos_Sintomas()
        {
            var _httpClient = new HttpClient();
            var response = _httpClient.GetAsync("https://localhost:44362/api/sintomas").Result;

            Debug.WriteLine(response.Content.ReadAsStringAsync().Result);

            Assert.IsTrue(response.IsSuccessStatusCode);
        }
    }
}
