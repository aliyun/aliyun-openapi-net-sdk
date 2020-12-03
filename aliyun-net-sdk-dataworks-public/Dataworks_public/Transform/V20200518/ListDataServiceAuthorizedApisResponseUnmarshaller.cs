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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListDataServiceAuthorizedApisResponseUnmarshaller
    {
        public static ListDataServiceAuthorizedApisResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataServiceAuthorizedApisResponse listDataServiceAuthorizedApisResponse = new ListDataServiceAuthorizedApisResponse();

			listDataServiceAuthorizedApisResponse.HttpResponse = _ctx.HttpResponse;
			listDataServiceAuthorizedApisResponse.ErrorCode = _ctx.StringValue("ListDataServiceAuthorizedApis.ErrorCode");
			listDataServiceAuthorizedApisResponse.ErrorMessage = _ctx.StringValue("ListDataServiceAuthorizedApis.ErrorMessage");
			listDataServiceAuthorizedApisResponse.HttpStatusCode = _ctx.IntegerValue("ListDataServiceAuthorizedApis.HttpStatusCode");
			listDataServiceAuthorizedApisResponse.RequestId = _ctx.StringValue("ListDataServiceAuthorizedApis.RequestId");
			listDataServiceAuthorizedApisResponse.Success = _ctx.BooleanValue("ListDataServiceAuthorizedApis.Success");

			ListDataServiceAuthorizedApisResponse.ListDataServiceAuthorizedApis_Data data = new ListDataServiceAuthorizedApisResponse.ListDataServiceAuthorizedApis_Data();
			data.PageNumber = _ctx.IntegerValue("ListDataServiceAuthorizedApis.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListDataServiceAuthorizedApis.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListDataServiceAuthorizedApis.Data.TotalCount");

			List<ListDataServiceAuthorizedApisResponse.ListDataServiceAuthorizedApis_Data.ListDataServiceAuthorizedApis_ApiAuthorized> data_apiAuthorizedList = new List<ListDataServiceAuthorizedApisResponse.ListDataServiceAuthorizedApis_Data.ListDataServiceAuthorizedApis_ApiAuthorized>();
			for (int i = 0; i < _ctx.Length("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList.Length"); i++) {
				ListDataServiceAuthorizedApisResponse.ListDataServiceAuthorizedApis_Data.ListDataServiceAuthorizedApis_ApiAuthorized apiAuthorized = new ListDataServiceAuthorizedApisResponse.ListDataServiceAuthorizedApis_Data.ListDataServiceAuthorizedApis_ApiAuthorized();
				apiAuthorized.ApiId = _ctx.LongValue("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList["+ i +"].ApiId");
				apiAuthorized.ApiName = _ctx.StringValue("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList["+ i +"].ApiName");
				apiAuthorized.ApiPath = _ctx.StringValue("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList["+ i +"].ApiPath");
				apiAuthorized.ApiStatus = _ctx.IntegerValue("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList["+ i +"].ApiStatus");
				apiAuthorized.CreatedTime = _ctx.StringValue("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList["+ i +"].CreatedTime");
				apiAuthorized.CreatorId = _ctx.StringValue("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList["+ i +"].CreatorId");
				apiAuthorized.GrantCreatedTime = _ctx.StringValue("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList["+ i +"].GrantCreatedTime");
				apiAuthorized.GrantEndTime = _ctx.StringValue("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList["+ i +"].GrantEndTime");
				apiAuthorized.GrantOperatorId = _ctx.StringValue("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList["+ i +"].GrantOperatorId");
				apiAuthorized.GroupId = _ctx.StringValue("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList["+ i +"].GroupId");
				apiAuthorized.ModifiedTime = _ctx.StringValue("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList["+ i +"].ModifiedTime");
				apiAuthorized.ProjectId = _ctx.LongValue("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList["+ i +"].ProjectId");
				apiAuthorized.TenantId = _ctx.LongValue("ListDataServiceAuthorizedApis.Data.ApiAuthorizedList["+ i +"].TenantId");

				data_apiAuthorizedList.Add(apiAuthorized);
			}
			data.ApiAuthorizedList = data_apiAuthorizedList;
			listDataServiceAuthorizedApisResponse.Data = data;
        
			return listDataServiceAuthorizedApisResponse;
        }
    }
}
