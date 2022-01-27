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
        public static UploadServerCertificateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UploadServerCertificateResponse uploadServerCertificateResponse = new UploadServerCertificateResponse();

			uploadServerCertificateResponse.HttpResponse = _ctx.HttpResponse;
			uploadServerCertificateResponse.RequestId = _ctx.StringValue("UploadServerCertificate.RequestId");
			uploadServerCertificateResponse.ServerCertificateId = _ctx.StringValue("UploadServerCertificate.ServerCertificateId");
			uploadServerCertificateResponse.Fingerprint = _ctx.StringValue("UploadServerCertificate.Fingerprint");
			uploadServerCertificateResponse.ServerCertificateName = _ctx.StringValue("UploadServerCertificate.ServerCertificateName");
			uploadServerCertificateResponse.RegionId = _ctx.StringValue("UploadServerCertificate.RegionId");
			uploadServerCertificateResponse.RegionIdAlias = _ctx.StringValue("UploadServerCertificate.RegionIdAlias");
			uploadServerCertificateResponse.AliCloudCertificateId = _ctx.StringValue("UploadServerCertificate.AliCloudCertificateId");
			uploadServerCertificateResponse.AliCloudCertificateName = _ctx.StringValue("UploadServerCertificate.AliCloudCertificateName");
			uploadServerCertificateResponse.IsAliCloudCertificate = _ctx.IntegerValue("UploadServerCertificate.IsAliCloudCertificate");
			uploadServerCertificateResponse.ResourceGroupId = _ctx.StringValue("UploadServerCertificate.ResourceGroupId");
			uploadServerCertificateResponse.CreateTime = _ctx.StringValue("UploadServerCertificate.CreateTime");
			uploadServerCertificateResponse.CreateTimeStamp = _ctx.LongValue("UploadServerCertificate.CreateTimeStamp");
			uploadServerCertificateResponse.ExpireTime = _ctx.StringValue("UploadServerCertificate.ExpireTime");
			uploadServerCertificateResponse.ExpireTimeStamp = _ctx.LongValue("UploadServerCertificate.ExpireTimeStamp");
			uploadServerCertificateResponse.CommonName = _ctx.StringValue("UploadServerCertificate.CommonName");

			List<string> uploadServerCertificateResponse_subjectAlternativeNames = new List<string>();
			for (int i = 0; i < _ctx.Length("UploadServerCertificate.SubjectAlternativeNames.Length"); i++) {
				uploadServerCertificateResponse_subjectAlternativeNames.Add(_ctx.StringValue("UploadServerCertificate.SubjectAlternativeNames["+ i +"]"));
			}
			uploadServerCertificateResponse.SubjectAlternativeNames = uploadServerCertificateResponse_subjectAlternativeNames;
        
			return uploadServerCertificateResponse;
        }
    }
}
