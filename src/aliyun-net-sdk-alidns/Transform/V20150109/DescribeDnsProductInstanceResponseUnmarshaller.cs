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
using Aliyun.Acs.Alidns.Model.V20150109;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeDnsProductInstanceResponseUnmarshaller
    {
        public static DescribeDnsProductInstanceResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDnsProductInstanceResponse describeDnsProductInstanceResponse = new DescribeDnsProductInstanceResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDnsProductInstance.RequestId"),
                InstanceId = context.StringValue("DescribeDnsProductInstance.InstanceId"),
                VersionCode = context.StringValue("DescribeDnsProductInstance.VersionCode"),
                VersionName = context.StringValue("DescribeDnsProductInstance.VersionName"),
                StartTime = context.StringValue("DescribeDnsProductInstance.StartTime"),
                StartTimestamp = context.LongValue("DescribeDnsProductInstance.StartTimestamp"),
                EndTime = context.StringValue("DescribeDnsProductInstance.EndTime"),
                EndTimestamp = context.LongValue("DescribeDnsProductInstance.EndTimestamp"),
                Domain = context.StringValue("DescribeDnsProductInstance.Domain"),
                BindCount = context.LongValue("DescribeDnsProductInstance.BindCount"),
                BindUsedCount = context.LongValue("DescribeDnsProductInstance.BindUsedCount"),
                TTLMinValue = context.LongValue("DescribeDnsProductInstance.TTLMinValue"),
                SubDomainLevel = context.LongValue("DescribeDnsProductInstance.SubDomainLevel"),
                DnsSLBCount = context.LongValue("DescribeDnsProductInstance.DnsSLBCount"),
                URLForwardCount = context.LongValue("DescribeDnsProductInstance.URLForwardCount"),
                DDosDefendFlow = context.LongValue("DescribeDnsProductInstance.DDosDefendFlow"),
                DDosDefendQuery = context.LongValue("DescribeDnsProductInstance.DDosDefendQuery"),
                OverseaDDosDefendFlow = context.LongValue("DescribeDnsProductInstance.OverseaDDosDefendFlow"),
                SearchEngineLines = context.StringValue("DescribeDnsProductInstance.SearchEngineLines"),
                ISPLines = context.StringValue("DescribeDnsProductInstance.ISPLines"),
                ISPRegionLines = context.StringValue("DescribeDnsProductInstance.ISPRegionLines"),
                OverseaLine = context.StringValue("DescribeDnsProductInstance.OverseaLine"),
                MonitorNodeCount = context.LongValue("DescribeDnsProductInstance.MonitorNodeCount"),
                MonitorFrequency = context.LongValue("DescribeDnsProductInstance.MonitorFrequency"),
                MonitorTaskCount = context.LongValue("DescribeDnsProductInstance.MonitorTaskCount")
            };


            List<string> dnsServers = new List<string>();
			for (int i = 0; i < context.Length("DescribeDnsProductInstance.DnsServers.Length"); i++) {
				dnsServers.Add(context.StringValue($"DescribeDnsProductInstance.DnsServers[{i}]"));
			}
			describeDnsProductInstanceResponse.DnsServers = dnsServers;
        
			return describeDnsProductInstanceResponse;
        }
    }
}