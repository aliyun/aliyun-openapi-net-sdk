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
    public class DescribeDnsProductInstancesResponseUnmarshaller
    {
        public static DescribeDnsProductInstancesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDnsProductInstancesResponse describeDnsProductInstancesResponse = new DescribeDnsProductInstancesResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDnsProductInstances.RequestId"),
                TotalCount = context.LongValue("DescribeDnsProductInstances.TotalCount"),
                PageNumber = context.LongValue("DescribeDnsProductInstances.PageNumber"),
                PageSize = context.LongValue("DescribeDnsProductInstances.PageSize")
            };


            List<DescribeDnsProductInstancesResponse.DnsProduct> dnsProducts = new List<DescribeDnsProductInstancesResponse.DnsProduct>();
			for (int i = 0; i < context.Length("DescribeDnsProductInstances.DnsProducts.Length"); i++) {
			    DescribeDnsProductInstancesResponse.DnsProduct dnsProduct = new DescribeDnsProductInstancesResponse.DnsProduct
			    {
			        InstanceId = context.StringValue($"DescribeDnsProductInstances.DnsProducts[{i}].InstanceId"),
			        VersionCode = context.StringValue($"DescribeDnsProductInstances.DnsProducts[{i}].VersionCode"),
			        VersionName = context.StringValue($"DescribeDnsProductInstances.DnsProducts[{i}].VersionName"),
			        StartTime = context.StringValue($"DescribeDnsProductInstances.DnsProducts[{i}].StartTime"),
			        EndTime = context.StringValue($"DescribeDnsProductInstances.DnsProducts[{i}].EndTime"),
			        StartTimestamp = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].StartTimestamp"),
			        EndTimestamp = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].EndTimestamp"),
			        Domain = context.StringValue($"DescribeDnsProductInstances.DnsProducts[{i}].Domain"),
			        BindCount = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].BindCount"),
			        BindUsedCount = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].BindUsedCount"),
			        TTLMinValue = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].TTLMinValue"),
			        SubDomainLevel = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].SubDomainLevel"),
			        DnsSLBCount = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].DnsSLBCount"),
			        URLForwardCount = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].URLForwardCount"),
			        DDosDefendFlow = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].DDosDefendFlow"),
			        DDosDefendQuery = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].DDosDefendQuery"),
			        OverseaDDosDefendFlow = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].OverseaDDosDefendFlow"),
			        SearchEngineLines = context.StringValue($"DescribeDnsProductInstances.DnsProducts[{i}].SearchEngineLines"),
			        ISPLines = context.StringValue($"DescribeDnsProductInstances.DnsProducts[{i}].ISPLines"),
			        ISPRegionLines = context.StringValue($"DescribeDnsProductInstances.DnsProducts[{i}].ISPRegionLines"),
			        OverseaLine = context.StringValue($"DescribeDnsProductInstances.DnsProducts[{i}].OverseaLine"),
			        MonitorNodeCount = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].MonitorNodeCount"),
			        MonitorFrequency = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].MonitorFrequency"),
			        MonitorTaskCount = context.LongValue($"DescribeDnsProductInstances.DnsProducts[{i}].MonitorTaskCount")
			    };

			    dnsProducts.Add(dnsProduct);
			}
			describeDnsProductInstancesResponse.DnsProducts = dnsProducts;
        
			return describeDnsProductInstancesResponse;
        }
    }
}