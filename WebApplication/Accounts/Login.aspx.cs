using PNI.Model;
using PNI.Services;
using PNI.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        private UserServices _service;
        protected void Page_Load(object sender, EventArgs e)
        {
            _service = new UserServices();
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}