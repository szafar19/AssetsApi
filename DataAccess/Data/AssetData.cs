using DataAccess.DBAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class AssetData : IAssetData
    {
        private readonly ISqlDataAccess _db;

        public AssetData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<AssetsModel>> GetAssets() =>
           _db.LoadData<AssetsModel, dynamic>(storedProcedure: "dbo.spAssets_GetAll", new { });


        public async Task<AssetsModel?> GetAsset(int id)
        {
            var results = await _db.LoadData<AssetsModel, dynamic>(storedProcedure: "dbo.spAsset_Get", new { Id = id });
            return results.FirstOrDefault();
        }

        public Task InsertAsset(AssetsModel asset) =>
            _db.SaveData(storedProcedure: "spAsset_Insert", new { asset.Status, asset.Name });

        public Task UpdateAsset(AssetsModel asset) =>
            _db.SaveData(storedProcedure: "spAsset_Update", asset);

        public Task DeleteAsset(int id) =>
            _db.SaveData(storedProcedure: "spAsset_Delete", new { Id = id });

    }
}
