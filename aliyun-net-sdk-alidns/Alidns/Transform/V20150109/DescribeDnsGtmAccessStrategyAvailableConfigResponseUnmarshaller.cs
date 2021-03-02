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
    public class DescribeDnsGtmAccessStrategyAvailableConfigResponseUnmarshaller
    {
        public static DescribeDnsGtmAccessStrategyAvailableConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsGtmAccessStrategyAvailableConfigResponse describeDnsGtmAccessStrategyAvailableConfigResponse = new DescribeDnsGtmAccessStrategyAvailableConfigResponse();

			describeDnsGtmAccessStrategyAvailableConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsGtmAccessStrategyAvailableConfigResponse.RequestId = _ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.RequestId");
			describeDnsGtmAccessStrategyAvailableConfigResponse.SuggestSetDefaultLine = _ctx.BooleanValue("DescribeDnsGtmAccessStrategyAvailableConfig.SuggestSetDefaultLine");

			List<string> describeDnsGtmAccessStrategyAvailableConfigResponse_selectedIpv4Lines = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmAccessStrategyAvailableConfig.SelectedIpv4Lines.Length"); i++) {
				describeDnsGtmAccessStrategyAvailableConfigResponse_selectedIpv4Lines.Add(_ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.SelectedIpv4Lines["+ i +"]"));
			}
			describeDnsGtmAccessStrategyAvailableConfigResponse.SelectedIpv4Lines = describeDnsGtmAccessStrategyAvailableConfigResponse_selectedIpv4Lines;

			List<string> describeDnsGtmAccessStrategyAvailableConfigResponse_selectedIpv6Lines = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmAccessStrategyAvailableConfig.SelectedIpv6Lines.Length"); i++) {
				describeDnsGtmAccessStrategyAvailableConfigResponse_selectedIpv6Lines.Add(_ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.SelectedIpv6Lines["+ i +"]"));
			}
			describeDnsGtmAccessStrategyAvailableConfigResponse.SelectedIpv6Lines = describeDnsGtmAccessStrategyAvailableConfigResponse_selectedIpv6Lines;

			List<string> describeDnsGtmAccessStrategyAvailableConfigResponse_selectedDomainLines = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmAccessStrategyAvailableConfig.SelectedDomainLines.Length"); i++) {
				describeDnsGtmAccessStrategyAvailableConfigResponse_selectedDomainLines.Add(_ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.SelectedDomainLines["+ i +"]"));
			}
			describeDnsGtmAccessStrategyAvailableConfigResponse.SelectedDomainLines = describeDnsGtmAccessStrategyAvailableConfigResponse_selectedDomainLines;

			List<DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_Ipv4AddrPool> describeDnsGtmAccessStrategyAvailableConfigResponse_ipv4AddrPools = new List<DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_Ipv4AddrPool>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmAccessStrategyAvailableConfig.Ipv4AddrPools.Length"); i++) {
				DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_Ipv4AddrPool ipv4AddrPool = new DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_Ipv4AddrPool();
				ipv4AddrPool.Id = _ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.Ipv4AddrPools["+ i +"].Id");
				ipv4AddrPool.Name = _ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.Ipv4AddrPools["+ i +"].Name");
				ipv4AddrPool.AddrCount = _ctx.IntegerValue("DescribeDnsGtmAccessStrategyAvailableConfig.Ipv4AddrPools["+ i +"].AddrCount");

				describeDnsGtmAccessStrategyAvailableConfigResponse_ipv4AddrPools.Add(ipv4AddrPool);
			}
			describeDnsGtmAccessStrategyAvailableConfigResponse.Ipv4AddrPools = describeDnsGtmAccessStrategyAvailableConfigResponse_ipv4AddrPools;

			List<DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_Line> describeDnsGtmAccessStrategyAvailableConfigResponse_lines = new List<DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_Line>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmAccessStrategyAvailableConfig.Lines.Length"); i++) {
				DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_Line line = new DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_Line();
				line.LineCode = _ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.Lines["+ i +"].LineCode");
				line.LineName = _ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.Lines["+ i +"].LineName");
				line.GroupCode = _ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.Lines["+ i +"].GroupCode");
				line.GroupName = _ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.Lines["+ i +"].GroupName");
				line.FatherCode = _ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.Lines["+ i +"].FatherCode");

				describeDnsGtmAccessStrategyAvailableConfigResponse_lines.Add(line);
			}
			describeDnsGtmAccessStrategyAvailableConfigResponse.Lines = describeDnsGtmAccessStrategyAvailableConfigResponse_lines;

			List<DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_Ipv6AddrPool> describeDnsGtmAccessStrategyAvailableConfigResponse_ipv6AddrPools = new List<DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_Ipv6AddrPool>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmAccessStrategyAvailableConfig.Ipv6AddrPools.Length"); i++) {
				DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_Ipv6AddrPool ipv6AddrPool = new DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_Ipv6AddrPool();
				ipv6AddrPool.Id = _ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.Ipv6AddrPools["+ i +"].Id");
				ipv6AddrPool.Name = _ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.Ipv6AddrPools["+ i +"].Name");
				ipv6AddrPool.AddrCount = _ctx.IntegerValue("DescribeDnsGtmAccessStrategyAvailableConfig.Ipv6AddrPools["+ i +"].AddrCount");

				describeDnsGtmAccessStrategyAvailableConfigResponse_ipv6AddrPools.Add(ipv6AddrPool);
			}
			describeDnsGtmAccessStrategyAvailableConfigResponse.Ipv6AddrPools = describeDnsGtmAccessStrategyAvailableConfigResponse_ipv6AddrPools;

			List<DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_DomainAddrPool> describeDnsGtmAccessStrategyAvailableConfigResponse_domainAddrPools = new List<DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_DomainAddrPool>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmAccessStrategyAvailableConfig.DomainAddrPools.Length"); i++) {
				DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_DomainAddrPool domainAddrPool = new DescribeDnsGtmAccessStrategyAvailableConfigResponse.DescribeDnsGtmAccessStrategyAvailableConfig_DomainAddrPool();
				domainAddrPool.Id = _ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.DomainAddrPools["+ i +"].Id");
				domainAddrPool.Name = _ctx.StringValue("DescribeDnsGtmAccessStrategyAvailableConfig.DomainAddrPools["+ i +"].Name");
				domainAddrPool.AddrCount = _ctx.IntegerValue("DescribeDnsGtmAccessStrategyAvailableConfig.DomainAddrPools["+ i +"].AddrCount");

				describeDnsGtmAccessStrategyAvailableConfigResponse_domainAddrPools.Add(domainAddrPool);
			}
			describeDnsGtmAccessStrategyAvailableConfigResponse.DomainAddrPools = describeDnsGtmAccessStrategyAvailableConfigResponse_domainAddrPools;
        
			return describeDnsGtmAccessStrategyAvailableConfigResponse;
        }
    }
}
