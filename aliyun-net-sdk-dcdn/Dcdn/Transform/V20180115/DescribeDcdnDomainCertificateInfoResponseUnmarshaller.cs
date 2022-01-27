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
    public class DescribeDcdnDomainCertificateInfoResponseUnmarshaller
    {
        public static DescribeDcdnDomainCertificateInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainCertificateInfoResponse describeDcdnDomainCertificateInfoResponse = new DescribeDcdnDomainCertificateInfoResponse();

			describeDcdnDomainCertificateInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainCertificateInfoResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainCertificateInfo.RequestId");

			List<DescribeDcdnDomainCertificateInfoResponse.DescribeDcdnDomainCertificateInfo_CertInfo> describeDcdnDomainCertificateInfoResponse_certInfos = new List<DescribeDcdnDomainCertificateInfoResponse.DescribeDcdnDomainCertificateInfo_CertInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainCertificateInfo.CertInfos.Length"); i++) {
				DescribeDcdnDomainCertificateInfoResponse.DescribeDcdnDomainCertificateInfo_CertInfo certInfo = new DescribeDcdnDomainCertificateInfoResponse.DescribeDcdnDomainCertificateInfo_CertInfo();
				certInfo.DomainName = _ctx.StringValue("DescribeDcdnDomainCertificateInfo.CertInfos["+ i +"].DomainName");
				certInfo.CertName = _ctx.StringValue("DescribeDcdnDomainCertificateInfo.CertInfos["+ i +"].CertName");
				certInfo.CertDomainName = _ctx.StringValue("DescribeDcdnDomainCertificateInfo.CertInfos["+ i +"].CertDomainName");
				certInfo.CertExpireTime = _ctx.StringValue("DescribeDcdnDomainCertificateInfo.CertInfos["+ i +"].CertExpireTime");
				certInfo.CertLife = _ctx.StringValue("DescribeDcdnDomainCertificateInfo.CertInfos["+ i +"].CertLife");
				certInfo.CertOrg = _ctx.StringValue("DescribeDcdnDomainCertificateInfo.CertInfos["+ i +"].CertOrg");
				certInfo.CertType = _ctx.StringValue("DescribeDcdnDomainCertificateInfo.CertInfos["+ i +"].CertType");
				certInfo.SSLProtocol = _ctx.StringValue("DescribeDcdnDomainCertificateInfo.CertInfos["+ i +"].SSLProtocol");
				certInfo.Status = _ctx.StringValue("DescribeDcdnDomainCertificateInfo.CertInfos["+ i +"].Status");
				certInfo.SSLPub = _ctx.StringValue("DescribeDcdnDomainCertificateInfo.CertInfos["+ i +"].SSLPub");

				describeDcdnDomainCertificateInfoResponse_certInfos.Add(certInfo);
			}
			describeDcdnDomainCertificateInfoResponse.CertInfos = describeDcdnDomainCertificateInfoResponse_certInfos;
        
			return describeDcdnDomainCertificateInfoResponse;
        }
    }
}
