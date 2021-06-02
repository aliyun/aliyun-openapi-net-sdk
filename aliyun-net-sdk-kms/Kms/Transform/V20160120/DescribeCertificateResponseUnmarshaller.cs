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
using Aliyun.Acs.Kms.Model.V20160120;

namespace Aliyun.Acs.Kms.Transform.V20160120
{
    public class DescribeCertificateResponseUnmarshaller
    {
        public static DescribeCertificateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCertificateResponse describeCertificateResponse = new DescribeCertificateResponse();

			describeCertificateResponse.HttpResponse = _ctx.HttpResponse;
			describeCertificateResponse.RequestId = _ctx.StringValue("DescribeCertificate.RequestId");
			describeCertificateResponse.CertificateId = _ctx.StringValue("DescribeCertificate.CertificateId");
			describeCertificateResponse.Arn = _ctx.StringValue("DescribeCertificate.Arn");
			describeCertificateResponse.KeySpec = _ctx.StringValue("DescribeCertificate.KeySpec");
			describeCertificateResponse.Status = _ctx.StringValue("DescribeCertificate.Status");
			describeCertificateResponse.CreatedAt = _ctx.StringValue("DescribeCertificate.CreatedAt");
			describeCertificateResponse.UpdatedAt = _ctx.StringValue("DescribeCertificate.UpdatedAt");
			describeCertificateResponse.Serial = _ctx.StringValue("DescribeCertificate.Serial");
			describeCertificateResponse.Subject = _ctx.StringValue("DescribeCertificate.Subject");
			describeCertificateResponse.Issuer = _ctx.StringValue("DescribeCertificate.Issuer");
			describeCertificateResponse.NotBefore = _ctx.StringValue("DescribeCertificate.NotBefore");
			describeCertificateResponse.NotAfter = _ctx.StringValue("DescribeCertificate.NotAfter");
			describeCertificateResponse.SignatureAlgorithm = _ctx.StringValue("DescribeCertificate.SignatureAlgorithm");
			describeCertificateResponse.SubjectPublicKey = _ctx.StringValue("DescribeCertificate.SubjectPublicKey");
			describeCertificateResponse.SubjectKeyIdentifier = _ctx.StringValue("DescribeCertificate.SubjectKeyIdentifier");
			describeCertificateResponse.Tags = _ctx.StringValue("DescribeCertificate.Tags");
			describeCertificateResponse.ExportablePrivateKey = _ctx.BooleanValue("DescribeCertificate.ExportablePrivateKey");
			describeCertificateResponse.ProtectionLevel = _ctx.StringValue("DescribeCertificate.ProtectionLevel");

			List<string> describeCertificateResponse_subjectAlternativeNames = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeCertificate.SubjectAlternativeNames.Length"); i++) {
				describeCertificateResponse_subjectAlternativeNames.Add(_ctx.StringValue("DescribeCertificate.SubjectAlternativeNames["+ i +"]"));
			}
			describeCertificateResponse.SubjectAlternativeNames = describeCertificateResponse_subjectAlternativeNames;
        
			return describeCertificateResponse;
        }
    }
}
