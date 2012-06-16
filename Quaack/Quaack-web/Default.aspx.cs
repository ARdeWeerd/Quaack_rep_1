using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Quaack_service.Service;
using Quaack_service.Service.impl;
using Quaack_domein.model;
using Quaack_web.Util;


namespace Quaack_web
{
    public partial class _Default : System.Web.UI.Page
    {
         protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ZoekButton_Click(object sender, EventArgs e)
        {
            List<Bericht> berichten = new List<Bericht>();
            try
            {
                
                berichten = ServiceUtil.getBerichtenService(Application).find(UserIdTextBox.Text);

                BerichtenService service = ServiceUtil.getBerichtenService(Application);
            }
            catch (ServiceException se)
            {
                this.Controls.Add(new LiteralControl("<BR>"));
                Label label = new Label();
                label.Text = se.Message;
                label.ForeColor = System.Drawing.Color.Red;
                this.Controls.Add(label);
            }
            BerichtenGridView.DataSource = berichten;
            BerichtenGridView.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<String> users = ServiceUtil.getProfielService(Application).findUsers(UserIdTextBox.Text);
            string tekst = "";
            foreach (string user in users)
            {
                tekst += user;
            }
            testProfielTextBox.Text = tekst;
        }
    }
}
