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
    public class UploadServerCertificateResponseUnmarshaller
    {
        public static UploadServerCertificateResponse Unmarshall(UnmarshallerContext context)
        {
			UploadServerCertificateResponse uploadServerCertificateResponse = new UploadServerCertificateResponse();

			uploadServerCertificateResponse.HttpResponse = context.HttpResponse;
			uploadServerCertificateResponse.RequestId = context.StringValue("UploadServerCertificate.RequestId");
			uploadServerCertificateResponse.ServerCertificateId = context.StringValue("UploadServerCertificate.ServerCertificateId");
			uploadServerCertificateResponse.Fingerprint = context.StringValue("UploadServerCertificate.Fingerprint");
			uploadServerCertificateResponse.ServerCertificateName = context.StringValue("UploadServerCertificate.ServerCertificateName");
			uploadServerCertificateResponse.RegionId = context.StringValue("UploadServerCertificate.RegionId");
			uploadServerCertificateResponse.RegionIdAlias = context.StringValue("UploadServerCertificate.RegionIdAlias");
			uploadServerCertificateResponse.AliCloudCertificateId = context.StringValue("UploadServerCertificate.AliCloudCertificateId");
			uploadServerCertificateResponse.AliCloudCertificateName = context.StringValue("UploadServerCertificate.AliCloudCertificateName");
			uploadServerCertificateResponse.IsAliCloudCertificate = context.IntegerValue("UploadServerCertificate.IsAliCloudCertificate");
			uploadServerCertificateResponse.ResourceGroupId = context.StringValue("UploadServerCertificate.ResourceGroupId");
			uploadServerCertificateResponse.CreateTime = context.StringValue("UploadServerCertificate.CreateTime");
			uploadServerCertificateResponse.CreateTimeStamp = context.LongValue("UploadServerCertificate.CreateTimeStamp");
			uploadServerCertificateResponse.ExpireTime = context.StringValue("UploadServerCertificate.ExpireTime");
			uploadServerCertificateResponse.ExpireTimeStamp = context.LongValue("UploadServerCertificate.ExpireTimeStamp");
			uploadServerCertificateResponse.CommonName = context.StringValue("UploadServerCertificate.CommonName");

			List<string> uploadServerCertificateResponse_subjectAlternativeNames = new List<string>();
			for (int i = 0; i < context.Length("UploadServerCertificate.SubjectAlternativeNames.Length"); i++) {
				uploadServerCertificateResponse_subjectAlternativeNames.Add(context.StringValue("UploadServerCertificate.SubjectAlternativeNames["+ i +"]"));
			}
			uploadServerCertificateResponse.SubjectAlternativeNames = uploadServerCertificateResponse_subjectAlternativeNames;
        
			return uploadServerCertificateResponse;
        }
    }
}
