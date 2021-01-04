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
        public static DescribeGtmInstanceAddressPoolResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGtmInstanceAddressPoolResponse describeGtmInstanceAddressPoolResponse = new DescribeGtmInstanceAddressPoolResponse();

			describeGtmInstanceAddressPoolResponse.HttpResponse = _ctx.HttpResponse;
			describeGtmInstanceAddressPoolResponse.RequestId = _ctx.StringValue("DescribeGtmInstanceAddressPool.RequestId");
			describeGtmInstanceAddressPoolResponse.AddrPoolId = _ctx.StringValue("DescribeGtmInstanceAddressPool.AddrPoolId");
			describeGtmInstanceAddressPoolResponse.CreateTime = _ctx.StringValue("DescribeGtmInstanceAddressPool.CreateTime");
			describeGtmInstanceAddressPoolResponse.CreateTimestamp = _ctx.LongValue("DescribeGtmInstanceAddressPool.CreateTimestamp");
			describeGtmInstanceAddressPoolResponse.UpdateTime = _ctx.StringValue("DescribeGtmInstanceAddressPool.UpdateTime");
			describeGtmInstanceAddressPoolResponse.UpdateTimestamp = _ctx.LongValue("DescribeGtmInstanceAddressPool.UpdateTimestamp");
			describeGtmInstanceAddressPoolResponse.AddrCount = _ctx.IntegerValue("DescribeGtmInstanceAddressPool.AddrCount");
			describeGtmInstanceAddressPoolResponse.MinAvailableAddrNum = _ctx.IntegerValue("DescribeGtmInstanceAddressPool.MinAvailableAddrNum");
			describeGtmInstanceAddressPoolResponse.MonitorConfigId = _ctx.StringValue("DescribeGtmInstanceAddressPool.MonitorConfigId");
			describeGtmInstanceAddressPoolResponse.MonitorStatus = _ctx.StringValue("DescribeGtmInstanceAddressPool.MonitorStatus");
			describeGtmInstanceAddressPoolResponse.Name = _ctx.StringValue("DescribeGtmInstanceAddressPool.Name");
			describeGtmInstanceAddressPoolResponse.Status = _ctx.StringValue("DescribeGtmInstanceAddressPool.Status");
			describeGtmInstanceAddressPoolResponse.Type = _ctx.StringValue("DescribeGtmInstanceAddressPool.Type");

			List<DescribeGtmInstanceAddressPoolResponse.DescribeGtmInstanceAddressPool_Addr> describeGtmInstanceAddressPoolResponse_addrs = new List<DescribeGtmInstanceAddressPoolResponse.DescribeGtmInstanceAddressPool_Addr>();
			for (int i = 0; i < _ctx.Length("DescribeGtmInstanceAddressPool.Addrs.Length"); i++) {
				DescribeGtmInstanceAddressPoolResponse.DescribeGtmInstanceAddressPool_Addr addr = new DescribeGtmInstanceAddressPoolResponse.DescribeGtmInstanceAddressPool_Addr();
				addr.AddrId = _ctx.LongValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].AddrId");
				addr.CreateTime = _ctx.StringValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].CreateTime");
				addr.CreateTimestamp = _ctx.LongValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].CreateTimestamp");
				addr.UpdateTime = _ctx.StringValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].UpdateTime");
				addr.UpdateTimestamp = _ctx.LongValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].UpdateTimestamp");
				addr._Value = _ctx.StringValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].Value");
				addr.LbaWeight = _ctx.IntegerValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].LbaWeight");
				addr.Mode = _ctx.StringValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].Mode");
				addr.AlertStatus = _ctx.StringValue("DescribeGtmInstanceAddressPool.Addrs["+ i +"].AlertStatus");

				describeGtmInstanceAddressPoolResponse_addrs.Add(addr);
			}
			describeGtmInstanceAddressPoolResponse.Addrs = describeGtmInstanceAddressPoolResponse_addrs;
        
			return describeGtmInstanceAddressPoolResponse;
        }
    }
}
