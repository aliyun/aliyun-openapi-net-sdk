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
    public class AIGCFaceVerifyResponseUnmarshaller
    {
        public static AIGCFaceVerifyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AIGCFaceVerifyResponse aIGCFaceVerifyResponse = new AIGCFaceVerifyResponse();

			aIGCFaceVerifyResponse.HttpResponse = _ctx.HttpResponse;
			aIGCFaceVerifyResponse.RequestId = _ctx.StringValue("AIGCFaceVerify.RequestId");
			aIGCFaceVerifyResponse.Message = _ctx.StringValue("AIGCFaceVerify.Message");
			aIGCFaceVerifyResponse.Code = _ctx.StringValue("AIGCFaceVerify.Code");

			AIGCFaceVerifyResponse.AIGCFaceVerify_ResultObject resultObject = new AIGCFaceVerifyResponse.AIGCFaceVerify_ResultObject();
			resultObject.Result = _ctx.StringValue("AIGCFaceVerify.ResultObject.Result");
			resultObject.Score = _ctx.StringValue("AIGCFaceVerify.ResultObject.Score");
			resultObject.CertifyId = _ctx.StringValue("AIGCFaceVerify.ResultObject.CertifyId");
			aIGCFaceVerifyResponse.ResultObject = resultObject;
        
			return aIGCFaceVerifyResponse;
        }
    }
}
