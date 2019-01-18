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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeForwardTablesResponseUnmarshaller
    {
        public static DescribeForwardTablesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeForwardTablesResponse describeForwardTablesResponse = new DescribeForwardTablesResponse();

			describeForwardTablesResponse.HttpResponse = context.HttpResponse;
			describeForwardTablesResponse.RequestId = context.StringValue("DescribeForwardTables.RequestId");
			describeForwardTablesResponse.TotalCount = context.IntegerValue("DescribeForwardTables.TotalCount");
			describeForwardTablesResponse.PageNumber = context.IntegerValue("DescribeForwardTables.PageNumber");
			describeForwardTablesResponse.PageSize = context.IntegerValue("DescribeForwardTables.PageSize");

			List<DescribeForwardTablesResponse.DescribeForwardTables_ForwardTable> describeForwardTablesResponse_forwardTables = new List<DescribeForwardTablesResponse.DescribeForwardTables_ForwardTable>();
			for (int i = 0; i < context.Length("DescribeForwardTables.ForwardTables.Length"); i++) {
				DescribeForwardTablesResponse.DescribeForwardTables_ForwardTable forwardTable = new DescribeForwardTablesResponse.DescribeForwardTables_ForwardTable();
				forwardTable.NatGatewayId = context.StringValue("DescribeForwardTables.ForwardTables["+ i +"].NatGatewayId");
				forwardTable.ForwardTableId = context.StringValue("DescribeForwardTables.ForwardTables["+ i +"].ForwardTableId");
				forwardTable.CreationTime = context.StringValue("DescribeForwardTables.ForwardTables["+ i +"].CreationTime");

				List<DescribeForwardTablesResponse.DescribeForwardTables_ForwardTable.DescribeForwardTables_ForwardEntry> forwardTable_forwardEntrys = new List<DescribeForwardTablesResponse.DescribeForwardTables_ForwardTable.DescribeForwardTables_ForwardEntry>();
				for (int j = 0; j < context.Length("DescribeForwardTables.ForwardTables["+ i +"].ForwardEntrys.Length"); j++) {
					DescribeForwardTablesResponse.DescribeForwardTables_ForwardTable.DescribeForwardTables_ForwardEntry forwardEntry = new DescribeForwardTablesResponse.DescribeForwardTables_ForwardTable.DescribeForwardTables_ForwardEntry();
					forwardEntry.ForwardTableId = context.StringValue("DescribeForwardTables.ForwardTables["+ i +"].ForwardEntrys["+ j +"].ForwardTableId");
					forwardEntry.ForwardEntryId = context.StringValue("DescribeForwardTables.ForwardTables["+ i +"].ForwardEntrys["+ j +"].ForwardEntryId");
					forwardEntry.ExternalIp = context.StringValue("DescribeForwardTables.ForwardTables["+ i +"].ForwardEntrys["+ j +"].ExternalIp");
					forwardEntry.ExternalPort = context.StringValue("DescribeForwardTables.ForwardTables["+ i +"].ForwardEntrys["+ j +"].ExternalPort");
					forwardEntry.IpProtocol = context.StringValue("DescribeForwardTables.ForwardTables["+ i +"].ForwardEntrys["+ j +"].IpProtocol");
					forwardEntry.InternalIp = context.StringValue("DescribeForwardTables.ForwardTables["+ i +"].ForwardEntrys["+ j +"].InternalIp");
					forwardEntry.InternalPort = context.StringValue("DescribeForwardTables.ForwardTables["+ i +"].ForwardEntrys["+ j +"].InternalPort");
					forwardEntry.Status = context.StringValue("DescribeForwardTables.ForwardTables["+ i +"].ForwardEntrys["+ j +"].Status");

					forwardTable_forwardEntrys.Add(forwardEntry);
				}
				forwardTable.ForwardEntrys = forwardTable_forwardEntrys;

				describeForwardTablesResponse_forwardTables.Add(forwardTable);
			}
			describeForwardTablesResponse.ForwardTables = describeForwardTablesResponse_forwardTables;
        
			return describeForwardTablesResponse;
        }
    }
}