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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ListFullNatEntriesResponseUnmarshaller
    {
        public static ListFullNatEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFullNatEntriesResponse listFullNatEntriesResponse = new ListFullNatEntriesResponse();

			listFullNatEntriesResponse.HttpResponse = _ctx.HttpResponse;
			listFullNatEntriesResponse.RequestId = _ctx.StringValue("ListFullNatEntries.RequestId");
			listFullNatEntriesResponse.NatGatewayId = _ctx.StringValue("ListFullNatEntries.NatGatewayId");
			listFullNatEntriesResponse.FullNatTableId = _ctx.StringValue("ListFullNatEntries.FullNatTableId");
			listFullNatEntriesResponse.TotalCount = _ctx.LongValue("ListFullNatEntries.TotalCount");
			listFullNatEntriesResponse.NextToken = _ctx.StringValue("ListFullNatEntries.NextToken");
			listFullNatEntriesResponse.MaxResults = _ctx.LongValue("ListFullNatEntries.MaxResults");

			List<ListFullNatEntriesResponse.ListFullNatEntries_FullNatEntry> listFullNatEntriesResponse_fullNatEntries = new List<ListFullNatEntriesResponse.ListFullNatEntries_FullNatEntry>();
			for (int i = 0; i < _ctx.Length("ListFullNatEntries.FullNatEntries.Length"); i++) {
				ListFullNatEntriesResponse.ListFullNatEntries_FullNatEntry fullNatEntry = new ListFullNatEntriesResponse.ListFullNatEntries_FullNatEntry();
				fullNatEntry.NatIp = _ctx.StringValue("ListFullNatEntries.FullNatEntries["+ i +"].NatIp");
				fullNatEntry.NatIpPort = _ctx.StringValue("ListFullNatEntries.FullNatEntries["+ i +"].NatIpPort");
				fullNatEntry.AccessIp = _ctx.StringValue("ListFullNatEntries.FullNatEntries["+ i +"].AccessIp");
				fullNatEntry.AccessPort = _ctx.StringValue("ListFullNatEntries.FullNatEntries["+ i +"].AccessPort");
				fullNatEntry.IpProtocol = _ctx.StringValue("ListFullNatEntries.FullNatEntries["+ i +"].IpProtocol");
				fullNatEntry.NetworkInterfaceId = _ctx.StringValue("ListFullNatEntries.FullNatEntries["+ i +"].NetworkInterfaceId");
				fullNatEntry.NetworkInterfaceType = _ctx.StringValue("ListFullNatEntries.FullNatEntries["+ i +"].NetworkInterfaceType");
				fullNatEntry.FullNatEntryName = _ctx.StringValue("ListFullNatEntries.FullNatEntries["+ i +"].FullNatEntryName");
				fullNatEntry.FullNatEntryDescription = _ctx.StringValue("ListFullNatEntries.FullNatEntries["+ i +"].FullNatEntryDescription");
				fullNatEntry.CreationTime = _ctx.StringValue("ListFullNatEntries.FullNatEntries["+ i +"].CreationTime");
				fullNatEntry.FullNatEntryId = _ctx.StringValue("ListFullNatEntries.FullNatEntries["+ i +"].FullNatEntryId");
				fullNatEntry.FullNatEntryStatus = _ctx.StringValue("ListFullNatEntries.FullNatEntries["+ i +"].FullNatEntryStatus");

				listFullNatEntriesResponse_fullNatEntries.Add(fullNatEntry);
			}
			listFullNatEntriesResponse.FullNatEntries = listFullNatEntriesResponse_fullNatEntries;
        
			return listFullNatEntriesResponse;
        }
    }
}
