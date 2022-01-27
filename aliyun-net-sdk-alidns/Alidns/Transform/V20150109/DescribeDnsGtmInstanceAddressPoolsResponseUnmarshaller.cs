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
    public class DescribeDnsGtmInstanceAddressPoolsResponseUnmarshaller
    {
        public static DescribeDnsGtmInstanceAddressPoolsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsGtmInstanceAddressPoolsResponse describeDnsGtmInstanceAddressPoolsResponse = new DescribeDnsGtmInstanceAddressPoolsResponse();

			describeDnsGtmInstanceAddressPoolsResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsGtmInstanceAddressPoolsResponse.RequestId = _ctx.StringValue("DescribeDnsGtmInstanceAddressPools.RequestId");
			describeDnsGtmInstanceAddressPoolsResponse.TotalItems = _ctx.IntegerValue("DescribeDnsGtmInstanceAddressPools.TotalItems");
			describeDnsGtmInstanceAddressPoolsResponse.TotalPages = _ctx.IntegerValue("DescribeDnsGtmInstanceAddressPools.TotalPages");
			describeDnsGtmInstanceAddressPoolsResponse.PageNumber = _ctx.IntegerValue("DescribeDnsGtmInstanceAddressPools.PageNumber");
			describeDnsGtmInstanceAddressPoolsResponse.PageSize = _ctx.IntegerValue("DescribeDnsGtmInstanceAddressPools.PageSize");

			List<DescribeDnsGtmInstanceAddressPoolsResponse.DescribeDnsGtmInstanceAddressPools_AddrPool> describeDnsGtmInstanceAddressPoolsResponse_addrPools = new List<DescribeDnsGtmInstanceAddressPoolsResponse.DescribeDnsGtmInstanceAddressPools_AddrPool>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmInstanceAddressPools.AddrPools.Length"); i++) {
				DescribeDnsGtmInstanceAddressPoolsResponse.DescribeDnsGtmInstanceAddressPools_AddrPool addrPool = new DescribeDnsGtmInstanceAddressPoolsResponse.DescribeDnsGtmInstanceAddressPools_AddrPool();
				addrPool.AddrPoolId = _ctx.StringValue("DescribeDnsGtmInstanceAddressPools.AddrPools["+ i +"].AddrPoolId");
				addrPool.CreateTime = _ctx.StringValue("DescribeDnsGtmInstanceAddressPools.AddrPools["+ i +"].CreateTime");
				addrPool.CreateTimestamp = _ctx.LongValue("DescribeDnsGtmInstanceAddressPools.AddrPools["+ i +"].CreateTimestamp");
				addrPool.UpdateTime = _ctx.StringValue("DescribeDnsGtmInstanceAddressPools.AddrPools["+ i +"].UpdateTime");
				addrPool.UpdateTimestamp = _ctx.LongValue("DescribeDnsGtmInstanceAddressPools.AddrPools["+ i +"].UpdateTimestamp");
				addrPool.AddrCount = _ctx.IntegerValue("DescribeDnsGtmInstanceAddressPools.AddrPools["+ i +"].AddrCount");
				addrPool.MonitorConfigId = _ctx.StringValue("DescribeDnsGtmInstanceAddressPools.AddrPools["+ i +"].MonitorConfigId");
				addrPool.MonitorStatus = _ctx.StringValue("DescribeDnsGtmInstanceAddressPools.AddrPools["+ i +"].MonitorStatus");
				addrPool.Name = _ctx.StringValue("DescribeDnsGtmInstanceAddressPools.AddrPools["+ i +"].Name");
				addrPool.Type = _ctx.StringValue("DescribeDnsGtmInstanceAddressPools.AddrPools["+ i +"].Type");
				addrPool.LbaStrategy = _ctx.StringValue("DescribeDnsGtmInstanceAddressPools.AddrPools["+ i +"].LbaStrategy");

				describeDnsGtmInstanceAddressPoolsResponse_addrPools.Add(addrPool);
			}
			describeDnsGtmInstanceAddressPoolsResponse.AddrPools = describeDnsGtmInstanceAddressPoolsResponse_addrPools;
        
			return describeDnsGtmInstanceAddressPoolsResponse;
        }
    }
}
