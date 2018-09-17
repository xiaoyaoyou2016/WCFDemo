using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class testapi : System.Web.UI.Page
    {
        protected static string ResultMsg;
        protected void Page_Load(object sender, EventArgs e)
        {
            ResultMsg = "";

            //WcfTest.SalesOptClient sc = new WcfTest.SalesOptClient();
            //sc.ClientCredentials.UserName.UserName = "fox";
            //sc.ClientCredentials.UserName.Password = "123456";

            //ResultMsg = Newtonsoft.Json.JsonConvert.SerializeObject(sc.GetData());

            //FoxCtrlTest.FoxCtrlClient sc = new FoxCtrlTest.FoxCtrlClient();
            //sc.ClientCredentials.UserName.UserName = "fox";
            //sc.ClientCredentials.UserName.Password = "123456";

            //ResultMsg = Newtonsoft.Json.JsonConvert.SerializeObject(sc.GetFoxData());

            //FoxServer.FoxCtrlClient sc = new FoxServer.FoxCtrlClient();
            //sc.ClientCredentials.UserName.UserName = "fox";
            //sc.ClientCredentials.UserName.Password = "123456";


            //ResultMsg ="FoxList：<br/>"+ Newtonsoft.Json.JsonConvert.SerializeObject(sc.GetFoxData());

            UserServer.UserCtrlClient uc = new UserServer.UserCtrlClient();
            uc.ClientCredentials.UserName.UserName = "fox";
            uc.ClientCredentials.UserName.Password = "123456";


            ResultMsg = "UserList：<br/>" + Newtonsoft.Json.JsonConvert.SerializeObject(uc.GetUserData());
        }
    }
}