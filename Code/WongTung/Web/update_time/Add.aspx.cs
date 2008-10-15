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
namespace WongTung.Web.update_time
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        		protected void Page_LoadComplete(object sender, EventArgs e)
		{
			(Master.FindControl("lblTitle") as Label).Text = "��Ϣ���";
		}
		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
	string strErr="";
	if(!PageValidate.IsDateTime(txtUT_DATE.Text))
	{
	strErr+="UT_DATE����ʱ���ʽ��\\n";	
	}
	if(this.txtUT_TIME.Text =="")
	{
		strErr+="UT_TIME����Ϊ�գ�\\n";	
	}
	if(!PageValidate.IsNumber(txtUT_FRE.Text))
	{
		strErr+="UT_FRE�������֣�\\n";	
	}
	if(this.txtUT_UPDATE_USER.Text =="")
	{
		strErr+="UT_UPDATE_USER����Ϊ�գ�\\n";	
	}
	if(!PageValidate.IsDateTime(txtUT_UPDATE_DT.Text))
	{
	strErr+="UT_UPDATE_DT����ʱ���ʽ��\\n";	
	}
	if(this.txtUT_INF.Text =="")
	{
		strErr+="UT_INF����Ϊ�գ�\\n";	
	}

	if(strErr!="")
	{
		MessageBox.Show(this,strErr);
		return;
	}
	DateTime UT_DATE=DateTime.Parse(this.txtUT_DATE.Text);
	string UT_TIME=this.txtUT_TIME.Text;
	int UT_FRE=int.Parse(this.txtUT_FRE.Text);
	string UT_UPDATE_USER=this.txtUT_UPDATE_USER.Text;
	DateTime UT_UPDATE_DT=DateTime.Parse(this.txtUT_UPDATE_DT.Text);
	string UT_INF=this.txtUT_INF.Text;

	WongTung.Model.update_time model=new WongTung.Model.update_time();
	model.UT_DATE=UT_DATE;
	model.UT_TIME=UT_TIME;
	model.UT_FRE=UT_FRE;
	model.UT_UPDATE_USER=UT_UPDATE_USER;
	model.UT_UPDATE_DT=UT_UPDATE_DT;
	model.UT_INF=UT_INF;

	WongTung.BLL.update_time bll=new WongTung.BLL.update_time();
	bll.Add(model);

		}

    }
}
