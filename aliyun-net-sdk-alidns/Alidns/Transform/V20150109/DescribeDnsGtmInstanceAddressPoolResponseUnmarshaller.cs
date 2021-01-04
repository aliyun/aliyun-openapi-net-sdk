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
    public class DescribeDnsGtmInstanceAddressPoolResponseUnmarshaller
    {
        public static DescribeDnsGtmInstanceAddressPoolResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsGtmInstanceAddressPoolResponse describeDnsGtmInstanceAddressPoolResponse = new DescribeDnsGtmInstanceAddressPoolResponse();

			describeDnsGtmInstanceAddressPoolResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsGtmInstanceAddressPoolResponse.RequestId = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.RequestId");
			describeDnsGtmInstanceAddressPoolResponse.AddrPoolId = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.AddrPoolId");
			describeDnsGtmInstanceAddressPoolResponse.CreateTime = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.CreateTime");
			describeDnsGtmInstanceAddressPoolResponse.CreateTimestamp = _ctx.LongValue("DescribeDnsGtmInstanceAddressPool.CreateTimestamp");
			describeDnsGtmInstanceAddressPoolResponse.UpdateTime = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.UpdateTime");
			describeDnsGtmInstanceAddressPoolResponse.UpdateTimestamp = _ctx.LongValue("DescribeDnsGtmInstanceAddressPool.UpdateTimestamp");
			describeDnsGtmInstanceAddressPoolResponse.AddrCount = _ctx.IntegerValue("DescribeDnsGtmInstanceAddressPool.AddrCount");
			describeDnsGtmInstanceAddressPoolResponse.MonitorConfigId = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.MonitorConfigId");
			describeDnsGtmInstanceAddressPoolResponse.MonitorStatus = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.MonitorStatus");
			describeDnsGtmInstanceAddressPoolResponse.Name = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.Name");
			describeDnsGtmInstanceAddressPoolResponse.Type = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.Type");
			describeDnsGtmInstanceAddressPoolResponse.LbaStrategy = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.LbaStrategy");

			List<DescribeDnsGtmInstanceAddressPoolResponse.DescribeDnsGtmInstanceAddressPool_Addr> describeDnsGtmInstanceAddressPoolResponse_addrs = new List<DescribeDnsGtmInstanceAddressPoolResponse.DescribeDnsGtmInstanceAddressPool_Addr>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmInstanceAddressPool.Addrs.Length"); i++) {
				DescribeDnsGtmInstanceAddressPoolResponse.DescribeDnsGtmInstanceAddressPool_Addr addr = new DescribeDnsGtmInstanceAddressPoolResponse.DescribeDnsGtmInstanceAddressPool_Addr();
				addr.CreateTime = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.Addrs["+ i +"].CreateTime");
				addr.CreateTimestamp = _ctx.LongValue("DescribeDnsGtmInstanceAddressPool.Addrs["+ i +"].CreateTimestamp");
				addr.UpdateTime = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.Addrs["+ i +"].UpdateTime");
				addr.UpdateTimestamp = _ctx.LongValue("DescribeDnsGtmInstanceAddressPool.Addrs["+ i +"].UpdateTimestamp");
				addr.Addr = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.Addrs["+ i +"].Addr");
				addr.LbaWeight = _ctx.IntegerValue("DescribeDnsGtmInstanceAddressPool.Addrs["+ i +"].LbaWeight");
				addr.Mode = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.Addrs["+ i +"].Mode");
				addr.AlertStatus = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.Addrs["+ i +"].AlertStatus");
				addr.Remark = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.Addrs["+ i +"].Remark");
				addr.AttributeInfo = _ctx.StringValue("DescribeDnsGtmInstanceAddressPool.Addrs["+ i +"].AttributeInfo");

				describeDnsGtmInstanceAddressPoolResponse_addrs.Add(addr);
			}
			describeDnsGtmInstanceAddressPoolResponse.Addrs = describeDnsGtmInstanceAddressPoolResponse_addrs;
        
			return describeDnsGtmInstanceAddressPoolResponse;
        }
    }
}
