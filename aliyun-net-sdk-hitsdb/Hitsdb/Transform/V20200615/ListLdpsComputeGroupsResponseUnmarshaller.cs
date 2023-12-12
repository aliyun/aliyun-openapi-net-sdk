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
using Aliyun.Acs.hitsdb.Model.V20200615;

namespace Aliyun.Acs.hitsdb.Transform.V20200615
{
    public class ListLdpsComputeGroupsResponseUnmarshaller
    {
        public static ListLdpsComputeGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLdpsComputeGroupsResponse listLdpsComputeGroupsResponse = new ListLdpsComputeGroupsResponse();

			listLdpsComputeGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listLdpsComputeGroupsResponse.RequestId = _ctx.StringValue("ListLdpsComputeGroups.RequestId");

			List<ListLdpsComputeGroupsResponse.ListLdpsComputeGroups_ComputeGroup> listLdpsComputeGroupsResponse_groupList = new List<ListLdpsComputeGroupsResponse.ListLdpsComputeGroups_ComputeGroup>();
			for (int i = 0; i < _ctx.Length("ListLdpsComputeGroups.GroupList.Length"); i++) {
				ListLdpsComputeGroupsResponse.ListLdpsComputeGroups_ComputeGroup computeGroup = new ListLdpsComputeGroupsResponse.ListLdpsComputeGroups_ComputeGroup();
				computeGroup.GroupName = _ctx.StringValue("ListLdpsComputeGroups.GroupList["+ i +"].GroupName");
				computeGroup.Properties = _ctx.StringValue("ListLdpsComputeGroups.GroupList["+ i +"].Properties");

				listLdpsComputeGroupsResponse_groupList.Add(computeGroup);
			}
			listLdpsComputeGroupsResponse.GroupList = listLdpsComputeGroupsResponse_groupList;
        
			return listLdpsComputeGroupsResponse;
        }
    }
}
