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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListClusterServiceQuickLinkResponseUnmarshaller
    {
        public static ListClusterServiceQuickLinkResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterServiceQuickLinkResponse listClusterServiceQuickLinkResponse = new ListClusterServiceQuickLinkResponse();

			listClusterServiceQuickLinkResponse.HttpResponse = context.HttpResponse;
			listClusterServiceQuickLinkResponse.RequestId = context.StringValue("ListClusterServiceQuickLink.RequestId");

			List<ListClusterServiceQuickLinkResponse.ListClusterServiceQuickLink_QuickLink> listClusterServiceQuickLinkResponse_quickLinkList = new List<ListClusterServiceQuickLinkResponse.ListClusterServiceQuickLink_QuickLink>();
			for (int i = 0; i < context.Length("ListClusterServiceQuickLink.QuickLinkList.Length"); i++) {
				ListClusterServiceQuickLinkResponse.ListClusterServiceQuickLink_QuickLink quickLink = new ListClusterServiceQuickLinkResponse.ListClusterServiceQuickLink_QuickLink();
				quickLink.ServiceName = context.StringValue("ListClusterServiceQuickLink.QuickLinkList["+ i +"].ServiceName");
				quickLink.ServiceDisplayName = context.StringValue("ListClusterServiceQuickLink.QuickLinkList["+ i +"].ServiceDisplayName");
				quickLink.QuickLinkAddress = context.StringValue("ListClusterServiceQuickLink.QuickLinkList["+ i +"].QuickLinkAddress");
				quickLink.Protocol = context.StringValue("ListClusterServiceQuickLink.QuickLinkList["+ i +"].Protocol");
				quickLink.Port = context.StringValue("ListClusterServiceQuickLink.QuickLinkList["+ i +"].Port");
				quickLink.Type = context.StringValue("ListClusterServiceQuickLink.QuickLinkList["+ i +"].Type");

				listClusterServiceQuickLinkResponse_quickLinkList.Add(quickLink);
			}
			listClusterServiceQuickLinkResponse.QuickLinkList = listClusterServiceQuickLinkResponse_quickLinkList;
        
			return listClusterServiceQuickLinkResponse;
        }
    }
}
