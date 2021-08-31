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
    public class ListClusterMembersResponseUnmarshaller
    {
        public static ListClusterMembersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterMembersResponse listClusterMembersResponse = new ListClusterMembersResponse();

			listClusterMembersResponse.HttpResponse = _ctx.HttpResponse;
			listClusterMembersResponse.Code = _ctx.IntegerValue("ListClusterMembers.Code");
			listClusterMembersResponse.Message = _ctx.StringValue("ListClusterMembers.Message");
			listClusterMembersResponse.RequestId = _ctx.StringValue("ListClusterMembers.RequestId");

			ListClusterMembersResponse.ListClusterMembers_ClusterMemberPage clusterMemberPage = new ListClusterMembersResponse.ListClusterMembers_ClusterMemberPage();
			clusterMemberPage.CurrentPage = _ctx.IntegerValue("ListClusterMembers.ClusterMemberPage.CurrentPage");
			clusterMemberPage.PageSize = _ctx.IntegerValue("ListClusterMembers.ClusterMemberPage.PageSize");
			clusterMemberPage.TotalSize = _ctx.IntegerValue("ListClusterMembers.ClusterMemberPage.TotalSize");

			List<ListClusterMembersResponse.ListClusterMembers_ClusterMemberPage.ListClusterMembers_ClusterMember> clusterMemberPage_clusterMemberList = new List<ListClusterMembersResponse.ListClusterMembers_ClusterMemberPage.ListClusterMembers_ClusterMember>();
			for (int i = 0; i < _ctx.Length("ListClusterMembers.ClusterMemberPage.ClusterMemberList.Length"); i++) {
				ListClusterMembersResponse.ListClusterMembers_ClusterMemberPage.ListClusterMembers_ClusterMember clusterMember = new ListClusterMembersResponse.ListClusterMembers_ClusterMemberPage.ListClusterMembers_ClusterMember();
				clusterMember.ClusterMemberId = _ctx.StringValue("ListClusterMembers.ClusterMemberPage.ClusterMemberList["+ i +"].ClusterMemberId");
				clusterMember.ClusterId = _ctx.StringValue("ListClusterMembers.ClusterMemberPage.ClusterMemberList["+ i +"].ClusterId");
				clusterMember.EcuId = _ctx.StringValue("ListClusterMembers.ClusterMemberPage.ClusterMemberList["+ i +"].EcuId");
				clusterMember.EcsId = _ctx.StringValue("ListClusterMembers.ClusterMemberPage.ClusterMemberList["+ i +"].EcsId");
				clusterMember.Status = _ctx.IntegerValue("ListClusterMembers.ClusterMemberPage.ClusterMemberList["+ i +"].Status");
				clusterMember.CreateTime = _ctx.LongValue("ListClusterMembers.ClusterMemberPage.ClusterMemberList["+ i +"].CreateTime");
				clusterMember.UpdateTime = _ctx.LongValue("ListClusterMembers.ClusterMemberPage.ClusterMemberList["+ i +"].UpdateTime");

				clusterMemberPage_clusterMemberList.Add(clusterMember);
			}
			clusterMemberPage.ClusterMemberList = clusterMemberPage_clusterMemberList;
			listClusterMembersResponse.ClusterMemberPage = clusterMemberPage;
        
			return listClusterMembersResponse;
        }
    }
}
