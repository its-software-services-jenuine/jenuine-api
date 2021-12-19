using Xunit;
using Its.Jenuiue.Api.Controllers;

namespace Its.Jenuiue.Api.Assets
{
    public class AssetControllersTest
    {
        private AssetsController ac;

        //private IDatabase mydatabase;
        //private readonly IAssetsService service;
        //private readonly IMapper mapper;
        
        [Fact]
        public void SetOrgidTest()
        {
            //AssetsController myser = new AssetsController(service,mapper);
            ac = new AssetsController(null, null);
        }
/*        
        [Fact]
        public void AssetServiceScenarioTest()
        {
            //string orgId = "AssetServiceScenarioTest";

            var db = DBUtils.CreateMockedMongoDb<MAsset>();

            var svc = new AssetsController(service,mapper);
            

            var q = new QueryParam()
            {
                Limit = 0,
                Offset = 0
            };

            var p = new MAsset();
            svc.GetAssets("console-test");
            svc.GetAssetById("console-test","61a5c9cb6a4f4b0a4041355a");
            svc.GetAssetsCount("console-test");
            
            var lbl = new Label()
            {
                Name = "name",
                Value = "value"
            };
            MVAsset asset = new MVAsset();
            var m = svc.AddAsset("console-test",asset);
            //m.Labels.Add(lbl);
            svc.UpdateAssetById("console-test","61a5c9cb6a4f4b0a4041355a",asset);
            svc.UpdateAssetRegisterFlagById("console-test","61a5c9cb6a4f4b0a4041355a",asset);
            svc.DeleteAssetById("console-test","61a5c9cb6a4f4b0a4041355a");
        }
*/        
    }
}

