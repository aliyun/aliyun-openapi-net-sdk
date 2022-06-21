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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveCertificateListResponseUnmarshaller
    {
        public static DescribeLiveCertificateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveCertificateListResponse describeLiveCertificateListResponse = new DescribeLiveCertificateListResponse();

			describeLiveCertificateListResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveCertificateListResponse.RequestId = _ctx.StringValue("DescribeLiveCertificateList.RequestId");

			DescribeLiveCertificateListResponse.DescribeLiveCertificateList_CertificateListModel certificateListModel = new DescribeLiveCertificateListResponse.DescribeLiveCertificateList_CertificateListModel();
			certificateListModel.Count = _ctx.IntegerValue("DescribeLiveCertificateList.CertificateListModel.Count");

			List<DescribeLiveCertificateListResponse.DescribeLiveCertificateList_CertificateListModel.DescribeLiveCertificateList_Cert> certificateListModel_certList = new List<DescribeLiveCertificateListResponse.DescribeLiveCertificateList_CertificateListModel.DescribeLiveCertificateList_Cert>();
			for (int i = 0; i < _ctx.Length("DescribeLiveCertificateList.CertificateListModel.CertList.Length"); i++) {
				DescribeLiveCertificateListResponse.DescribeLiveCertificateList_CertificateListModel.DescribeLiveCertificateList_Cert cert = new DescribeLiveCertificateListResponse.DescribeLiveCertificateList_CertificateListModel.DescribeLiveCertificateList_Cert();
				cert.CertName = _ctx.StringValue("DescribeLiveCertificateList.CertificateListModel.CertList["+ i +"].CertName");
				cert.CertId = _ctx.LongValue("DescribeLiveCertificateList.CertificateListModel.CertList["+ i +"].CertId");
				cert.Fingerprint = _ctx.StringValue("DescribeLiveCertificateList.CertificateListModel.CertList["+ i +"].Fingerprint");
				cert.Common = _ctx.StringValue("DescribeLiveCertificateList.CertificateListModel.CertList["+ i +"].Common");
				cert.Issuer = _ctx.StringValue("DescribeLiveCertificateList.CertificateListModel.CertList["+ i +"].Issuer");
				cert.LastTime = _ctx.LongValue("DescribeLiveCertificateList.CertificateListModel.CertList["+ i +"].LastTime");

				certificateListModel_certList.Add(cert);
			}
			certificateListModel.CertList = certificateListModel_certList;
			describeLiveCertificateListResponse.CertificateListModel = certificateListModel;
        
			return describeLiveCertificateListResponse;
        }
    }
}
