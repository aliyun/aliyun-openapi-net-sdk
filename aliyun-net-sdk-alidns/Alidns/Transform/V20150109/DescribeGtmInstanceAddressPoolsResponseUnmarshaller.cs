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
    public class DescribeGtmInstanceAddressPoolsResponseUnmarshaller
    {
        public static DescribeGtmInstanceAddressPoolsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGtmInstanceAddressPoolsResponse describeGtmInstanceAddressPoolsResponse = new DescribeGtmInstanceAddressPoolsResponse();

			describeGtmInstanceAddressPoolsResponse.HttpResponse = context.HttpResponse;
			describeGtmInstanceAddressPoolsResponse.RequestId = context.StringValue("DescribeGtmInstanceAddressPools.RequestId");
			describeGtmInstanceAddressPoolsResponse.TotalItems = context.IntegerValue("DescribeGtmInstanceAddressPools.TotalItems");
			describeGtmInstanceAddressPoolsResponse.TotalPages = context.IntegerValue("DescribeGtmInstanceAddressPools.TotalPages");
			describeGtmInstanceAddressPoolsResponse.PageNumber = context.IntegerValue("DescribeGtmInstanceAddressPools.PageNumber");
			describeGtmInstanceAddressPoolsResponse.PageSize = context.IntegerValue("DescribeGtmInstanceAddressPools.PageSize");

			List<DescribeGtmInstanceAddressPoolsResponse.DescribeGtmInstanceAddressPools_AddrPool> describeGtmInstanceAddressPoolsResponse_addrPools = new List<DescribeGtmInstanceAddressPoolsResponse.DescribeGtmInstanceAddressPools_AddrPool>();
			for (int i = 0; i < context.Length("DescribeGtmInstanceAddressPools.AddrPools.Length"); i++) {
				DescribeGtmInstanceAddressPoolsResponse.DescribeGtmInstanceAddressPools_AddrPool addrPool = new DescribeGtmInstanceAddressPoolsResponse.DescribeGtmInstanceAddressPools_AddrPool();
				addrPool.AddrPoolId = context.StringValue("DescribeGtmInstanceAddressPools.AddrPools["+ i +"].AddrPoolId");
				addrPool.CreateTime = context.StringValue("DescribeGtmInstanceAddressPools.AddrPools["+ i +"].CreateTime");
				addrPool.CreateTimestamp = context.LongValue("DescribeGtmInstanceAddressPools.AddrPools["+ i +"].CreateTimestamp");
				addrPool.UpdateTime = context.StringValue("DescribeGtmInstanceAddressPools.AddrPools["+ i +"].UpdateTime");
				addrPool.UpdateTimestamp = context.LongValue("DescribeGtmInstanceAddressPools.AddrPools["+ i +"].UpdateTimestamp");
				addrPool.AddrCount = context.IntegerValue("DescribeGtmInstanceAddressPools.AddrPools["+ i +"].AddrCount");
				addrPool.MinAvailableAddrNum = context.IntegerValue("DescribeGtmInstanceAddressPools.AddrPools["+ i +"].MinAvailableAddrNum");
				addrPool.MonitorConfigId = context.StringValue("DescribeGtmInstanceAddressPools.AddrPools["+ i +"].MonitorConfigId");
				addrPool.MonitorStatus = context.StringValue("DescribeGtmInstanceAddressPools.AddrPools["+ i +"].MonitorStatus");
				addrPool.Name = context.StringValue("DescribeGtmInstanceAddressPools.AddrPools["+ i +"].Name");
				addrPool.Status = context.StringValue("DescribeGtmInstanceAddressPools.AddrPools["+ i +"].Status");
				addrPool.Type = context.StringValue("DescribeGtmInstanceAddressPools.AddrPools["+ i +"].Type");

				describeGtmInstanceAddressPoolsResponse_addrPools.Add(addrPool);
			}
			describeGtmInstanceAddressPoolsResponse.AddrPools = describeGtmInstanceAddressPoolsResponse_addrPools;
        
			return describeGtmInstanceAddressPoolsResponse;
        }
    }
}
