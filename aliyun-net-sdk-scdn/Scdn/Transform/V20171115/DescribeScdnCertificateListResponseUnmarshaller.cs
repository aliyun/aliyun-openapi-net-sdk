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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnCertificateListResponseUnmarshaller
    {
        public static DescribeScdnCertificateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnCertificateListResponse describeScdnCertificateListResponse = new DescribeScdnCertificateListResponse();

			describeScdnCertificateListResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnCertificateListResponse.RequestId = _ctx.StringValue("DescribeScdnCertificateList.RequestId");

			DescribeScdnCertificateListResponse.DescribeScdnCertificateList_CertificateListModel certificateListModel = new DescribeScdnCertificateListResponse.DescribeScdnCertificateList_CertificateListModel();
			certificateListModel.Count = _ctx.IntegerValue("DescribeScdnCertificateList.CertificateListModel.Count");

			List<DescribeScdnCertificateListResponse.DescribeScdnCertificateList_CertificateListModel.DescribeScdnCertificateList_Cert> certificateListModel_certList = new List<DescribeScdnCertificateListResponse.DescribeScdnCertificateList_CertificateListModel.DescribeScdnCertificateList_Cert>();
			for (int i = 0; i < _ctx.Length("DescribeScdnCertificateList.CertificateListModel.CertList.Length"); i++) {
				DescribeScdnCertificateListResponse.DescribeScdnCertificateList_CertificateListModel.DescribeScdnCertificateList_Cert cert = new DescribeScdnCertificateListResponse.DescribeScdnCertificateList_CertificateListModel.DescribeScdnCertificateList_Cert();
				cert.CertName = _ctx.StringValue("DescribeScdnCertificateList.CertificateListModel.CertList["+ i +"].CertName");
				cert.CertId = _ctx.LongValue("DescribeScdnCertificateList.CertificateListModel.CertList["+ i +"].CertId");
				cert.Fingerprint = _ctx.StringValue("DescribeScdnCertificateList.CertificateListModel.CertList["+ i +"].Fingerprint");
				cert.Common = _ctx.StringValue("DescribeScdnCertificateList.CertificateListModel.CertList["+ i +"].Common");
				cert.Issuer = _ctx.StringValue("DescribeScdnCertificateList.CertificateListModel.CertList["+ i +"].Issuer");
				cert.LastTime = _ctx.LongValue("DescribeScdnCertificateList.CertificateListModel.CertList["+ i +"].LastTime");

				certificateListModel_certList.Add(cert);
			}
			certificateListModel.CertList = certificateListModel_certList;
			describeScdnCertificateListResponse.CertificateListModel = certificateListModel;
        
			return describeScdnCertificateListResponse;
        }
    }
}
