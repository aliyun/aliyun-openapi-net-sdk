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
    public class DescribeCertificateInfoByIDResponseUnmarshaller
    {
        public static DescribeCertificateInfoByIDResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCertificateInfoByIDResponse describeCertificateInfoByIDResponse = new DescribeCertificateInfoByIDResponse();

			describeCertificateInfoByIDResponse.HttpResponse = context.HttpResponse;
			describeCertificateInfoByIDResponse.RequestId = context.StringValue("DescribeCertificateInfoByID.RequestId");

			List<DescribeCertificateInfoByIDResponse.DescribeCertificateInfoByID_CertInfo> describeCertificateInfoByIDResponse_certInfos = new List<DescribeCertificateInfoByIDResponse.DescribeCertificateInfoByID_CertInfo>();
			for (int i = 0; i < context.Length("DescribeCertificateInfoByID.CertInfos.Length"); i++) {
				DescribeCertificateInfoByIDResponse.DescribeCertificateInfoByID_CertInfo certInfo = new DescribeCertificateInfoByIDResponse.DescribeCertificateInfoByID_CertInfo();
				certInfo.CertId = context.StringValue("DescribeCertificateInfoByID.CertInfos["+ i +"].CertId");
				certInfo.CertName = context.StringValue("DescribeCertificateInfoByID.CertInfos["+ i +"].CertName");
				certInfo.CreateTime = context.StringValue("DescribeCertificateInfoByID.CertInfos["+ i +"].CreateTime");
				certInfo.HttpsCrt = context.StringValue("DescribeCertificateInfoByID.CertInfos["+ i +"].HttpsCrt");
				certInfo.CertType = context.StringValue("DescribeCertificateInfoByID.CertInfos["+ i +"].CertType");
				certInfo.CertExpireTime = context.StringValue("DescribeCertificateInfoByID.CertInfos["+ i +"].CertExpireTime");
				certInfo.DomainList = context.StringValue("DescribeCertificateInfoByID.CertInfos["+ i +"].DomainList");

				describeCertificateInfoByIDResponse_certInfos.Add(certInfo);
			}
			describeCertificateInfoByIDResponse.CertInfos = describeCertificateInfoByIDResponse_certInfos;
        
			return describeCertificateInfoByIDResponse;
        }
    }
}
