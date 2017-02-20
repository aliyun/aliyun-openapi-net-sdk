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
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeCdnDomainDetailResponseUnmarshaller
    {
        public static DescribeCdnDomainDetailResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeCdnDomainDetailResponse describeCdnDomainDetailResponse = new DescribeCdnDomainDetailResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeCdnDomainDetail.RequestId")
            };
            DescribeCdnDomainDetailResponse.GetDomainDetailModel_ getDomainDetailModel = new DescribeCdnDomainDetailResponse.GetDomainDetailModel_()
            {
                GmtCreated = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.GmtCreated"),
                GmtModified = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.GmtModified"),
                SourceType = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceType"),
                DomainStatus = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.DomainStatus"),
                SourcePort = context.IntegerValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourcePort"),
                CdnType = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.CdnType"),
                Cname = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.Cname"),
                HttpsCname = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.HttpsCname"),
                DomainName = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.DomainName"),
                Description = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.Description"),
                ServerCertificateStatus = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.ServerCertificateStatus"),
                ServerCertificate = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.ServerCertificate"),
                Scope = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.Scope"),
                CertificateName = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.CertificateName")
            };
            List<string> sources = new List<string>();
			for (int i = 0; i < context.Length("DescribeCdnDomainDetail.GetDomainDetailModel.Sources.Length"); i++) {
				sources.Add(context.StringValue($"DescribeCdnDomainDetail.GetDomainDetailModel.Sources[{i}]"));
			}
			getDomainDetailModel.Sources = sources;
			describeCdnDomainDetailResponse.GetDomainDetailModel = getDomainDetailModel;
        
			return describeCdnDomainDetailResponse;
        }
    }
}