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
        public static DescribeScdnDomainDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainDetailResponse describeScdnDomainDetailResponse = new DescribeScdnDomainDetailResponse();

			describeScdnDomainDetailResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainDetailResponse.RequestId = context.StringValue("DescribeScdnDomainDetail.RequestId");

			DescribeScdnDomainDetailResponse.DescribeScdnDomainDetail_DomainDetail domainDetail = new DescribeScdnDomainDetailResponse.DescribeScdnDomainDetail_DomainDetail();
			domainDetail.GmtCreated = context.StringValue("DescribeScdnDomainDetail.DomainDetail.GmtCreated");
			domainDetail.GmtModified = context.StringValue("DescribeScdnDomainDetail.DomainDetail.GmtModified");
			domainDetail.DomainStatus = context.StringValue("DescribeScdnDomainDetail.DomainDetail.DomainStatus");
			domainDetail.Cname = context.StringValue("DescribeScdnDomainDetail.DomainDetail.Cname");
			domainDetail.DomainName = context.StringValue("DescribeScdnDomainDetail.DomainDetail.DomainName");
			domainDetail.Description = context.StringValue("DescribeScdnDomainDetail.DomainDetail.Description");
			domainDetail.SSLProtocol = context.StringValue("DescribeScdnDomainDetail.DomainDetail.SSLProtocol");
			domainDetail.SSLPub = context.StringValue("DescribeScdnDomainDetail.DomainDetail.SSLPub");
			domainDetail.Scope = context.StringValue("DescribeScdnDomainDetail.DomainDetail.Scope");
			domainDetail.CertName = context.StringValue("DescribeScdnDomainDetail.DomainDetail.CertName");
			domainDetail.ResourceGroupId = context.StringValue("DescribeScdnDomainDetail.DomainDetail.ResourceGroupId");

			List<DescribeScdnDomainDetailResponse.DescribeScdnDomainDetail_DomainDetail.DescribeScdnDomainDetail_Source> domainDetail_sources = new List<DescribeScdnDomainDetailResponse.DescribeScdnDomainDetail_DomainDetail.DescribeScdnDomainDetail_Source>();
			for (int i = 0; i < context.Length("DescribeScdnDomainDetail.DomainDetail.Sources.Length"); i++) {
				DescribeScdnDomainDetailResponse.DescribeScdnDomainDetail_DomainDetail.DescribeScdnDomainDetail_Source source = new DescribeScdnDomainDetailResponse.DescribeScdnDomainDetail_DomainDetail.DescribeScdnDomainDetail_Source();
				source.Content = context.StringValue("DescribeScdnDomainDetail.DomainDetail.Sources["+ i +"].Content");
				source.Type = context.StringValue("DescribeScdnDomainDetail.DomainDetail.Sources["+ i +"].Type");
				source.Port = context.IntegerValue("DescribeScdnDomainDetail.DomainDetail.Sources["+ i +"].Port");
				source.Enabled = context.StringValue("DescribeScdnDomainDetail.DomainDetail.Sources["+ i +"].Enabled");
				source.Priority = context.StringValue("DescribeScdnDomainDetail.DomainDetail.Sources["+ i +"].Priority");

				domainDetail_sources.Add(source);
			}
			domainDetail.Sources = domainDetail_sources;
			describeScdnDomainDetailResponse.DomainDetail = domainDetail;
        
			return describeScdnDomainDetailResponse;
        }
    }
}
