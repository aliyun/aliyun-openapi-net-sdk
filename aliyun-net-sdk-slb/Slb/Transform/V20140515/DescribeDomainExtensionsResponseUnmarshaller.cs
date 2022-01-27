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
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeDomainExtensionsResponseUnmarshaller
    {
        public static DescribeDomainExtensionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainExtensionsResponse describeDomainExtensionsResponse = new DescribeDomainExtensionsResponse();

			describeDomainExtensionsResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainExtensionsResponse.RequestId = _ctx.StringValue("DescribeDomainExtensions.RequestId");

			List<DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension> describeDomainExtensionsResponse_domainExtensions = new List<DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension>();
			for (int i = 0; i < _ctx.Length("DescribeDomainExtensions.DomainExtensions.Length"); i++) {
				DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension domainExtension = new DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension();
				domainExtension.DomainExtensionId = _ctx.StringValue("DescribeDomainExtensions.DomainExtensions["+ i +"].DomainExtensionId");
				domainExtension.Domain = _ctx.StringValue("DescribeDomainExtensions.DomainExtensions["+ i +"].Domain");
				domainExtension.ServerCertificateId = _ctx.StringValue("DescribeDomainExtensions.DomainExtensions["+ i +"].ServerCertificateId");

				List<DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension.DescribeDomainExtensions_Certificate> domainExtension_certificates = new List<DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension.DescribeDomainExtensions_Certificate>();
				for (int j = 0; j < _ctx.Length("DescribeDomainExtensions.DomainExtensions["+ i +"].Certificates.Length"); j++) {
					DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension.DescribeDomainExtensions_Certificate certificate = new DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension.DescribeDomainExtensions_Certificate();
					certificate.CertificateId = _ctx.StringValue("DescribeDomainExtensions.DomainExtensions["+ i +"].Certificates["+ j +"].CertificateId");
					certificate.EncryptionAlgorithm = _ctx.StringValue("DescribeDomainExtensions.DomainExtensions["+ i +"].Certificates["+ j +"].EncryptionAlgorithm");

					domainExtension_certificates.Add(certificate);
				}
				domainExtension.Certificates = domainExtension_certificates;

				List<DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension.DescribeDomainExtensions_ServerCertificate> domainExtension_serverCertificates = new List<DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension.DescribeDomainExtensions_ServerCertificate>();
				for (int j = 0; j < _ctx.Length("DescribeDomainExtensions.DomainExtensions["+ i +"].ServerCertificates.Length"); j++) {
					DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension.DescribeDomainExtensions_ServerCertificate serverCertificate = new DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension.DescribeDomainExtensions_ServerCertificate();
					serverCertificate.CertificateId = _ctx.StringValue("DescribeDomainExtensions.DomainExtensions["+ i +"].ServerCertificates["+ j +"].CertificateId");
					serverCertificate.EncryptionAlgorithm = _ctx.StringValue("DescribeDomainExtensions.DomainExtensions["+ i +"].ServerCertificates["+ j +"].EncryptionAlgorithm");
					serverCertificate.BindingType = _ctx.StringValue("DescribeDomainExtensions.DomainExtensions["+ i +"].ServerCertificates["+ j +"].BindingType");
					serverCertificate.StandardType = _ctx.StringValue("DescribeDomainExtensions.DomainExtensions["+ i +"].ServerCertificates["+ j +"].StandardType");

					domainExtension_serverCertificates.Add(serverCertificate);
				}
				domainExtension.ServerCertificates = domainExtension_serverCertificates;

				describeDomainExtensionsResponse_domainExtensions.Add(domainExtension);
			}
			describeDomainExtensionsResponse.DomainExtensions = describeDomainExtensionsResponse_domainExtensions;
        
			return describeDomainExtensionsResponse;
        }
    }
}
