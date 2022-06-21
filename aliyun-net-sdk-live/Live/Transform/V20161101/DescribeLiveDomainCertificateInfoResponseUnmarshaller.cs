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
    public class DescribeLiveDomainCertificateInfoResponseUnmarshaller
    {
        public static DescribeLiveDomainCertificateInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainCertificateInfoResponse describeLiveDomainCertificateInfoResponse = new DescribeLiveDomainCertificateInfoResponse();

			describeLiveDomainCertificateInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainCertificateInfoResponse.RequestId = _ctx.StringValue("DescribeLiveDomainCertificateInfo.RequestId");

			List<DescribeLiveDomainCertificateInfoResponse.DescribeLiveDomainCertificateInfo_CertInfo> describeLiveDomainCertificateInfoResponse_certInfos = new List<DescribeLiveDomainCertificateInfoResponse.DescribeLiveDomainCertificateInfo_CertInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainCertificateInfo.CertInfos.Length"); i++) {
				DescribeLiveDomainCertificateInfoResponse.DescribeLiveDomainCertificateInfo_CertInfo certInfo = new DescribeLiveDomainCertificateInfoResponse.DescribeLiveDomainCertificateInfo_CertInfo();
				certInfo.DomainName = _ctx.StringValue("DescribeLiveDomainCertificateInfo.CertInfos["+ i +"].DomainName");
				certInfo.CertName = _ctx.StringValue("DescribeLiveDomainCertificateInfo.CertInfos["+ i +"].CertName");
				certInfo.CertDomainName = _ctx.StringValue("DescribeLiveDomainCertificateInfo.CertInfos["+ i +"].CertDomainName");
				certInfo.CertExpireTime = _ctx.StringValue("DescribeLiveDomainCertificateInfo.CertInfos["+ i +"].CertExpireTime");
				certInfo.CertLife = _ctx.StringValue("DescribeLiveDomainCertificateInfo.CertInfos["+ i +"].CertLife");
				certInfo.CertOrg = _ctx.StringValue("DescribeLiveDomainCertificateInfo.CertInfos["+ i +"].CertOrg");
				certInfo.CertType = _ctx.StringValue("DescribeLiveDomainCertificateInfo.CertInfos["+ i +"].CertType");
				certInfo.SSLProtocol = _ctx.StringValue("DescribeLiveDomainCertificateInfo.CertInfos["+ i +"].SSLProtocol");
				certInfo.Status = _ctx.StringValue("DescribeLiveDomainCertificateInfo.CertInfos["+ i +"].Status");
				certInfo.SSLPub = _ctx.StringValue("DescribeLiveDomainCertificateInfo.CertInfos["+ i +"].SSLPub");

				describeLiveDomainCertificateInfoResponse_certInfos.Add(certInfo);
			}
			describeLiveDomainCertificateInfoResponse.CertInfos = describeLiveDomainCertificateInfoResponse_certInfos;
        
			return describeLiveDomainCertificateInfoResponse;
        }
    }
}
