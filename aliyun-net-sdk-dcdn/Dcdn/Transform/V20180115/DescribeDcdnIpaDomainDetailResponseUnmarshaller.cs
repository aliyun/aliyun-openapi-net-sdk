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
        public static DescribeDcdnIpaDomainDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnIpaDomainDetailResponse describeDcdnIpaDomainDetailResponse = new DescribeDcdnIpaDomainDetailResponse();

			describeDcdnIpaDomainDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnIpaDomainDetailResponse.RequestId = _ctx.StringValue("DescribeDcdnIpaDomainDetail.RequestId");

			DescribeDcdnIpaDomainDetailResponse.DescribeDcdnIpaDomainDetail_DomainDetail domainDetail = new DescribeDcdnIpaDomainDetailResponse.DescribeDcdnIpaDomainDetail_DomainDetail();
			domainDetail.GmtCreated = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.GmtCreated");
			domainDetail.GmtModified = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.GmtModified");
			domainDetail.DomainStatus = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.DomainStatus");
			domainDetail.Cname = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Cname");
			domainDetail.DomainName = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.DomainName");
			domainDetail.Description = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Description");
			domainDetail.SSLProtocol = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.SSLProtocol");
			domainDetail.SSLPub = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.SSLPub");
			domainDetail.Scope = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Scope");
			domainDetail.CertName = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.CertName");
			domainDetail.ResourceGroupId = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.ResourceGroupId");

			List<DescribeDcdnIpaDomainDetailResponse.DescribeDcdnIpaDomainDetail_DomainDetail.DescribeDcdnIpaDomainDetail_Source> domainDetail_sources = new List<DescribeDcdnIpaDomainDetailResponse.DescribeDcdnIpaDomainDetail_DomainDetail.DescribeDcdnIpaDomainDetail_Source>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnIpaDomainDetail.DomainDetail.Sources.Length"); i++) {
				DescribeDcdnIpaDomainDetailResponse.DescribeDcdnIpaDomainDetail_DomainDetail.DescribeDcdnIpaDomainDetail_Source source = new DescribeDcdnIpaDomainDetailResponse.DescribeDcdnIpaDomainDetail_DomainDetail.DescribeDcdnIpaDomainDetail_Source();
				source.Content = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Sources["+ i +"].Content");
				source.Type = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Sources["+ i +"].Type");
				source.Port = _ctx.IntegerValue("DescribeDcdnIpaDomainDetail.DomainDetail.Sources["+ i +"].Port");
				source.Enabled = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Sources["+ i +"].Enabled");
				source.Priority = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Sources["+ i +"].Priority");
				source.Weight = _ctx.StringValue("DescribeDcdnIpaDomainDetail.DomainDetail.Sources["+ i +"].Weight");

				domainDetail_sources.Add(source);
			}
			domainDetail.Sources = domainDetail_sources;
			describeDcdnIpaDomainDetailResponse.DomainDetail = domainDetail;
        
			return describeDcdnIpaDomainDetailResponse;
        }
    }
}
