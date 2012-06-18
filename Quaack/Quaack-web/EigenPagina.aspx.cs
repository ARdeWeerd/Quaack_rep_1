using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Quaack_service.Service;
using Quaack_service.Service.impl;
using Quaack_domein.model;

namespace Quaack_web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gvMessages_Load(object sender, EventArgs e)
        {
            BerichtenService bs = BerichtenServiceImpl.Instance;
            List<Bericht> berichten = bs.find(this.User.Identity.Name);
            gvMessages.DataSource = berichten;
            gvMessages.DataBind();
        }

        protected void gvMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Getting the index of the selected row.
            int index = gvMessages.SelectedIndex;
            List<Bericht> lijst = (List<Bericht>) gvMessages.DataSource;
            Bericht bericht = lijst[index];
        }

    }
}