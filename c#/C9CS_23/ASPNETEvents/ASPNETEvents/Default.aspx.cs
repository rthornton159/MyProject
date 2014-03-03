using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETEvents
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button3.Click += new EventHandler(Button3_Click);
        }

        void Button3_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Label1.Text = "Hi from Button3";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Hello world!";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "Hello from Button2";
        }
    }
}
