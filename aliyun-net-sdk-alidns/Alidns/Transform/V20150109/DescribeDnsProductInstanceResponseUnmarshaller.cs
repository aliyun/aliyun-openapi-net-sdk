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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeDnsProductInstanceResponseUnmarshaller
    {
        public static DescribeDnsProductInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDnsProductInstanceResponse describeDnsProductInstanceResponse = new DescribeDnsProductInstanceResponse();

			describeDnsProductInstanceResponse.HttpResponse = context.HttpResponse;
			describeDnsProductInstanceResponse.RequestId = context.StringValue("DescribeDnsProductInstance.RequestId");
			describeDnsProductInstanceResponse.InstanceId = context.StringValue("DescribeDnsProductInstance.InstanceId");
			describeDnsProductInstanceResponse.VersionCode = context.StringValue("DescribeDnsProductInstance.VersionCode");
			describeDnsProductInstanceResponse.VersionName = context.StringValue("DescribeDnsProductInstance.VersionName");
			describeDnsProductInstanceResponse.StartTime = context.StringValue("DescribeDnsProductInstance.StartTime");
			describeDnsProductInstanceResponse.StartTimestamp = context.LongValue("DescribeDnsProductInstance.StartTimestamp");
			describeDnsProductInstanceResponse.EndTime = context.StringValue("DescribeDnsProductInstance.EndTime");
			describeDnsProductInstanceResponse.EndTimestamp = context.LongValue("DescribeDnsProductInstance.EndTimestamp");
			describeDnsProductInstanceResponse.Domain = context.StringValue("DescribeDnsProductInstance.Domain");
			describeDnsProductInstanceResponse.BindCount = context.LongValue("DescribeDnsProductInstance.BindCount");
			describeDnsProductInstanceResponse.BindUsedCount = context.LongValue("DescribeDnsProductInstance.BindUsedCount");
			describeDnsProductInstanceResponse.TTLMinValue = context.LongValue("DescribeDnsProductInstance.TTLMinValue");
			describeDnsProductInstanceResponse.SubDomainLevel = context.LongValue("DescribeDnsProductInstance.SubDomainLevel");
			describeDnsProductInstanceResponse.DnsSLBCount = context.LongValue("DescribeDnsProductInstance.DnsSLBCount");
			describeDnsProductInstanceResponse.URLForwardCount = context.LongValue("DescribeDnsProductInstance.URLForwardCount");
			describeDnsProductInstanceResponse.DDosDefendFlow = context.LongValue("DescribeDnsProductInstance.DDosDefendFlow");
			describeDnsProductInstanceResponse.DDosDefendQuery = context.LongValue("DescribeDnsProductInstance.DDosDefendQuery");
			describeDnsProductInstanceResponse.OverseaDDosDefendFlow = context.LongValue("DescribeDnsProductInstance.OverseaDDosDefendFlow");
			describeDnsProductInstanceResponse.SearchEngineLines = context.StringValue("DescribeDnsProductInstance.SearchEngineLines");
			describeDnsProductInstanceResponse.ISPLines = context.StringValue("DescribeDnsProductInstance.ISPLines");
			describeDnsProductInstanceResponse.ISPRegionLines = context.StringValue("DescribeDnsProductInstance.ISPRegionLines");
			describeDnsProductInstanceResponse.OverseaLine = context.StringValue("DescribeDnsProductInstance.OverseaLine");
			describeDnsProductInstanceResponse.MonitorNodeCount = context.LongValue("DescribeDnsProductInstance.MonitorNodeCount");
			describeDnsProductInstanceResponse.MonitorFrequency = context.LongValue("DescribeDnsProductInstance.MonitorFrequency");
			describeDnsProductInstanceResponse.MonitorTaskCount = context.LongValue("DescribeDnsProductInstance.MonitorTaskCount");

			List<string> dnsServers = new List<string>();
			for (int i = 0; i < context.Length("DescribeDnsProductInstance.DnsServers.Length"); i++) {
				dnsServers.Add(context.StringValue("DescribeDnsProductInstance.DnsServers["+ i +"]"));
			}
			describeDnsProductInstanceResponse.DnsServers = dnsServers;
        
			return describeDnsProductInstanceResponse;
        }
    }
}