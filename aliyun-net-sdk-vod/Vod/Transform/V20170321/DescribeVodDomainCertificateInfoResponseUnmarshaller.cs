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
    public class DescribeVodDomainCertificateInfoResponseUnmarshaller
    {
        public static DescribeVodDomainCertificateInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainCertificateInfoResponse describeVodDomainCertificateInfoResponse = new DescribeVodDomainCertificateInfoResponse();

			describeVodDomainCertificateInfoResponse.HttpResponse = context.HttpResponse;
			describeVodDomainCertificateInfoResponse.RequestId = context.StringValue("DescribeVodDomainCertificateInfo.RequestId");

			List<DescribeVodDomainCertificateInfoResponse.DescribeVodDomainCertificateInfo_CertInfo> describeVodDomainCertificateInfoResponse_certInfos = new List<DescribeVodDomainCertificateInfoResponse.DescribeVodDomainCertificateInfo_CertInfo>();
			for (int i = 0; i < context.Length("DescribeVodDomainCertificateInfo.CertInfos.Length"); i++) {
				DescribeVodDomainCertificateInfoResponse.DescribeVodDomainCertificateInfo_CertInfo certInfo = new DescribeVodDomainCertificateInfoResponse.DescribeVodDomainCertificateInfo_CertInfo();
				certInfo.DomainName = context.StringValue("DescribeVodDomainCertificateInfo.CertInfos["+ i +"].DomainName");
				certInfo.CertName = context.StringValue("DescribeVodDomainCertificateInfo.CertInfos["+ i +"].CertName");
				certInfo.CertDomainName = context.StringValue("DescribeVodDomainCertificateInfo.CertInfos["+ i +"].CertDomainName");
				certInfo.CertExpireTime = context.StringValue("DescribeVodDomainCertificateInfo.CertInfos["+ i +"].CertExpireTime");
				certInfo.CertLife = context.StringValue("DescribeVodDomainCertificateInfo.CertInfos["+ i +"].CertLife");
				certInfo.CertOrg = context.StringValue("DescribeVodDomainCertificateInfo.CertInfos["+ i +"].CertOrg");
				certInfo.CertType = context.StringValue("DescribeVodDomainCertificateInfo.CertInfos["+ i +"].CertType");
				certInfo.ServerCertificateStatus = context.StringValue("DescribeVodDomainCertificateInfo.CertInfos["+ i +"].ServerCertificateStatus");
				certInfo.Status = context.StringValue("DescribeVodDomainCertificateInfo.CertInfos["+ i +"].Status");

				describeVodDomainCertificateInfoResponse_certInfos.Add(certInfo);
			}
			describeVodDomainCertificateInfoResponse.CertInfos = describeVodDomainCertificateInfoResponse_certInfos;
        
			return describeVodDomainCertificateInfoResponse;
        }
    }
}
