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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ModifyOutboundCallNumberResponseUnmarshaller
    {
        public static ModifyOutboundCallNumberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyOutboundCallNumberResponse modifyOutboundCallNumberResponse = new ModifyOutboundCallNumberResponse();

			modifyOutboundCallNumberResponse.HttpResponse = _ctx.HttpResponse;
			modifyOutboundCallNumberResponse.Code = _ctx.StringValue("ModifyOutboundCallNumber.Code");
			modifyOutboundCallNumberResponse.HttpStatusCode = _ctx.IntegerValue("ModifyOutboundCallNumber.HttpStatusCode");
			modifyOutboundCallNumberResponse.Message = _ctx.StringValue("ModifyOutboundCallNumber.Message");
			modifyOutboundCallNumberResponse.RequestId = _ctx.StringValue("ModifyOutboundCallNumber.RequestId");
			modifyOutboundCallNumberResponse.Success = _ctx.BooleanValue("ModifyOutboundCallNumber.Success");

			ModifyOutboundCallNumberResponse.ModifyOutboundCallNumber_OutboundCallNumber outboundCallNumber = new ModifyOutboundCallNumberResponse.ModifyOutboundCallNumber_OutboundCallNumber();
			outboundCallNumber.Number = _ctx.StringValue("ModifyOutboundCallNumber.OutboundCallNumber.Number");
			outboundCallNumber.OutboundCallNumberId = _ctx.StringValue("ModifyOutboundCallNumber.OutboundCallNumber.OutboundCallNumberId");
			outboundCallNumber.RateLimitCount = _ctx.StringValue("ModifyOutboundCallNumber.OutboundCallNumber.RateLimitCount");
			outboundCallNumber.RateLimitPeriod = _ctx.StringValue("ModifyOutboundCallNumber.OutboundCallNumber.RateLimitPeriod");
			modifyOutboundCallNumberResponse.OutboundCallNumber = outboundCallNumber;
        
			return modifyOutboundCallNumberResponse;
        }
    }
}
