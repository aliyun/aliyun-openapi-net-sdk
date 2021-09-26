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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsCertificateListResponseUnmarshaller
    {
        public static DescribeVsCertificateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVsCertificateListResponse describeVsCertificateListResponse = new DescribeVsCertificateListResponse();

			describeVsCertificateListResponse.HttpResponse = _ctx.HttpResponse;
			describeVsCertificateListResponse.RequestId = _ctx.StringValue("DescribeVsCertificateList.RequestId");

			DescribeVsCertificateListResponse.DescribeVsCertificateList_CertificateListModel certificateListModel = new DescribeVsCertificateListResponse.DescribeVsCertificateList_CertificateListModel();
			certificateListModel.Count = _ctx.IntegerValue("DescribeVsCertificateList.CertificateListModel.Count");

			List<DescribeVsCertificateListResponse.DescribeVsCertificateList_CertificateListModel.DescribeVsCertificateList_Cert> certificateListModel_certList = new List<DescribeVsCertificateListResponse.DescribeVsCertificateList_CertificateListModel.DescribeVsCertificateList_Cert>();
			for (int i = 0; i < _ctx.Length("DescribeVsCertificateList.CertificateListModel.CertList.Length"); i++) {
				DescribeVsCertificateListResponse.DescribeVsCertificateList_CertificateListModel.DescribeVsCertificateList_Cert cert = new DescribeVsCertificateListResponse.DescribeVsCertificateList_CertificateListModel.DescribeVsCertificateList_Cert();
				cert.CertName = _ctx.StringValue("DescribeVsCertificateList.CertificateListModel.CertList["+ i +"].CertName");
				cert.CertId = _ctx.LongValue("DescribeVsCertificateList.CertificateListModel.CertList["+ i +"].CertId");
				cert.Fingerprint = _ctx.StringValue("DescribeVsCertificateList.CertificateListModel.CertList["+ i +"].Fingerprint");
				cert.Common = _ctx.StringValue("DescribeVsCertificateList.CertificateListModel.CertList["+ i +"].Common");
				cert.Issuer = _ctx.StringValue("DescribeVsCertificateList.CertificateListModel.CertList["+ i +"].Issuer");
				cert.LastTime = _ctx.LongValue("DescribeVsCertificateList.CertificateListModel.CertList["+ i +"].LastTime");

				certificateListModel_certList.Add(cert);
			}
			certificateListModel.CertList = certificateListModel_certList;
			describeVsCertificateListResponse.CertificateListModel = certificateListModel;
        
			return describeVsCertificateListResponse;
        }
    }
}
