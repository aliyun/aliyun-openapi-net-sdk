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
    public class DescribeCdnDomainBaseDetailResponseUnmarshaller
    {
        public static DescribeCdnDomainBaseDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCdnDomainBaseDetailResponse describeCdnDomainBaseDetailResponse = new DescribeCdnDomainBaseDetailResponse();

			describeCdnDomainBaseDetailResponse.HttpResponse = context.HttpResponse;
			describeCdnDomainBaseDetailResponse.RequestId = context.StringValue("DescribeCdnDomainBaseDetail.RequestId");

			DescribeCdnDomainBaseDetailResponse.DescribeCdnDomainBaseDetail_DomainBaseDetailModel domainBaseDetailModel = new DescribeCdnDomainBaseDetailResponse.DescribeCdnDomainBaseDetail_DomainBaseDetailModel();
			domainBaseDetailModel.Cname = context.StringValue("DescribeCdnDomainBaseDetail.DomainBaseDetailModel.Cname");
			domainBaseDetailModel.CdnType = context.StringValue("DescribeCdnDomainBaseDetail.DomainBaseDetailModel.CdnType");
			domainBaseDetailModel.DomainStatus = context.StringValue("DescribeCdnDomainBaseDetail.DomainBaseDetailModel.DomainStatus");
			domainBaseDetailModel.SourceType = context.StringValue("DescribeCdnDomainBaseDetail.DomainBaseDetailModel.SourceType");
			domainBaseDetailModel.Region = context.StringValue("DescribeCdnDomainBaseDetail.DomainBaseDetailModel.Region");
			domainBaseDetailModel.DomainName = context.StringValue("DescribeCdnDomainBaseDetail.DomainBaseDetailModel.DomainName");
			domainBaseDetailModel.Remark = context.StringValue("DescribeCdnDomainBaseDetail.DomainBaseDetailModel.Remark");
			domainBaseDetailModel.GmtModified = context.StringValue("DescribeCdnDomainBaseDetail.DomainBaseDetailModel.GmtModified");
			domainBaseDetailModel.GmtCreated = context.StringValue("DescribeCdnDomainBaseDetail.DomainBaseDetailModel.GmtCreated");

			List<string> domainBaseDetailModel_sources = new List<string>();
			for (int i = 0; i < context.Length("DescribeCdnDomainBaseDetail.DomainBaseDetailModel.Sources.Length"); i++) {
				domainBaseDetailModel_sources.Add(context.StringValue("DescribeCdnDomainBaseDetail.DomainBaseDetailModel.Sources["+ i +"]"));
			}
			domainBaseDetailModel.Sources = domainBaseDetailModel_sources;
			describeCdnDomainBaseDetailResponse.DomainBaseDetailModel = domainBaseDetailModel;
        
			return describeCdnDomainBaseDetailResponse;
        }
    }
}