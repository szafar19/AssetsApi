using DataAccess.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssetsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssetsController : Controller
    {

        // GET: AssetsController
        [HttpGet(Name = "GetAssets")]
        public async Task<IResult> Get(IAssetData assetData)
        {
            try
            {
                return Results.Ok(await assetData.GetAssets());

            }catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        //[HttpGet("{id}")]
        //private async Task<IResult> GetAsset(IAssetData assetData, int id)
        //{
        //    try
        //    {
        //        return Results.Ok(await assetData.GetAsset(id));

        //    }
        //    catch (Exception ex)
        //    {
        //        return Results.Problem(ex.Message);
        //    }
        //}

    }
}
