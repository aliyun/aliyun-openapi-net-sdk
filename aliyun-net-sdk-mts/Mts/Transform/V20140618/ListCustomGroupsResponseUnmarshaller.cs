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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ListCustomGroupsResponseUnmarshaller
    {
        public static ListCustomGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCustomGroupsResponse listCustomGroupsResponse = new ListCustomGroupsResponse();

			listCustomGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listCustomGroupsResponse.RequestId = _ctx.StringValue("ListCustomGroups.RequestId");
			listCustomGroupsResponse.PageNumber = _ctx.IntegerValue("ListCustomGroups.PageNumber");
			listCustomGroupsResponse.PageSize = _ctx.IntegerValue("ListCustomGroups.PageSize");
			listCustomGroupsResponse.TotalCount = _ctx.LongValue("ListCustomGroups.TotalCount");

			List<ListCustomGroupsResponse.ListCustomGroups_CustomGroup> listCustomGroupsResponse_customGroups = new List<ListCustomGroupsResponse.ListCustomGroups_CustomGroup>();
			for (int i = 0; i < _ctx.Length("ListCustomGroups.CustomGroups.Length"); i++) {
				ListCustomGroupsResponse.ListCustomGroups_CustomGroup customGroup = new ListCustomGroupsResponse.ListCustomGroups_CustomGroup();
				customGroup.CustomGroupId = _ctx.StringValue("ListCustomGroups.CustomGroups["+ i +"].CustomGroupId");
				customGroup.CustomGroupName = _ctx.StringValue("ListCustomGroups.CustomGroups["+ i +"].CustomGroupName");
				customGroup.CustomGroupDescription = _ctx.StringValue("ListCustomGroups.CustomGroups["+ i +"].CustomGroupDescription");

				listCustomGroupsResponse_customGroups.Add(customGroup);
			}
			listCustomGroupsResponse.CustomGroups = listCustomGroupsResponse_customGroups;
        
			return listCustomGroupsResponse;
        }
    }
}
