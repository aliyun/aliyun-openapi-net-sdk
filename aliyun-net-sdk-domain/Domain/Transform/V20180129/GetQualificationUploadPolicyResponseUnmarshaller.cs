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
        public static GetQualificationUploadPolicyResponse Unmarshall(UnmarshallerContext context)
        {
			GetQualificationUploadPolicyResponse getQualificationUploadPolicyResponse = new GetQualificationUploadPolicyResponse();

			getQualificationUploadPolicyResponse.HttpResponse = context.HttpResponse;
			getQualificationUploadPolicyResponse.RequestId = context.StringValue("GetQualificationUploadPolicy.RequestId");
			getQualificationUploadPolicyResponse.Accessid = context.StringValue("GetQualificationUploadPolicy.Accessid");
			getQualificationUploadPolicyResponse.Policy = context.StringValue("GetQualificationUploadPolicy.Policy");
			getQualificationUploadPolicyResponse.Signature = context.StringValue("GetQualificationUploadPolicy.Signature");
			getQualificationUploadPolicyResponse.Dir = context.StringValue("GetQualificationUploadPolicy.Dir");
			getQualificationUploadPolicyResponse.Prefix = context.StringValue("GetQualificationUploadPolicy.Prefix");
			getQualificationUploadPolicyResponse.Host = context.StringValue("GetQualificationUploadPolicy.Host");
			getQualificationUploadPolicyResponse.Expire = context.StringValue("GetQualificationUploadPolicy.Expire");
        
			return getQualificationUploadPolicyResponse;
        }
    }
}
