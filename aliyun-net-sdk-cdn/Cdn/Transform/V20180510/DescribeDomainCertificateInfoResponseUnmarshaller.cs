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
    public class DescribeDomainCertificateInfoResponseUnmarshaller
    {
        public static DescribeDomainCertificateInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainCertificateInfoResponse describeDomainCertificateInfoResponse = new DescribeDomainCertificateInfoResponse();

			describeDomainCertificateInfoResponse.HttpResponse = context.HttpResponse;
			describeDomainCertificateInfoResponse.RequestId = context.StringValue("DescribeDomainCertificateInfo.RequestId");

			List<DescribeDomainCertificateInfoResponse.DescribeDomainCertificateInfo_CertInfo> describeDomainCertificateInfoResponse_certInfos = new List<DescribeDomainCertificateInfoResponse.DescribeDomainCertificateInfo_CertInfo>();
			for (int i = 0; i < context.Length("DescribeDomainCertificateInfo.CertInfos.Length"); i++) {
				DescribeDomainCertificateInfoResponse.DescribeDomainCertificateInfo_CertInfo certInfo = new DescribeDomainCertificateInfoResponse.DescribeDomainCertificateInfo_CertInfo();
				certInfo.DomainName = context.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].DomainName");
				certInfo.CertName = context.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertName");
				certInfo.CertDomainName = context.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertDomainName");
				certInfo.CertExpireTime = context.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertExpireTime");
				certInfo.CertLife = context.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertLife");
				certInfo.CertOrg = context.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertOrg");
				certInfo.CertType = context.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertType");
				certInfo.ServerCertificateStatus = context.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].ServerCertificateStatus");
				certInfo.Status = context.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].Status");
				certInfo.ServerCertificate = context.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].ServerCertificate");
				certInfo.CertUpdateTime = context.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertUpdateTime");
				certInfo.CertStartTime = context.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].CertStartTime");
				certInfo.DomainCnameStatus = context.StringValue("DescribeDomainCertificateInfo.CertInfos["+ i +"].DomainCnameStatus");

				describeDomainCertificateInfoResponse_certInfos.Add(certInfo);
			}
			describeDomainCertificateInfoResponse.CertInfos = describeDomainCertificateInfoResponse_certInfos;
        
			return describeDomainCertificateInfoResponse;
        }
    }
}
