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
    public class GetQualificationUploadPolicyResponseUnmarshaller
    {
        public static GetQualificationUploadPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetQualificationUploadPolicyResponse getQualificationUploadPolicyResponse = new GetQualificationUploadPolicyResponse();

			getQualificationUploadPolicyResponse.HttpResponse = _ctx.HttpResponse;
			getQualificationUploadPolicyResponse.RequestId = _ctx.StringValue("GetQualificationUploadPolicy.RequestId");
			getQualificationUploadPolicyResponse.Accessid = _ctx.StringValue("GetQualificationUploadPolicy.Accessid");
			getQualificationUploadPolicyResponse.Policy = _ctx.StringValue("GetQualificationUploadPolicy.Policy");
			getQualificationUploadPolicyResponse.Signature = _ctx.StringValue("GetQualificationUploadPolicy.Signature");
			getQualificationUploadPolicyResponse.Dir = _ctx.StringValue("GetQualificationUploadPolicy.Dir");
			getQualificationUploadPolicyResponse.Prefix = _ctx.StringValue("GetQualificationUploadPolicy.Prefix");
			getQualificationUploadPolicyResponse.Host = _ctx.StringValue("GetQualificationUploadPolicy.Host");
			getQualificationUploadPolicyResponse.Expire = _ctx.StringValue("GetQualificationUploadPolicy.Expire");
        
			return getQualificationUploadPolicyResponse;
        }
    }
}
