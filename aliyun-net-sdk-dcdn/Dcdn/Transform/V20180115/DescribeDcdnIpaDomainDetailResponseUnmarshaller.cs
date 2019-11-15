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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnIpaDomainDetailResponseUnmarshaller
    {
        public static DescribeDcdnIpaDomainDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnIpaDomainDetailResponse describeDcdnIpaDomainDetailResponse = new DescribeDcdnIpaDomainDetailResponse();

			describeDcdnIpaDomainDetailResponse.HttpResponse = context.HttpResponse;
			describeDcdnIpaDomainDetailResponse.RequestId = context.StringValue("DescribeDcdnIpaDomainDetail.RequestId");

			DescribeDcdnIpaDomainDetailResponse.DescribeDcdnIpaDomainDetail_DomainDetail domainDetail = new DescribeDcdnIpaDomainDetailResponse.DescribeDcdnIpaDomainDetail_DomainDetail();
			domainDetail.GmtCreated = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.GmtCreated");
			domainDetail.GmtModified = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.GmtModified");
			domainDetail.DomainStatus = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.DomainStatus");
			domainDetail.Cname = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Cname");
			domainDetail.DomainName = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.DomainName");
			domainDetail.Description = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Description");
			domainDetail.SSLProtocol = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.SSLProtocol");
			domainDetail.SSLPub = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.SSLPub");
			domainDetail.Scope = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Scope");
			domainDetail.CertName = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.CertName");
			domainDetail.ResourceGroupId = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.ResourceGroupId");

			List<DescribeDcdnIpaDomainDetailResponse.DescribeDcdnIpaDomainDetail_DomainDetail.DescribeDcdnIpaDomainDetail_Source> domainDetail_sources = new List<DescribeDcdnIpaDomainDetailResponse.DescribeDcdnIpaDomainDetail_DomainDetail.DescribeDcdnIpaDomainDetail_Source>();
			for (int i = 0; i < context.Length("DescribeDcdnIpaDomainDetail.DomainDetail.Sources.Length"); i++) {
				DescribeDcdnIpaDomainDetailResponse.DescribeDcdnIpaDomainDetail_DomainDetail.DescribeDcdnIpaDomainDetail_Source source = new DescribeDcdnIpaDomainDetailResponse.DescribeDcdnIpaDomainDetail_DomainDetail.DescribeDcdnIpaDomainDetail_Source();
				source.Content = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Sources["+ i +"].Content");
				source.Type = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Sources["+ i +"].Type");
				source.Port = context.IntegerValue("DescribeDcdnIpaDomainDetail.DomainDetail.Sources["+ i +"].Port");
				source.Enabled = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Sources["+ i +"].Enabled");
				source.Priority = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Sources["+ i +"].Priority");
				source.Weight = context.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Sources["+ i +"].Weight");

				domainDetail_sources.Add(source);
			}
			domainDetail.Sources = domainDetail_sources;
			describeDcdnIpaDomainDetailResponse.DomainDetail = domainDetail;
        
			return describeDcdnIpaDomainDetailResponse;
        }
    }
}
