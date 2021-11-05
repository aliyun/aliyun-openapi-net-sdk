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
    public class DescribeCdnSMCertificateListResponseUnmarshaller
    {
        public static DescribeCdnSMCertificateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnSMCertificateListResponse describeCdnSMCertificateListResponse = new DescribeCdnSMCertificateListResponse();

			describeCdnSMCertificateListResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnSMCertificateListResponse.RequestId = _ctx.StringValue("DescribeCdnSMCertificateList.RequestId");

			DescribeCdnSMCertificateListResponse.DescribeCdnSMCertificateList_CertificateListModel certificateListModel = new DescribeCdnSMCertificateListResponse.DescribeCdnSMCertificateList_CertificateListModel();
			certificateListModel.Count = _ctx.IntegerValue("DescribeCdnSMCertificateList.CertificateListModel.Count");

			List<DescribeCdnSMCertificateListResponse.DescribeCdnSMCertificateList_CertificateListModel.DescribeCdnSMCertificateList_Cert> certificateListModel_certList = new List<DescribeCdnSMCertificateListResponse.DescribeCdnSMCertificateList_CertificateListModel.DescribeCdnSMCertificateList_Cert>();
			for (int i = 0; i < _ctx.Length("DescribeCdnSMCertificateList.CertificateListModel.CertList.Length"); i++) {
				DescribeCdnSMCertificateListResponse.DescribeCdnSMCertificateList_CertificateListModel.DescribeCdnSMCertificateList_Cert cert = new DescribeCdnSMCertificateListResponse.DescribeCdnSMCertificateList_CertificateListModel.DescribeCdnSMCertificateList_Cert();
				cert.CertName = _ctx.StringValue("DescribeCdnSMCertificateList.CertificateListModel.CertList["+ i +"].CertName");
				cert.CertIdentifier = _ctx.StringValue("DescribeCdnSMCertificateList.CertificateListModel.CertList["+ i +"].CertIdentifier");
				cert.Common = _ctx.StringValue("DescribeCdnSMCertificateList.CertificateListModel.CertList["+ i +"].Common");
				cert.Issuer = _ctx.StringValue("DescribeCdnSMCertificateList.CertificateListModel.CertList["+ i +"].Issuer");

				certificateListModel_certList.Add(cert);
			}
			certificateListModel.CertList = certificateListModel_certList;
			describeCdnSMCertificateListResponse.CertificateListModel = certificateListModel;
        
			return describeCdnSMCertificateListResponse;
        }
    }
}
