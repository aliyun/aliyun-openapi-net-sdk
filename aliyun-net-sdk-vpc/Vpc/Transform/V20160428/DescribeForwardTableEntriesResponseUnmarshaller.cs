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
    public class DescribeForwardTableEntriesResponseUnmarshaller
    {
        public static DescribeForwardTableEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeForwardTableEntriesResponse describeForwardTableEntriesResponse = new DescribeForwardTableEntriesResponse();

			describeForwardTableEntriesResponse.HttpResponse = _ctx.HttpResponse;
			describeForwardTableEntriesResponse.RequestId = _ctx.StringValue("DescribeForwardTableEntries.RequestId");
			describeForwardTableEntriesResponse.TotalCount = _ctx.IntegerValue("DescribeForwardTableEntries.TotalCount");
			describeForwardTableEntriesResponse.PageNumber = _ctx.IntegerValue("DescribeForwardTableEntries.PageNumber");
			describeForwardTableEntriesResponse.PageSize = _ctx.IntegerValue("DescribeForwardTableEntries.PageSize");

			List<DescribeForwardTableEntriesResponse.DescribeForwardTableEntries_ForwardTableEntry> describeForwardTableEntriesResponse_forwardTableEntries = new List<DescribeForwardTableEntriesResponse.DescribeForwardTableEntries_ForwardTableEntry>();
			for (int i = 0; i < _ctx.Length("DescribeForwardTableEntries.ForwardTableEntries.Length"); i++) {
				DescribeForwardTableEntriesResponse.DescribeForwardTableEntries_ForwardTableEntry forwardTableEntry = new DescribeForwardTableEntriesResponse.DescribeForwardTableEntries_ForwardTableEntry();
				forwardTableEntry.ForwardTableId = _ctx.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].ForwardTableId");
				forwardTableEntry.ForwardEntryId = _ctx.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].ForwardEntryId");
				forwardTableEntry.ExternalIp = _ctx.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].ExternalIp");
				forwardTableEntry.ExternalPort = _ctx.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].ExternalPort");
				forwardTableEntry.IpProtocol = _ctx.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].IpProtocol");
				forwardTableEntry.InternalIp = _ctx.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].InternalIp");
				forwardTableEntry.InternalPort = _ctx.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].InternalPort");
				forwardTableEntry.Status = _ctx.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].Status");
				forwardTableEntry.ForwardEntryName = _ctx.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].ForwardEntryName");

				describeForwardTableEntriesResponse_forwardTableEntries.Add(forwardTableEntry);
			}
			describeForwardTableEntriesResponse.ForwardTableEntries = describeForwardTableEntriesResponse_forwardTableEntries;
        
			return describeForwardTableEntriesResponse;
        }
    }
}
