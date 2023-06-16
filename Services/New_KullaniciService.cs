//using MauiApp1.Models;
//using Newtonsoft.Json;
//using SQLite;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.Json.Serialization;
//using System.Threading.Tasks;

//namespace MauiApp1.Services
//{
//    public class New_KullaniciService : INew_KullaniciService
//    {
//        private SQLiteAsyncConnection _dbConn;
//        public New_KullaniciService()
//        {
//            SetupDb();
//        }

//        private async void SetupDb()
//        {
//            if(_dbConn == null)
//            {
//                string _dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder
//                    .LocalApplicationData), "Game.db");
//                _dbConn = new SQLiteAsyncConnection (_dbPath);
//                await _dbConn.CreateTableAsync<TBL_NEW_KULLANICI>();
//            }
//        }
//        public async Task<int> AddKullanici(TBL_NEW_KULLANICI _kullanici)
//        {
//          return await _dbConn.InsertAsync(_kullanici);
//        }

//        public async Task<int> DeleteKullanici(TBL_NEW_KULLANICI _kullanici)
//        {
//            return await _dbConn.DeleteAsync(_kullanici);
//        }
//        public async Task<int> UpdateKullanici(TBL_NEW_KULLANICI _kullanici)
//        {
//            return await _dbConn.UpdateAsync(_kullanici);
//        }

//        public async Task<List<TBL_NEW_KULLANICI>> GetAllKullanici()
//        {
//           return await _dbConn.Table<TBL_NEW_KULLANICI>().ToListAsync();
//        }

//        public async Task<TBL_NEW_KULLANICI> GetKullaniciByID(int ID)
//        {
//            //var kullanici = await _dbConn.QueryAsync<TBL_KULLANICI>($"Select * From{nameof(TBL_KULLANICI)} where ID={ID}");
//            var kullanici = await _dbConn.Table<TBL_NEW_KULLANICI>().Where(x => x.ID == ID).ToListAsync();
//            return kullanici.FirstOrDefault();
//        }

        
//    } 
//}
