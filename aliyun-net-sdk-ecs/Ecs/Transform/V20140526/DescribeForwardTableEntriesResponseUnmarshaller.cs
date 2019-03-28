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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeForwardTableEntriesResponseUnmarshaller
    {
        public static DescribeForwardTableEntriesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeForwardTableEntriesResponse describeForwardTableEntriesResponse = new DescribeForwardTableEntriesResponse();

			describeForwardTableEntriesResponse.HttpResponse = context.HttpResponse;
			describeForwardTableEntriesResponse.RequestId = context.StringValue("DescribeForwardTableEntries.RequestId");
			describeForwardTableEntriesResponse.TotalCount = context.IntegerValue("DescribeForwardTableEntries.TotalCount");
			describeForwardTableEntriesResponse.PageNumber = context.IntegerValue("DescribeForwardTableEntries.PageNumber");
			describeForwardTableEntriesResponse.PageSize = context.IntegerValue("DescribeForwardTableEntries.PageSize");

			List<DescribeForwardTableEntriesResponse.DescribeForwardTableEntries_ForwardTableEntry> describeForwardTableEntriesResponse_forwardTableEntries = new List<DescribeForwardTableEntriesResponse.DescribeForwardTableEntries_ForwardTableEntry>();
			for (int i = 0; i < context.Length("DescribeForwardTableEntries.ForwardTableEntries.Length"); i++) {
				DescribeForwardTableEntriesResponse.DescribeForwardTableEntries_ForwardTableEntry forwardTableEntry = new DescribeForwardTableEntriesResponse.DescribeForwardTableEntries_ForwardTableEntry();
				forwardTableEntry.ForwardTableId = context.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].ForwardTableId");
				forwardTableEntry.ForwardEntryId = context.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].ForwardEntryId");
				forwardTableEntry.ExternalIp = context.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].ExternalIp");
				forwardTableEntry.ExternalPort = context.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].ExternalPort");
				forwardTableEntry.IpProtocol = context.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].IpProtocol");
				forwardTableEntry.InternalIp = context.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].InternalIp");
				forwardTableEntry.InternalPort = context.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].InternalPort");
				forwardTableEntry.Status = context.StringValue("DescribeForwardTableEntries.ForwardTableEntries["+ i +"].Status");

				describeForwardTableEntriesResponse_forwardTableEntries.Add(forwardTableEntry);
			}
			describeForwardTableEntriesResponse.ForwardTableEntries = describeForwardTableEntriesResponse_forwardTableEntries;
        
			return describeForwardTableEntriesResponse;
        }
    }
}
