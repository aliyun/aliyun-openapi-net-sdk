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
using Aliyun.Acs.Kms.Model.V20160120;

namespace Aliyun.Acs.Kms.Transform.V20160120
{
    public class ListCertificatesResponseUnmarshaller
    {
        public static ListCertificatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCertificatesResponse listCertificatesResponse = new ListCertificatesResponse();

			listCertificatesResponse.HttpResponse = _ctx.HttpResponse;
			listCertificatesResponse.RequestId = _ctx.StringValue("ListCertificates.RequestId");
			listCertificatesResponse.TotalSize = _ctx.IntegerValue("ListCertificates.TotalSize");
			listCertificatesResponse.PageNumber = _ctx.IntegerValue("ListCertificates.PageNumber");
			listCertificatesResponse.PageSize = _ctx.IntegerValue("ListCertificates.PageSize");

			List<ListCertificatesResponse.ListCertificates_CertificateSummary> listCertificatesResponse_certificateSummaryList = new List<ListCertificatesResponse.ListCertificates_CertificateSummary>();
			for (int i = 0; i < _ctx.Length("ListCertificates.CertificateSummaryList.Length"); i++) {
				ListCertificatesResponse.ListCertificates_CertificateSummary certificateSummary = new ListCertificatesResponse.ListCertificates_CertificateSummary();
				certificateSummary.CertificateId = _ctx.StringValue("ListCertificates.CertificateSummaryList["+ i +"].CertificateId");
				certificateSummary.Subject = _ctx.StringValue("ListCertificates.CertificateSummaryList["+ i +"].Subject");
				certificateSummary.Issuer = _ctx.StringValue("ListCertificates.CertificateSummaryList["+ i +"].Issuer");
				certificateSummary.KeySpec = _ctx.StringValue("ListCertificates.CertificateSummaryList["+ i +"].KeySpec");
				certificateSummary.ProtectionLevel = _ctx.StringValue("ListCertificates.CertificateSummaryList["+ i +"].ProtectionLevel");
				certificateSummary.NotBefore = _ctx.StringValue("ListCertificates.CertificateSummaryList["+ i +"].NotBefore");
				certificateSummary.NotAfter = _ctx.StringValue("ListCertificates.CertificateSummaryList["+ i +"].NotAfter");
				certificateSummary.Status = _ctx.StringValue("ListCertificates.CertificateSummaryList["+ i +"].Status");

				listCertificatesResponse_certificateSummaryList.Add(certificateSummary);
			}
			listCertificatesResponse.CertificateSummaryList = listCertificatesResponse_certificateSummaryList;
        
			return listCertificatesResponse;
        }
    }
}
