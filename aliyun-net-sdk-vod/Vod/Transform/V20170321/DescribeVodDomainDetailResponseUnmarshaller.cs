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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainDetailResponseUnmarshaller
    {
        public static DescribeVodDomainDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodDomainDetailResponse describeVodDomainDetailResponse = new DescribeVodDomainDetailResponse();

			describeVodDomainDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeVodDomainDetailResponse.RequestId = _ctx.StringValue("DescribeVodDomainDetail.RequestId");

			DescribeVodDomainDetailResponse.DescribeVodDomainDetail_DomainDetail domainDetail = new DescribeVodDomainDetailResponse.DescribeVodDomainDetail_DomainDetail();
			domainDetail.GmtCreated = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.GmtCreated");
			domainDetail.GmtModified = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.GmtModified");
			domainDetail.DomainStatus = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.DomainStatus");
			domainDetail.Cname = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.Cname");
			domainDetail.DomainName = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.DomainName");
			domainDetail.Description = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.Description");
			domainDetail.SSLProtocol = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.SSLProtocol");
			domainDetail.SSLPub = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.SSLPub");
			domainDetail.Scope = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.Scope");
			domainDetail.CertName = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.CertName");
			domainDetail.Weight = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.Weight");

			List<DescribeVodDomainDetailResponse.DescribeVodDomainDetail_DomainDetail.DescribeVodDomainDetail_Source> domainDetail_sources = new List<DescribeVodDomainDetailResponse.DescribeVodDomainDetail_DomainDetail.DescribeVodDomainDetail_Source>();
			for (int i = 0; i < _ctx.Length("DescribeVodDomainDetail.DomainDetail.Sources.Length"); i++) {
				DescribeVodDomainDetailResponse.DescribeVodDomainDetail_DomainDetail.DescribeVodDomainDetail_Source source = new DescribeVodDomainDetailResponse.DescribeVodDomainDetail_DomainDetail.DescribeVodDomainDetail_Source();
				source.Content = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.Sources["+ i +"].Content");
				source.Type = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.Sources["+ i +"].Type");
				source.Port = _ctx.IntegerValue("DescribeVodDomainDetail.DomainDetail.Sources["+ i +"].Port");
				source.Enabled = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.Sources["+ i +"].Enabled");
				source.Priority = _ctx.StringValue("DescribeVodDomainDetail.DomainDetail.Sources["+ i +"].Priority");

				domainDetail_sources.Add(source);
			}
			domainDetail.Sources = domainDetail_sources;
			describeVodDomainDetailResponse.DomainDetail = domainDetail;
        
			return describeVodDomainDetailResponse;
        }
    }
}
