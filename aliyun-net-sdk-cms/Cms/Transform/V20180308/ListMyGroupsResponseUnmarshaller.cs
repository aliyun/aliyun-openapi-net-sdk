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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cms.Model.V20180308;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class ListMyGroupsResponseUnmarshaller
    {
        public static ListMyGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			ListMyGroupsResponse listMyGroupsResponse = new ListMyGroupsResponse();

			listMyGroupsResponse.HttpResponse = context.HttpResponse;
			listMyGroupsResponse.RequestId = context.StringValue("ListMyGroups.RequestId");
			listMyGroupsResponse.Success = context.BooleanValue("ListMyGroups.Success");
			listMyGroupsResponse.ErrorCode = context.IntegerValue("ListMyGroups.ErrorCode");
			listMyGroupsResponse.ErrorMessage = context.StringValue("ListMyGroups.ErrorMessage");
			listMyGroupsResponse.PageNumber = context.IntegerValue("ListMyGroups.PageNumber");
			listMyGroupsResponse.PageSize = context.IntegerValue("ListMyGroups.PageSize");
			listMyGroupsResponse.Total = context.IntegerValue("ListMyGroups.Total");

			List<ListMyGroupsResponse.ListMyGroups_Resource> listMyGroupsResponse_resources = new List<ListMyGroupsResponse.ListMyGroups_Resource>();
			for (int i = 0; i < context.Length("ListMyGroups.Resources.Length"); i++) {
				ListMyGroupsResponse.ListMyGroups_Resource resource = new ListMyGroupsResponse.ListMyGroups_Resource();
				resource.GroupId = context.LongValue("ListMyGroups.Resources["+ i +"].GroupId");
				resource.GroupName = context.StringValue("ListMyGroups.Resources["+ i +"].GroupName");
				resource.ServiceId = context.StringValue("ListMyGroups.Resources["+ i +"].ServiceId");
				resource.BindUrls = context.StringValue("ListMyGroups.Resources["+ i +"].BindUrls");
				resource.Type = context.StringValue("ListMyGroups.Resources["+ i +"].Type");
				resource.GmtModified = context.LongValue("ListMyGroups.Resources["+ i +"].GmtModified");
				resource.GmtCreate = context.LongValue("ListMyGroups.Resources["+ i +"].GmtCreate");

				List<ListMyGroupsResponse.ListMyGroups_Resource.ListMyGroups_ContactGroup> resource_contactGroups = new List<ListMyGroupsResponse.ListMyGroups_Resource.ListMyGroups_ContactGroup>();
				for (int j = 0; j < context.Length("ListMyGroups.Resources["+ i +"].ContactGroups.Length"); j++) {
					ListMyGroupsResponse.ListMyGroups_Resource.ListMyGroups_ContactGroup contactGroup = new ListMyGroupsResponse.ListMyGroups_Resource.ListMyGroups_ContactGroup();
					contactGroup.Name = context.StringValue("ListMyGroups.Resources["+ i +"].ContactGroups["+ j +"].Name");

					resource_contactGroups.Add(contactGroup);
				}
				resource.ContactGroups = resource_contactGroups;

				listMyGroupsResponse_resources.Add(resource);
			}
			listMyGroupsResponse.Resources = listMyGroupsResponse_resources;
        
			return listMyGroupsResponse;
        }
    }
}