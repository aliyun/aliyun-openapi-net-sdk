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
    public class DescribeLiveHttpsDomainListResponseUnmarshaller
    {
        public static DescribeLiveHttpsDomainListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveHttpsDomainListResponse describeLiveHttpsDomainListResponse = new DescribeLiveHttpsDomainListResponse();

			describeLiveHttpsDomainListResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveHttpsDomainListResponse.TotalCount = _ctx.IntegerValue("DescribeLiveHttpsDomainList.TotalCount");
			describeLiveHttpsDomainListResponse.RequestId = _ctx.StringValue("DescribeLiveHttpsDomainList.RequestId");

			List<DescribeLiveHttpsDomainListResponse.DescribeLiveHttpsDomainList_CertInfo> describeLiveHttpsDomainListResponse_certInfos = new List<DescribeLiveHttpsDomainListResponse.DescribeLiveHttpsDomainList_CertInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveHttpsDomainList.CertInfos.Length"); i++) {
				DescribeLiveHttpsDomainListResponse.DescribeLiveHttpsDomainList_CertInfo certInfo = new DescribeLiveHttpsDomainListResponse.DescribeLiveHttpsDomainList_CertInfo();
				certInfo.CertStartTime = _ctx.StringValue("DescribeLiveHttpsDomainList.CertInfos["+ i +"].CertStartTime");
				certInfo.CertExpireTime = _ctx.StringValue("DescribeLiveHttpsDomainList.CertInfos["+ i +"].CertExpireTime");
				certInfo.CertUpdateTime = _ctx.StringValue("DescribeLiveHttpsDomainList.CertInfos["+ i +"].CertUpdateTime");
				certInfo.CertType = _ctx.StringValue("DescribeLiveHttpsDomainList.CertInfos["+ i +"].CertType");
				certInfo.CertName = _ctx.StringValue("DescribeLiveHttpsDomainList.CertInfos["+ i +"].CertName");
				certInfo.CertStatus = _ctx.StringValue("DescribeLiveHttpsDomainList.CertInfos["+ i +"].CertStatus");
				certInfo.DomainName = _ctx.StringValue("DescribeLiveHttpsDomainList.CertInfos["+ i +"].DomainName");
				certInfo.CertCommonName = _ctx.StringValue("DescribeLiveHttpsDomainList.CertInfos["+ i +"].CertCommonName");

				describeLiveHttpsDomainListResponse_certInfos.Add(certInfo);
			}
			describeLiveHttpsDomainListResponse.CertInfos = describeLiveHttpsDomainListResponse_certInfos;
        
			return describeLiveHttpsDomainListResponse;
        }
    }
}
