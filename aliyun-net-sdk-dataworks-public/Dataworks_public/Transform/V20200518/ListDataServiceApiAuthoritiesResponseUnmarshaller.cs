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
    public class ListDataServiceApiAuthoritiesResponseUnmarshaller
    {
        public static ListDataServiceApiAuthoritiesResponse Unmarshall(UnmarshallerContext context)
        {
			ListDataServiceApiAuthoritiesResponse listDataServiceApiAuthoritiesResponse = new ListDataServiceApiAuthoritiesResponse();

			listDataServiceApiAuthoritiesResponse.HttpResponse = context.HttpResponse;
			listDataServiceApiAuthoritiesResponse.ErrorCode = context.StringValue("ListDataServiceApiAuthorities.ErrorCode");
			listDataServiceApiAuthoritiesResponse.ErrorMessage = context.StringValue("ListDataServiceApiAuthorities.ErrorMessage");
			listDataServiceApiAuthoritiesResponse.HttpStatusCode = context.IntegerValue("ListDataServiceApiAuthorities.HttpStatusCode");
			listDataServiceApiAuthoritiesResponse.RequestId = context.StringValue("ListDataServiceApiAuthorities.RequestId");
			listDataServiceApiAuthoritiesResponse.Success = context.BooleanValue("ListDataServiceApiAuthorities.Success");

			ListDataServiceApiAuthoritiesResponse.ListDataServiceApiAuthorities_Data data = new ListDataServiceApiAuthoritiesResponse.ListDataServiceApiAuthorities_Data();
			data.PageNumber = context.IntegerValue("ListDataServiceApiAuthorities.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListDataServiceApiAuthorities.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListDataServiceApiAuthorities.Data.TotalCount");

			List<ListDataServiceApiAuthoritiesResponse.ListDataServiceApiAuthorities_Data.ListDataServiceApiAuthorities_ApiAuthorization> data_apiAuthorizationList = new List<ListDataServiceApiAuthoritiesResponse.ListDataServiceApiAuthorities_Data.ListDataServiceApiAuthorities_ApiAuthorization>();
			for (int i = 0; i < context.Length("ListDataServiceApiAuthorities.Data.ApiAuthorizationList.Length"); i++) {
				ListDataServiceApiAuthoritiesResponse.ListDataServiceApiAuthorities_Data.ListDataServiceApiAuthorities_ApiAuthorization apiAuthorization = new ListDataServiceApiAuthoritiesResponse.ListDataServiceApiAuthorities_Data.ListDataServiceApiAuthorities_ApiAuthorization();
				apiAuthorization.ApiId = context.LongValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].ApiId");
				apiAuthorization.ApiName = context.StringValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].ApiName");
				apiAuthorization.ApiPath = context.StringValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].ApiPath");
				apiAuthorization.ApiStatus = context.IntegerValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].ApiStatus");
				apiAuthorization.CreatedTime = context.StringValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].CreatedTime");
				apiAuthorization.CreatorId = context.StringValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].CreatorId");
				apiAuthorization.GroupId = context.StringValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].GroupId");
				apiAuthorization.ModifiedTime = context.StringValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].ModifiedTime");
				apiAuthorization.ProjectId = context.LongValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].ProjectId");
				apiAuthorization.TenantId = context.LongValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].TenantId");

				List<ListDataServiceApiAuthoritiesResponse.ListDataServiceApiAuthorities_Data.ListDataServiceApiAuthorities_ApiAuthorization.ListDataServiceApiAuthorities_AuthorizationRecord> apiAuthorization_authorizationRecords = new List<ListDataServiceApiAuthoritiesResponse.ListDataServiceApiAuthorities_Data.ListDataServiceApiAuthorities_ApiAuthorization.ListDataServiceApiAuthorities_AuthorizationRecord>();
				for (int j = 0; j < context.Length("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].AuthorizationRecords.Length"); j++) {
					ListDataServiceApiAuthoritiesResponse.ListDataServiceApiAuthorities_Data.ListDataServiceApiAuthorities_ApiAuthorization.ListDataServiceApiAuthorities_AuthorizationRecord authorizationRecord = new ListDataServiceApiAuthoritiesResponse.ListDataServiceApiAuthorities_Data.ListDataServiceApiAuthorities_ApiAuthorization.ListDataServiceApiAuthorities_AuthorizationRecord();
					authorizationRecord.CreatedTime = context.StringValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].AuthorizationRecords["+ j +"].CreatedTime");
					authorizationRecord.CreatorId = context.StringValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].AuthorizationRecords["+ j +"].CreatorId");
					authorizationRecord.EndTime = context.StringValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].AuthorizationRecords["+ j +"].EndTime");
					authorizationRecord.ProjectId = context.LongValue("ListDataServiceApiAuthorities.Data.ApiAuthorizationList["+ i +"].AuthorizationRecords["+ j +"].ProjectId");

					apiAuthorization_authorizationRecords.Add(authorizationRecord);
				}
				apiAuthorization.AuthorizationRecords = apiAuthorization_authorizationRecords;

				data_apiAuthorizationList.Add(apiAuthorization);
			}
			data.ApiAuthorizationList = data_apiAuthorizationList;
			listDataServiceApiAuthoritiesResponse.Data = data;
        
			return listDataServiceApiAuthoritiesResponse;
        }
    }
}
