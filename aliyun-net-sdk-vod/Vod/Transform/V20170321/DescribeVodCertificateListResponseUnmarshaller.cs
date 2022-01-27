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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodCertificateListResponseUnmarshaller
    {
        public static DescribeVodCertificateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodCertificateListResponse describeVodCertificateListResponse = new DescribeVodCertificateListResponse();

			describeVodCertificateListResponse.HttpResponse = _ctx.HttpResponse;
			describeVodCertificateListResponse.RequestId = _ctx.StringValue("DescribeVodCertificateList.RequestId");

			DescribeVodCertificateListResponse.DescribeVodCertificateList_CertificateListModel certificateListModel = new DescribeVodCertificateListResponse.DescribeVodCertificateList_CertificateListModel();
			certificateListModel.Count = _ctx.IntegerValue("DescribeVodCertificateList.CertificateListModel.Count");

			List<DescribeVodCertificateListResponse.DescribeVodCertificateList_CertificateListModel.DescribeVodCertificateList_Cert> certificateListModel_certList = new List<DescribeVodCertificateListResponse.DescribeVodCertificateList_CertificateListModel.DescribeVodCertificateList_Cert>();
			for (int i = 0; i < _ctx.Length("DescribeVodCertificateList.CertificateListModel.CertList.Length"); i++) {
				DescribeVodCertificateListResponse.DescribeVodCertificateList_CertificateListModel.DescribeVodCertificateList_Cert cert = new DescribeVodCertificateListResponse.DescribeVodCertificateList_CertificateListModel.DescribeVodCertificateList_Cert();
				cert.CertName = _ctx.StringValue("DescribeVodCertificateList.CertificateListModel.CertList["+ i +"].CertName");
				cert.CertId = _ctx.LongValue("DescribeVodCertificateList.CertificateListModel.CertList["+ i +"].CertId");
				cert.Fingerprint = _ctx.StringValue("DescribeVodCertificateList.CertificateListModel.CertList["+ i +"].Fingerprint");
				cert.Common = _ctx.StringValue("DescribeVodCertificateList.CertificateListModel.CertList["+ i +"].Common");
				cert.Issuer = _ctx.StringValue("DescribeVodCertificateList.CertificateListModel.CertList["+ i +"].Issuer");
				cert.LastTime = _ctx.LongValue("DescribeVodCertificateList.CertificateListModel.CertList["+ i +"].LastTime");

				certificateListModel_certList.Add(cert);
			}
			certificateListModel.CertList = certificateListModel_certList;
			describeVodCertificateListResponse.CertificateListModel = certificateListModel;
        
			return describeVodCertificateListResponse;
        }
    }
}
