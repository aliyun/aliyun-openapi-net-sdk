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
    public class DescribeDomainExtensionAttributeResponseUnmarshaller
    {
        public static DescribeDomainExtensionAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainExtensionAttributeResponse describeDomainExtensionAttributeResponse = new DescribeDomainExtensionAttributeResponse();

			describeDomainExtensionAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainExtensionAttributeResponse.RequestId = _ctx.StringValue("DescribeDomainExtensionAttribute.RequestId");
			describeDomainExtensionAttributeResponse.DomainExtensionId = _ctx.StringValue("DescribeDomainExtensionAttribute.DomainExtensionId");
			describeDomainExtensionAttributeResponse.Domain = _ctx.StringValue("DescribeDomainExtensionAttribute.Domain");
			describeDomainExtensionAttributeResponse.ServerCertificateId = _ctx.StringValue("DescribeDomainExtensionAttribute.ServerCertificateId");
			describeDomainExtensionAttributeResponse.LoadBalancerId = _ctx.StringValue("DescribeDomainExtensionAttribute.LoadBalancerId");
			describeDomainExtensionAttributeResponse.ListenerPort = _ctx.IntegerValue("DescribeDomainExtensionAttribute.ListenerPort");

			List<DescribeDomainExtensionAttributeResponse.DescribeDomainExtensionAttribute_Certificate> describeDomainExtensionAttributeResponse_certificates = new List<DescribeDomainExtensionAttributeResponse.DescribeDomainExtensionAttribute_Certificate>();
			for (int i = 0; i < _ctx.Length("DescribeDomainExtensionAttribute.Certificates.Length"); i++) {
				DescribeDomainExtensionAttributeResponse.DescribeDomainExtensionAttribute_Certificate certificate = new DescribeDomainExtensionAttributeResponse.DescribeDomainExtensionAttribute_Certificate();
				certificate.CertificateId = _ctx.StringValue("DescribeDomainExtensionAttribute.Certificates["+ i +"].CertificateId");
				certificate.EncryptionAlgorithm = _ctx.StringValue("DescribeDomainExtensionAttribute.Certificates["+ i +"].EncryptionAlgorithm");

				describeDomainExtensionAttributeResponse_certificates.Add(certificate);
			}
			describeDomainExtensionAttributeResponse.Certificates = describeDomainExtensionAttributeResponse_certificates;

			List<DescribeDomainExtensionAttributeResponse.DescribeDomainExtensionAttribute_ServerCertificate> describeDomainExtensionAttributeResponse_serverCertificates = new List<DescribeDomainExtensionAttributeResponse.DescribeDomainExtensionAttribute_ServerCertificate>();
			for (int i = 0; i < _ctx.Length("DescribeDomainExtensionAttribute.ServerCertificates.Length"); i++) {
				DescribeDomainExtensionAttributeResponse.DescribeDomainExtensionAttribute_ServerCertificate serverCertificate = new DescribeDomainExtensionAttributeResponse.DescribeDomainExtensionAttribute_ServerCertificate();
				serverCertificate.CertificateId = _ctx.StringValue("DescribeDomainExtensionAttribute.ServerCertificates["+ i +"].CertificateId");
				serverCertificate.EncryptionAlgorithm = _ctx.StringValue("DescribeDomainExtensionAttribute.ServerCertificates["+ i +"].EncryptionAlgorithm");
				serverCertificate.StandardType = _ctx.StringValue("DescribeDomainExtensionAttribute.ServerCertificates["+ i +"].StandardType");
				serverCertificate.BindingType = _ctx.StringValue("DescribeDomainExtensionAttribute.ServerCertificates["+ i +"].BindingType");

				describeDomainExtensionAttributeResponse_serverCertificates.Add(serverCertificate);
			}
			describeDomainExtensionAttributeResponse.ServerCertificates = describeDomainExtensionAttributeResponse_serverCertificates;
        
			return describeDomainExtensionAttributeResponse;
        }
    }
}
