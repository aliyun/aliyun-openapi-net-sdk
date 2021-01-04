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
    public class DescribeDnsProductInstancesResponseUnmarshaller
    {
        public static DescribeDnsProductInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsProductInstancesResponse describeDnsProductInstancesResponse = new DescribeDnsProductInstancesResponse();

			describeDnsProductInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsProductInstancesResponse.RequestId = _ctx.StringValue("DescribeDnsProductInstances.RequestId");
			describeDnsProductInstancesResponse.TotalCount = _ctx.LongValue("DescribeDnsProductInstances.TotalCount");
			describeDnsProductInstancesResponse.PageNumber = _ctx.LongValue("DescribeDnsProductInstances.PageNumber");
			describeDnsProductInstancesResponse.PageSize = _ctx.LongValue("DescribeDnsProductInstances.PageSize");
			describeDnsProductInstancesResponse.DomainType = _ctx.StringValue("DescribeDnsProductInstances.DomainType");

			List<DescribeDnsProductInstancesResponse.DescribeDnsProductInstances_DnsProduct> describeDnsProductInstancesResponse_dnsProducts = new List<DescribeDnsProductInstancesResponse.DescribeDnsProductInstances_DnsProduct>();
			for (int i = 0; i < _ctx.Length("DescribeDnsProductInstances.DnsProducts.Length"); i++) {
				DescribeDnsProductInstancesResponse.DescribeDnsProductInstances_DnsProduct dnsProduct = new DescribeDnsProductInstancesResponse.DescribeDnsProductInstances_DnsProduct();
				dnsProduct.InstanceId = _ctx.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].InstanceId");
				dnsProduct.VersionCode = _ctx.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].VersionCode");
				dnsProduct.VersionName = _ctx.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].VersionName");
				dnsProduct.StartTime = _ctx.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].StartTime");
				dnsProduct.EndTime = _ctx.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].EndTime");
				dnsProduct.StartTimestamp = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].StartTimestamp");
				dnsProduct.EndTimestamp = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].EndTimestamp");
				dnsProduct.Domain = _ctx.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].Domain");
				dnsProduct.BindCount = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].BindCount");
				dnsProduct.BindUsedCount = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].BindUsedCount");
				dnsProduct.TTLMinValue = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].TTLMinValue");
				dnsProduct.SubDomainLevel = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].SubDomainLevel");
				dnsProduct.DnsSLBCount = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].DnsSLBCount");
				dnsProduct.URLForwardCount = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].URLForwardCount");
				dnsProduct.DDosDefendFlow = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].DDosDefendFlow");
				dnsProduct.DDosDefendQuery = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].DDosDefendQuery");
				dnsProduct.OverseaDDosDefendFlow = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].OverseaDDosDefendFlow");
				dnsProduct.SearchEngineLines = _ctx.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].SearchEngineLines");
				dnsProduct.ISPLines = _ctx.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].ISPLines");
				dnsProduct.ISPRegionLines = _ctx.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].ISPRegionLines");
				dnsProduct.OverseaLine = _ctx.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].OverseaLine");
				dnsProduct.MonitorNodeCount = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].MonitorNodeCount");
				dnsProduct.MonitorFrequency = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].MonitorFrequency");
				dnsProduct.MonitorTaskCount = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].MonitorTaskCount");
				dnsProduct.RegionLines = _ctx.BooleanValue("DescribeDnsProductInstances.DnsProducts["+ i +"].RegionLines");
				dnsProduct.Gslb = _ctx.BooleanValue("DescribeDnsProductInstances.DnsProducts["+ i +"].Gslb");
				dnsProduct.InClean = _ctx.BooleanValue("DescribeDnsProductInstances.DnsProducts["+ i +"].InClean");
				dnsProduct.InBlackHole = _ctx.BooleanValue("DescribeDnsProductInstances.DnsProducts["+ i +"].InBlackHole");
				dnsProduct.BindDomainCount = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].BindDomainCount");
				dnsProduct.BindDomainUsedCount = _ctx.LongValue("DescribeDnsProductInstances.DnsProducts["+ i +"].BindDomainUsedCount");
				dnsProduct.DnsSecurity = _ctx.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].DnsSecurity");
				dnsProduct.PaymentType = _ctx.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].PaymentType");

				describeDnsProductInstancesResponse_dnsProducts.Add(dnsProduct);
			}
			describeDnsProductInstancesResponse.DnsProducts = describeDnsProductInstancesResponse_dnsProducts;
        
			return describeDnsProductInstancesResponse;
        }
    }
}
