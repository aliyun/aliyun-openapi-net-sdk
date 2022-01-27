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
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeServerCertificatesResponseUnmarshaller
    {
        public static DescribeServerCertificatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeServerCertificatesResponse describeServerCertificatesResponse = new DescribeServerCertificatesResponse();

			describeServerCertificatesResponse.HttpResponse = _ctx.HttpResponse;
			describeServerCertificatesResponse.RequestId = _ctx.StringValue("DescribeServerCertificates.RequestId");

			List<DescribeServerCertificatesResponse.DescribeServerCertificates_ServerCertificate> describeServerCertificatesResponse_serverCertificates = new List<DescribeServerCertificatesResponse.DescribeServerCertificates_ServerCertificate>();
			for (int i = 0; i < _ctx.Length("DescribeServerCertificates.ServerCertificates.Length"); i++) {
				DescribeServerCertificatesResponse.DescribeServerCertificates_ServerCertificate serverCertificate = new DescribeServerCertificatesResponse.DescribeServerCertificates_ServerCertificate();
				serverCertificate.ServerCertificateId = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].ServerCertificateId");
				serverCertificate.Fingerprint = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].Fingerprint");
				serverCertificate.ServerCertificateName = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].ServerCertificateName");
				serverCertificate.RegionId = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].RegionId");
				serverCertificate.RegionIdAlias = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].RegionIdAlias");
				serverCertificate.AliCloudCertificateId = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].AliCloudCertificateId");
				serverCertificate.AliCloudCertificateName = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].AliCloudCertificateName");
				serverCertificate.IsAliCloudCertificate = _ctx.IntegerValue("DescribeServerCertificates.ServerCertificates["+ i +"].IsAliCloudCertificate");
				serverCertificate.ResourceGroupId = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].ResourceGroupId");
				serverCertificate.CreateTime = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].CreateTime");
				serverCertificate.CreateTimeStamp = _ctx.LongValue("DescribeServerCertificates.ServerCertificates["+ i +"].CreateTimeStamp");
				serverCertificate.ExpireTime = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].ExpireTime");
				serverCertificate.ExpireTimeStamp = _ctx.LongValue("DescribeServerCertificates.ServerCertificates["+ i +"].ExpireTimeStamp");
				serverCertificate.CommonName = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].CommonName");
				serverCertificate.EncryptionAlgorithm = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].EncryptionAlgorithm");
				serverCertificate.EncryptionKeyLength = _ctx.IntegerValue("DescribeServerCertificates.ServerCertificates["+ i +"].EncryptionKeyLength");
				serverCertificate.StandardType = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].StandardType");

				List<string> serverCertificate_subjectAlternativeNames = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeServerCertificates.ServerCertificates["+ i +"].SubjectAlternativeNames.Length"); j++) {
					serverCertificate_subjectAlternativeNames.Add(_ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].SubjectAlternativeNames["+ j +"]"));
				}
				serverCertificate.SubjectAlternativeNames = serverCertificate_subjectAlternativeNames;

				List<DescribeServerCertificatesResponse.DescribeServerCertificates_ServerCertificate.DescribeServerCertificates_Tag> serverCertificate_tags = new List<DescribeServerCertificatesResponse.DescribeServerCertificates_ServerCertificate.DescribeServerCertificates_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeServerCertificates.ServerCertificates["+ i +"].Tags.Length"); j++) {
					DescribeServerCertificatesResponse.DescribeServerCertificates_ServerCertificate.DescribeServerCertificates_Tag tag = new DescribeServerCertificatesResponse.DescribeServerCertificates_ServerCertificate.DescribeServerCertificates_Tag();
					tag.TagKey = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeServerCertificates.ServerCertificates["+ i +"].Tags["+ j +"].TagValue");

					serverCertificate_tags.Add(tag);
				}
				serverCertificate.Tags = serverCertificate_tags;

				describeServerCertificatesResponse_serverCertificates.Add(serverCertificate);
			}
			describeServerCertificatesResponse.ServerCertificates = describeServerCertificatesResponse_serverCertificates;
        
			return describeServerCertificatesResponse;
        }
    }
}
