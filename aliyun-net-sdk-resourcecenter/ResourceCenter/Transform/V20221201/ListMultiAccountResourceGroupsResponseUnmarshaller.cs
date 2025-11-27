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
using Aliyun.Acs.ResourceCenter.Model.V20221201;

namespace Aliyun.Acs.ResourceCenter.Transform.V20221201
{
    public class ListMultiAccountResourceGroupsResponseUnmarshaller
    {
        public static ListMultiAccountResourceGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMultiAccountResourceGroupsResponse listMultiAccountResourceGroupsResponse = new ListMultiAccountResourceGroupsResponse();

			listMultiAccountResourceGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listMultiAccountResourceGroupsResponse.DynamicCode = _ctx.StringValue("ListMultiAccountResourceGroups.DynamicCode");
			listMultiAccountResourceGroupsResponse.DynamicMessage = _ctx.StringValue("ListMultiAccountResourceGroups.DynamicMessage");
			listMultiAccountResourceGroupsResponse.ErrorCode = _ctx.StringValue("ListMultiAccountResourceGroups.ErrorCode");
			listMultiAccountResourceGroupsResponse.ErrorMessage = _ctx.StringValue("ListMultiAccountResourceGroups.ErrorMessage");
			listMultiAccountResourceGroupsResponse.NextToken = _ctx.StringValue("ListMultiAccountResourceGroups.NextToken");
			listMultiAccountResourceGroupsResponse.RequestId = _ctx.StringValue("ListMultiAccountResourceGroups.RequestId");
			listMultiAccountResourceGroupsResponse.Success = _ctx.BooleanValue("ListMultiAccountResourceGroups.Success");

			List<ListMultiAccountResourceGroupsResponse.ListMultiAccountResourceGroups_ResourceGroup> listMultiAccountResourceGroupsResponse_resourceGroups = new List<ListMultiAccountResourceGroupsResponse.ListMultiAccountResourceGroups_ResourceGroup>();
			for (int i = 0; i < _ctx.Length("ListMultiAccountResourceGroups.ResourceGroups.Length"); i++) {
				ListMultiAccountResourceGroupsResponse.ListMultiAccountResourceGroups_ResourceGroup resourceGroup = new ListMultiAccountResourceGroupsResponse.ListMultiAccountResourceGroups_ResourceGroup();
				resourceGroup.AccountId = _ctx.StringValue("ListMultiAccountResourceGroups.ResourceGroups["+ i +"].AccountId");
				resourceGroup.CreateDate = _ctx.StringValue("ListMultiAccountResourceGroups.ResourceGroups["+ i +"].CreateDate");
				resourceGroup.DisplayName = _ctx.StringValue("ListMultiAccountResourceGroups.ResourceGroups["+ i +"].DisplayName");
				resourceGroup.Id = _ctx.StringValue("ListMultiAccountResourceGroups.ResourceGroups["+ i +"].Id");
				resourceGroup.Name = _ctx.StringValue("ListMultiAccountResourceGroups.ResourceGroups["+ i +"].Name");
				resourceGroup.Status = _ctx.StringValue("ListMultiAccountResourceGroups.ResourceGroups["+ i +"].Status");

				listMultiAccountResourceGroupsResponse_resourceGroups.Add(resourceGroup);
			}
			listMultiAccountResourceGroupsResponse.ResourceGroups = listMultiAccountResourceGroupsResponse_resourceGroups;
        
			return listMultiAccountResourceGroupsResponse;
        }
    }
}
