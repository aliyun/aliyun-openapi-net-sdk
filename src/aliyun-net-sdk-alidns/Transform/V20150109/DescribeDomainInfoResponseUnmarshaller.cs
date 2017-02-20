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
    public class DescribeDomainInfoResponseUnmarshaller
    {
        public static DescribeDomainInfoResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainInfoResponse describeDomainInfoResponse = new DescribeDomainInfoResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainInfo.RequestId"),
                DomainId = context.StringValue("DescribeDomainInfo.DomainId"),
                DomainName = context.StringValue("DescribeDomainInfo.DomainName"),
                PunyCode = context.StringValue("DescribeDomainInfo.PunyCode"),
                AliDomain = context.BooleanValue("DescribeDomainInfo.AliDomain"),
                RegistrantEmail = context.StringValue("DescribeDomainInfo.RegistrantEmail"),
                GroupId = context.StringValue("DescribeDomainInfo.GroupId"),
                GroupName = context.StringValue("DescribeDomainInfo.GroupName"),
                InstanceId = context.StringValue("DescribeDomainInfo.InstanceId"),
                VersionCode = context.StringValue("DescribeDomainInfo.VersionCode"),
                VersionName = context.StringValue("DescribeDomainInfo.VersionName")
            };


            List<string> dnsServers = new List<string>();
			for (int i = 0; i < context.Length("DescribeDomainInfo.DnsServers.Length"); i++) {
				dnsServers.Add(context.StringValue($"DescribeDomainInfo.DnsServers[{i}]"));
			}
			describeDomainInfoResponse.DnsServers = dnsServers;
        
			return describeDomainInfoResponse;
        }
    }
}