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
using Aliyun.Acs.Dypnsapi_intl.Model.V20170725;

namespace Aliyun.Acs.Dypnsapi_intl.Transform.V20170725
{
    public class StartVerificationResponseUnmarshaller
    {
        public static StartVerificationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartVerificationResponse startVerificationResponse = new StartVerificationResponse();

			startVerificationResponse.HttpResponse = _ctx.HttpResponse;
			startVerificationResponse.RequestId = _ctx.StringValue("StartVerification.RequestId");
			startVerificationResponse.Message = _ctx.StringValue("StartVerification.Message");
			startVerificationResponse.Model = _ctx.StringValue("StartVerification.Model");
			startVerificationResponse.Code = _ctx.StringValue("StartVerification.Code");
			startVerificationResponse.Success = _ctx.BooleanValue("StartVerification.Success");
        
			return startVerificationResponse;
        }
    }
}
