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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeCdnDomainDetailResponseUnmarshaller
    {
        public static DescribeCdnDomainDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnDomainDetailResponse describeCdnDomainDetailResponse = new DescribeCdnDomainDetailResponse();

			describeCdnDomainDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnDomainDetailResponse.RequestId = _ctx.StringValue("DescribeCdnDomainDetail.RequestId");

			DescribeCdnDomainDetailResponse.DescribeCdnDomainDetail_GetDomainDetailModel getDomainDetailModel = new DescribeCdnDomainDetailResponse.DescribeCdnDomainDetail_GetDomainDetailModel();
			getDomainDetailModel.DomainName = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.DomainName");
			getDomainDetailModel.Cname = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.Cname");
			getDomainDetailModel.HttpsCname = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.HttpsCname");
			getDomainDetailModel.DomainStatus = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.DomainStatus");
			getDomainDetailModel.CdnType = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.CdnType");
			getDomainDetailModel.ServerCertificateStatus = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.ServerCertificateStatus");
			getDomainDetailModel.GmtCreated = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.GmtCreated");
			getDomainDetailModel.GmtModified = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.GmtModified");
			getDomainDetailModel.ResourceGroupId = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.ResourceGroupId");
			getDomainDetailModel.Description = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.Description");
			getDomainDetailModel.Scope = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.Scope");

			List<DescribeCdnDomainDetailResponse.DescribeCdnDomainDetail_GetDomainDetailModel.DescribeCdnDomainDetail_SourceModel> getDomainDetailModel_sourceModels = new List<DescribeCdnDomainDetailResponse.DescribeCdnDomainDetail_GetDomainDetailModel.DescribeCdnDomainDetail_SourceModel>();
			for (int i = 0; i < _ctx.Length("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels.Length"); i++) {
				DescribeCdnDomainDetailResponse.DescribeCdnDomainDetail_GetDomainDetailModel.DescribeCdnDomainDetail_SourceModel sourceModel = new DescribeCdnDomainDetailResponse.DescribeCdnDomainDetail_GetDomainDetailModel.DescribeCdnDomainDetail_SourceModel();
				sourceModel.Content = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels["+ i +"].Content");
				sourceModel.Type = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels["+ i +"].Type");
				sourceModel.Port = _ctx.IntegerValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels["+ i +"].Port");
				sourceModel.Enabled = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels["+ i +"].Enabled");
				sourceModel.Priority = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels["+ i +"].Priority");
				sourceModel.Weight = _ctx.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels["+ i +"].Weight");

				getDomainDetailModel_sourceModels.Add(sourceModel);
			}
			getDomainDetailModel.SourceModels = getDomainDetailModel_sourceModels;
			describeCdnDomainDetailResponse.GetDomainDetailModel = getDomainDetailModel;
        
			return describeCdnDomainDetailResponse;
        }
    }
}
