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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryFinancialAccountInfoResponseUnmarshaller
    {
        public static QueryFinancialAccountInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFinancialAccountInfoResponse queryFinancialAccountInfoResponse = new QueryFinancialAccountInfoResponse();

			queryFinancialAccountInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryFinancialAccountInfoResponse.Code = _ctx.StringValue("QueryFinancialAccountInfo.Code");
			queryFinancialAccountInfoResponse.RequestId = _ctx.StringValue("QueryFinancialAccountInfo.RequestId");
			queryFinancialAccountInfoResponse.Success = _ctx.BooleanValue("QueryFinancialAccountInfo.Success");
			queryFinancialAccountInfoResponse.Message = _ctx.StringValue("QueryFinancialAccountInfo.Message");

			QueryFinancialAccountInfoResponse.QueryFinancialAccountInfo_Data data = new QueryFinancialAccountInfoResponse.QueryFinancialAccountInfo_Data();
			data.UserName = _ctx.StringValue("QueryFinancialAccountInfo.Data.UserName");
			data.IsFinancialAccount = _ctx.BooleanValue("QueryFinancialAccountInfo.Data.IsFinancialAccount");
			data.AccountType = _ctx.StringValue("QueryFinancialAccountInfo.Data.AccountType");
			data.MemberNickName = _ctx.StringValue("QueryFinancialAccountInfo.Data.MemberNickName");
			data.MemberGroupId = _ctx.LongValue("QueryFinancialAccountInfo.Data.MemberGroupId");
			data.MemberGroupName = _ctx.StringValue("QueryFinancialAccountInfo.Data.MemberGroupName");
			queryFinancialAccountInfoResponse.Data = data;
        
			return queryFinancialAccountInfoResponse;
        }
    }
}
