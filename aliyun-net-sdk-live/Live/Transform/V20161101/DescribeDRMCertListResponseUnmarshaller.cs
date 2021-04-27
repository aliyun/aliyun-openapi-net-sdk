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
    public class DescribeDRMCertListResponseUnmarshaller
    {
        public static DescribeDRMCertListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDRMCertListResponse describeDRMCertListResponse = new DescribeDRMCertListResponse();

			describeDRMCertListResponse.HttpResponse = _ctx.HttpResponse;
			describeDRMCertListResponse.RequestId = _ctx.StringValue("DescribeDRMCertList.RequestId");

			List<DescribeDRMCertListResponse.DescribeDRMCertList_CertInfo> describeDRMCertListResponse_dRMCertInfoListList = new List<DescribeDRMCertListResponse.DescribeDRMCertList_CertInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDRMCertList.DRMCertInfoListList.Length"); i++) {
				DescribeDRMCertListResponse.DescribeDRMCertList_CertInfo certInfo = new DescribeDRMCertListResponse.DescribeDRMCertList_CertInfo();
				certInfo.CertId = _ctx.StringValue("DescribeDRMCertList.DRMCertInfoListList["+ i +"].CertId");
				certInfo.CertName = _ctx.StringValue("DescribeDRMCertList.DRMCertInfoListList["+ i +"].CertName");
				certInfo.ServCert = _ctx.StringValue("DescribeDRMCertList.DRMCertInfoListList["+ i +"].ServCert");
				certInfo.PrivateKey = _ctx.StringValue("DescribeDRMCertList.DRMCertInfoListList["+ i +"].PrivateKey");
				certInfo.Passphrase = _ctx.StringValue("DescribeDRMCertList.DRMCertInfoListList["+ i +"].Passphrase");
				certInfo.Ask = _ctx.StringValue("DescribeDRMCertList.DRMCertInfoListList["+ i +"].Ask");
				certInfo.Description = _ctx.StringValue("DescribeDRMCertList.DRMCertInfoListList["+ i +"].Description");

				describeDRMCertListResponse_dRMCertInfoListList.Add(certInfo);
			}
			describeDRMCertListResponse.DRMCertInfoListList = describeDRMCertListResponse_dRMCertInfoListList;
        
			return describeDRMCertListResponse;
        }
    }
}
