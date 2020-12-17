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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class ListStackGroupsResponseUnmarshaller
    {
        public static ListStackGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStackGroupsResponse listStackGroupsResponse = new ListStackGroupsResponse();

			listStackGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listStackGroupsResponse.RequestId = _ctx.StringValue("ListStackGroups.RequestId");
			listStackGroupsResponse.PageNumber = _ctx.IntegerValue("ListStackGroups.PageNumber");
			listStackGroupsResponse.PageSize = _ctx.IntegerValue("ListStackGroups.PageSize");
			listStackGroupsResponse.TotalCount = _ctx.IntegerValue("ListStackGroups.TotalCount");

			List<ListStackGroupsResponse.ListStackGroups_StackGroup> listStackGroupsResponse_stackGroups = new List<ListStackGroupsResponse.ListStackGroups_StackGroup>();
			for (int i = 0; i < _ctx.Length("ListStackGroups.StackGroups.Length"); i++) {
				ListStackGroupsResponse.ListStackGroups_StackGroup stackGroup = new ListStackGroupsResponse.ListStackGroups_StackGroup();
				stackGroup.StackGroupName = _ctx.StringValue("ListStackGroups.StackGroups["+ i +"].StackGroupName");
				stackGroup.StackGroupId = _ctx.StringValue("ListStackGroups.StackGroups["+ i +"].StackGroupId");
				stackGroup.Status = _ctx.StringValue("ListStackGroups.StackGroups["+ i +"].Status");
				stackGroup.Description = _ctx.StringValue("ListStackGroups.StackGroups["+ i +"].Description");
				stackGroup.DriftDetectionTime = _ctx.StringValue("ListStackGroups.StackGroups["+ i +"].DriftDetectionTime");
				stackGroup.StackGroupDriftStatus = _ctx.StringValue("ListStackGroups.StackGroups["+ i +"].StackGroupDriftStatus");

				listStackGroupsResponse_stackGroups.Add(stackGroup);
			}
			listStackGroupsResponse.StackGroups = listStackGroupsResponse_stackGroups;
        
			return listStackGroupsResponse;
        }
    }
}
