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
    public class GetConcurrentConversationQuotaResponseUnmarshaller
    {
        public static GetConcurrentConversationQuotaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetConcurrentConversationQuotaResponse getConcurrentConversationQuotaResponse = new GetConcurrentConversationQuotaResponse();

			getConcurrentConversationQuotaResponse.HttpResponse = _ctx.HttpResponse;
			getConcurrentConversationQuotaResponse.Code = _ctx.StringValue("GetConcurrentConversationQuota.Code");
			getConcurrentConversationQuotaResponse.HttpStatusCode = _ctx.IntegerValue("GetConcurrentConversationQuota.HttpStatusCode");
			getConcurrentConversationQuotaResponse.MaxConcurrent = _ctx.IntegerValue("GetConcurrentConversationQuota.MaxConcurrent");
			getConcurrentConversationQuotaResponse.Message = _ctx.StringValue("GetConcurrentConversationQuota.Message");
			getConcurrentConversationQuotaResponse.RemainingConcurrent = _ctx.IntegerValue("GetConcurrentConversationQuota.RemainingConcurrent");
			getConcurrentConversationQuotaResponse.RequestId = _ctx.StringValue("GetConcurrentConversationQuota.RequestId");
			getConcurrentConversationQuotaResponse.Success = _ctx.BooleanValue("GetConcurrentConversationQuota.Success");
        
			return getConcurrentConversationQuotaResponse;
        }
    }
}
