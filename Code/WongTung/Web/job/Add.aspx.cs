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
namespace WongTung.Web.job
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
	if(this.txtJOB_CO_CODE.Text =="")
	{
		strErr+="JOB_CO_CODE����Ϊ�գ�\\n";	
	}
	if(this.txtJOB_NAME.Text =="")
	{
		strErr+="JOB_NAME����Ϊ�գ�\\n";	
	}
	if(!PageValidate.IsDecimal(txtJOB_CON.Text))
	{
		strErr+="JOB_CON�������֣�\\n";	
	}
	if(!PageValidate.IsDecimal(txtJOB_OPEN_BAL_HOUR.Text))
	{
		strErr+="JOB_OPEN_BAL_HOUR�������֣�\\n";	
	}
	if(!PageValidate.IsDecimal(txtJOB_YTD_HOUR.Text))
	{
		strErr+="JOB_YTD_HOUR�������֣�\\n";	
	}
	if(!PageValidate.IsDecimal(txtJOB_OPEN_BAL_AMT.Text))
	{
		strErr+="JOB_OPEN_BAL_AMT�������֣�\\n";	
	}
	if(!PageValidate.IsDecimal(txtJOB_YTD_AMT.Text))
	{
		strErr+="JOB_YTD_AMT�������֣�\\n";	
	}
	if(!PageValidate.IsDecimal(txtJOB_REC.Text))
	{
		strErr+="JOB_REC�������֣�\\n";	
	}
	if(!PageValidate.IsDecimal(txtJOB_OS_BAL.Text))
	{
		strErr+="JOB_OS_BAL�������֣�\\n";	
	}
	if(!PageValidate.IsDecimal(txtJOB_BUD_HOUR.Text))
	{
		strErr+="JOB_BUD_HOUR�������֣�\\n";	
	}
	if(!PageValidate.IsNumber(txtJOB_CO_ORD.Text))
	{
		strErr+="JOB_CO_ORD�������֣�\\n";	
	}
	if(!PageValidate.IsNumber(txtJOB_ADMIN.Text))
	{
		strErr+="JOB_ADMIN�������֣�\\n";	
	}
	if(!PageValidate.IsNumber(txtJOB_DESIGN.Text))
	{
		strErr+="JOB_DESIGN�������֣�\\n";	
	}
	if(!PageValidate.IsNumber(txtJOB_LEV1.Text))
	{
		strErr+="JOB_LEV1�������֣�\\n";	
	}
	if(!PageValidate.IsNumber(txtJOB_LEV2.Text))
	{
		strErr+="JOB_LEV2�������֣�\\n";	
	}
	if(!PageValidate.IsNumber(txtJOB_LEV3.Text))
	{
		strErr+="JOB_LEV3�������֣�\\n";	
	}
	if(!PageValidate.IsNumber(txtJOB_CHARGE_OUT.Text))
	{
		strErr+="JOB_CHARGE_OUT�������֣�\\n";	
	}
	if(!PageValidate.IsNumber(txtJOB_DAILY.Text))
	{
		strErr+="JOB_DAILY�������֣�\\n";	
	}
	if(!PageValidate.IsNumber(txtJOB_MON.Text))
	{
		strErr+="JOB_MON�������֣�\\n";	
	}
	if(!PageValidate.IsDecimal(txtJOB_PERIOD.Text))
	{
		strErr+="JOB_PERIOD�������֣�\\n";	
	}
	if(!PageValidate.IsDecimal(txtJOB_PERIOD_VAL.Text))
	{
		strErr+="JOB_PERIOD_VAL�������֣�\\n";	
	}
	if(this.txtJOB_AUTH.Text =="")
	{
		strErr+="JOB_AUTH����Ϊ�գ�\\n";	
	}
	if(this.txtJOB_OFF_INCHG_AD.Text =="")
	{
		strErr+="JOB_OFF_INCHG_AD����Ϊ�գ�\\n";	
	}
	if(this.txtJOB_OFF_INCHG_DES.Text =="")
	{
		strErr+="JOB_OFF_INCHG_DES����Ϊ�գ�\\n";	
	}
	if(this.txtJOB_AUTH_1.Text =="")
	{
		strErr+="JOB_AUTH_1����Ϊ�գ�\\n";	
	}
	if(this.txtJOB_AUTH_2.Text =="")
	{
		strErr+="JOB_AUTH_2����Ϊ�գ�\\n";	
	}
	if(this.txtJOB_AUTH_3.Text =="")
	{
		strErr+="JOB_AUTH_3����Ϊ�գ�\\n";	
	}
	if(this.txtJOB_AUTH_4.Text =="")
	{
		strErr+="JOB_AUTH_4����Ϊ�գ�\\n";	
	}
	if(this.txtJOB_AUTH_5.Text =="")
	{
		strErr+="JOB_AUTH_5����Ϊ�գ�\\n";	
	}
	if(!PageValidate.IsNumber(txtJOB_INDEX.Text))
	{
		strErr+="JOB_INDEX�������֣�\\n";	
	}
	if(this.txtJOB_NAME_S.Text =="")
	{
		strErr+="JOB_NAME_S����Ϊ�գ�\\n";	
	}
	if(this.txtJOB_NAME_T.Text =="")
	{
		strErr+="JOB_NAME_T����Ϊ�գ�\\n";	
	}

	if(strErr!="")
	{
		MessageBox.Show(this,strErr);
		return;
	}
	string JOB_CO_CODE=this.txtJOB_CO_CODE.Text;
	string JOB_NAME=this.txtJOB_NAME.Text;
	decimal JOB_CON=decimal.Parse(this.txtJOB_CON.Text);
	decimal JOB_OPEN_BAL_HOUR=decimal.Parse(this.txtJOB_OPEN_BAL_HOUR.Text);
	decimal JOB_YTD_HOUR=decimal.Parse(this.txtJOB_YTD_HOUR.Text);
	decimal JOB_OPEN_BAL_AMT=decimal.Parse(this.txtJOB_OPEN_BAL_AMT.Text);
	decimal JOB_YTD_AMT=decimal.Parse(this.txtJOB_YTD_AMT.Text);
	decimal JOB_REC=decimal.Parse(this.txtJOB_REC.Text);
	decimal JOB_OS_BAL=decimal.Parse(this.txtJOB_OS_BAL.Text);
	decimal JOB_BUD_HOUR=decimal.Parse(this.txtJOB_BUD_HOUR.Text);
	int JOB_CO_ORD=int.Parse(this.txtJOB_CO_ORD.Text);
	int JOB_ADMIN=int.Parse(this.txtJOB_ADMIN.Text);
	int JOB_DESIGN=int.Parse(this.txtJOB_DESIGN.Text);
	int JOB_LEV1=int.Parse(this.txtJOB_LEV1.Text);
	int JOB_LEV2=int.Parse(this.txtJOB_LEV2.Text);
	int JOB_LEV3=int.Parse(this.txtJOB_LEV3.Text);
	int JOB_CHARGE_OUT=int.Parse(this.txtJOB_CHARGE_OUT.Text);
	int JOB_DAILY=int.Parse(this.txtJOB_DAILY.Text);
	int JOB_MON=int.Parse(this.txtJOB_MON.Text);
	decimal JOB_PERIOD=decimal.Parse(this.txtJOB_PERIOD.Text);
	decimal JOB_PERIOD_VAL=decimal.Parse(this.txtJOB_PERIOD_VAL.Text);
	string JOB_AUTH=this.txtJOB_AUTH.Text;
	string JOB_OFF_INCHG_AD=this.txtJOB_OFF_INCHG_AD.Text;
	string JOB_OFF_INCHG_DES=this.txtJOB_OFF_INCHG_DES.Text;
	string JOB_AUTH_1=this.txtJOB_AUTH_1.Text;
	string JOB_AUTH_2=this.txtJOB_AUTH_2.Text;
	string JOB_AUTH_3=this.txtJOB_AUTH_3.Text;
	string JOB_AUTH_4=this.txtJOB_AUTH_4.Text;
	string JOB_AUTH_5=this.txtJOB_AUTH_5.Text;
	int JOB_INDEX=int.Parse(this.txtJOB_INDEX.Text);
	string JOB_NAME_S=this.txtJOB_NAME_S.Text;
	string JOB_NAME_T=this.txtJOB_NAME_T.Text;

	WongTung.Model.job model=new WongTung.Model.job();
	model.JOB_CO_CODE=JOB_CO_CODE;
	model.JOB_NAME=JOB_NAME;
	model.JOB_CON=JOB_CON;
	model.JOB_OPEN_BAL_HOUR=JOB_OPEN_BAL_HOUR;
	model.JOB_YTD_HOUR=JOB_YTD_HOUR;
	model.JOB_OPEN_BAL_AMT=JOB_OPEN_BAL_AMT;
	model.JOB_YTD_AMT=JOB_YTD_AMT;
	model.JOB_REC=JOB_REC;
	model.JOB_OS_BAL=JOB_OS_BAL;
	model.JOB_BUD_HOUR=JOB_BUD_HOUR;
	model.JOB_CO_ORD=JOB_CO_ORD;
	model.JOB_ADMIN=JOB_ADMIN;
	model.JOB_DESIGN=JOB_DESIGN;
	model.JOB_LEV1=JOB_LEV1;
	model.JOB_LEV2=JOB_LEV2;
	model.JOB_LEV3=JOB_LEV3;
	model.JOB_CHARGE_OUT=JOB_CHARGE_OUT;
	model.JOB_DAILY=JOB_DAILY;
	model.JOB_MON=JOB_MON;
	model.JOB_PERIOD=JOB_PERIOD;
	model.JOB_PERIOD_VAL=JOB_PERIOD_VAL;
	model.JOB_AUTH=JOB_AUTH;
	model.JOB_OFF_INCHG_AD=JOB_OFF_INCHG_AD;
	model.JOB_OFF_INCHG_DES=JOB_OFF_INCHG_DES;
	model.JOB_AUTH_1=JOB_AUTH_1;
	model.JOB_AUTH_2=JOB_AUTH_2;
	model.JOB_AUTH_3=JOB_AUTH_3;
	model.JOB_AUTH_4=JOB_AUTH_4;
	model.JOB_AUTH_5=JOB_AUTH_5;
	model.JOB_INDEX=JOB_INDEX;
	model.JOB_NAME_S=JOB_NAME_S;
	model.JOB_NAME_T=JOB_NAME_T;

	WongTung.BLL.job bll=new WongTung.BLL.job();
	bll.Add(model);

		}

    }
}
