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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeOrganizationUserCertsResponseUnmarshaller
    {
        public static DescribeOrganizationUserCertsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrganizationUserCertsResponse describeOrganizationUserCertsResponse = new DescribeOrganizationUserCertsResponse();

			describeOrganizationUserCertsResponse.HttpResponse = context.HttpResponse;
			describeOrganizationUserCertsResponse.RequestId = context.StringValue("DescribeOrganizationUserCerts.RequestId");
			describeOrganizationUserCertsResponse.Success = context.BooleanValue("DescribeOrganizationUserCerts.Success");
			describeOrganizationUserCertsResponse.ErrorCode = context.IntegerValue("DescribeOrganizationUserCerts.ErrorCode");
			describeOrganizationUserCertsResponse.DynamicCode = context.StringValue("DescribeOrganizationUserCerts.DynamicCode");
			describeOrganizationUserCertsResponse.DynamicMessage = context.StringValue("DescribeOrganizationUserCerts.DynamicMessage");

			DescribeOrganizationUserCertsResponse.DescribeOrganizationUserCerts_Result result = new DescribeOrganizationUserCertsResponse.DescribeOrganizationUserCerts_Result();

			DescribeOrganizationUserCertsResponse.DescribeOrganizationUserCerts_Result.DescribeOrganizationUserCerts_KeyPair keyPair = new DescribeOrganizationUserCertsResponse.DescribeOrganizationUserCerts_Result.DescribeOrganizationUserCerts_KeyPair();
			keyPair.PrivateKey = context.StringValue("DescribeOrganizationUserCerts.Result.KeyPair.PrivateKey");
			keyPair.PublicKey = context.StringValue("DescribeOrganizationUserCerts.Result.KeyPair.PublicKey");
			result.KeyPair = keyPair;

			List<DescribeOrganizationUserCertsResponse.DescribeOrganizationUserCerts_Result.DescribeOrganizationUserCerts_Certificate> result_certificates = new List<DescribeOrganizationUserCertsResponse.DescribeOrganizationUserCerts_Result.DescribeOrganizationUserCerts_Certificate>();
			for (int i = 0; i < context.Length("DescribeOrganizationUserCerts.Result.Certificates.Length"); i++) {
				DescribeOrganizationUserCertsResponse.DescribeOrganizationUserCerts_Result.DescribeOrganizationUserCerts_Certificate certificate = new DescribeOrganizationUserCertsResponse.DescribeOrganizationUserCerts_Result.DescribeOrganizationUserCerts_Certificate();
				certificate.Scope = context.StringValue("DescribeOrganizationUserCerts.Result.Certificates["+ i +"].Scope");
				certificate.Name = context.StringValue("DescribeOrganizationUserCerts.Result.Certificates["+ i +"].Name");
				certificate.Subject = context.StringValue("DescribeOrganizationUserCerts.Result.Certificates["+ i +"].Subject");
				certificate.Issuer = context.StringValue("DescribeOrganizationUserCerts.Result.Certificates["+ i +"].Issuer");
				certificate.ValidFrom = context.StringValue("DescribeOrganizationUserCerts.Result.Certificates["+ i +"].ValidFrom");
				certificate.ValidTo = context.StringValue("DescribeOrganizationUserCerts.Result.Certificates["+ i +"].ValidTo");
				certificate.CertData = context.StringValue("DescribeOrganizationUserCerts.Result.Certificates["+ i +"].CertData");

				result_certificates.Add(certificate);
			}
			result.Certificates = result_certificates;
			describeOrganizationUserCertsResponse.Result = result;
        
			return describeOrganizationUserCertsResponse;
        }
    }
}