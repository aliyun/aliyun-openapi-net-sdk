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
    public class GetDownloadFileResponseUnmarshaller
    {
        public static GetDownloadFileResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDownloadFileResponse getDownloadFileResponse = new GetDownloadFileResponse();

			getDownloadFileResponse.HttpResponse = _ctx.HttpResponse;
			getDownloadFileResponse.RequestId = _ctx.StringValue("GetDownloadFile.RequestId");
			getDownloadFileResponse.Success = _ctx.BooleanValue("GetDownloadFile.Success");
			getDownloadFileResponse.Code = _ctx.StringValue("GetDownloadFile.Code");
			getDownloadFileResponse.ErrorMessage = _ctx.StringValue("GetDownloadFile.ErrorMessage");

			GetDownloadFileResponse.GetDownloadFile_Data data = new GetDownloadFileResponse.GetDownloadFile_Data();
			data.PreviewSize = _ctx.IntegerValue("GetDownloadFile.Data.PreviewSize");
			data.CsvUrl = _ctx.StringValue("GetDownloadFile.Data.CsvUrl");
			data.DatasetId = _ctx.StringValue("GetDownloadFile.Data.DatasetId");
			data.LongJobId = _ctx.StringValue("GetDownloadFile.Data.LongJobId");
			data.Status = _ctx.IntegerValue("GetDownloadFile.Data.Status");
			data.BeginTime = _ctx.LongValue("GetDownloadFile.Data.BeginTime");
			data.EndTime = _ctx.LongValue("GetDownloadFile.Data.EndTime");
			data.ResultDataInString = _ctx.StringValue("GetDownloadFile.Data.ResultDataInString");
			data.AsyncExecute = _ctx.BooleanValue("GetDownloadFile.Data.AsyncExecute");
			data.TotalCount = _ctx.LongValue("GetDownloadFile.Data.TotalCount");
			data.PageNo = _ctx.IntegerValue("GetDownloadFile.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("GetDownloadFile.Data.PageSize");
			data.CsvUrl1 = _ctx.StringValue("GetDownloadFile.Data.CsvUrl");
			data.CsvFileName = _ctx.StringValue("GetDownloadFile.Data.CsvFileName");

			List<Dictionary<string, string>> data_result = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("GetDownloadFile.Data.Result.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "GetDownloadFile.Data.Result["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					data_result.Add(tmp);
				}
			}
			data.Result = data_result;

			GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_QuerySetting querySetting = new GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_QuerySetting();

			List<GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_QuerySetting.GetDownloadFile_SelectedHeadersItem> querySetting_selectedHeaders = new List<GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_QuerySetting.GetDownloadFile_SelectedHeadersItem>();
			for (int i = 0; i < _ctx.Length("GetDownloadFile.Data.QuerySetting.SelectedHeaders.Length"); i++) {
				GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_QuerySetting.GetDownloadFile_SelectedHeadersItem selectedHeadersItem = new GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_QuerySetting.GetDownloadFile_SelectedHeadersItem();
				selectedHeadersItem.FieldName = _ctx.StringValue("GetDownloadFile.Data.QuerySetting.SelectedHeaders["+ i +"].FieldName");
				selectedHeadersItem.Alias = _ctx.StringValue("GetDownloadFile.Data.QuerySetting.SelectedHeaders["+ i +"].Alias");
				selectedHeadersItem.FieldType = _ctx.StringValue("GetDownloadFile.Data.QuerySetting.SelectedHeaders["+ i +"].FieldType");
				selectedHeadersItem.TimeClass = _ctx.StringValue("GetDownloadFile.Data.QuerySetting.SelectedHeaders["+ i +"].TimeClass");
				selectedHeadersItem.GeoClass = _ctx.StringValue("GetDownloadFile.Data.QuerySetting.SelectedHeaders["+ i +"].GeoClass");
				selectedHeadersItem.DimDateClass = _ctx.StringValue("GetDownloadFile.Data.QuerySetting.SelectedHeaders["+ i +"].DimDateClass");

				querySetting_selectedHeaders.Add(selectedHeadersItem);
			}
			querySetting.SelectedHeaders = querySetting_selectedHeaders;

			List<GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_QuerySetting.GetDownloadFile_AstExprItem> querySetting_astExpr = new List<GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_QuerySetting.GetDownloadFile_AstExprItem>();
			for (int i = 0; i < _ctx.Length("GetDownloadFile.Data.QuerySetting.AstExpr.Length"); i++) {
				GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_QuerySetting.GetDownloadFile_AstExprItem astExprItem = new GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_QuerySetting.GetDownloadFile_AstExprItem();
				astExprItem.Expr = _ctx.StringValue("GetDownloadFile.Data.QuerySetting.AstExpr["+ i +"].Expr");
				astExprItem.ExprType = _ctx.StringValue("GetDownloadFile.Data.QuerySetting.AstExpr["+ i +"].ExprType");

				querySetting_astExpr.Add(astExprItem);
			}
			querySetting.AstExpr = querySetting_astExpr;
			data.QuerySetting = querySetting;

			List<GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_HeaderItem> data_header = new List<GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_HeaderItem>();
			for (int i = 0; i < _ctx.Length("GetDownloadFile.Data.Header.Length"); i++) {
				GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_HeaderItem headerItem = new GetDownloadFileResponse.GetDownloadFile_Data.GetDownloadFile_HeaderItem();
				headerItem.FieldName = _ctx.StringValue("GetDownloadFile.Data.Header["+ i +"].FieldName");
				headerItem.Alias = _ctx.StringValue("GetDownloadFile.Data.Header["+ i +"].Alias");
				headerItem.FieldType = _ctx.StringValue("GetDownloadFile.Data.Header["+ i +"].FieldType");
				headerItem.TypeClass = _ctx.StringValue("GetDownloadFile.Data.Header["+ i +"].TypeClass");
				headerItem.TimeClass = _ctx.StringValue("GetDownloadFile.Data.Header["+ i +"].TimeClass");
				headerItem.GeoClass = _ctx.StringValue("GetDownloadFile.Data.Header["+ i +"].GeoClass");
				headerItem.DimDateClass = _ctx.StringValue("GetDownloadFile.Data.Header["+ i +"].DimDateClass");

				data_header.Add(headerItem);
			}
			data.Header = data_header;
			getDownloadFileResponse.Data = data;
        
			return getDownloadFileResponse;
        }
    }
}
