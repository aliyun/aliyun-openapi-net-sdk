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
    public class DescribeDcdnCertificateListResponseUnmarshaller
    {
        public static DescribeDcdnCertificateListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnCertificateListResponse describeDcdnCertificateListResponse = new DescribeDcdnCertificateListResponse();

			describeDcdnCertificateListResponse.HttpResponse = context.HttpResponse;
			describeDcdnCertificateListResponse.RequestId = context.StringValue("DescribeDcdnCertificateList.RequestId");

			DescribeDcdnCertificateListResponse.DescribeDcdnCertificateList_CertificateListModel certificateListModel = new DescribeDcdnCertificateListResponse.DescribeDcdnCertificateList_CertificateListModel();
			certificateListModel.Count = context.IntegerValue("DescribeDcdnCertificateList.CertificateListModel.Count");

			List<DescribeDcdnCertificateListResponse.DescribeDcdnCertificateList_CertificateListModel.DescribeDcdnCertificateList_Cert> certificateListModel_certList = new List<DescribeDcdnCertificateListResponse.DescribeDcdnCertificateList_CertificateListModel.DescribeDcdnCertificateList_Cert>();
			for (int i = 0; i < context.Length("DescribeDcdnCertificateList.CertificateListModel.CertList.Length"); i++) {
				DescribeDcdnCertificateListResponse.DescribeDcdnCertificateList_CertificateListModel.DescribeDcdnCertificateList_Cert cert = new DescribeDcdnCertificateListResponse.DescribeDcdnCertificateList_CertificateListModel.DescribeDcdnCertificateList_Cert();
				cert.CertName = context.StringValue("DescribeDcdnCertificateList.CertificateListModel.CertList["+ i +"].CertName");
				cert.CertId = context.LongValue("DescribeDcdnCertificateList.CertificateListModel.CertList["+ i +"].CertId");
				cert.Fingerprint = context.StringValue("DescribeDcdnCertificateList.CertificateListModel.CertList["+ i +"].Fingerprint");
				cert.Common = context.StringValue("DescribeDcdnCertificateList.CertificateListModel.CertList["+ i +"].Common");
				cert.Issuer = context.StringValue("DescribeDcdnCertificateList.CertificateListModel.CertList["+ i +"].Issuer");
				cert.LastTime = context.LongValue("DescribeDcdnCertificateList.CertificateListModel.CertList["+ i +"].LastTime");

				certificateListModel_certList.Add(cert);
			}
			certificateListModel.CertList = certificateListModel_certList;
			describeDcdnCertificateListResponse.CertificateListModel = certificateListModel;
        
			return describeDcdnCertificateListResponse;
        }
    }
}
