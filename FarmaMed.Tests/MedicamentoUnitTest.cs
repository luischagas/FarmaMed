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
    public class MedicamentoUnitTest
    {
        [TestMethod]
        public void Adicionar_Medicamento()
        {

            //Sintomas

            //9268ea3f-14e2-4c43-5be5-08d77bf30fd5 - Febre
            //8a10d392-fa3a-47bb-5be6-08d77bf30fd5 - Dor no corpo
            //96a6a8fb-1ab4-4738-5be7-08d77bf30fd5 - Dor de cabeça
            //bcdbeece-a420-4ea5-5be8-08d77bf30fd5 - Ânsia de vômito
            //83702003-2f4d-49bc-adce-08d77bfbff11 - Dor na barriga
            //9b02c8e5-e196-46f7-9b77-08d77d148cf0 - Dor na nuca

            var sintomas = new List<SintomaViewModel>();
            sintomas.Add(new SintomaViewModel { Id = Guid.Parse("bcdbeece-a420-4ea5-5be8-08d77bf30fd5") });
            sintomas.Add(new SintomaViewModel { Id = Guid.Parse("9b02c8e5-e196-46f7-9b77-08d77d148cf0") });


            var data = JsonConvert.SerializeObject(
                    new MedicamentoViewModel
                    {
                        Nome = "Deocil",
                        Preco = 5.00m,
                        Sintomas = sintomas
                    });

            var _httpClient = new HttpClient();
            var response = _httpClient.PostAsync("https://localhost:44362/api/medicamentos",
                new StringContent(data, Encoding.UTF8, "application/json")).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);

        }

        [TestMethod]
        public void Recuperar_Todos_Medicamentos()
        {
            var _httpClient = new HttpClient();
            var response = _httpClient.GetAsync("https://localhost:44362/api/medicamentos").Result;

            Debug.WriteLine(response.Content.ReadAsStringAsync().Result);

            Assert.IsTrue(response.IsSuccessStatusCode);
        }
    }
}
