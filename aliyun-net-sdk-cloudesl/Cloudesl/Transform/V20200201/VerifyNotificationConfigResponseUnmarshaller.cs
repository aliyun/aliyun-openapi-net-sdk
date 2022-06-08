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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class VerifyNotificationConfigResponseUnmarshaller
    {
        public static VerifyNotificationConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			VerifyNotificationConfigResponse verifyNotificationConfigResponse = new VerifyNotificationConfigResponse();

			verifyNotificationConfigResponse.HttpResponse = _ctx.HttpResponse;
			verifyNotificationConfigResponse.RequestId = _ctx.StringValue("VerifyNotificationConfig.RequestId");
			verifyNotificationConfigResponse.ErrorMessage = _ctx.StringValue("VerifyNotificationConfig.ErrorMessage");
			verifyNotificationConfigResponse.Success = _ctx.BooleanValue("VerifyNotificationConfig.Success");
			verifyNotificationConfigResponse.ErrorCode = _ctx.StringValue("VerifyNotificationConfig.ErrorCode");
			verifyNotificationConfigResponse.Code = _ctx.StringValue("VerifyNotificationConfig.Code");
			verifyNotificationConfigResponse.Message = _ctx.StringValue("VerifyNotificationConfig.Message");
			verifyNotificationConfigResponse.DynamicMessage = _ctx.StringValue("VerifyNotificationConfig.DynamicMessage");
			verifyNotificationConfigResponse.DynamicCode = _ctx.StringValue("VerifyNotificationConfig.DynamicCode");
			verifyNotificationConfigResponse.Result = _ctx.BooleanValue("VerifyNotificationConfig.Result");
			verifyNotificationConfigResponse.SendTime = _ctx.StringValue("VerifyNotificationConfig.SendTime");
			verifyNotificationConfigResponse.ExceptionMessage = _ctx.StringValue("VerifyNotificationConfig.ExceptionMessage");
        
			return verifyNotificationConfigResponse;
        }
    }
}
