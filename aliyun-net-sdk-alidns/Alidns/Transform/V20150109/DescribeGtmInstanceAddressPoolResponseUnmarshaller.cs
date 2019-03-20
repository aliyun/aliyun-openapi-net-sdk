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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeGtmInstanceAddressPoolResponseUnmarshaller
    {
        public static DescribeGtmInstanceAddressPoolResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGtmInstanceAddressPoolResponse describeGtmInstanceAddressPoolResponse = new DescribeGtmInstanceAddressPoolResponse();

			describeGtmInstanceAddressPoolResponse.HttpResponse = context.HttpResponse;
			describeGtmInstanceAddressPoolResponse.RequestId = context.StringValue("DescribeGtmInstanceAddressPool.RequestId");
			describeGtmInstanceAddressPoolResponse.AddrPoolId = context.StringValue("DescribeGtmInstanceAddressPool.AddrPoolId");
			describeGtmInstanceAddressPoolResponse.CreateTime = context.StringValue("DescribeGtmInstanceAddressPool.CreateTime");
			describeGtmInstanceAddressPoolResponse.CreateTimestamp = context.LongValue("DescribeGtmInstanceAddressPool.CreateTimestamp");
			describeGtmInstanceAddressPoolResponse.UpdateTime = context.StringValue("DescribeGtmInstanceAddressPool.UpdateTime");
			describeGtmInstanceAddressPoolResponse.UpdateTimestamp = context.LongValue("DescribeGtmInstanceAddressPool.UpdateTimestamp");
			describeGtmInstanceAddressPoolResponse.AddrCount = context.IntegerValue("DescribeGtmInstanceAddressPool.AddrCount");
			describeGtmInstanceAddressPoolResponse.MinAvailableAddrNum = context.IntegerValue("DescribeGtmInstanceAddressPool.MinAvailableAddrNum");
			describeGtmInstanceAddressPoolResponse.MonitorConfigId = context.StringValue("DescribeGtmInstanceAddressPool.MonitorConfigId");
			describeGtmInstanceAddressPoolResponse.MonitorStatus = context.StringValue("DescribeGtmInstanceAddressPool.MonitorStatus");
			describeGtmInstanceAddressPoolResponse.Name = context.StringValue("DescribeGtmInstanceAddressPool.Name");
			describeGtmInstanceAddressPoolResponse.Status = context.StringValue("DescribeGtmInstanceAddressPool.Status");
			describeGtmInstanceAddressPoolResponse.Type = context.StringValue("DescribeGtmInstanceAddressPool.Type");

			List<DescribeGtmInstanceAddressPoolResponse.DescribeGtmInstanceAddressPool_Addr> describeGtmInstanceAddressPoolResponse_addrs = new List<DescribeGtmInstanceAddressPoolResponse.DescribeGtmInstanceAddressPool_Addr>();
			for (int i = 0; i < context.Length("DescribeGtmInstanceAddressPool.Addrs.Length"); i++) {
				DescribeGtmInstanceAddressPoolResponse.DescribeGtmInstanceAddressPool_Addr addr = new DescribeGtmInstanceAddressPoolResponse.DescribeGtmInstanceAddressPool_Addr();
				addr.AddrId = context.LongValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].AddrId");
				addr.CreateTime = context.StringValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].CreateTime");
				addr.CreateTimestamp = context.LongValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].CreateTimestamp");
				addr.UpdateTime = context.StringValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].UpdateTime");
				addr.UpdateTimestamp = context.LongValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].UpdateTimestamp");
				addr._Value = context.StringValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].Value");
				addr.LbaWeight = context.IntegerValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].LbaWeight");
				addr.Mode = context.StringValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].Mode");
				addr.AlertStatus = context.StringValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].AlertStatus");

				describeGtmInstanceAddressPoolResponse_addrs.Add(addr);
			}
			describeGtmInstanceAddressPoolResponse.Addrs = describeGtmInstanceAddressPoolResponse_addrs;
        
			return describeGtmInstanceAddressPoolResponse;
        }
    }
}
