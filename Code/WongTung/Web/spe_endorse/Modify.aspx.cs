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
using LTP.Common;
namespace WongTung.Web.spe_endorse
{
    public partial class Modify : System.Web.UI.Page
    {       

        		protected void Page_LoadComplete(object sender, EventArgs e)
		{
			(Master.FindControl("lblTitle") as Label).Text = "��Ϣ�޸�";
		}
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null || Request.Params["id"].Trim() != "")
				{
					string id = Request.Params["id"];
					//ShowInfo(SPE_CODE);
				}
			}
		}
			
	private void ShowInfo(string SPE_CODE)
	{
		WongTung.BLL.spe_endorse bll=new WongTung.BLL.spe_endorse();
		WongTung.Model.spe_endorse model=bll.GetModel(SPE_CODE);
		this.lblSPE_CODE.Text=model.SPE_CODE;
		this.txtSPE_CRE_EMP.Text=model.SPE_CRE_EMP;
		this.txtSPE_CRE_DATE.Text=model.SPE_CRE_DATE.ToString();

	}

		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
	string strErr="";
	if(this.txtSPE_CRE_EMP.Text =="")
	{
		strErr+="SPE_CRE_EMP����Ϊ�գ�\\n";	
	}
	if(!PageValidate.IsDateTime(txtSPE_CRE_DATE.Text))
	{
		strErr+="SPE_CRE_DATE����ʱ���ʽ��\\n";	
	}

	if(strErr!="")
	{
		MessageBox.Show(this,strErr);
		return;
	}
	string SPE_CRE_EMP=this.txtSPE_CRE_EMP.Text;
	DateTime SPE_CRE_DATE=DateTime.Parse(this.txtSPE_CRE_DATE.Text);


	WongTung.Model.spe_endorse model=new WongTung.Model.spe_endorse();
	model.SPE_CRE_EMP=SPE_CRE_EMP;
	model.SPE_CRE_DATE=SPE_CRE_DATE;

	WongTung.BLL.spe_endorse bll=new WongTung.BLL.spe_endorse();
	bll.Update(model);

		}

    }
}
