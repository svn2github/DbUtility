using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace WongTung.Web.workstage
{
    public partial class Show : System.Web.UI.Page
    {        
        		protected void Page_LoadComplete(object sender, EventArgs e)
		{
			(Master.FindControl("lblTitle") as Label).Text = "��ϸ��Ϣ";
		}
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null || Request.Params["id"].Trim() != "")
				{
					string id = Request.Params["id"];
					//ShowInfo(WT_CODE);
				}
			}
		}
		
	private void ShowInfo(string WT_CODE)
	{
		WongTung.BLL.workstage bll=new WongTung.BLL.workstage();
		WongTung.Model.workstage model=bll.GetModel(WT_CODE);
		this.lblWT_CO_CODE.Text=model.WT_CO_CODE;
		this.lblWT_DESC.Text=model.WT_DESC;
		this.lblWT_DESC_T.Text=model.WT_DESC_T;
		this.lblWT_DESC_S.Text=model.WT_DESC_S;

	}


    }
}
