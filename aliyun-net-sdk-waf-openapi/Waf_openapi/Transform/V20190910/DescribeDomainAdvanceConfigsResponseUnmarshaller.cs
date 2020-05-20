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
using Aliyun.Acs.waf_openapi.Model.V20190910;

namespace Aliyun.Acs.waf_openapi.Transform.V20190910
{
    public class DescribeDomainAdvanceConfigsResponseUnmarshaller
    {
        public static DescribeDomainAdvanceConfigsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainAdvanceConfigsResponse describeDomainAdvanceConfigsResponse = new DescribeDomainAdvanceConfigsResponse();

			describeDomainAdvanceConfigsResponse.HttpResponse = context.HttpResponse;
			describeDomainAdvanceConfigsResponse.RequestId = context.StringValue("DescribeDomainAdvanceConfigs.RequestId");

			List<DescribeDomainAdvanceConfigsResponse.DescribeDomainAdvanceConfigs_DomainConfig> describeDomainAdvanceConfigsResponse_domainConfigs = new List<DescribeDomainAdvanceConfigsResponse.DescribeDomainAdvanceConfigs_DomainConfig>();
			for (int i = 0; i < context.Length("DescribeDomainAdvanceConfigs.DomainConfigs.Length"); i++) {
				DescribeDomainAdvanceConfigsResponse.DescribeDomainAdvanceConfigs_DomainConfig domainConfig = new DescribeDomainAdvanceConfigsResponse.DescribeDomainAdvanceConfigs_DomainConfig();
				domainConfig.Domain = context.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Domain");

				DescribeDomainAdvanceConfigsResponse.DescribeDomainAdvanceConfigs_DomainConfig.DescribeDomainAdvanceConfigs_Profile profile = new DescribeDomainAdvanceConfigsResponse.DescribeDomainAdvanceConfigs_DomainConfig.DescribeDomainAdvanceConfigs_Profile();
				profile.Cname = context.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.Cname");
				profile.ResolvedType = context.IntegerValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.ResolvedType");
				profile.VipServiceStatus = context.IntegerValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.VipServiceStatus");
				profile.CertStatus = context.IntegerValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.CertStatus");
				profile.ExclusiveVipStatus = context.IntegerValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.ExclusiveVipStatus");
				profile.Ipv6Status = context.IntegerValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.Ipv6Status");
				profile.HttpPort = context.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.HttpPort");
				profile.HttpsPort = context.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.HttpsPort");
				profile.Http2Port = context.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.Http2Port");
				profile.Rs = context.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.Rs");
				profile.ClusterType = context.IntegerValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.ClusterType");
				profile.GSLBStatus = context.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.GSLBStatus");
				domainConfig.Profile = profile;

				describeDomainAdvanceConfigsResponse_domainConfigs.Add(domainConfig);
			}
			describeDomainAdvanceConfigsResponse.DomainConfigs = describeDomainAdvanceConfigsResponse_domainConfigs;
        
			return describeDomainAdvanceConfigsResponse;
        }
    }
}
