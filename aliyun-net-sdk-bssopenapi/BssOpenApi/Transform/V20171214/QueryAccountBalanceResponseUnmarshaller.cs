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
    public class QueryAccountBalanceResponseUnmarshaller
    {
        public static QueryAccountBalanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAccountBalanceResponse queryAccountBalanceResponse = new QueryAccountBalanceResponse();

			queryAccountBalanceResponse.HttpResponse = _ctx.HttpResponse;
			queryAccountBalanceResponse.RequestId = _ctx.StringValue("QueryAccountBalance.RequestId");
			queryAccountBalanceResponse.Success = _ctx.BooleanValue("QueryAccountBalance.Success");
			queryAccountBalanceResponse.Code = _ctx.StringValue("QueryAccountBalance.Code");
			queryAccountBalanceResponse.Message = _ctx.StringValue("QueryAccountBalance.Message");

			QueryAccountBalanceResponse.QueryAccountBalance_Data data = new QueryAccountBalanceResponse.QueryAccountBalance_Data();
			data.AvailableAmount = _ctx.StringValue("QueryAccountBalance.Data.AvailableAmount");
			data.AvailableCashAmount = _ctx.StringValue("QueryAccountBalance.Data.AvailableCashAmount");
			data.CreditAmount = _ctx.StringValue("QueryAccountBalance.Data.CreditAmount");
			data.MybankCreditAmount = _ctx.StringValue("QueryAccountBalance.Data.MybankCreditAmount");
			data.Currency = _ctx.StringValue("QueryAccountBalance.Data.Currency");
			queryAccountBalanceResponse.Data = data;
        
			return queryAccountBalanceResponse;
        }
    }
}
