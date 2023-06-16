using MauiApp1.Models;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public class KullaniciService : IKullaniciService
    {   
        private string uri = "https://localhost:7148";
        
        public async Task<string> Login_Kullanici(TBL_KULLANICI login_kullanici)
        {
            string returnStr = string.Empty;
            using (var client = new HttpClient())
            {
                var url = $"{uri}{API.Login_Kullanici}";
                string json = JsonConvert.SerializeObject(login_kullanici);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage = await client.PostAsync(url, content);
          

                if (responseMessage.IsSuccessStatusCode)
                {
                    returnStr = await responseMessage.Content.ReadAsStringAsync();
                }
            }
            return returnStr;
        }

        public async Task<(bool IsSuccess, string ErrorMessage)> New_Kullanici(TBL_NEW_KULLANICI new_kullanici)
        {
            string errorMessage = string.Empty;
            bool isSuccess = false;
            using (var http = new HttpClient())
            {
                var url = $"{uri}{API.New_Kullanici}";
                var str = JsonConvert.SerializeObject(new_kullanici);
                var response = await http.PostAsync(url, new StringContent(str, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                   isSuccess = true;
                }
                else
                {
                    errorMessage = await response.Content.ReadAsStringAsync();
                }
            }
            return (isSuccess, errorMessage);
        }



    }
}
        
    

