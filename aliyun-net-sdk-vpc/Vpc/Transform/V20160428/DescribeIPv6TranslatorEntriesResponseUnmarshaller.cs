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
    public class DescribeIPv6TranslatorEntriesResponseUnmarshaller
    {
        public static DescribeIPv6TranslatorEntriesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIPv6TranslatorEntriesResponse describeIPv6TranslatorEntriesResponse = new DescribeIPv6TranslatorEntriesResponse();

			describeIPv6TranslatorEntriesResponse.HttpResponse = context.HttpResponse;
			describeIPv6TranslatorEntriesResponse.RequestId = context.StringValue("DescribeIPv6TranslatorEntries.RequestId");
			describeIPv6TranslatorEntriesResponse.TotalCount = context.IntegerValue("DescribeIPv6TranslatorEntries.TotalCount");
			describeIPv6TranslatorEntriesResponse.PageNumber = context.IntegerValue("DescribeIPv6TranslatorEntries.PageNumber");
			describeIPv6TranslatorEntriesResponse.PageSize = context.IntegerValue("DescribeIPv6TranslatorEntries.PageSize");

			List<DescribeIPv6TranslatorEntriesResponse.DescribeIPv6TranslatorEntries_Ipv6TranslatorEntry> describeIPv6TranslatorEntriesResponse_ipv6TranslatorEntries = new List<DescribeIPv6TranslatorEntriesResponse.DescribeIPv6TranslatorEntries_Ipv6TranslatorEntry>();
			for (int i = 0; i < context.Length("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries.Length"); i++) {
				DescribeIPv6TranslatorEntriesResponse.DescribeIPv6TranslatorEntries_Ipv6TranslatorEntry ipv6TranslatorEntry = new DescribeIPv6TranslatorEntriesResponse.DescribeIPv6TranslatorEntries_Ipv6TranslatorEntry();
				ipv6TranslatorEntry.Ipv6TranslatorId = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].Ipv6TranslatorId");
				ipv6TranslatorEntry.Ipv6TranslatorEntryId = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].Ipv6TranslatorEntryId");
				ipv6TranslatorEntry.AllocateIpv6Addr = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].AllocateIpv6Addr");
				ipv6TranslatorEntry.AllocateIpv6Port = context.IntegerValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].AllocateIpv6Port");
				ipv6TranslatorEntry.BackendIpv4Addr = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].BackendIpv4Addr");
				ipv6TranslatorEntry.BackendIpv4Port = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].BackendIpv4Port");
				ipv6TranslatorEntry.TransProtocol = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].TransProtocol");
				ipv6TranslatorEntry.EntryBandwidth = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].EntryBandwidth");
				ipv6TranslatorEntry.EntryDescription = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].EntryDescription");
				ipv6TranslatorEntry.EntryName = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].EntryName");
				ipv6TranslatorEntry.EntryStatus = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].EntryStatus");
				ipv6TranslatorEntry.AclStatus = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].AclStatus");
				ipv6TranslatorEntry.AclType = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].AclType");
				ipv6TranslatorEntry.AclId = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].AclId");
				ipv6TranslatorEntry.RegionId = context.StringValue("DescribeIPv6TranslatorEntries.Ipv6TranslatorEntries["+ i +"].RegionId");

				describeIPv6TranslatorEntriesResponse_ipv6TranslatorEntries.Add(ipv6TranslatorEntry);
			}
			describeIPv6TranslatorEntriesResponse.Ipv6TranslatorEntries = describeIPv6TranslatorEntriesResponse_ipv6TranslatorEntries;
        
			return describeIPv6TranslatorEntriesResponse;
        }
    }
}
