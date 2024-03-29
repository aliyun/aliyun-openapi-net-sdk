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
    public class LivenessFaceVerifyResponseUnmarshaller
    {
        public static LivenessFaceVerifyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			LivenessFaceVerifyResponse livenessFaceVerifyResponse = new LivenessFaceVerifyResponse();

			livenessFaceVerifyResponse.HttpResponse = _ctx.HttpResponse;
			livenessFaceVerifyResponse.Code = _ctx.StringValue("LivenessFaceVerify.Code");
			livenessFaceVerifyResponse.Message = _ctx.StringValue("LivenessFaceVerify.Message");
			livenessFaceVerifyResponse.RequestId = _ctx.StringValue("LivenessFaceVerify.RequestId");

			LivenessFaceVerifyResponse.LivenessFaceVerify_ResultObject resultObject = new LivenessFaceVerifyResponse.LivenessFaceVerify_ResultObject();
			resultObject.CertifyId = _ctx.StringValue("LivenessFaceVerify.ResultObject.CertifyId");
			resultObject.SubCode = _ctx.StringValue("LivenessFaceVerify.ResultObject.SubCode");
			resultObject.MaterialInfo = _ctx.StringValue("LivenessFaceVerify.ResultObject.MaterialInfo");
			resultObject.Passed = _ctx.StringValue("LivenessFaceVerify.ResultObject.Passed");
			livenessFaceVerifyResponse.ResultObject = resultObject;
        
			return livenessFaceVerifyResponse;
        }
    }
}
