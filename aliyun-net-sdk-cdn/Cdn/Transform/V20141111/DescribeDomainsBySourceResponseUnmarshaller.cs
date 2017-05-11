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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainsBySourceResponseUnmarshaller
    {
        public static DescribeDomainsBySourceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainsBySourceResponse describeDomainsBySourceResponse = new DescribeDomainsBySourceResponse();

			describeDomainsBySourceResponse.HttpResponse = context.HttpResponse;
			describeDomainsBySourceResponse.RequestId = context.StringValue("DescribeDomainsBySource.RequestId");
			describeDomainsBySourceResponse.Sources = context.StringValue("DescribeDomainsBySource.Sources");

			List<DescribeDomainsBySourceResponse.DomainsData> domainsList = new List<DescribeDomainsBySourceResponse.DomainsData>();
			for (int i = 0; i < context.Length("DescribeDomainsBySource.DomainsList.Length"); i++) {
				DescribeDomainsBySourceResponse.DomainsData domainsData = new DescribeDomainsBySourceResponse.DomainsData();
				domainsData.Source = context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].Source");

				List<string> domains = new List<string>();
				for (int j = 0; j < context.Length("DescribeDomainsBySource.DomainsList["+ i +"].Domains.Length"); j++) {
					domains.Add(context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].Domains["+ j +"]"));
				}
				domainsData.Domains = domains;

				List<DescribeDomainsBySourceResponse.DomainsData.domainInfo> domainInfos = new List<DescribeDomainsBySourceResponse.DomainsData.domainInfo>();
				for (int j = 0; j < context.Length("DescribeDomainsBySource.DomainsList["+ i +"].DomainInfos.Length"); j++) {
					DescribeDomainsBySourceResponse.DomainsData.domainInfo domainInfo = new DescribeDomainsBySourceResponse.DomainsData.domainInfo();
					domainInfo.DomainName = context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].DomainInfos["+ j +"].DomainName");
					domainInfo.DomainCname = context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].DomainInfos["+ j +"].DomainCname");
					domainInfo.CreateTime = context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].DomainInfos["+ j +"].CreateTime");
					domainInfo.UpdateTime = context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].DomainInfos["+ j +"].UpdateTime");
					domainInfo.Status = context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].DomainInfos["+ j +"].Status");

					domainInfos.Add(domainInfo);
				}
				domainsData.DomainInfos = domainInfos;

				domainsList.Add(domainsData);
			}
			describeDomainsBySourceResponse.DomainsList = domainsList;
        
			return describeDomainsBySourceResponse;
        }
    }
}