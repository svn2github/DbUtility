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
namespace WongTung.Web.nocontrol
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
					ShowInfo();
				}
			}
		}
			
	private void ShowInfo()
	{
		WongTung.BLL.nocontrol bll=new WongTung.BLL.nocontrol();
		WongTung.Model.nocontrol model=bll.GetModel();
		this.txtNO_CO_CODE.Text=model.NO_CO_CODE;
		this.txtNO_CODE.Text=model.NO_CODE;
		this.txtNO_DESC.Text=model.NO_DESC;
		this.txtNO_STA_NO.Text=model.NO_STA_NO.ToString();
		this.txtNO_SEQ_NO.Text=model.NO_SEQ_NO.ToString();

	}

		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
	string strErr="";
	if(this.txtNO_CO_CODE.Text =="")
	{
		strErr+="NO_CO_CODE����Ϊ�գ�\\n";	
	}
	if(this.txtNO_CODE.Text =="")
	{
		strErr+="NO_CODE����Ϊ�գ�\\n";	
	}
	if(this.txtNO_DESC.Text =="")
	{
		strErr+="NO_DESC����Ϊ�գ�\\n";	
	}
	if(!PageValidate.IsDecimal(txtNO_STA_NO.Text))
	{
		strErr+="NO_STA_NO�������֣�\\n";	
	}
	if(!PageValidate.IsDecimal(txtNO_SEQ_NO.Text))
	{
		strErr+="NO_SEQ_NO�������֣�\\n";	
	}

	if(strErr!="")
	{
		MessageBox.Show(this,strErr);
		return;
	}
	string NO_CO_CODE=this.txtNO_CO_CODE.Text;
	string NO_CODE=this.txtNO_CODE.Text;
	string NO_DESC=this.txtNO_DESC.Text;
	decimal NO_STA_NO=decimal.Parse(this.txtNO_STA_NO.Text);
	decimal NO_SEQ_NO=decimal.Parse(this.txtNO_SEQ_NO.Text);


	WongTung.Model.nocontrol model=new WongTung.Model.nocontrol();
	model.NO_CO_CODE=NO_CO_CODE;
	model.NO_CODE=NO_CODE;
	model.NO_DESC=NO_DESC;
	model.NO_STA_NO=NO_STA_NO;
	model.NO_SEQ_NO=NO_SEQ_NO;

	WongTung.BLL.nocontrol bll=new WongTung.BLL.nocontrol();
	bll.Update(model);

		}

    }
}
