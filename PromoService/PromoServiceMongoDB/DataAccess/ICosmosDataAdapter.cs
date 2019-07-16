﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;
using PromoServiceMongoDB.Model;

namespace PromoServiceMongoDB.DataAccess
{
    public interface ICosmosDataAdapter
    {
      /*  Task<IEnumerable<ProductPromo>> Get();*/

       /* Task Add(string dbName, string name);*/

       /* Task<ProductPromo> Get(string id);*/



        Task<bool> CreateDocument(string v1, string v2, ProductPromo productpromo);
        Task<ProductPromo> DeleteUserAsync(string dbName, string name, string id);
        Task<dynamic> GetDataAsync(string dbName, string name);
        Task<FeedResponse<dynamic>> GetBy(string dbName, string name, string id);
        Task<bool> CreateAction(string v1, string v2, ProductPromoAction productpromoaction);
        
       // Task updateDocumentAsyncAction(string dbName, string name, ProductPromoAction productpromoaction);
        Task<bool> updateDocumentAsyncAction(string dbName, string name, ProductPromoAction productpromoaction);
        






        // Task<FeedResponse<dynamic>> GetDataAsync(string dbName, string name)



        /* Task<UserInfo> UpsertUserAsync(UserInfo user);

         Task<bool> CreateDatabase(string name);
         Task<bool> CreateCollection(string dbName, string name);
         Task<bool> CreateDocument(string dbName, string name, UserInfo userInfo);

         Task<bool> PlaceOrder(string dbName, string name, Order order);

         Task<dynamic> GetData(string dbName, string name);
         Task<UserInfo> DeleteUserAsync(string dbName, string name, string id);*/
    }
}
