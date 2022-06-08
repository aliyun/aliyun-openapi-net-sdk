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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class ListTransitRouterMulticastGroupsResponseUnmarshaller
    {
        public static ListTransitRouterMulticastGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRouterMulticastGroupsResponse listTransitRouterMulticastGroupsResponse = new ListTransitRouterMulticastGroupsResponse();

			listTransitRouterMulticastGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRouterMulticastGroupsResponse.RequestId = _ctx.StringValue("ListTransitRouterMulticastGroups.RequestId");
			listTransitRouterMulticastGroupsResponse.TotalCount = _ctx.IntegerValue("ListTransitRouterMulticastGroups.TotalCount");
			listTransitRouterMulticastGroupsResponse.MaxResults = _ctx.IntegerValue("ListTransitRouterMulticastGroups.MaxResults");
			listTransitRouterMulticastGroupsResponse.NextToken = _ctx.StringValue("ListTransitRouterMulticastGroups.NextToken");

			List<ListTransitRouterMulticastGroupsResponse.ListTransitRouterMulticastGroups_TransitRouterMulticastGroup> listTransitRouterMulticastGroupsResponse_transitRouterMulticastGroups = new List<ListTransitRouterMulticastGroupsResponse.ListTransitRouterMulticastGroups_TransitRouterMulticastGroup>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups.Length"); i++) {
				ListTransitRouterMulticastGroupsResponse.ListTransitRouterMulticastGroups_TransitRouterMulticastGroup transitRouterMulticastGroup = new ListTransitRouterMulticastGroupsResponse.ListTransitRouterMulticastGroups_TransitRouterMulticastGroup();
				transitRouterMulticastGroup.GroupIpAddress = _ctx.StringValue("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups["+ i +"].GroupIpAddress");
				transitRouterMulticastGroup.TransitRouterAttachmentId = _ctx.StringValue("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups["+ i +"].TransitRouterAttachmentId");
				transitRouterMulticastGroup.VSwitchId = _ctx.StringValue("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups["+ i +"].VSwitchId");
				transitRouterMulticastGroup.NetworkInterfaceId = _ctx.StringValue("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups["+ i +"].NetworkInterfaceId");
				transitRouterMulticastGroup.PeerTransitRouterMulticastDomainId = _ctx.StringValue("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups["+ i +"].PeerTransitRouterMulticastDomainId");
				transitRouterMulticastGroup.Status = _ctx.StringValue("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups["+ i +"].Status");
				transitRouterMulticastGroup.GroupSource = _ctx.BooleanValue("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups["+ i +"].GroupSource");
				transitRouterMulticastGroup.GroupMember = _ctx.BooleanValue("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups["+ i +"].GroupMember");
				transitRouterMulticastGroup.MemberType = _ctx.StringValue("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups["+ i +"].MemberType");
				transitRouterMulticastGroup.SourceType = _ctx.StringValue("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups["+ i +"].SourceType");
				transitRouterMulticastGroup.ResourceType = _ctx.StringValue("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups["+ i +"].ResourceType");
				transitRouterMulticastGroup.ResourceOwnerId = _ctx.LongValue("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups["+ i +"].ResourceOwnerId");
				transitRouterMulticastGroup.ResourceId = _ctx.StringValue("ListTransitRouterMulticastGroups.TransitRouterMulticastGroups["+ i +"].ResourceId");

				listTransitRouterMulticastGroupsResponse_transitRouterMulticastGroups.Add(transitRouterMulticastGroup);
			}
			listTransitRouterMulticastGroupsResponse.TransitRouterMulticastGroups = listTransitRouterMulticastGroupsResponse_transitRouterMulticastGroups;
        
			return listTransitRouterMulticastGroupsResponse;
        }
    }
}
