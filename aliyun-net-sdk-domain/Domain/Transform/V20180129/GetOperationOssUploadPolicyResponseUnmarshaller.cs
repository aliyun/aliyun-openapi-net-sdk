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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class GetOperationOssUploadPolicyResponseUnmarshaller
    {
        public static GetOperationOssUploadPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOperationOssUploadPolicyResponse getOperationOssUploadPolicyResponse = new GetOperationOssUploadPolicyResponse();

			getOperationOssUploadPolicyResponse.HttpResponse = _ctx.HttpResponse;
			getOperationOssUploadPolicyResponse.RequestId = _ctx.StringValue("GetOperationOssUploadPolicy.RequestId");
			getOperationOssUploadPolicyResponse.Accessid = _ctx.StringValue("GetOperationOssUploadPolicy.Accessid");
			getOperationOssUploadPolicyResponse.EncodedPolicy = _ctx.StringValue("GetOperationOssUploadPolicy.EncodedPolicy");
			getOperationOssUploadPolicyResponse.Signature = _ctx.StringValue("GetOperationOssUploadPolicy.Signature");
			getOperationOssUploadPolicyResponse.FileDir = _ctx.StringValue("GetOperationOssUploadPolicy.FileDir");
			getOperationOssUploadPolicyResponse.Host = _ctx.StringValue("GetOperationOssUploadPolicy.Host");
			getOperationOssUploadPolicyResponse.ExpireTime = _ctx.StringValue("GetOperationOssUploadPolicy.ExpireTime");
        
			return getOperationOssUploadPolicyResponse;
        }
    }
}
