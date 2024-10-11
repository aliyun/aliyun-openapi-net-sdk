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
    public class DescribeVodSSLCertificateListResponseUnmarshaller
    {
        public static DescribeVodSSLCertificateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodSSLCertificateListResponse describeVodSSLCertificateListResponse = new DescribeVodSSLCertificateListResponse();

			describeVodSSLCertificateListResponse.HttpResponse = _ctx.HttpResponse;
			describeVodSSLCertificateListResponse.RequestId = _ctx.StringValue("DescribeVodSSLCertificateList.RequestId");

			DescribeVodSSLCertificateListResponse.DescribeVodSSLCertificateList_CertificateListModel certificateListModel = new DescribeVodSSLCertificateListResponse.DescribeVodSSLCertificateList_CertificateListModel();
			certificateListModel.Count = _ctx.IntegerValue("DescribeVodSSLCertificateList.CertificateListModel.Count");
			certificateListModel.PageNumber = _ctx.LongValue("DescribeVodSSLCertificateList.CertificateListModel.PageNumber");
			certificateListModel.PageSize = _ctx.LongValue("DescribeVodSSLCertificateList.CertificateListModel.PageSize");

			List<DescribeVodSSLCertificateListResponse.DescribeVodSSLCertificateList_CertificateListModel.DescribeVodSSLCertificateList_Cert> certificateListModel_certList = new List<DescribeVodSSLCertificateListResponse.DescribeVodSSLCertificateList_CertificateListModel.DescribeVodSSLCertificateList_Cert>();
			for (int i = 0; i < _ctx.Length("DescribeVodSSLCertificateList.CertificateListModel.CertList.Length"); i++) {
				DescribeVodSSLCertificateListResponse.DescribeVodSSLCertificateList_CertificateListModel.DescribeVodSSLCertificateList_Cert cert = new DescribeVodSSLCertificateListResponse.DescribeVodSSLCertificateList_CertificateListModel.DescribeVodSSLCertificateList_Cert();
				cert.LastTime = _ctx.LongValue("DescribeVodSSLCertificateList.CertificateListModel.CertList["+ i +"].LastTime");
				cert.Fingerprint = _ctx.StringValue("DescribeVodSSLCertificateList.CertificateListModel.CertList["+ i +"].Fingerprint");
				cert.CertName = _ctx.StringValue("DescribeVodSSLCertificateList.CertificateListModel.CertList["+ i +"].CertName");
				cert.Issuer = _ctx.StringValue("DescribeVodSSLCertificateList.CertificateListModel.CertList["+ i +"].Issuer");
				cert.CertId = _ctx.LongValue("DescribeVodSSLCertificateList.CertificateListModel.CertList["+ i +"].CertId");
				cert.Common = _ctx.StringValue("DescribeVodSSLCertificateList.CertificateListModel.CertList["+ i +"].Common");
				cert.CertRegion = _ctx.StringValue("DescribeVodSSLCertificateList.CertificateListModel.CertList["+ i +"].CertRegion");

				certificateListModel_certList.Add(cert);
			}
			certificateListModel.CertList = certificateListModel_certList;
			describeVodSSLCertificateListResponse.CertificateListModel = certificateListModel;
        
			return describeVodSSLCertificateListResponse;
        }
    }
}
