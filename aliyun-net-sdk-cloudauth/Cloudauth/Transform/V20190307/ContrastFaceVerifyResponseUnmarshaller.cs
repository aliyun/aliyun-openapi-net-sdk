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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class ContrastFaceVerifyResponseUnmarshaller
    {
        public static ContrastFaceVerifyResponse Unmarshall(UnmarshallerContext context)
        {
			ContrastFaceVerifyResponse contrastFaceVerifyResponse = new ContrastFaceVerifyResponse();

			contrastFaceVerifyResponse.HttpResponse = context.HttpResponse;
			contrastFaceVerifyResponse.RequestId = context.StringValue("ContrastFaceVerify.RequestId");
			contrastFaceVerifyResponse.Message = context.StringValue("ContrastFaceVerify.Message");
			contrastFaceVerifyResponse.Code = context.StringValue("ContrastFaceVerify.Code");

			ContrastFaceVerifyResponse.ContrastFaceVerify_ResultObject resultObject = new ContrastFaceVerifyResponse.ContrastFaceVerify_ResultObject();
			resultObject.Passed = context.StringValue("ContrastFaceVerify.ResultObject.Passed");
			resultObject.IdentityInfo = context.StringValue("ContrastFaceVerify.ResultObject.IdentityInfo");
			resultObject.MaterialInfo = context.StringValue("ContrastFaceVerify.ResultObject.MaterialInfo");
			resultObject.SubCode = context.StringValue("ContrastFaceVerify.ResultObject.SubCode");
			contrastFaceVerifyResponse.ResultObject = resultObject;
        
			return contrastFaceVerifyResponse;
        }
    }
}
