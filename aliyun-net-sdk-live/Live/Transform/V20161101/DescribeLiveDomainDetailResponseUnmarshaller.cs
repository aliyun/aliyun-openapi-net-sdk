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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveDomainDetailResponseUnmarshaller
    {
        public static DescribeLiveDomainDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainDetailResponse describeLiveDomainDetailResponse = new DescribeLiveDomainDetailResponse();

			describeLiveDomainDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainDetailResponse.RequestId = _ctx.StringValue("DescribeLiveDomainDetail.RequestId");

			DescribeLiveDomainDetailResponse.DescribeLiveDomainDetail_DomainDetail domainDetail = new DescribeLiveDomainDetailResponse.DescribeLiveDomainDetail_DomainDetail();
			domainDetail.GmtCreated = _ctx.StringValue("DescribeLiveDomainDetail.DomainDetail.GmtCreated");
			domainDetail.GmtModified = _ctx.StringValue("DescribeLiveDomainDetail.DomainDetail.GmtModified");
			domainDetail.DomainStatus = _ctx.StringValue("DescribeLiveDomainDetail.DomainDetail.DomainStatus");
			domainDetail.Cname = _ctx.StringValue("DescribeLiveDomainDetail.DomainDetail.Cname");
			domainDetail.DomainName = _ctx.StringValue("DescribeLiveDomainDetail.DomainDetail.DomainName");
			domainDetail.LiveDomainType = _ctx.StringValue("DescribeLiveDomainDetail.DomainDetail.LiveDomainType");
			domainDetail.Region = _ctx.StringValue("DescribeLiveDomainDetail.DomainDetail.Region");
			domainDetail.Description = _ctx.StringValue("DescribeLiveDomainDetail.DomainDetail.Description");
			domainDetail.SSLProtocol = _ctx.StringValue("DescribeLiveDomainDetail.DomainDetail.SSLProtocol");
			domainDetail.SSLPub = _ctx.StringValue("DescribeLiveDomainDetail.DomainDetail.SSLPub");
			domainDetail.Scope = _ctx.StringValue("DescribeLiveDomainDetail.DomainDetail.Scope");
			domainDetail.CertName = _ctx.StringValue("DescribeLiveDomainDetail.DomainDetail.CertName");
			describeLiveDomainDetailResponse.DomainDetail = domainDetail;
        
			return describeLiveDomainDetailResponse;
        }
    }
}
