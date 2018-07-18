using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Main : System.Web.UI.Page
{

    protected void chkDetailsView_CheckedChanged(object sender, EventArgs e)
    {
        if (chkDetailsView.Checked)
            dvPanel.Visible = true;
        else
            dvPanel.Visible = false;
    }

    protected void dvEmployees_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
    {
        gvSales.DataBind();//runs after item is removed from details view
        gvSummary.DataBind();//added to show how to update Summary Div after deletion of record from dvEmployees
    }

    protected void gvSales_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        gvSummary.DataBind();//refreshes summary grid view after a record is deleted from from gvSales
    }

    protected void gvSales_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        gvSummary.DataBind();//refreshes summary grid view after a record is updated
    }
}