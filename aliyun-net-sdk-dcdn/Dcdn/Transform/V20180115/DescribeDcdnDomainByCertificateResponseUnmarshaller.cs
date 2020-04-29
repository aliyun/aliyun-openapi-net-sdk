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
    public class DescribeDcdnDomainByCertificateResponseUnmarshaller
    {
        public static DescribeDcdnDomainByCertificateResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainByCertificateResponse describeDcdnDomainByCertificateResponse = new DescribeDcdnDomainByCertificateResponse();

			describeDcdnDomainByCertificateResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainByCertificateResponse.RequestId = context.StringValue("DescribeDcdnDomainByCertificate.RequestId");

			List<DescribeDcdnDomainByCertificateResponse.DescribeDcdnDomainByCertificate_CertInfo> describeDcdnDomainByCertificateResponse_certInfos = new List<DescribeDcdnDomainByCertificateResponse.DescribeDcdnDomainByCertificate_CertInfo>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainByCertificate.CertInfos.Length"); i++) {
				DescribeDcdnDomainByCertificateResponse.DescribeDcdnDomainByCertificate_CertInfo certInfo = new DescribeDcdnDomainByCertificateResponse.DescribeDcdnDomainByCertificate_CertInfo();
				certInfo.Issuer = context.StringValue("DescribeDcdnDomainByCertificate.CertInfos["+ i +"].Issuer");
				certInfo.CertType = context.StringValue("DescribeDcdnDomainByCertificate.CertInfos["+ i +"].CertType");
				certInfo.CertSubjectCommonName = context.StringValue("DescribeDcdnDomainByCertificate.CertInfos["+ i +"].CertSubjectCommonName");
				certInfo.CertExpireTime = context.StringValue("DescribeDcdnDomainByCertificate.CertInfos["+ i +"].CertExpireTime");
				certInfo.CertStartTime = context.StringValue("DescribeDcdnDomainByCertificate.CertInfos["+ i +"].CertStartTime");
				certInfo.DomainNames = context.StringValue("DescribeDcdnDomainByCertificate.CertInfos["+ i +"].DomainNames");
				certInfo.DomainList = context.StringValue("DescribeDcdnDomainByCertificate.CertInfos["+ i +"].DomainList");
				certInfo.CertExpired = context.StringValue("DescribeDcdnDomainByCertificate.CertInfos["+ i +"].CertExpired");
				certInfo.CertCaIsLegacy = context.StringValue("DescribeDcdnDomainByCertificate.CertInfos["+ i +"].CertCaIsLegacy");

				describeDcdnDomainByCertificateResponse_certInfos.Add(certInfo);
			}
			describeDcdnDomainByCertificateResponse.CertInfos = describeDcdnDomainByCertificateResponse_certInfos;
        
			return describeDcdnDomainByCertificateResponse;
        }
    }
}
