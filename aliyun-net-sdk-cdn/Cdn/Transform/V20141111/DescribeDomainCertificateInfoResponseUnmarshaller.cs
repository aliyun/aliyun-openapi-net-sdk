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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainCertificateInfoResponseUnmarshaller
    {
        public static DescribeDomainCertificateInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainCertificateInfoResponse describeDomainCertificateInfoResponse = new DescribeDomainCertificateInfoResponse();

			describeDomainCertificateInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainCertificateInfoResponse.RequestId = _ctx.StringValue("DescribeDomainCertificateInfo.RequestId");

			List<DescribeDomainCertificateInfoResponse.DescribeDomainCertificateInfo_CertInfo> describeDomainCertificateInfoResponse_certInfos = new List<DescribeDomainCertificateInfoResponse.DescribeDomainCertificateInfo_CertInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDomainCertificateInfo.CertInfos.Length"); i++) {
				DescribeDomainCertificateInfoResponse.DescribeDomainCertificateInfo_CertInfo certInfo = new DescribeDomainCertificateInfoResponse.DescribeDomainCertificateInfo_CertInfo();
				certInfo.DomainName = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].DomainName");
				certInfo.CertName = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertName");
				certInfo.CertDomainName = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertDomainName");
				certInfo.CertExpireTime = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertExpireTime");
				certInfo.CertLife = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertLife");
				certInfo.CertOrg = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertOrg");
				certInfo.CertType = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertType");
				certInfo.ServerCertificateStatus = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].ServerCertificateStatus");
				certInfo.Status = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].Status");
				certInfo.ServerCertificate = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].ServerCertificate");
				certInfo.CertUpdateTime = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertUpdateTime");
				certInfo.CertStartTime = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertStartTime");
				certInfo.CertCommonName = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertCommonName");
				certInfo.DomainCnameStatus = _ctx.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].DomainCnameStatus");

				describeDomainCertificateInfoResponse_certInfos.Add(certInfo);
			}
			describeDomainCertificateInfoResponse.CertInfos = describeDomainCertificateInfoResponse_certInfos;
        
			return describeDomainCertificateInfoResponse;
        }
    }
}
