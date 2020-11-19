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
    public class DescribeCdnHttpsDomainListResponseUnmarshaller
    {
        public static DescribeCdnHttpsDomainListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnHttpsDomainListResponse describeCdnHttpsDomainListResponse = new DescribeCdnHttpsDomainListResponse();

			describeCdnHttpsDomainListResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnHttpsDomainListResponse.RequestId = _ctx.StringValue("DescribeCdnHttpsDomainList.RequestId");
			describeCdnHttpsDomainListResponse.TotalCount = _ctx.IntegerValue("DescribeCdnHttpsDomainList.TotalCount");

			List<DescribeCdnHttpsDomainListResponse.DescribeCdnHttpsDomainList_CertInfo> describeCdnHttpsDomainListResponse_certInfos = new List<DescribeCdnHttpsDomainListResponse.DescribeCdnHttpsDomainList_CertInfo>();
			for (int i = 0; i < _ctx.Length("DescribeCdnHttpsDomainList.CertInfos.Length"); i++) {
				DescribeCdnHttpsDomainListResponse.DescribeCdnHttpsDomainList_CertInfo certInfo = new DescribeCdnHttpsDomainListResponse.DescribeCdnHttpsDomainList_CertInfo();
				certInfo.CertCommonName = _ctx.StringValue("DescribeCdnHttpsDomainList.CertInfos["+ i +"].CertCommonName");
				certInfo.CertName = _ctx.StringValue("DescribeCdnHttpsDomainList.CertInfos["+ i +"].CertName");
				certInfo.CertStartTime = _ctx.StringValue("DescribeCdnHttpsDomainList.CertInfos["+ i +"].CertStartTime");
				certInfo.CertExpireTime = _ctx.StringValue("DescribeCdnHttpsDomainList.CertInfos["+ i +"].CertExpireTime");
				certInfo.CertStatus = _ctx.StringValue("DescribeCdnHttpsDomainList.CertInfos["+ i +"].CertStatus");
				certInfo.CertType = _ctx.StringValue("DescribeCdnHttpsDomainList.CertInfos["+ i +"].CertType");
				certInfo.DomainName = _ctx.StringValue("DescribeCdnHttpsDomainList.CertInfos["+ i +"].DomainName");
				certInfo.CertUpdateTime = _ctx.StringValue("DescribeCdnHttpsDomainList.CertInfos["+ i +"].CertUpdateTime");

				describeCdnHttpsDomainListResponse_certInfos.Add(certInfo);
			}
			describeCdnHttpsDomainListResponse.CertInfos = describeCdnHttpsDomainListResponse_certInfos;
        
			return describeCdnHttpsDomainListResponse;
        }
    }
}
