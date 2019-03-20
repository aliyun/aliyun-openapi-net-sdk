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
    public class DescribeDNSSLBSubDomainsResponseUnmarshaller
    {
        public static DescribeDNSSLBSubDomainsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDNSSLBSubDomainsResponse describeDNSSLBSubDomainsResponse = new DescribeDNSSLBSubDomainsResponse();

			describeDNSSLBSubDomainsResponse.HttpResponse = context.HttpResponse;
			describeDNSSLBSubDomainsResponse.RequestId = context.StringValue("DescribeDNSSLBSubDomains.RequestId");
			describeDNSSLBSubDomainsResponse.TotalCount = context.LongValue("DescribeDNSSLBSubDomains.TotalCount");
			describeDNSSLBSubDomainsResponse.PageNumber = context.LongValue("DescribeDNSSLBSubDomains.PageNumber");
			describeDNSSLBSubDomainsResponse.PageSize = context.LongValue("DescribeDNSSLBSubDomains.PageSize");

			List<DescribeDNSSLBSubDomainsResponse.DescribeDNSSLBSubDomains_SlbSubDomain> describeDNSSLBSubDomainsResponse_slbSubDomains = new List<DescribeDNSSLBSubDomainsResponse.DescribeDNSSLBSubDomains_SlbSubDomain>();
			for (int i = 0; i < context.Length("DescribeDNSSLBSubDomains.SlbSubDomains.Length"); i++) {
				DescribeDNSSLBSubDomainsResponse.DescribeDNSSLBSubDomains_SlbSubDomain slbSubDomain = new DescribeDNSSLBSubDomainsResponse.DescribeDNSSLBSubDomains_SlbSubDomain();
				slbSubDomain.SubDomain = context.StringValue("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].SubDomain");
				slbSubDomain.RecordCount = context.LongValue("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].RecordCount");
				slbSubDomain.Open = context.BooleanValue("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].Open");
				slbSubDomain.Type = context.StringValue("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].Type");

				describeDNSSLBSubDomainsResponse_slbSubDomains.Add(slbSubDomain);
			}
			describeDNSSLBSubDomainsResponse.SlbSubDomains = describeDNSSLBSubDomainsResponse_slbSubDomains;
        
			return describeDNSSLBSubDomainsResponse;
        }
    }
}
