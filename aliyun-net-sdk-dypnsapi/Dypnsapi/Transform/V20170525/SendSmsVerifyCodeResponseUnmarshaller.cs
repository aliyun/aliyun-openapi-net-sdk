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
using Aliyun.Acs.Dypnsapi.Model.V20170525;

namespace Aliyun.Acs.Dypnsapi.Transform.V20170525
{
    public class SendSmsVerifyCodeResponseUnmarshaller
    {
        public static SendSmsVerifyCodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SendSmsVerifyCodeResponse sendSmsVerifyCodeResponse = new SendSmsVerifyCodeResponse();

			sendSmsVerifyCodeResponse.HttpResponse = _ctx.HttpResponse;
			sendSmsVerifyCodeResponse.AccessDeniedDetail = _ctx.StringValue("SendSmsVerifyCode.AccessDeniedDetail");
			sendSmsVerifyCodeResponse.Message = _ctx.StringValue("SendSmsVerifyCode.Message");
			sendSmsVerifyCodeResponse.Code = _ctx.StringValue("SendSmsVerifyCode.Code");
			sendSmsVerifyCodeResponse.Success = _ctx.BooleanValue("SendSmsVerifyCode.Success");

			SendSmsVerifyCodeResponse.SendSmsVerifyCode_Model model = new SendSmsVerifyCodeResponse.SendSmsVerifyCode_Model();
			model.VerifyCode = _ctx.StringValue("SendSmsVerifyCode.Model.VerifyCode");
			model.RequestId = _ctx.StringValue("SendSmsVerifyCode.Model.RequestId");
			model.OutId = _ctx.StringValue("SendSmsVerifyCode.Model.OutId");
			model.BizId = _ctx.StringValue("SendSmsVerifyCode.Model.BizId");
			sendSmsVerifyCodeResponse.Model = model;
        
			return sendSmsVerifyCodeResponse;
        }
    }
}
