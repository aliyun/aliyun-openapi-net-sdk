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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetPackageStorageCredentialResponseUnmarshaller
    {
        public static GetPackageStorageCredentialResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPackageStorageCredentialResponse getPackageStorageCredentialResponse = new GetPackageStorageCredentialResponse();

			getPackageStorageCredentialResponse.HttpResponse = _ctx.HttpResponse;
			getPackageStorageCredentialResponse.RequestId = _ctx.StringValue("GetPackageStorageCredential.RequestId");
			getPackageStorageCredentialResponse.Code = _ctx.IntegerValue("GetPackageStorageCredential.Code");
			getPackageStorageCredentialResponse.Message = _ctx.StringValue("GetPackageStorageCredential.Message");

			GetPackageStorageCredentialResponse.GetPackageStorageCredential_Credential credential = new GetPackageStorageCredentialResponse.GetPackageStorageCredential_Credential();
			credential.AccessKeyId = _ctx.StringValue("GetPackageStorageCredential.Credential.AccessKeyId");
			credential.AccessKeySecret = _ctx.StringValue("GetPackageStorageCredential.Credential.AccessKeySecret");
			credential.Bucket = _ctx.StringValue("GetPackageStorageCredential.Credential.Bucket");
			credential.Expiration = _ctx.StringValue("GetPackageStorageCredential.Credential.Expiration");
			credential.KeyPrefix = _ctx.StringValue("GetPackageStorageCredential.Credential.KeyPrefix");
			credential.RegionId = _ctx.StringValue("GetPackageStorageCredential.Credential.RegionId");
			credential.SecurityToken = _ctx.StringValue("GetPackageStorageCredential.Credential.SecurityToken");
			getPackageStorageCredentialResponse.Credential = credential;
        
			return getPackageStorageCredentialResponse;
        }
    }
}
