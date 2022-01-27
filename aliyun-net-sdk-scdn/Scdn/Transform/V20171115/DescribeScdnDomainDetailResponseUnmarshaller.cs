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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnDomainDetailResponseUnmarshaller
    {
        public static DescribeScdnDomainDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnDomainDetailResponse describeScdnDomainDetailResponse = new DescribeScdnDomainDetailResponse();

			describeScdnDomainDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnDomainDetailResponse.RequestId = _ctx.StringValue("DescribeScdnDomainDetail.RequestId");

			DescribeScdnDomainDetailResponse.DescribeScdnDomainDetail_DomainDetail domainDetail = new DescribeScdnDomainDetailResponse.DescribeScdnDomainDetail_DomainDetail();
			domainDetail.GmtCreated = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.GmtCreated");
			domainDetail.GmtModified = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.GmtModified");
			domainDetail.DomainStatus = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.DomainStatus");
			domainDetail.Cname = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.Cname");
			domainDetail.DomainName = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.DomainName");
			domainDetail.Description = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.Description");
			domainDetail.SSLProtocol = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.SSLProtocol");
			domainDetail.SSLPub = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.SSLPub");
			domainDetail.Scope = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.Scope");
			domainDetail.CertName = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.CertName");
			domainDetail.ResourceGroupId = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.ResourceGroupId");

			List<DescribeScdnDomainDetailResponse.DescribeScdnDomainDetail_DomainDetail.DescribeScdnDomainDetail_Source> domainDetail_sources = new List<DescribeScdnDomainDetailResponse.DescribeScdnDomainDetail_DomainDetail.DescribeScdnDomainDetail_Source>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDomainDetail.DomainDetail.Sources.Length"); i++) {
				DescribeScdnDomainDetailResponse.DescribeScdnDomainDetail_DomainDetail.DescribeScdnDomainDetail_Source source = new DescribeScdnDomainDetailResponse.DescribeScdnDomainDetail_DomainDetail.DescribeScdnDomainDetail_Source();
				source.Content = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.Sources["+ i +"].Content");
				source.Type = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.Sources["+ i +"].Type");
				source.Port = _ctx.IntegerValue("DescribeScdnDomainDetail.DomainDetail.Sources["+ i +"].Port");
				source.Enabled = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.Sources["+ i +"].Enabled");
				source.Priority = _ctx.StringValue("DescribeScdnDomainDetail.DomainDetail.Sources["+ i +"].Priority");

				domainDetail_sources.Add(source);
			}
			domainDetail.Sources = domainDetail_sources;
			describeScdnDomainDetailResponse.DomainDetail = domainDetail;
        
			return describeScdnDomainDetailResponse;
        }
    }
}
