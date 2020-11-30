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
        public static DescribeDcdnCertificateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnCertificateListResponse describeDcdnCertificateListResponse = new DescribeDcdnCertificateListResponse();

			describeDcdnCertificateListResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnCertificateListResponse.RequestId = _ctx.StringValue("DescribeDcdnCertificateList.RequestId");

			DescribeDcdnCertificateListResponse.DescribeDcdnCertificateList_CertificateListModel certificateListModel = new DescribeDcdnCertificateListResponse.DescribeDcdnCertificateList_CertificateListModel();
			certificateListModel.Count = _ctx.IntegerValue("DescribeDcdnCertificateList.CertificateListModel.Count");

			List<DescribeDcdnCertificateListResponse.DescribeDcdnCertificateList_CertificateListModel.DescribeDcdnCertificateList_Cert> certificateListModel_certList = new List<DescribeDcdnCertificateListResponse.DescribeDcdnCertificateList_CertificateListModel.DescribeDcdnCertificateList_Cert>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnCertificateList.CertificateListModel.CertList.Length"); i++) {
				DescribeDcdnCertificateListResponse.DescribeDcdnCertificateList_CertificateListModel.DescribeDcdnCertificateList_Cert cert = new DescribeDcdnCertificateListResponse.DescribeDcdnCertificateList_CertificateListModel.DescribeDcdnCertificateList_Cert();
				cert.CertName = _ctx.StringValue("DescribeDcdnCertificateList.CertificateListModel.CertList["+ i +"].CertName");
				cert.CertId = _ctx.LongValue("DescribeDcdnCertificateList.CertificateListModel.CertList["+ i +"].CertId");
				cert.Fingerprint = _ctx.StringValue("DescribeDcdnCertificateList.CertificateListModel.CertList["+ i +"].Fingerprint");
				cert.Common = _ctx.StringValue("DescribeDcdnCertificateList.CertificateListModel.CertList["+ i +"].Common");
				cert.Issuer = _ctx.StringValue("DescribeDcdnCertificateList.CertificateListModel.CertList["+ i +"].Issuer");
				cert.LastTime = _ctx.LongValue("DescribeDcdnCertificateList.CertificateListModel.CertList["+ i +"].LastTime");

				certificateListModel_certList.Add(cert);
			}
			certificateListModel.CertList = certificateListModel_certList;
			describeDcdnCertificateListResponse.CertificateListModel = certificateListModel;
        
			return describeDcdnCertificateListResponse;
        }
    }
}
