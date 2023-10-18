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
    public class DescribeLiveDomainByCertificateResponseUnmarshaller
    {
        public static DescribeLiveDomainByCertificateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainByCertificateResponse describeLiveDomainByCertificateResponse = new DescribeLiveDomainByCertificateResponse();

			describeLiveDomainByCertificateResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainByCertificateResponse.RequestId = _ctx.StringValue("DescribeLiveDomainByCertificate.RequestId");

			List<DescribeLiveDomainByCertificateResponse.DescribeLiveDomainByCertificate_CertInfo> describeLiveDomainByCertificateResponse_certInfos = new List<DescribeLiveDomainByCertificateResponse.DescribeLiveDomainByCertificate_CertInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainByCertificate.CertInfos.Length"); i++) {
				DescribeLiveDomainByCertificateResponse.DescribeLiveDomainByCertificate_CertInfo certInfo = new DescribeLiveDomainByCertificateResponse.DescribeLiveDomainByCertificate_CertInfo();
				certInfo.CertExpireTime = _ctx.StringValue("DescribeLiveDomainByCertificate.CertInfos["+ i +"].CertExpireTime");
				certInfo.CertStartTime = _ctx.StringValue("DescribeLiveDomainByCertificate.CertInfos["+ i +"].CertStartTime");
				certInfo.CertType = _ctx.StringValue("DescribeLiveDomainByCertificate.CertInfos["+ i +"].CertType");
				certInfo.CertSubjectCommonName = _ctx.StringValue("DescribeLiveDomainByCertificate.CertInfos["+ i +"].CertSubjectCommonName");
				certInfo.CertCaIsLegacy = _ctx.StringValue("DescribeLiveDomainByCertificate.CertInfos["+ i +"].CertCaIsLegacy");
				certInfo.DomainNames = _ctx.StringValue("DescribeLiveDomainByCertificate.CertInfos["+ i +"].DomainNames");
				certInfo.CertExpired = _ctx.StringValue("DescribeLiveDomainByCertificate.CertInfos["+ i +"].CertExpired");
				certInfo.Issuer = _ctx.StringValue("DescribeLiveDomainByCertificate.CertInfos["+ i +"].Issuer");
				certInfo.DomainList = _ctx.StringValue("DescribeLiveDomainByCertificate.CertInfos["+ i +"].DomainList");

				describeLiveDomainByCertificateResponse_certInfos.Add(certInfo);
			}
			describeLiveDomainByCertificateResponse.CertInfos = describeLiveDomainByCertificateResponse_certInfos;
        
			return describeLiveDomainByCertificateResponse;
        }
    }
}
