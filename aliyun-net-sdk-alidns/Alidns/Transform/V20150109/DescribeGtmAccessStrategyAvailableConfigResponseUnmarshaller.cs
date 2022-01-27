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
    public class DescribeGtmAccessStrategyAvailableConfigResponseUnmarshaller
    {
        public static DescribeGtmAccessStrategyAvailableConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGtmAccessStrategyAvailableConfigResponse describeGtmAccessStrategyAvailableConfigResponse = new DescribeGtmAccessStrategyAvailableConfigResponse();

			describeGtmAccessStrategyAvailableConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeGtmAccessStrategyAvailableConfigResponse.RequestId = _ctx.StringValue("DescribeGtmAccessStrategyAvailableConfig.RequestId");

			List<DescribeGtmAccessStrategyAvailableConfigResponse.DescribeGtmAccessStrategyAvailableConfig_AddrPool> describeGtmAccessStrategyAvailableConfigResponse_addrPools = new List<DescribeGtmAccessStrategyAvailableConfigResponse.DescribeGtmAccessStrategyAvailableConfig_AddrPool>();
			for (int i = 0; i < _ctx.Length("DescribeGtmAccessStrategyAvailableConfig.AddrPools.Length"); i++) {
				DescribeGtmAccessStrategyAvailableConfigResponse.DescribeGtmAccessStrategyAvailableConfig_AddrPool addrPool = new DescribeGtmAccessStrategyAvailableConfigResponse.DescribeGtmAccessStrategyAvailableConfig_AddrPool();
				addrPool.AddrPoolId = _ctx.StringValue("DescribeGtmAccessStrategyAvailableConfig.AddrPools["+ i +"].AddrPoolId");
				addrPool.AddrPoolName = _ctx.StringValue("DescribeGtmAccessStrategyAvailableConfig.AddrPools["+ i +"].AddrPoolName");

				describeGtmAccessStrategyAvailableConfigResponse_addrPools.Add(addrPool);
			}
			describeGtmAccessStrategyAvailableConfigResponse.AddrPools = describeGtmAccessStrategyAvailableConfigResponse_addrPools;

			List<DescribeGtmAccessStrategyAvailableConfigResponse.DescribeGtmAccessStrategyAvailableConfig_Line> describeGtmAccessStrategyAvailableConfigResponse_lines = new List<DescribeGtmAccessStrategyAvailableConfigResponse.DescribeGtmAccessStrategyAvailableConfig_Line>();
			for (int i = 0; i < _ctx.Length("DescribeGtmAccessStrategyAvailableConfig.Lines.Length"); i++) {
				DescribeGtmAccessStrategyAvailableConfigResponse.DescribeGtmAccessStrategyAvailableConfig_Line line = new DescribeGtmAccessStrategyAvailableConfigResponse.DescribeGtmAccessStrategyAvailableConfig_Line();
				line.LineCode = _ctx.StringValue("DescribeGtmAccessStrategyAvailableConfig.Lines["+ i +"].LineCode");
				line.LineName = _ctx.StringValue("DescribeGtmAccessStrategyAvailableConfig.Lines["+ i +"].LineName");
				line.GroupCode = _ctx.StringValue("DescribeGtmAccessStrategyAvailableConfig.Lines["+ i +"].GroupCode");
				line.GroupName = _ctx.StringValue("DescribeGtmAccessStrategyAvailableConfig.Lines["+ i +"].GroupName");
				line.Status = _ctx.StringValue("DescribeGtmAccessStrategyAvailableConfig.Lines["+ i +"].Status");
				line.FatherCode = _ctx.StringValue("DescribeGtmAccessStrategyAvailableConfig.Lines["+ i +"].FatherCode");

				describeGtmAccessStrategyAvailableConfigResponse_lines.Add(line);
			}
			describeGtmAccessStrategyAvailableConfigResponse.Lines = describeGtmAccessStrategyAvailableConfigResponse_lines;
        
			return describeGtmAccessStrategyAvailableConfigResponse;
        }
    }
}
