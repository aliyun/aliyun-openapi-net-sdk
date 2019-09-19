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
using Aliyun.Acs.companyreg.Model.V20190508;

namespace Aliyun.Acs.companyreg.Transform.V20190508
{
    public class GenerateCompanyRegUploadPolicyResponseUnmarshaller
    {
        public static GenerateCompanyRegUploadPolicyResponse Unmarshall(UnmarshallerContext context)
        {
			GenerateCompanyRegUploadPolicyResponse generateCompanyRegUploadPolicyResponse = new GenerateCompanyRegUploadPolicyResponse();

			generateCompanyRegUploadPolicyResponse.HttpResponse = context.HttpResponse;
			generateCompanyRegUploadPolicyResponse.RequestId = context.StringValue("GenerateCompanyRegUploadPolicy.RequestId");
			generateCompanyRegUploadPolicyResponse.AccessId = context.StringValue("GenerateCompanyRegUploadPolicy.AccessId");
			generateCompanyRegUploadPolicyResponse.Signature = context.StringValue("GenerateCompanyRegUploadPolicy.Signature");
			generateCompanyRegUploadPolicyResponse.FileDir = context.StringValue("GenerateCompanyRegUploadPolicy.FileDir");
			generateCompanyRegUploadPolicyResponse.Host = context.StringValue("GenerateCompanyRegUploadPolicy.Host");
			generateCompanyRegUploadPolicyResponse.ExpireTime = context.LongValue("GenerateCompanyRegUploadPolicy.ExpireTime");
			generateCompanyRegUploadPolicyResponse.EncodedPolicy = context.StringValue("GenerateCompanyRegUploadPolicy.EncodedPolicy");
			generateCompanyRegUploadPolicyResponse.Min = context.LongValue("GenerateCompanyRegUploadPolicy.Min");
			generateCompanyRegUploadPolicyResponse.Max = context.LongValue("GenerateCompanyRegUploadPolicy.Max");
			generateCompanyRegUploadPolicyResponse.Encryption = context.StringValue("GenerateCompanyRegUploadPolicy.Encryption");
        
			return generateCompanyRegUploadPolicyResponse;
        }
    }
}
