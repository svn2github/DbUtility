<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="WongTung.Web.budgetot.Modify" Title="�޸�ҳ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		BG_CO_CODE
	</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBG_CO_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BG_JOB_CODE
	</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBG_JOB_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BG_SER_CODE
	</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBG_SER_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BG_POS
	</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBG_POS" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BG_HOUR
	</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBG_HOUR" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BG_EXP_BUDGET
	</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBG_EXP_BUDGET" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:Button ID="btnAdd" runat="server" Text="�� �ύ ��" OnClick="btnAdd_Click" ></asp:Button>
		<asp:Button ID="btnCancel" runat="server" Text="�� ȡ�� ��" OnClick="btnCancel_Click" ></asp:Button>
	</div></td></tr>
</table>

</asp:Content>
