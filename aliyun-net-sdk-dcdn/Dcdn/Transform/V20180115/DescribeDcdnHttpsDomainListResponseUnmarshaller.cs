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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnHttpsDomainListResponseUnmarshaller
    {
        public static DescribeDcdnHttpsDomainListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnHttpsDomainListResponse describeDcdnHttpsDomainListResponse = new DescribeDcdnHttpsDomainListResponse();

			describeDcdnHttpsDomainListResponse.HttpResponse = context.HttpResponse;
			describeDcdnHttpsDomainListResponse.RequestId = context.StringValue("DescribeDcdnHttpsDomainList.RequestId");
			describeDcdnHttpsDomainListResponse.TotalCount = context.IntegerValue("DescribeDcdnHttpsDomainList.TotalCount");

			List<DescribeDcdnHttpsDomainListResponse.DescribeDcdnHttpsDomainList_CertInfo> describeDcdnHttpsDomainListResponse_certInfos = new List<DescribeDcdnHttpsDomainListResponse.DescribeDcdnHttpsDomainList_CertInfo>();
			for (int i = 0; i < context.Length("DescribeDcdnHttpsDomainList.CertInfos.Length"); i++) {
				DescribeDcdnHttpsDomainListResponse.DescribeDcdnHttpsDomainList_CertInfo certInfo = new DescribeDcdnHttpsDomainListResponse.DescribeDcdnHttpsDomainList_CertInfo();
				certInfo.CertCommonName = context.StringValue("DescribeDcdnHttpsDomainList.CertInfos["+ i +"].CertCommonName");
				certInfo.CertName = context.StringValue("DescribeDcdnHttpsDomainList.CertInfos["+ i +"].CertName");
				certInfo.CertStartTime = context.StringValue("DescribeDcdnHttpsDomainList.CertInfos["+ i +"].CertStartTime");
				certInfo.CertExpireTime = context.StringValue("DescribeDcdnHttpsDomainList.CertInfos["+ i +"].CertExpireTime");
				certInfo.CertStatus = context.StringValue("DescribeDcdnHttpsDomainList.CertInfos["+ i +"].CertStatus");
				certInfo.CertType = context.StringValue("DescribeDcdnHttpsDomainList.CertInfos["+ i +"].CertType");
				certInfo.DomainName = context.StringValue("DescribeDcdnHttpsDomainList.CertInfos["+ i +"].DomainName");
				certInfo.CertUpdateTime = context.StringValue("DescribeDcdnHttpsDomainList.CertInfos["+ i +"].CertUpdateTime");

				describeDcdnHttpsDomainListResponse_certInfos.Add(certInfo);
			}
			describeDcdnHttpsDomainListResponse.CertInfos = describeDcdnHttpsDomainListResponse_certInfos;
        
			return describeDcdnHttpsDomainListResponse;
        }
    }
}
