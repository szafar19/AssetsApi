using DataAccess.Data;
using DataAccess.Models;

namespace AssetsApi
{
    public static class AssetsApi
    {
        public static void ConfigureApi(this WebApplication app)
        {
            app.MapGet(pattern: "/Assets", GetAssets);
            app.MapGet(pattern: "/Assets/{id}", GetAsset);
            app.MapPost(pattern: "/Assets", InsertAsset);
            app.MapPut(pattern: "/Assets", UpdateAsset);
            app.MapDelete(pattern: "/Assets", DeleteAsset);

        }

        private static async Task<IResult> GetAssets(IAssetData assetsData)
        {
            try
            {
                return Results.Ok(await assetsData.GetAssets());

            }catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetAsset(IAssetData assetsData, int id)
        {
            try
            {
                var result = await assetsData.GetAsset(id);
                if (result == null) return Results.NotFound();
                return Results.Ok(result);

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertAsset(IAssetData assetData, AssetsModel asset)
        {
            try
            {
                await assetData.InsertAsset(asset);
                return Results.Ok();
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateAsset(AssetsModel asset, IAssetData assetData)
        {
            try
            {
                await assetData.UpdateAsset(asset);
                return Results.Ok();

            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteAsset(int id, IAssetData assetData)
        {
            try
            {
                await assetData.DeleteAsset(id);
                return Results.Ok();

            }catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
