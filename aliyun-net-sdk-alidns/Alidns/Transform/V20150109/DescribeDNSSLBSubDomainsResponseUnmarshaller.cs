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
        public static DescribeDNSSLBSubDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDNSSLBSubDomainsResponse describeDNSSLBSubDomainsResponse = new DescribeDNSSLBSubDomainsResponse();

			describeDNSSLBSubDomainsResponse.HttpResponse = _ctx.HttpResponse;
			describeDNSSLBSubDomainsResponse.RequestId = _ctx.StringValue("DescribeDNSSLBSubDomains.RequestId");
			describeDNSSLBSubDomainsResponse.TotalCount = _ctx.LongValue("DescribeDNSSLBSubDomains.TotalCount");
			describeDNSSLBSubDomainsResponse.PageNumber = _ctx.LongValue("DescribeDNSSLBSubDomains.PageNumber");
			describeDNSSLBSubDomainsResponse.PageSize = _ctx.LongValue("DescribeDNSSLBSubDomains.PageSize");

			List<DescribeDNSSLBSubDomainsResponse.DescribeDNSSLBSubDomains_SlbSubDomain> describeDNSSLBSubDomainsResponse_slbSubDomains = new List<DescribeDNSSLBSubDomainsResponse.DescribeDNSSLBSubDomains_SlbSubDomain>();
			for (int i = 0; i < _ctx.Length("DescribeDNSSLBSubDomains.SlbSubDomains.Length"); i++) {
				DescribeDNSSLBSubDomainsResponse.DescribeDNSSLBSubDomains_SlbSubDomain slbSubDomain = new DescribeDNSSLBSubDomainsResponse.DescribeDNSSLBSubDomains_SlbSubDomain();
				slbSubDomain.SubDomain = _ctx.StringValue("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].SubDomain");
				slbSubDomain.RecordCount = _ctx.LongValue("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].RecordCount");
				slbSubDomain.Open = _ctx.BooleanValue("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].Open");
				slbSubDomain.Type = _ctx.StringValue("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].Type");

				List<DescribeDNSSLBSubDomainsResponse.DescribeDNSSLBSubDomains_SlbSubDomain.DescribeDNSSLBSubDomains_LineAlgorithm> slbSubDomain_lineAlgorithms = new List<DescribeDNSSLBSubDomainsResponse.DescribeDNSSLBSubDomains_SlbSubDomain.DescribeDNSSLBSubDomains_LineAlgorithm>();
				for (int j = 0; j < _ctx.Length("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].LineAlgorithms.Length"); j++) {
					DescribeDNSSLBSubDomainsResponse.DescribeDNSSLBSubDomains_SlbSubDomain.DescribeDNSSLBSubDomains_LineAlgorithm lineAlgorithm = new DescribeDNSSLBSubDomainsResponse.DescribeDNSSLBSubDomains_SlbSubDomain.DescribeDNSSLBSubDomains_LineAlgorithm();
					lineAlgorithm.Line = _ctx.StringValue("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].LineAlgorithms["+ j +"].Line");
					lineAlgorithm.Open = _ctx.BooleanValue("DescribeDNSSLBSubDomains.SlbSubDomains["+ i +"].LineAlgorithms["+ j +"].Open");

					slbSubDomain_lineAlgorithms.Add(lineAlgorithm);
				}
				slbSubDomain.LineAlgorithms = slbSubDomain_lineAlgorithms;

				describeDNSSLBSubDomainsResponse_slbSubDomains.Add(slbSubDomain);
			}
			describeDNSSLBSubDomainsResponse.SlbSubDomains = describeDNSSLBSubDomainsResponse_slbSubDomains;
        
			return describeDNSSLBSubDomainsResponse;
        }
    }
}
