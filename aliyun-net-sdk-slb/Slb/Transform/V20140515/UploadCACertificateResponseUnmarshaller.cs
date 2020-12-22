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
    public class UploadCACertificateResponseUnmarshaller
    {
        public static UploadCACertificateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UploadCACertificateResponse uploadCACertificateResponse = new UploadCACertificateResponse();

			uploadCACertificateResponse.HttpResponse = _ctx.HttpResponse;
			uploadCACertificateResponse.RequestId = _ctx.StringValue("UploadCACertificate.RequestId");
			uploadCACertificateResponse.CACertificateId = _ctx.StringValue("UploadCACertificate.CACertificateId");
			uploadCACertificateResponse.CACertificateName = _ctx.StringValue("UploadCACertificate.CACertificateName");
			uploadCACertificateResponse.Fingerprint = _ctx.StringValue("UploadCACertificate.Fingerprint");
			uploadCACertificateResponse.ResourceGroupId = _ctx.StringValue("UploadCACertificate.ResourceGroupId");
			uploadCACertificateResponse.CreateTime = _ctx.StringValue("UploadCACertificate.CreateTime");
			uploadCACertificateResponse.CreateTimeStamp = _ctx.LongValue("UploadCACertificate.CreateTimeStamp");
			uploadCACertificateResponse.ExpireTime = _ctx.StringValue("UploadCACertificate.ExpireTime");
			uploadCACertificateResponse.ExpireTimeStamp = _ctx.LongValue("UploadCACertificate.ExpireTimeStamp");
			uploadCACertificateResponse.CommonName = _ctx.StringValue("UploadCACertificate.CommonName");
        
			return uploadCACertificateResponse;
        }
    }
}
