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
    public class DescribeDnsProductInstancesResponseUnmarshaller
    {
        public static DescribeDnsProductInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDnsProductInstancesResponse describeDnsProductInstancesResponse = new DescribeDnsProductInstancesResponse();

			describeDnsProductInstancesResponse.HttpResponse = context.HttpResponse;
			describeDnsProductInstancesResponse.RequestId = context.StringValue("DescribeDnsProductInstances.RequestId");
			describeDnsProductInstancesResponse.TotalCount = context.LongValue("DescribeDnsProductInstances.TotalCount");
			describeDnsProductInstancesResponse.PageNumber = context.LongValue("DescribeDnsProductInstances.PageNumber");
			describeDnsProductInstancesResponse.PageSize = context.LongValue("DescribeDnsProductInstances.PageSize");

			List<DescribeDnsProductInstancesResponse.DnsProduct> dnsProducts = new List<DescribeDnsProductInstancesResponse.DnsProduct>();
			for (int i = 0; i < context.Length("DescribeDnsProductInstances.DnsProducts.Length"); i++) {
				DescribeDnsProductInstancesResponse.DnsProduct dnsProduct = new DescribeDnsProductInstancesResponse.DnsProduct();
				dnsProduct.InstanceId = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].InstanceId");
				dnsProduct.VersionCode = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].VersionCode");
				dnsProduct.VersionName = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].VersionName");
				dnsProduct.StartTime = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].StartTime");
				dnsProduct.EndTime = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].EndTime");
				dnsProduct.StartTimestamp = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].StartTimestamp");
				dnsProduct.EndTimestamp = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].EndTimestamp");
				dnsProduct.Domain = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].Domain");
				dnsProduct.BindCount = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].BindCount");
				dnsProduct.BindUsedCount = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].BindUsedCount");
				dnsProduct.TTLMinValue = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].TTLMinValue");
				dnsProduct.SubDomainLevel = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].SubDomainLevel");
				dnsProduct.DnsSLBCount = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].DnsSLBCount");
				dnsProduct.URLForwardCount = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].URLForwardCount");
				dnsProduct.DDosDefendFlow = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].DDosDefendFlow");
				dnsProduct.DDosDefendQuery = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].DDosDefendQuery");
				dnsProduct.OverseaDDosDefendFlow = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].OverseaDDosDefendFlow");
				dnsProduct.SearchEngineLines = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].SearchEngineLines");
				dnsProduct.ISPLines = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].ISPLines");
				dnsProduct.ISPRegionLines = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].ISPRegionLines");
				dnsProduct.OverseaLine = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].OverseaLine");
				dnsProduct.MonitorNodeCount = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].MonitorNodeCount");
				dnsProduct.MonitorFrequency = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].MonitorFrequency");
				dnsProduct.MonitorTaskCount = context.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].MonitorTaskCount");

				dnsProducts.Add(dnsProduct);
			}
			describeDnsProductInstancesResponse.DnsProducts = dnsProducts;
        
			return describeDnsProductInstancesResponse;
        }
    }
}