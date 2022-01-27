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
    public class DescribeDnsProductInstanceResponseUnmarshaller
    {
        public static DescribeDnsProductInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsProductInstanceResponse describeDnsProductInstanceResponse = new DescribeDnsProductInstanceResponse();

			describeDnsProductInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsProductInstanceResponse.RequestId = _ctx.StringValue("DescribeDnsProductInstance.RequestId");
			describeDnsProductInstanceResponse.InstanceId = _ctx.StringValue("DescribeDnsProductInstance.InstanceId");
			describeDnsProductInstanceResponse.VersionCode = _ctx.StringValue("DescribeDnsProductInstance.VersionCode");
			describeDnsProductInstanceResponse.VersionName = _ctx.StringValue("DescribeDnsProductInstance.VersionName");
			describeDnsProductInstanceResponse.StartTime = _ctx.StringValue("DescribeDnsProductInstance.StartTime");
			describeDnsProductInstanceResponse.StartTimestamp = _ctx.LongValue("DescribeDnsProductInstance.StartTimestamp");
			describeDnsProductInstanceResponse.EndTime = _ctx.StringValue("DescribeDnsProductInstance.EndTime");
			describeDnsProductInstanceResponse.EndTimestamp = _ctx.LongValue("DescribeDnsProductInstance.EndTimestamp");
			describeDnsProductInstanceResponse.Domain = _ctx.StringValue("DescribeDnsProductInstance.Domain");
			describeDnsProductInstanceResponse.BindCount = _ctx.LongValue("DescribeDnsProductInstance.BindCount");
			describeDnsProductInstanceResponse.BindUsedCount = _ctx.LongValue("DescribeDnsProductInstance.BindUsedCount");
			describeDnsProductInstanceResponse.TTLMinValue = _ctx.LongValue("DescribeDnsProductInstance.TTLMinValue");
			describeDnsProductInstanceResponse.SubDomainLevel = _ctx.LongValue("DescribeDnsProductInstance.SubDomainLevel");
			describeDnsProductInstanceResponse.DnsSLBCount = _ctx.LongValue("DescribeDnsProductInstance.DnsSLBCount");
			describeDnsProductInstanceResponse.URLForwardCount = _ctx.LongValue("DescribeDnsProductInstance.URLForwardCount");
			describeDnsProductInstanceResponse.DDosDefendFlow = _ctx.LongValue("DescribeDnsProductInstance.DDosDefendFlow");
			describeDnsProductInstanceResponse.DDosDefendQuery = _ctx.LongValue("DescribeDnsProductInstance.DDosDefendQuery");
			describeDnsProductInstanceResponse.OverseaDDosDefendFlow = _ctx.LongValue("DescribeDnsProductInstance.OverseaDDosDefendFlow");
			describeDnsProductInstanceResponse.SearchEngineLines = _ctx.StringValue("DescribeDnsProductInstance.SearchEngineLines");
			describeDnsProductInstanceResponse.ISPLines = _ctx.StringValue("DescribeDnsProductInstance.ISPLines");
			describeDnsProductInstanceResponse.ISPRegionLines = _ctx.StringValue("DescribeDnsProductInstance.ISPRegionLines");
			describeDnsProductInstanceResponse.OverseaLine = _ctx.StringValue("DescribeDnsProductInstance.OverseaLine");
			describeDnsProductInstanceResponse.MonitorNodeCount = _ctx.LongValue("DescribeDnsProductInstance.MonitorNodeCount");
			describeDnsProductInstanceResponse.MonitorFrequency = _ctx.LongValue("DescribeDnsProductInstance.MonitorFrequency");
			describeDnsProductInstanceResponse.MonitorTaskCount = _ctx.LongValue("DescribeDnsProductInstance.MonitorTaskCount");
			describeDnsProductInstanceResponse.RegionLines = _ctx.BooleanValue("DescribeDnsProductInstance.RegionLines");
			describeDnsProductInstanceResponse.Gslb = _ctx.BooleanValue("DescribeDnsProductInstance.Gslb");
			describeDnsProductInstanceResponse.InClean = _ctx.BooleanValue("DescribeDnsProductInstance.InClean");
			describeDnsProductInstanceResponse.InBlackHole = _ctx.BooleanValue("DescribeDnsProductInstance.InBlackHole");
			describeDnsProductInstanceResponse.BindDomainCount = _ctx.LongValue("DescribeDnsProductInstance.BindDomainCount");
			describeDnsProductInstanceResponse.BindDomainUsedCount = _ctx.LongValue("DescribeDnsProductInstance.BindDomainUsedCount");
			describeDnsProductInstanceResponse.DnsSecurity = _ctx.StringValue("DescribeDnsProductInstance.DnsSecurity");
			describeDnsProductInstanceResponse.PaymentType = _ctx.StringValue("DescribeDnsProductInstance.PaymentType");
			describeDnsProductInstanceResponse.DomainType = _ctx.StringValue("DescribeDnsProductInstance.DomainType");

			List<string> describeDnsProductInstanceResponse_dnsServers = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDnsProductInstance.DnsServers.Length"); i++) {
				describeDnsProductInstanceResponse_dnsServers.Add(_ctx.StringValue("DescribeDnsProductInstance.DnsServers["+ i +"]"));
			}
			describeDnsProductInstanceResponse.DnsServers = describeDnsProductInstanceResponse_dnsServers;
        
			return describeDnsProductInstanceResponse;
        }
    }
}
