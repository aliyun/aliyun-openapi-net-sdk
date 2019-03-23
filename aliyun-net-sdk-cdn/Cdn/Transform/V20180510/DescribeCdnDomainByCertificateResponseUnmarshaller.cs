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
    public class DescribeCdnDomainByCertificateResponseUnmarshaller
    {
        public static DescribeCdnDomainByCertificateResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeCdnDomainByCertificateResponse describeCdnDomainByCertificateResponse = new DescribeCdnDomainByCertificateResponse();

            describeCdnDomainByCertificateResponse.HttpResponse = context.HttpResponse;
            describeCdnDomainByCertificateResponse.RequestId = context.StringValue("DescribeCdnDomainByCertificate.RequestId");

            List<DescribeCdnDomainByCertificateResponse.DescribeCdnDomainByCertificate_CertInfo> describeCdnDomainByCertificateResponse_certInfos = new List<DescribeCdnDomainByCertificateResponse.DescribeCdnDomainByCertificate_CertInfo>();
            for (int i = 0; i < context.Length("DescribeCdnDomainByCertificate.CertInfos.Length"); i++)
            {
                DescribeCdnDomainByCertificateResponse.DescribeCdnDomainByCertificate_CertInfo certInfo = new DescribeCdnDomainByCertificateResponse.DescribeCdnDomainByCertificate_CertInfo();
                certInfo.Issuer = context.StringValue("DescribeCdnDomainByCertificate.CertInfos[" + i + "].Issuer");
                certInfo.CertType = context.StringValue("DescribeCdnDomainByCertificate.CertInfos[" + i + "].CertType");
                certInfo.CertSubjectCommonName = context.StringValue("DescribeCdnDomainByCertificate.CertInfos[" + i + "].CertSubjectCommonName");
                certInfo.CertExpireTime = context.StringValue("DescribeCdnDomainByCertificate.CertInfos[" + i + "].CertExpireTime");
                certInfo.CertStartTime = context.StringValue("DescribeCdnDomainByCertificate.CertInfos[" + i + "].CertStartTime");
                certInfo.DomainNames = context.StringValue("DescribeCdnDomainByCertificate.CertInfos[" + i + "].DomainNames");
                certInfo.DomainList = context.StringValue("DescribeCdnDomainByCertificate.CertInfos[" + i + "].DomainList");
                certInfo.CertExpired = context.StringValue("DescribeCdnDomainByCertificate.CertInfos[" + i + "].CertExpired");
                certInfo.CertCaIsLegacy = context.StringValue("DescribeCdnDomainByCertificate.CertInfos[" + i + "].CertCaIsLegacy");

                describeCdnDomainByCertificateResponse_certInfos.Add(certInfo);
            }
            describeCdnDomainByCertificateResponse.CertInfos = describeCdnDomainByCertificateResponse_certInfos;

            return describeCdnDomainByCertificateResponse;
        }
    }
}
