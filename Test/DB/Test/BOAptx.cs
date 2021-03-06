﻿using System;
using System.Data;
using System.Collections.Generic;
using hwj.DBUtility;
using Test.DB.DAL;
using Test.DB.Entity;

namespace Test.DB.BLL
{
    /// <summary>
    /// Business [BOAptx]
    /// </summary>
    public class BOAptx
    {
        private static DAAptx da = new DAAptx("Data Source=10.100.133.83;Initial Catalog=eAccount;Persist Security Info=True;User ID=sa;Password=gzuat");
        //private static DAAptx da = new DAAptx("Data Source=127.0.0.1;Initial Catalog=eAccount;Integrated Security=True");

        public BOAptx()
        { }
        public static bool Exists(string CompanyCode, string APTxNum)
        {
            FilterParams fp = new FilterParams();
            fp.AddParam(tbAptx.Fields.CompanyCode, CompanyCode, Enums.Relation.Equal, Enums.Expression.AND);
            fp.AddParam(tbAptx.Fields.APTxNum, APTxNum, Enums.Relation.Equal, Enums.Expression.AND);
            return da.RecordCount(fp) > 0;
        }

        public static bool Add(tbAptx entity)
        {
            return da.Add(entity);
        }

        public static bool Update(tbAptx updateEntity, string CompanyCode, string APTxNum)
        {
            FilterParams fp = new FilterParams();
            fp.AddParam(tbAptx.Fields.CompanyCode, CompanyCode, Enums.Relation.Equal, Enums.Expression.AND);
            fp.AddParam(tbAptx.Fields.APTxNum, APTxNum, Enums.Relation.Equal, Enums.Expression.AND);
            return da.Update(updateEntity, fp);
        }

        public static bool Delete(string CompanyCode, string APTxNum)
        {
            FilterParams fp = new FilterParams();
            fp.AddParam(tbAptx.Fields.CompanyCode, CompanyCode, Enums.Relation.Equal, Enums.Expression.AND);
            fp.AddParam(tbAptx.Fields.APTxNum, APTxNum, Enums.Relation.Equal, Enums.Expression.AND);
            return da.Delete(fp);
        }

        public static tbAptx GetEntity(string CompanyCode, string APTxNum)
        {
            FilterParams fp = new FilterParams();
            fp.AddParam(tbAptx.Fields.CompanyCode, CompanyCode, Enums.Relation.Equal, Enums.Expression.AND);
            fp.AddParam(tbAptx.Fields.APTxNum, APTxNum, Enums.Relation.Equal, Enums.Expression.AND);
            return da.GetEntity(fp);
        }

        public static tbAptxs GetList(string CompanyCode, string APTxNum)
        {
            FilterParams fp = new FilterParams();
            fp.AddParam(tbAptx.Fields.CompanyCode, CompanyCode, Enums.Relation.Equal, Enums.Expression.AND);
            fp.AddParam(tbAptx.Fields.APTxNum, APTxNum, Enums.Relation.Equal, Enums.Expression.AND);
            fp.AddParam(tbAptx.Fields.UpdateBy, "", Enums.Relation.Equal, Enums.Expression.AND);
            //fp.AddParam(tbAptx.Fields.APTxDesc, "", Enums.Relation.Equal, Enums.Expression.AND);
            return da.GetList(null, fp);
        }

        public static tbAptxs GetList(string CompanyCode, int top)
        {
            FilterParams fp = new FilterParams();
            fp.AddParam(tbAptx.Fields.CompanyCode, CompanyCode, Enums.Relation.Equal, Enums.Expression.AND);
            return da.GetList(null, fp, null, top);
        }

