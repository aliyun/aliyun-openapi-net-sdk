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

			List<DescribeDNSSLBSubDomainsResponse.SlbSubDomain> slbSubDomains = new List<DescribeDNSSLBSubDomainsResponse.SlbSubDomain>();
			for (int i = 0; i < context.Length("DescribeDNSSLBSubDomains.SlbSubDomains.Length"); i++) {
				DescribeDNSSLBSubDomainsResponse.SlbSubDomain slbSubDomain = new DescribeDNSSLBSubDomainsResponse.SlbSubDomain();
				slbSubDomain.SubDomain = context.StringValue("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].SubDomain");
				slbSubDomain.RecordCount = context.LongValue("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].RecordCount");
				slbSubDomain.Open = context.BooleanValue("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].Open");

				slbSubDomains.Add(slbSubDomain);
			}
			describeDNSSLBSubDomainsResponse.SlbSubDomains = slbSubDomains;
        
			return describeDNSSLBSubDomainsResponse;
        }
    }
}