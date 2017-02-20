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
using Aliyun.Acs.Slb.Model.V20140515;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeCaCertificatesResponseUnmarshaller
    {
        public static DescribeCaCertificatesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeCaCertificatesResponse describeCaCertificatesResponse = new DescribeCaCertificatesResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeCACertificates.RequestId")
            };
            List<DescribeCaCertificatesResponse.CaCertificate> cACertificates = new List<DescribeCaCertificatesResponse.CaCertificate>();
			for (int i = 0; i < context.Length("DescribeCACertificates.CACertificates.Length"); i++) {
                DescribeCaCertificatesResponse.CaCertificate cACertificate = new DescribeCaCertificatesResponse.CaCertificate()
                {
                    RegionId = context.StringValue($"DescribeCACertificates.CACertificates[{i}].RegionId"),
                    CaCertificateId = context.StringValue($"DescribeCACertificates.CACertificates[{i}].CACertificateId"),
                    CaCertificateName = context.StringValue($"DescribeCACertificates.CACertificates[{i}].CACertificateName"),
                    Fingerprint = context.StringValue($"DescribeCACertificates.CACertificates[{i}].Fingerprint")
                };
                cACertificates.Add(cACertificate);
			}
			describeCaCertificatesResponse.CaCertificates = cACertificates;
        
			return describeCaCertificatesResponse;
        }
    }
}