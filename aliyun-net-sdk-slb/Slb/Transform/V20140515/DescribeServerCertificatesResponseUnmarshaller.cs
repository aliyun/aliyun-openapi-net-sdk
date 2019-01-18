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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Slb.Model.V20140515;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeServerCertificatesResponseUnmarshaller
    {
        public static DescribeServerCertificatesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeServerCertificatesResponse describeServerCertificatesResponse = new DescribeServerCertificatesResponse();

			describeServerCertificatesResponse.HttpResponse = context.HttpResponse;
			describeServerCertificatesResponse.RequestId = context.StringValue("DescribeServerCertificates.RequestId");

			List<DescribeServerCertificatesResponse.DescribeServerCertificates_ServerCertificate> describeServerCertificatesResponse_serverCertificates = new List<DescribeServerCertificatesResponse.DescribeServerCertificates_ServerCertificate>();
			for (int i = 0; i < context.Length("DescribeServerCertificates.ServerCertificates.Length"); i++) {
				DescribeServerCertificatesResponse.DescribeServerCertificates_ServerCertificate serverCertificate = new DescribeServerCertificatesResponse.DescribeServerCertificates_ServerCertificate();
				serverCertificate.ServerCertificateId = context.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].ServerCertificateId");
				serverCertificate.Fingerprint = context.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].Fingerprint");
				serverCertificate.ServerCertificateName = context.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].ServerCertificateName");
				serverCertificate.RegionId = context.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].RegionId");
				serverCertificate.RegionIdAlias = context.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].RegionIdAlias");
				serverCertificate.AliCloudCertificateId = context.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].AliCloudCertificateId");
				serverCertificate.AliCloudCertificateName = context.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].AliCloudCertificateName");
				serverCertificate.IsAliCloudCertificate = context.IntegerValue("DescribeServerCertificates.ServerCertificates["+ i +"].IsAliCloudCertificate");
				serverCertificate.ResourceGroupId = context.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].ResourceGroupId");
				serverCertificate.CreateTime = context.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].CreateTime");
				serverCertificate.CreateTimeStamp = context.LongValue("DescribeServerCertificates.ServerCertificates["+ i +"].CreateTimeStamp");

				describeServerCertificatesResponse_serverCertificates.Add(serverCertificate);
			}
			describeServerCertificatesResponse.ServerCertificates = describeServerCertificatesResponse_serverCertificates;
        
			return describeServerCertificatesResponse;
        }
    }
}