        public static tbAptxs GetListForAPTxNumList(string CompanyCode, List<string> lst)
        {
            FilterParams fp = new FilterParams();
            fp.AddParam(tbAptx.Fields.CompanyCode, CompanyCode, Enums.Relation.Equal, Enums.Expression.AND);
            fp.AddParam(tbAptx.Fields.APTxNum, lst, Enums.Relation.IN, Enums.Expression.AND);
            return da.GetList(null, fp);
        }
        public static tbAptxs GetListForAPTxNumList2(string CompanyCode, List<string> lst)
        {
            FilterParams fp = new FilterParams();
            fp.AddParam(tbAptx.Fields.CompanyCode, CompanyCode, Enums.Relation.Equal, Enums.Expression.AND);
            fp.AddParam(tbAptx.Fields.APTxNum, lst, Enums.Relation.IN_InsertSQL, Enums.Expression.AND);
            return da.GetList(null, fp);
        }

        public static tbAptxs GetListForAmtList(string CompanyCode, List<string> lst)
        {
            FilterParams fp = new FilterParams();
            fp.AddParam(tbAptx.Fields.CompanyCode, CompanyCode, Enums.Relation.Equal, Enums.Expression.AND);
            fp.AddParam(tbAptx.Fields.AmtPrm, lst, Enums.Relation.IN, Enums.Expression.AND);
            return da.GetList(null, fp);
        }

        public static tbAptxPage GetPage(int pageIndex, int pageSize)
        {
            int RecordCount;
            tbAptxPage page = new tbAptxPage();
            DisplayFields pk = new DisplayFields();
            pk.Add(tbAptx.Fields.CompanyCode);
            pk.Add(tbAptx.Fields.APTxNum);
            page.PageSize = pageSize;
            page.Result = da.GetPage(null, null, null, pk, pageIndex, page.PageSize, out RecordCount);
            page.RecordCount = RecordCount;
            return page;
        }

        public static bool UpdateList(string CompanyCode, List<string> lst)
        {
            UpdateParam up = new UpdateParam();
            up.AddParam(tbAptx.Fields.LastReptNum, "VIN");

            FilterParams fp = new FilterParams();
            fp.AddParam(tbAptx.Fields.CompanyCode, CompanyCode, Enums.Relation.Equal, Enums.Expression.AND);
            fp.AddParam(tbAptx.Fields.LastReptNum, null, Enums.Relation.IsNull, Enums.Expression.AND);
            fp.AddParam(tbAptx.Fields.APTxNum, lst, Enums.Relation.IN, Enums.Expression.AND);

            return da.Update(up, fp);
        }

        public static bool UpdateList2(string CompanyCode, List<string> lst)
        {
            UpdateParam up = new UpdateParam();
            up.AddParam(tbAptx.Fields.LastReptNum, null);

            FilterParams fp = new FilterParams();
            fp.AddParam(tbAptx.Fields.CompanyCode, CompanyCode, Enums.Relation.Equal, Enums.Expression.AND);
            fp.AddParam(tbAptx.Fields.LastReptNum, "VIN", Enums.Relation.Equal, Enums.Expression.AND);
            fp.AddParam(tbAptx.Fields.APTxNum, lst, Enums.Relation.IN_InsertSQL, Enums.Expression.AND);

            return da.Update(up, fp);
        }
        public static string GetList1(string CompanyCode)
        {
            DisplayFields df = new DisplayFields();
            df.Add(tbAptx.Fields.CompanyCode);

            FilterParams fp = new FilterParams();
            fp.AddParam(tbAptx.Fields.CompanyCode, CompanyCode, Enums.Relation.Equal, Enums.Expression.AND);

            return da.GetList(df, fp, null, 1)[0].CompanyCode + "|" + da.SqlEntity.CommandText;

            //return da.SqlEntity;
        }

        public static string GetList2(string CompanyCode)
        {
            DisplayFields df = new DisplayFields();
            df.Add(tbAptx.Fields.APTxNum);

            FilterParams fp = new FilterParams();
            fp.AddParam(tbAptx.Fields.CompanyCode, CompanyCode, Enums.Relation.Equal, Enums.Expression.AND);

            tbAptx ap = da.GetList(df, fp, null, 1)[0];
            return ap.CompanyCode + "|" + ap.APTxNum + "|" + da.SqlEntity.CommandText;

            //return da.SqlEntity;
        }
    }
}

