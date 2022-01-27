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
    public class DescribeDcdnSMCertificateListResponseUnmarshaller
    {
        public static DescribeDcdnSMCertificateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnSMCertificateListResponse describeDcdnSMCertificateListResponse = new DescribeDcdnSMCertificateListResponse();

			describeDcdnSMCertificateListResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnSMCertificateListResponse.RequestId = _ctx.StringValue("DescribeDcdnSMCertificateList.RequestId");

			DescribeDcdnSMCertificateListResponse.DescribeDcdnSMCertificateList_CertificateListModel certificateListModel = new DescribeDcdnSMCertificateListResponse.DescribeDcdnSMCertificateList_CertificateListModel();
			certificateListModel.Count = _ctx.IntegerValue("DescribeDcdnSMCertificateList.CertificateListModel.Count");

			List<DescribeDcdnSMCertificateListResponse.DescribeDcdnSMCertificateList_CertificateListModel.DescribeDcdnSMCertificateList_Cert> certificateListModel_certList = new List<DescribeDcdnSMCertificateListResponse.DescribeDcdnSMCertificateList_CertificateListModel.DescribeDcdnSMCertificateList_Cert>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnSMCertificateList.CertificateListModel.CertList.Length"); i++) {
				DescribeDcdnSMCertificateListResponse.DescribeDcdnSMCertificateList_CertificateListModel.DescribeDcdnSMCertificateList_Cert cert = new DescribeDcdnSMCertificateListResponse.DescribeDcdnSMCertificateList_CertificateListModel.DescribeDcdnSMCertificateList_Cert();
				cert.CertName = _ctx.StringValue("DescribeDcdnSMCertificateList.CertificateListModel.CertList["+ i +"].CertName");
				cert.CertIdentifier = _ctx.StringValue("DescribeDcdnSMCertificateList.CertificateListModel.CertList["+ i +"].CertIdentifier");
				cert.Common = _ctx.StringValue("DescribeDcdnSMCertificateList.CertificateListModel.CertList["+ i +"].Common");
				cert.Issuer = _ctx.StringValue("DescribeDcdnSMCertificateList.CertificateListModel.CertList["+ i +"].Issuer");

				certificateListModel_certList.Add(cert);
			}
			certificateListModel.CertList = certificateListModel_certList;
			describeDcdnSMCertificateListResponse.CertificateListModel = certificateListModel;
        
			return describeDcdnSMCertificateListResponse;
        }
    }
}
