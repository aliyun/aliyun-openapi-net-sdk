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
using Aliyun.Acs.waf_openapi.Model.V20190910;

namespace Aliyun.Acs.waf_openapi.Transform.V20190910
{
    public class DescribeCertificatesResponseUnmarshaller
    {
        public static DescribeCertificatesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCertificatesResponse describeCertificatesResponse = new DescribeCertificatesResponse();

			describeCertificatesResponse.HttpResponse = context.HttpResponse;
			describeCertificatesResponse.RequestId = context.StringValue("DescribeCertificates.RequestId");

			List<DescribeCertificatesResponse.DescribeCertificates_Certificate> describeCertificatesResponse_certificates = new List<DescribeCertificatesResponse.DescribeCertificates_Certificate>();
			for (int i = 0; i < context.Length("DescribeCertificates.Certificates.Length"); i++) {
				DescribeCertificatesResponse.DescribeCertificates_Certificate certificate = new DescribeCertificatesResponse.DescribeCertificates_Certificate();
				certificate.CommonName = context.StringValue("DescribeCertificates.Certificates["+ i +"].CommonName");
				certificate.IsUsing = context.BooleanValue("DescribeCertificates.Certificates["+ i +"].IsUsing");
				certificate.CertificateName = context.StringValue("DescribeCertificates.Certificates["+ i +"].CertificateName");
				certificate.CertificateId = context.LongValue("DescribeCertificates.Certificates["+ i +"].CertificateId");

				List<string> certificate_sans = new List<string>();
				for (int j = 0; j < context.Length("DescribeCertificates.Certificates["+ i +"].Sans.Length"); j++) {
					certificate_sans.Add(context.StringValue("DescribeCertificates.Certificates["+ i +"].Sans["+ j +"]"));
				}
				certificate.Sans = certificate_sans;

				describeCertificatesResponse_certificates.Add(certificate);
			}
			describeCertificatesResponse.Certificates = describeCertificatesResponse_certificates;
        
			return describeCertificatesResponse;
        }
    }
}
