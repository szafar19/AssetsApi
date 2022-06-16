using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IAssetData
    {
        Task DeleteAsset(int id);
        Task<AssetsModel?> GetAsset(int id);
        Task<IEnumerable<AssetsModel>> GetAssets();
        Task InsertAsset(AssetsModel asset);
        Task UpdateAsset(AssetsModel asset);
    }
}