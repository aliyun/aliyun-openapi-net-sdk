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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class ListOrganizationsResponseUnmarshaller
    {
        public static ListOrganizationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOrganizationsResponse listOrganizationsResponse = new ListOrganizationsResponse();

			listOrganizationsResponse.HttpResponse = _ctx.HttpResponse;
			listOrganizationsResponse.RequestId = _ctx.StringValue("ListOrganizations.RequestId");
			listOrganizationsResponse.ErrorCode = _ctx.StringValue("ListOrganizations.ErrorCode");
			listOrganizationsResponse.Success = _ctx.BooleanValue("ListOrganizations.Success");
			listOrganizationsResponse.ErrorMessage = _ctx.StringValue("ListOrganizations.ErrorMessage");

			List<ListOrganizationsResponse.ListOrganizations_ResultItem> listOrganizationsResponse_result = new List<ListOrganizationsResponse.ListOrganizations_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListOrganizations.Result.Length"); i++) {
				ListOrganizationsResponse.ListOrganizations_ResultItem resultItem = new ListOrganizationsResponse.ListOrganizations_ResultItem();
				resultItem.OrganizationId = _ctx.StringValue("ListOrganizations.Result["+ i +"].OrganizationId");
				resultItem.OrganizationName = _ctx.StringValue("ListOrganizations.Result["+ i +"].OrganizationName");
				resultItem.OrganizationRole = _ctx.StringValue("ListOrganizations.Result["+ i +"].OrganizationRole");
				resultItem.AccessLevel = _ctx.IntegerValue("ListOrganizations.Result["+ i +"].AccessLevel");

				listOrganizationsResponse_result.Add(resultItem);
			}
			listOrganizationsResponse.Result = listOrganizationsResponse_result;
        
			return listOrganizationsResponse;
        }
    }
}
