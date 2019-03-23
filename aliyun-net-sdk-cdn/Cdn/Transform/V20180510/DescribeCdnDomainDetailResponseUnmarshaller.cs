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
        public static DescribeCdnDomainDetailResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeCdnDomainDetailResponse describeCdnDomainDetailResponse = new DescribeCdnDomainDetailResponse();

            describeCdnDomainDetailResponse.HttpResponse = context.HttpResponse;
            describeCdnDomainDetailResponse.RequestId = context.StringValue("DescribeCdnDomainDetail.RequestId");

            DescribeCdnDomainDetailResponse.DescribeCdnDomainDetail_GetDomainDetailModel getDomainDetailModel = new DescribeCdnDomainDetailResponse.DescribeCdnDomainDetail_GetDomainDetailModel();
            getDomainDetailModel.DomainName = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.DomainName");
            getDomainDetailModel.Cname = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.Cname");
            getDomainDetailModel.HttpsCname = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.HttpsCname");
            getDomainDetailModel.DomainStatus = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.DomainStatus");
            getDomainDetailModel.CdnType = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.CdnType");
            getDomainDetailModel.ServerCertificateStatus = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.ServerCertificateStatus");
            getDomainDetailModel.GmtCreated = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.GmtCreated");
            getDomainDetailModel.GmtModified = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.GmtModified");
            getDomainDetailModel.ResourceGroupId = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.ResourceGroupId");
            getDomainDetailModel.Description = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.Description");
            getDomainDetailModel.Scope = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.Scope");

            List<DescribeCdnDomainDetailResponse.DescribeCdnDomainDetail_GetDomainDetailModel.DescribeCdnDomainDetail_SourceModel> getDomainDetailModel_sourceModels = new List<DescribeCdnDomainDetailResponse.DescribeCdnDomainDetail_GetDomainDetailModel.DescribeCdnDomainDetail_SourceModel>();
            for (int i = 0; i < context.Length("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels.Length"); i++)
            {
                DescribeCdnDomainDetailResponse.DescribeCdnDomainDetail_GetDomainDetailModel.DescribeCdnDomainDetail_SourceModel sourceModel = new DescribeCdnDomainDetailResponse.DescribeCdnDomainDetail_GetDomainDetailModel.DescribeCdnDomainDetail_SourceModel();
                sourceModel.Content = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels[" + i + "].Content");
                sourceModel.Type = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels[" + i + "].Type");
                sourceModel.Port = context.IntegerValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels[" + i + "].Port");
                sourceModel.Enabled = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels[" + i + "].Enabled");
                sourceModel.Priority = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels[" + i + "].Priority");
                sourceModel.Weight = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceModels[" + i + "].Weight");

                getDomainDetailModel_sourceModels.Add(sourceModel);
            }
            getDomainDetailModel.SourceModels = getDomainDetailModel_sourceModels;
            describeCdnDomainDetailResponse.GetDomainDetailModel = getDomainDetailModel;

            return describeCdnDomainDetailResponse;
        }
    }
}
