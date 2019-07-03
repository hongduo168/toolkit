using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using Toolkit.WinForm.ApiDesign.Model;
using System.Linq;
using System.Data.Common;

namespace Toolkit.WinForm.ApiDesign
{
    public class DataProvider
    {
        //private string connectionString = System.Configuration.ConfigurationManager.AppSettings["DbString"];

        private static IDatabase db = null;
        public DataProvider()
        {
            if (db == null)
            {
                db = DatabaseConfiguration.Build().UsingConnectionStringName("DbString").Create();
                //db = DatabaseConfiguration.Build().UsingProvider<MySqlDatabaseProvider>().UsingConnectionString(connectionString).Create();
            }
        }

        public static DataProvider Instance()
        {
            return new DataProvider();
        }


        #region Interface
        public int SaveProject(ProjectInfo info)
        {
            if (!string.IsNullOrEmpty(info.SID))
                return db.Update(info);
            else
                this.InsertProject(info);

            return int.MinValue;

        }

        public int DeleteProject(string SID)
        {
            return db.Delete<ProjectInfo>("WHERE `SID` = @0", SID);
        }

        public void InsertProject(ProjectInfo info)
        {
            if (info.ProjectName == null) info.ProjectName = string.Empty;
            if (info.Namespace == null) info.Namespace = string.Empty;
            if (string.IsNullOrEmpty(info.SID)) info.SID = Guid.NewGuid().ToString("N");

            db.Insert(info);

        }

        public List<ProjectInfo> GetProject()
        {
            return db.Query<ProjectInfo>(string.Empty).ToList();
        }
        public ProjectInfo GetProject(string id)
        {
            ProjectInfo result = db.Single<ProjectInfo>("WHERE SID=@0 ", id);

            if (result != null)
            {
                result.ApiInterfaces = db.Query<ApiInterfaceInfo>("WHERE ProjectSID=@0 ", id).ToList();
                foreach (var detail in result.ApiInterfaces)
                {
                    detail.RequestBodys = db.Query<RequestBodyInfo>("WHERE RelationSID=@0 ", detail.SID).ToList();
                    detail.ResponseBodys = db.Query<ResponseBodyInfo>("WHERE RelationSID=@0 ", detail.SID).ToList();
                }
            }
            return result;
        }

        public List<ApiInterfaceInfo> GetApi(ProjectInfo info)
        {
            var result = db.Query<ApiInterfaceInfo>("WHERE ProjectSID=@0 ", info.SID).ToList();
            foreach (var detail in result)
            {
                detail.RequestBodys = db.Query<RequestBodyInfo>("WHERE RelationSID=@0 ", detail.SID).ToList();
                detail.ResponseBodys = db.Query<ResponseBodyInfo>("WHERE RelationSID=@0 ", detail.SID).ToList();
            }

            return result;
        }
        public ApiInterfaceInfo GetApi(string routePath)
        {
            var result = db.Query<ApiInterfaceInfo>("WHERE InterfaceRoute=@0 ", routePath).ToList();
            foreach (var detail in result)
            {
                detail.RequestBodys = db.Query<RequestBodyInfo>("WHERE RelationSID=?SID ", detail.SID).ToList();
                detail.ResponseBodys = db.Query<ResponseBodyInfo>("WHERE RelationSID=?SID ", detail.SID).ToList();
            }

            return result.FirstOrDefault();
        }
        public ApiInterfaceInfo GetApi(string routePath, string projectSID)
        {
            var result = db.Query<ApiInterfaceInfo>("WHERE InterfaceRoute=@0 AND ProjectSID=?1", routePath, projectSID).ToList();
            foreach (var detail in result)
            {
                detail.RequestBodys = db.Query<RequestBodyInfo>("WHERE RelationSID=@0 ", detail.SID).ToList();
                detail.ResponseBodys = db.Query<ResponseBodyInfo>("WHERE RelationSID=@0 ", detail.SID).ToList();
            }

            return result.FirstOrDefault();
        }
        #endregion

        /// <summary>
        /// 新增RequestBody
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public void InsertRequestBody(RequestBodyInfo info)
        {
            if (info.FieldName == null) info.FieldName = string.Empty;
            if (info.DataType == null) info.DataType = string.Empty;
            if (string.IsNullOrEmpty(info.SID)) info.SID = Guid.NewGuid().ToString("N");

            db.Insert(info);

        }
        /// <summary>
        /// 更新RequestBody数据
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int SaveRequestBody(RequestBodyInfo info)
        {
            return db.Update(info);
        }
        /// <summary>
        /// 删除RequestBody
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DeleteRequestBody(RequestBodyInfo info)
        {
            return db.Delete<RequestBodyInfo>("WHERE `SID` = @0", info.SID);
        }

        /// <summary>
        /// 新增ResponseBody
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public void InsertResponseBody(ResponseBodyInfo info)
        {
            if (info.FieldName == null) info.FieldName = string.Empty;
            if (info.FieldCode == null) info.FieldCode = string.Empty;
            if (info.DataType == null) info.DataType = string.Empty;
            if (string.IsNullOrEmpty(info.SID)) info.SID = Guid.NewGuid().ToString("N");

            db.Insert(info);
        }
        /// <summary>
        /// 更新ResponseBody数据
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int SaveResponseBody(ResponseBodyInfo info)
        {
            return db.Update(info);
        }
        /// <summary>
        /// 删除ResponseBody
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DeleteResponseBody(ResponseBodyInfo info)
        {
            return db.Delete<ResponseBodyInfo>("WHERE `SID` = @0", info.SID);
        }

        #region Api

        public void InsertApi(ApiInterfaceInfo info)
        {
            if (info.ActionName == null) info.ActionName = string.Empty;
            if (info.ApiName == null) info.ApiName = string.Empty;
            if (info.ApiCode == null) info.ApiCode = string.Empty;
            if (info.ActionRoute == null) info.ActionRoute = string.Empty;
            if (string.IsNullOrEmpty(info.SID)) info.SID = Guid.NewGuid().ToString("N");


            db.Insert(info);
        }
        /// <summary>
        /// 更新ApiInterfaceInfo
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int SaveApi(ApiInterfaceInfo info)
        {
            return db.Update(info);
        }

        /// <summary>
        /// 删除ApiInterfaceInfo
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DeleteApi(ApiInterfaceInfo info)
        {
            int rows = 0;
            try
            {
                db.BeginTransaction();

                rows += db.Delete<RequestBodyInfo>("WHERE `RelationSID` = @0", info.SID);
                rows += db.Delete<ResponseBodyInfo>("WHERE `RelationSID` = @0", info.SID);
                rows += db.Delete<ApiInterfaceInfo>("WHERE `SID` = @0", info.SID);

                db.CompleteTransaction();
            }
            catch (Exception e)
            {
                db.AbortTransaction();
            }
            return rows;
        }
        #endregion
    }
}
