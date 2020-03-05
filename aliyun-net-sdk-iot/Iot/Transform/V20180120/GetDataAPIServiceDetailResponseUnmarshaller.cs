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
    public class GetDataAPIServiceDetailResponseUnmarshaller
    {
        public static GetDataAPIServiceDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetDataAPIServiceDetailResponse getDataAPIServiceDetailResponse = new GetDataAPIServiceDetailResponse();

			getDataAPIServiceDetailResponse.HttpResponse = context.HttpResponse;
			getDataAPIServiceDetailResponse.RequestId = context.StringValue("GetDataAPIServiceDetail.RequestId");
			getDataAPIServiceDetailResponse.Success = context.BooleanValue("GetDataAPIServiceDetail.Success");
			getDataAPIServiceDetailResponse.Code = context.StringValue("GetDataAPIServiceDetail.Code");
			getDataAPIServiceDetailResponse.ErrorMessage = context.StringValue("GetDataAPIServiceDetail.ErrorMessage");

			GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data data = new GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data();
			data.ApiSrn = context.StringValue("GetDataAPIServiceDetail.Data.ApiSrn");
			data.Status = context.IntegerValue("GetDataAPIServiceDetail.Data.Status");
			data.DisplayName = context.StringValue("GetDataAPIServiceDetail.Data.DisplayName");
			data.ApiPath = context.StringValue("GetDataAPIServiceDetail.Data.ApiPath");
			data.CreateTime = context.LongValue("GetDataAPIServiceDetail.Data.CreateTime");
			data.LastUpdateTime = context.LongValue("GetDataAPIServiceDetail.Data.LastUpdateTime");
			data.DateFormat = context.StringValue("GetDataAPIServiceDetail.Data.DateFormat");
			data.RequestMethod = context.StringValue("GetDataAPIServiceDetail.Data.RequestMethod");
			data.RequestProtocol = context.StringValue("GetDataAPIServiceDetail.Data.RequestProtocol");
			data.Description = context.StringValue("GetDataAPIServiceDetail.Data.Description");

			GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO sqlTemplateDTO = new GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO();
			sqlTemplateDTO.OriginSql = context.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.OriginSql");
			sqlTemplateDTO.TemplateSql = context.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.TemplateSql");

			List<GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_RequestParamsItem> sqlTemplateDTO_requestParams = new List<GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_RequestParamsItem>();
			for (int i = 0; i < context.Length("GetDataAPIServiceDetail.Data.SqlTemplateDTO.RequestParams.Length"); i++) {
				GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_RequestParamsItem requestParamsItem = new GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_RequestParamsItem();
				requestParamsItem.Name = context.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.RequestParams["+ i +"].Name");
				requestParamsItem.Type = context.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.RequestParams["+ i +"].Type");
				requestParamsItem.Desc = context.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.RequestParams["+ i +"].Desc");
				requestParamsItem.Example = context.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.RequestParams["+ i +"].Example");
				requestParamsItem.Required = context.BooleanValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.RequestParams["+ i +"].Required");

				sqlTemplateDTO_requestParams.Add(requestParamsItem);
			}
			sqlTemplateDTO.RequestParams = sqlTemplateDTO_requestParams;

			List<GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_ResponseParamsItem> sqlTemplateDTO_responseParams = new List<GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_ResponseParamsItem>();
			for (int i = 0; i < context.Length("GetDataAPIServiceDetail.Data.SqlTemplateDTO.ResponseParams.Length"); i++) {
				GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_ResponseParamsItem responseParamsItem = new GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_ResponseParamsItem();
				responseParamsItem.Name = context.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.ResponseParams["+ i +"].Name");
				responseParamsItem.Type = context.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.ResponseParams["+ i +"].Type");
				responseParamsItem.Desc = context.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.ResponseParams["+ i +"].Desc");
				responseParamsItem.Example = context.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.ResponseParams["+ i +"].Example");
				responseParamsItem.Required = context.BooleanValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.ResponseParams["+ i +"].Required");

				sqlTemplateDTO_responseParams.Add(responseParamsItem);
			}
			sqlTemplateDTO.ResponseParams = sqlTemplateDTO_responseParams;
			data.SqlTemplateDTO = sqlTemplateDTO;
			getDataAPIServiceDetailResponse.Data = data;
        
			return getDataAPIServiceDetailResponse;
        }
    }
}
