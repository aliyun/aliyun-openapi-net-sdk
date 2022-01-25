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
using Aliyun.Acs.quickbi_public.Model.V20210325;

namespace Aliyun.Acs.quickbi_public.Transform.V20210325
{
    public class QueryTicketInfoResponseUnmarshaller
    {
        public static QueryTicketInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTicketInfoResponse queryTicketInfoResponse = new QueryTicketInfoResponse();

			queryTicketInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryTicketInfoResponse.RequestId = _ctx.StringValue("QueryTicketInfo.RequestId");
			queryTicketInfoResponse.Success = _ctx.BooleanValue("QueryTicketInfo.Success");

			QueryTicketInfoResponse.QueryTicketInfo_Result result = new QueryTicketInfoResponse.QueryTicketInfo_Result();
			result.AccessTicket = _ctx.StringValue("QueryTicketInfo.Result.AccessTicket");
			result.OrganizationId = _ctx.StringValue("QueryTicketInfo.Result.OrganizationId");
			result.UserId = _ctx.StringValue("QueryTicketInfo.Result.UserId");
			result.UsedTicketNum = _ctx.IntegerValue("QueryTicketInfo.Result.UsedTicketNum");
			result.MaxTicketNum = _ctx.IntegerValue("QueryTicketInfo.Result.MaxTicketNum");
			result.RegisterTime = _ctx.StringValue("QueryTicketInfo.Result.RegisterTime");
			result.InvalidTime = _ctx.StringValue("QueryTicketInfo.Result.InvalidTime");
			result.WorksId = _ctx.StringValue("QueryTicketInfo.Result.WorksId");
			result.CmptId = _ctx.StringValue("QueryTicketInfo.Result.CmptId");
			result.GlobalParam = _ctx.StringValue("QueryTicketInfo.Result.GlobalParam");
			result.WatermarkParam = _ctx.StringValue("QueryTicketInfo.Result.WatermarkParam");
			queryTicketInfoResponse.Result = result;
        
			return queryTicketInfoResponse;
        }
    }
}
