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
using Aliyun.Acs.captcha.Model.V20230305;

namespace Aliyun.Acs.captcha.Transform.V20230305
{
    public class VerifyIntelligentCaptchaResponseUnmarshaller
    {
        public static VerifyIntelligentCaptchaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			VerifyIntelligentCaptchaResponse verifyIntelligentCaptchaResponse = new VerifyIntelligentCaptchaResponse();

			verifyIntelligentCaptchaResponse.HttpResponse = _ctx.HttpResponse;
			verifyIntelligentCaptchaResponse.RequestId = _ctx.StringValue("VerifyIntelligentCaptcha.RequestId");
			verifyIntelligentCaptchaResponse.Success = _ctx.BooleanValue("VerifyIntelligentCaptcha.Success");
			verifyIntelligentCaptchaResponse.Code = _ctx.StringValue("VerifyIntelligentCaptcha.Code");
			verifyIntelligentCaptchaResponse.Message = _ctx.StringValue("VerifyIntelligentCaptcha.Message");

			VerifyIntelligentCaptchaResponse.VerifyIntelligentCaptcha_Result result = new VerifyIntelligentCaptchaResponse.VerifyIntelligentCaptcha_Result();
			result.VerifyResult = _ctx.BooleanValue("VerifyIntelligentCaptcha.Result.VerifyResult");
			result.VerifyCode = _ctx.StringValue("VerifyIntelligentCaptcha.Result.VerifyCode");
			verifyIntelligentCaptchaResponse.Result = result;
        
			return verifyIntelligentCaptchaResponse;
        }
    }
}
