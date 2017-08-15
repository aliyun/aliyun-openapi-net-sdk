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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeCACertificatesResponseUnmarshaller
    {
        public static DescribeCACertificatesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCACertificatesResponse describeCACertificatesResponse = new DescribeCACertificatesResponse();

			describeCACertificatesResponse.HttpResponse = context.HttpResponse;
			describeCACertificatesResponse.RequestId = context.StringValue("DescribeCACertificates.RequestId");

			List<DescribeCACertificatesResponse.DescribeCACertificates_CACertificate> describeCACertificatesResponse_cACertificates = new List<DescribeCACertificatesResponse.DescribeCACertificates_CACertificate>();
			for (int i = 0; i < context.Length("DescribeCACertificates.CACertificates.Length"); i++) {
				DescribeCACertificatesResponse.DescribeCACertificates_CACertificate cACertificate = new DescribeCACertificatesResponse.DescribeCACertificates_CACertificate();
				cACertificate.RegionId = context.StringValue("DescribeCACertificates.CACertificates["+ i +"].RegionId");
				cACertificate.CACertificateId = context.StringValue("DescribeCACertificates.CACertificates["+ i +"].CACertificateId");
				cACertificate.CACertificateName = context.StringValue("DescribeCACertificates.CACertificates["+ i +"].CACertificateName");
				cACertificate.Fingerprint = context.StringValue("DescribeCACertificates.CACertificates["+ i +"].Fingerprint");
				cACertificate.ResourceGroupId = context.StringValue("DescribeCACertificates.CACertificates["+ i +"].ResourceGroupId");
				cACertificate.CreateTime = context.StringValue("DescribeCACertificates.CACertificates["+ i +"].CreateTime");
				cACertificate.CreateTimeStamp = context.LongValue("DescribeCACertificates.CACertificates["+ i +"].CreateTimeStamp");

				describeCACertificatesResponse_cACertificates.Add(cACertificate);
			}
			describeCACertificatesResponse.CACertificates = describeCACertificatesResponse_cACertificates;
        
			return describeCACertificatesResponse;
        }
    }
}