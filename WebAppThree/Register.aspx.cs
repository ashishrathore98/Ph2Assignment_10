using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebAppThree
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblMsg.Visible = false;
            }
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Registration Success!!";
            LblMsg.Text += "<br/>Name: " + TxtName.Text;
            LblMsg.Text += "<br/>Password: " + TxtPwd.Text;
            LblMsg.Text += "<br/>Email: " + TxtEmail.Text;
            LblMsg.Text += "<br/>PinCode: " + TxtPinCode.Text;
            LblMsg.Text += "<br/>Age: " + TxtAge.Text;
            LblMsg.Text += "<br/>Date of Joining: " + CalDOJ.SelectedDate;
        }
    }
}