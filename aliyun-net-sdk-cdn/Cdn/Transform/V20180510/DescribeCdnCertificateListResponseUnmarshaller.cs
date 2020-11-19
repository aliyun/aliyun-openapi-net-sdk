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
    public class DescribeCdnCertificateListResponseUnmarshaller
    {
        public static DescribeCdnCertificateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnCertificateListResponse describeCdnCertificateListResponse = new DescribeCdnCertificateListResponse();

			describeCdnCertificateListResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnCertificateListResponse.RequestId = _ctx.StringValue("DescribeCdnCertificateList.RequestId");

			DescribeCdnCertificateListResponse.DescribeCdnCertificateList_CertificateListModel certificateListModel = new DescribeCdnCertificateListResponse.DescribeCdnCertificateList_CertificateListModel();
			certificateListModel.Count = _ctx.IntegerValue("DescribeCdnCertificateList.CertificateListModel.Count");

			List<DescribeCdnCertificateListResponse.DescribeCdnCertificateList_CertificateListModel.DescribeCdnCertificateList_Cert> certificateListModel_certList = new List<DescribeCdnCertificateListResponse.DescribeCdnCertificateList_CertificateListModel.DescribeCdnCertificateList_Cert>();
			for (int i = 0; i < _ctx.Length("DescribeCdnCertificateList.CertificateListModel.CertList.Length"); i++) {
				DescribeCdnCertificateListResponse.DescribeCdnCertificateList_CertificateListModel.DescribeCdnCertificateList_Cert cert = new DescribeCdnCertificateListResponse.DescribeCdnCertificateList_CertificateListModel.DescribeCdnCertificateList_Cert();
				cert.CertName = _ctx.StringValue("DescribeCdnCertificateList.CertificateListModel.CertList["+ i +"].CertName");
				cert.CertId = _ctx.LongValue("DescribeCdnCertificateList.CertificateListModel.CertList["+ i +"].CertId");
				cert.Fingerprint = _ctx.StringValue("DescribeCdnCertificateList.CertificateListModel.CertList["+ i +"].Fingerprint");
				cert.Common = _ctx.StringValue("DescribeCdnCertificateList.CertificateListModel.CertList["+ i +"].Common");
				cert.Issuer = _ctx.StringValue("DescribeCdnCertificateList.CertificateListModel.CertList["+ i +"].Issuer");
				cert.LastTime = _ctx.LongValue("DescribeCdnCertificateList.CertificateListModel.CertList["+ i +"].LastTime");

				certificateListModel_certList.Add(cert);
			}
			certificateListModel.CertList = certificateListModel_certList;
			describeCdnCertificateListResponse.CertificateListModel = certificateListModel;
        
			return describeCdnCertificateListResponse;
        }
    }
}
