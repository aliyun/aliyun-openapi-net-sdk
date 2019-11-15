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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnDomainCertificateInfoResponseUnmarshaller
    {
        public static DescribeScdnDomainCertificateInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainCertificateInfoResponse describeScdnDomainCertificateInfoResponse = new DescribeScdnDomainCertificateInfoResponse();

			describeScdnDomainCertificateInfoResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainCertificateInfoResponse.RequestId = context.StringValue("DescribeScdnDomainCertificateInfo.RequestId");

			List<DescribeScdnDomainCertificateInfoResponse.DescribeScdnDomainCertificateInfo_CertInfo> describeScdnDomainCertificateInfoResponse_certInfos = new List<DescribeScdnDomainCertificateInfoResponse.DescribeScdnDomainCertificateInfo_CertInfo>();
			for (int i = 0; i < context.Length("DescribeScdnDomainCertificateInfo.CertInfos.Length"); i++) {
				DescribeScdnDomainCertificateInfoResponse.DescribeScdnDomainCertificateInfo_CertInfo certInfo = new DescribeScdnDomainCertificateInfoResponse.DescribeScdnDomainCertificateInfo_CertInfo();
				certInfo.DomainName = context.StringValue("DescribeScdnDomainCertificateInfo.CertInfos["+ i +"].DomainName");
				certInfo.CertName = context.StringValue("DescribeScdnDomainCertificateInfo.CertInfos["+ i +"].CertName");
				certInfo.CertDomainName = context.StringValue("DescribeScdnDomainCertificateInfo.CertInfos["+ i +"].CertDomainName");
				certInfo.CertExpireTime = context.StringValue("DescribeScdnDomainCertificateInfo.CertInfos["+ i +"].CertExpireTime");
				certInfo.CertLife = context.StringValue("DescribeScdnDomainCertificateInfo.CertInfos["+ i +"].CertLife");
				certInfo.CertOrg = context.StringValue("DescribeScdnDomainCertificateInfo.CertInfos["+ i +"].CertOrg");
				certInfo.CertType = context.StringValue("DescribeScdnDomainCertificateInfo.CertInfos["+ i +"].CertType");
				certInfo.SSLProtocol = context.StringValue("DescribeScdnDomainCertificateInfo.CertInfos["+ i +"].SSLProtocol");
				certInfo.Status = context.StringValue("DescribeScdnDomainCertificateInfo.CertInfos["+ i +"].Status");
				certInfo.SSLPub = context.StringValue("DescribeScdnDomainCertificateInfo.CertInfos["+ i +"].SSLPub");

				describeScdnDomainCertificateInfoResponse_certInfos.Add(certInfo);
			}
			describeScdnDomainCertificateInfoResponse.CertInfos = describeScdnDomainCertificateInfoResponse_certInfos;
        
			return describeScdnDomainCertificateInfoResponse;
        }
    }
}
