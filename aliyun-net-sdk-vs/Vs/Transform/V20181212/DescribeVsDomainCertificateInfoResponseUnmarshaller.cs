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
    public class DescribeVsDomainCertificateInfoResponseUnmarshaller
    {
        public static DescribeVsDomainCertificateInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVsDomainCertificateInfoResponse describeVsDomainCertificateInfoResponse = new DescribeVsDomainCertificateInfoResponse();

			describeVsDomainCertificateInfoResponse.HttpResponse = context.HttpResponse;
			describeVsDomainCertificateInfoResponse.RequestId = context.StringValue("DescribeVsDomainCertificateInfo.RequestId");

			List<DescribeVsDomainCertificateInfoResponse.DescribeVsDomainCertificateInfo_CertInfo> describeVsDomainCertificateInfoResponse_certInfos = new List<DescribeVsDomainCertificateInfoResponse.DescribeVsDomainCertificateInfo_CertInfo>();
			for (int i = 0; i < context.Length("DescribeVsDomainCertificateInfo.CertInfos.Length"); i++) {
				DescribeVsDomainCertificateInfoResponse.DescribeVsDomainCertificateInfo_CertInfo certInfo = new DescribeVsDomainCertificateInfoResponse.DescribeVsDomainCertificateInfo_CertInfo();
				certInfo.DomainName = context.StringValue("DescribeVsDomainCertificateInfo.CertInfos["+ i +"].DomainName");
				certInfo.CertName = context.StringValue("DescribeVsDomainCertificateInfo.CertInfos["+ i +"].CertName");
				certInfo.CertDomainName = context.StringValue("DescribeVsDomainCertificateInfo.CertInfos["+ i +"].CertDomainName");
				certInfo.CertExpireTime = context.StringValue("DescribeVsDomainCertificateInfo.CertInfos["+ i +"].CertExpireTime");
				certInfo.CertLife = context.StringValue("DescribeVsDomainCertificateInfo.CertInfos["+ i +"].CertLife");
				certInfo.CertOrg = context.StringValue("DescribeVsDomainCertificateInfo.CertInfos["+ i +"].CertOrg");
				certInfo.CertType = context.StringValue("DescribeVsDomainCertificateInfo.CertInfos["+ i +"].CertType");
				certInfo.ServerCertificateStatus = context.StringValue("DescribeVsDomainCertificateInfo.CertInfos["+ i +"].ServerCertificateStatus");
				certInfo.Status = context.StringValue("DescribeVsDomainCertificateInfo.CertInfos["+ i +"].Status");
				certInfo.SSLPub = context.StringValue("DescribeVsDomainCertificateInfo.CertInfos["+ i +"].SSLPub");

				describeVsDomainCertificateInfoResponse_certInfos.Add(certInfo);
			}
			describeVsDomainCertificateInfoResponse.CertInfos = describeVsDomainCertificateInfoResponse_certInfos;
        
			return describeVsDomainCertificateInfoResponse;
        }
    }
}
