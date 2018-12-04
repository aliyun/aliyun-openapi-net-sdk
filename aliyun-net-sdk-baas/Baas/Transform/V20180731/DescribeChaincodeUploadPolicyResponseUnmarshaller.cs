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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeChaincodeUploadPolicyResponseUnmarshaller
    {
        public static DescribeChaincodeUploadPolicyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeChaincodeUploadPolicyResponse describeChaincodeUploadPolicyResponse = new DescribeChaincodeUploadPolicyResponse();

			describeChaincodeUploadPolicyResponse.HttpResponse = context.HttpResponse;
			describeChaincodeUploadPolicyResponse.RequestId = context.StringValue("DescribeChaincodeUploadPolicy.RequestId");
			describeChaincodeUploadPolicyResponse.Success = context.BooleanValue("DescribeChaincodeUploadPolicy.Success");
			describeChaincodeUploadPolicyResponse.ErrorCode = context.IntegerValue("DescribeChaincodeUploadPolicy.ErrorCode");

			DescribeChaincodeUploadPolicyResponse.DescribeChaincodeUploadPolicy_Result result = new DescribeChaincodeUploadPolicyResponse.DescribeChaincodeUploadPolicy_Result();
			result.AccessId = context.StringValue("DescribeChaincodeUploadPolicy.Result.AccessId");
			result.Policy = context.StringValue("DescribeChaincodeUploadPolicy.Result.Policy");
			result.Signature = context.StringValue("DescribeChaincodeUploadPolicy.Result.Signature");
			result.Dir = context.StringValue("DescribeChaincodeUploadPolicy.Result.Dir");
			result.Host = context.StringValue("DescribeChaincodeUploadPolicy.Result.Host");
			result.Expire = context.IntegerValue("DescribeChaincodeUploadPolicy.Result.Expire");
			describeChaincodeUploadPolicyResponse.Result = result;
        
			return describeChaincodeUploadPolicyResponse;
        }
    }
}