/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class CreateDownloadDataJobResponseUnmarshaller
    {
        public static CreateDownloadDataJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateDownloadDataJobResponse createDownloadDataJobResponse = new CreateDownloadDataJobResponse();

			createDownloadDataJobResponse.HttpResponse = _ctx.HttpResponse;
			createDownloadDataJobResponse.RequestId = _ctx.StringValue("CreateDownloadDataJob.RequestId");
			createDownloadDataJobResponse.Success = _ctx.BooleanValue("CreateDownloadDataJob.Success");
			createDownloadDataJobResponse.Code = _ctx.StringValue("CreateDownloadDataJob.Code");
			createDownloadDataJobResponse.ErrorMessage = _ctx.StringValue("CreateDownloadDataJob.ErrorMessage");

			CreateDownloadDataJobResponse.CreateDownloadDataJob_Data data = new CreateDownloadDataJobResponse.CreateDownloadDataJob_Data();
			data.PreviewSize = _ctx.IntegerValue("CreateDownloadDataJob.Data.PreviewSize");
			data.CsvUrl = _ctx.StringValue("CreateDownloadDataJob.Data.CsvUrl");
			data.DatasetId = _ctx.StringValue("CreateDownloadDataJob.Data.DatasetId");
			data.LongJobId = _ctx.StringValue("CreateDownloadDataJob.Data.LongJobId");
			data.Status = _ctx.IntegerValue("CreateDownloadDataJob.Data.Status");
			data.BeginTime = _ctx.LongValue("CreateDownloadDataJob.Data.BeginTime");
			data.EndTime = _ctx.LongValue("CreateDownloadDataJob.Data.EndTime");
			data.ResultDataInString = _ctx.StringValue("CreateDownloadDataJob.Data.ResultDataInString");
			data.AsyncExecute = _ctx.BooleanValue("CreateDownloadDataJob.Data.AsyncExecute");
			data.TotalCount = _ctx.LongValue("CreateDownloadDataJob.Data.TotalCount");
			data.PageNo = _ctx.IntegerValue("CreateDownloadDataJob.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("CreateDownloadDataJob.Data.PageSize");
			data.CsvFileName = _ctx.StringValue("CreateDownloadDataJob.Data.CsvFileName");

			CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_QuerySetting querySetting = new CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_QuerySetting();

			List<CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_QuerySetting.CreateDownloadDataJob_SelectedHeadersItem> querySetting_selectedHeaders = new List<CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_QuerySetting.CreateDownloadDataJob_SelectedHeadersItem>();
			for (int i = 0; i < _ctx.Length("CreateDownloadDataJob.Data.QuerySetting.SelectedHeaders.Length"); i++) {
				CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_QuerySetting.CreateDownloadDataJob_SelectedHeadersItem selectedHeadersItem = new CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_QuerySetting.CreateDownloadDataJob_SelectedHeadersItem();
				selectedHeadersItem.FieldName = _ctx.StringValue("CreateDownloadDataJob.Data.QuerySetting.SelectedHeaders["+ i +"].FieldName");
				selectedHeadersItem.Alias = _ctx.StringValue("CreateDownloadDataJob.Data.QuerySetting.SelectedHeaders["+ i +"].Alias");
				selectedHeadersItem.FieldType = _ctx.StringValue("CreateDownloadDataJob.Data.QuerySetting.SelectedHeaders["+ i +"].FieldType");
				selectedHeadersItem.TimeClass = _ctx.StringValue("CreateDownloadDataJob.Data.QuerySetting.SelectedHeaders["+ i +"].TimeClass");
				selectedHeadersItem.GeoClass = _ctx.StringValue("CreateDownloadDataJob.Data.QuerySetting.SelectedHeaders["+ i +"].GeoClass");
				selectedHeadersItem.DimDateClass = _ctx.StringValue("CreateDownloadDataJob.Data.QuerySetting.SelectedHeaders["+ i +"].DimDateClass");

				querySetting_selectedHeaders.Add(selectedHeadersItem);
			}
			querySetting.SelectedHeaders = querySetting_selectedHeaders;

			List<CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_QuerySetting.CreateDownloadDataJob_AstExprItem> querySetting_astExpr = new List<CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_QuerySetting.CreateDownloadDataJob_AstExprItem>();
			for (int i = 0; i < _ctx.Length("CreateDownloadDataJob.Data.QuerySetting.AstExpr.Length"); i++) {
				CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_QuerySetting.CreateDownloadDataJob_AstExprItem astExprItem = new CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_QuerySetting.CreateDownloadDataJob_AstExprItem();
				astExprItem.Expr = _ctx.StringValue("CreateDownloadDataJob.Data.QuerySetting.AstExpr["+ i +"].Expr");
				astExprItem.ExprType = _ctx.StringValue("CreateDownloadDataJob.Data.QuerySetting.AstExpr["+ i +"].ExprType");

				querySetting_astExpr.Add(astExprItem);
			}
			querySetting.AstExpr = querySetting_astExpr;
			data.QuerySetting = querySetting;

			List<CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_HeaderItem> data_header = new List<CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_HeaderItem>();
			for (int i = 0; i < _ctx.Length("CreateDownloadDataJob.Data.Header.Length"); i++) {
				CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_HeaderItem headerItem = new CreateDownloadDataJobResponse.CreateDownloadDataJob_Data.CreateDownloadDataJob_HeaderItem();
				headerItem.FieldName = _ctx.StringValue("CreateDownloadDataJob.Data.Header["+ i +"].FieldName");
				headerItem.Alias = _ctx.StringValue("CreateDownloadDataJob.Data.Header["+ i +"].Alias");
				headerItem.FieldType = _ctx.StringValue("CreateDownloadDataJob.Data.Header["+ i +"].FieldType");
				headerItem.TypeClass = _ctx.StringValue("CreateDownloadDataJob.Data.Header["+ i +"].TypeClass");
				headerItem.TimeClass = _ctx.StringValue("CreateDownloadDataJob.Data.Header["+ i +"].TimeClass");
				headerItem.GeoClass = _ctx.StringValue("CreateDownloadDataJob.Data.Header["+ i +"].GeoClass");
				headerItem.DimDateClass = _ctx.StringValue("CreateDownloadDataJob.Data.Header["+ i +"].DimDateClass");
				headerItem.DataPrecision = _ctx.StringValue("CreateDownloadDataJob.Data.Header["+ i +"].DataPrecision");

				data_header.Add(headerItem);
			}
			data.Header = data_header;
			createDownloadDataJobResponse.Data = data;
        
			return createDownloadDataJobResponse;
        }
    }
}
