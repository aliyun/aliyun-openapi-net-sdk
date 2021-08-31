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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListServiceGroupsResponseUnmarshaller
    {
        public static ListServiceGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListServiceGroupsResponse listServiceGroupsResponse = new ListServiceGroupsResponse();

			listServiceGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listServiceGroupsResponse.Code = _ctx.IntegerValue("ListServiceGroups.Code");
			listServiceGroupsResponse.Message = _ctx.StringValue("ListServiceGroups.Message");
			listServiceGroupsResponse.RequestId = _ctx.StringValue("ListServiceGroups.RequestId");

			List<ListServiceGroupsResponse.ListServiceGroups_ListServiceGroups> listServiceGroupsResponse_serviceGroupsList = new List<ListServiceGroupsResponse.ListServiceGroups_ListServiceGroups>();
			for (int i = 0; i < _ctx.Length("ListServiceGroups.ServiceGroupsList.Length"); i++) {
				ListServiceGroupsResponse.ListServiceGroups_ListServiceGroups listServiceGroups = new ListServiceGroupsResponse.ListServiceGroups_ListServiceGroups();
				listServiceGroups.CreateTime = _ctx.StringValue("ListServiceGroups.ServiceGroupsList["+ i +"].CreateTime");
				listServiceGroups.GroupId = _ctx.StringValue("ListServiceGroups.ServiceGroupsList["+ i +"].GroupId");
				listServiceGroups.GroupName = _ctx.StringValue("ListServiceGroups.ServiceGroupsList["+ i +"].GroupName");

				listServiceGroupsResponse_serviceGroupsList.Add(listServiceGroups);
			}
			listServiceGroupsResponse.ServiceGroupsList = listServiceGroupsResponse_serviceGroupsList;
        
			return listServiceGroupsResponse;
        }
    }
}
