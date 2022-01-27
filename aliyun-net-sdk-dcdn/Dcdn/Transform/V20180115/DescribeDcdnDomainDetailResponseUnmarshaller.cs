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
    public class DescribeDcdnDomainDetailResponseUnmarshaller
    {
        public static DescribeDcdnDomainDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainDetailResponse describeDcdnDomainDetailResponse = new DescribeDcdnDomainDetailResponse();

			describeDcdnDomainDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainDetailResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainDetail.RequestId");

			DescribeDcdnDomainDetailResponse.DescribeDcdnDomainDetail_DomainDetail domainDetail = new DescribeDcdnDomainDetailResponse.DescribeDcdnDomainDetail_DomainDetail();
			domainDetail.GmtCreated = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.GmtCreated");
			domainDetail.GmtModified = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.GmtModified");
			domainDetail.DomainStatus = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.DomainStatus");
			domainDetail.Cname = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.Cname");
			domainDetail.DomainName = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.DomainName");
			domainDetail.Description = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.Description");
			domainDetail.SSLProtocol = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.SSLProtocol");
			domainDetail.SSLPub = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.SSLPub");
			domainDetail.Scope = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.Scope");
			domainDetail.CertName = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.CertName");
			domainDetail.ResourceGroupId = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.ResourceGroupId");

			List<DescribeDcdnDomainDetailResponse.DescribeDcdnDomainDetail_DomainDetail.DescribeDcdnDomainDetail_Source> domainDetail_sources = new List<DescribeDcdnDomainDetailResponse.DescribeDcdnDomainDetail_DomainDetail.DescribeDcdnDomainDetail_Source>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainDetail.DomainDetail.Sources.Length"); i++) {
				DescribeDcdnDomainDetailResponse.DescribeDcdnDomainDetail_DomainDetail.DescribeDcdnDomainDetail_Source source = new DescribeDcdnDomainDetailResponse.DescribeDcdnDomainDetail_DomainDetail.DescribeDcdnDomainDetail_Source();
				source.Content = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.Sources["+ i +"].Content");
				source.Type = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.Sources["+ i +"].Type");
				source.Port = _ctx.IntegerValue("DescribeDcdnDomainDetail.DomainDetail.Sources["+ i +"].Port");
				source.Enabled = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.Sources["+ i +"].Enabled");
				source.Priority = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.Sources["+ i +"].Priority");
				source.Weight = _ctx.StringValue("DescribeDcdnDomainDetail.DomainDetail.Sources["+ i +"].Weight");

				domainDetail_sources.Add(source);
			}
			domainDetail.Sources = domainDetail_sources;
			describeDcdnDomainDetailResponse.DomainDetail = domainDetail;
        
			return describeDcdnDomainDetailResponse;
        }
    }
}
