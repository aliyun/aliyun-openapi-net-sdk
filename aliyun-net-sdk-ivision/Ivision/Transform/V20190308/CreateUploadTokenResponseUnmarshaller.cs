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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class CreateUploadTokenResponseUnmarshaller
    {
        public static CreateUploadTokenResponse Unmarshall(UnmarshallerContext context)
        {
			CreateUploadTokenResponse createUploadTokenResponse = new CreateUploadTokenResponse();

			createUploadTokenResponse.HttpResponse = context.HttpResponse;
			createUploadTokenResponse.RequestId = context.StringValue("CreateUploadToken.RequestId");

			CreateUploadTokenResponse.CreateUploadToken_UploadToken uploadToken = new CreateUploadTokenResponse.CreateUploadToken_UploadToken();
			uploadToken.AccessKeyId = context.StringValue("CreateUploadToken.UploadToken.AccessKeyId");
			uploadToken.AccessKeySecret = context.StringValue("CreateUploadToken.UploadToken.AccessKeySecret");
			uploadToken.SecurityToken = context.StringValue("CreateUploadToken.UploadToken.SecurityToken");
			uploadToken.Expiration = context.StringValue("CreateUploadToken.UploadToken.Expiration");
			uploadToken.Bucket = context.StringValue("CreateUploadToken.UploadToken.Bucket");
			uploadToken._Object = context.StringValue("CreateUploadToken.UploadToken.Object");
			uploadToken.Endpoint = context.StringValue("CreateUploadToken.UploadToken.Endpoint");
			uploadToken.Url = context.StringValue("CreateUploadToken.UploadToken.Url");
			createUploadTokenResponse.UploadToken = uploadToken;
        
			return createUploadTokenResponse;
        }
    }
}
