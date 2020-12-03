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
        public static GetDataAPIServiceDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDataAPIServiceDetailResponse getDataAPIServiceDetailResponse = new GetDataAPIServiceDetailResponse();

			getDataAPIServiceDetailResponse.HttpResponse = _ctx.HttpResponse;
			getDataAPIServiceDetailResponse.RequestId = _ctx.StringValue("GetDataAPIServiceDetail.RequestId");
			getDataAPIServiceDetailResponse.Success = _ctx.BooleanValue("GetDataAPIServiceDetail.Success");
			getDataAPIServiceDetailResponse.Code = _ctx.StringValue("GetDataAPIServiceDetail.Code");
			getDataAPIServiceDetailResponse.ErrorMessage = _ctx.StringValue("GetDataAPIServiceDetail.ErrorMessage");

			GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data data = new GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data();
			data.ApiSrn = _ctx.StringValue("GetDataAPIServiceDetail.Data.ApiSrn");
			data.Status = _ctx.IntegerValue("GetDataAPIServiceDetail.Data.Status");
			data.DisplayName = _ctx.StringValue("GetDataAPIServiceDetail.Data.DisplayName");
			data.ApiPath = _ctx.StringValue("GetDataAPIServiceDetail.Data.ApiPath");
			data.CreateTime = _ctx.LongValue("GetDataAPIServiceDetail.Data.CreateTime");
			data.LastUpdateTime = _ctx.LongValue("GetDataAPIServiceDetail.Data.LastUpdateTime");
			data.DateFormat = _ctx.StringValue("GetDataAPIServiceDetail.Data.DateFormat");
			data.RequestMethod = _ctx.StringValue("GetDataAPIServiceDetail.Data.RequestMethod");
			data.RequestProtocol = _ctx.StringValue("GetDataAPIServiceDetail.Data.RequestProtocol");
			data.Description = _ctx.StringValue("GetDataAPIServiceDetail.Data.Description");

			GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO sqlTemplateDTO = new GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO();
			sqlTemplateDTO.OriginSql = _ctx.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.OriginSql");
			sqlTemplateDTO.TemplateSql = _ctx.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.TemplateSql");

			List<GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_RequestParamsItem> sqlTemplateDTO_requestParams = new List<GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_RequestParamsItem>();
			for (int i = 0; i < _ctx.Length("GetDataAPIServiceDetail.Data.SqlTemplateDTO.RequestParams.Length"); i++) {
				GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_RequestParamsItem requestParamsItem = new GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_RequestParamsItem();
				requestParamsItem.Name = _ctx.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.RequestParams["+ i +"].Name");
				requestParamsItem.Type = _ctx.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.RequestParams["+ i +"].Type");
				requestParamsItem.Desc = _ctx.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.RequestParams["+ i +"].Desc");
				requestParamsItem.Example = _ctx.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.RequestParams["+ i +"].Example");
				requestParamsItem.Required = _ctx.BooleanValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.RequestParams["+ i +"].Required");

				sqlTemplateDTO_requestParams.Add(requestParamsItem);
			}
			sqlTemplateDTO.RequestParams = sqlTemplateDTO_requestParams;

			List<GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_ResponseParamsItem> sqlTemplateDTO_responseParams = new List<GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_ResponseParamsItem>();
			for (int i = 0; i < _ctx.Length("GetDataAPIServiceDetail.Data.SqlTemplateDTO.ResponseParams.Length"); i++) {
				GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_ResponseParamsItem responseParamsItem = new GetDataAPIServiceDetailResponse.GetDataAPIServiceDetail_Data.GetDataAPIServiceDetail_SqlTemplateDTO.GetDataAPIServiceDetail_ResponseParamsItem();
				responseParamsItem.Name = _ctx.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.ResponseParams["+ i +"].Name");
				responseParamsItem.Type = _ctx.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.ResponseParams["+ i +"].Type");
				responseParamsItem.Desc = _ctx.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.ResponseParams["+ i +"].Desc");
				responseParamsItem.Example = _ctx.StringValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.ResponseParams["+ i +"].Example");
				responseParamsItem.Required = _ctx.BooleanValue("GetDataAPIServiceDetail.Data.SqlTemplateDTO.ResponseParams["+ i +"].Required");

				sqlTemplateDTO_responseParams.Add(responseParamsItem);
			}
			sqlTemplateDTO.ResponseParams = sqlTemplateDTO_responseParams;
			data.SqlTemplateDTO = sqlTemplateDTO;
			getDataAPIServiceDetailResponse.Data = data;
        
			return getDataAPIServiceDetailResponse;
        }
    }
}
