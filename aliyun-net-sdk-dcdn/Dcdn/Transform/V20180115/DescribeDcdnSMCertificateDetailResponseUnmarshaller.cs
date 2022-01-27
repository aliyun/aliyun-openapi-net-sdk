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
    public class DescribeDcdnSMCertificateDetailResponseUnmarshaller
    {
        public static DescribeDcdnSMCertificateDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnSMCertificateDetailResponse describeDcdnSMCertificateDetailResponse = new DescribeDcdnSMCertificateDetailResponse();

			describeDcdnSMCertificateDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnSMCertificateDetailResponse.RequestId = _ctx.StringValue("DescribeDcdnSMCertificateDetail.RequestId");
			describeDcdnSMCertificateDetailResponse.SignCertificate = _ctx.StringValue("DescribeDcdnSMCertificateDetail.SignCertificate");
			describeDcdnSMCertificateDetailResponse.EncryptCertificate = _ctx.StringValue("DescribeDcdnSMCertificateDetail.EncryptCertificate");
			describeDcdnSMCertificateDetailResponse.CertIdentifier = _ctx.StringValue("DescribeDcdnSMCertificateDetail.CertIdentifier");
			describeDcdnSMCertificateDetailResponse.CertName = _ctx.StringValue("DescribeDcdnSMCertificateDetail.CertName");
			describeDcdnSMCertificateDetailResponse.CommonName = _ctx.StringValue("DescribeDcdnSMCertificateDetail.CommonName");
			describeDcdnSMCertificateDetailResponse.Sans = _ctx.StringValue("DescribeDcdnSMCertificateDetail.Sans");
			describeDcdnSMCertificateDetailResponse.CertOrg = _ctx.StringValue("DescribeDcdnSMCertificateDetail.CertOrg");
			describeDcdnSMCertificateDetailResponse.CertExpireTime = _ctx.StringValue("DescribeDcdnSMCertificateDetail.CertExpireTime");
        
			return describeDcdnSMCertificateDetailResponse;
        }
    }
}
