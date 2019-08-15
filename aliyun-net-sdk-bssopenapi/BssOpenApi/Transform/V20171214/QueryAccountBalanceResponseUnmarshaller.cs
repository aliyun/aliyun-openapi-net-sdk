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
        public static QueryAccountBalanceResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAccountBalanceResponse queryAccountBalanceResponse = new QueryAccountBalanceResponse();

			queryAccountBalanceResponse.HttpResponse = context.HttpResponse;
			queryAccountBalanceResponse.RequestId = context.StringValue("QueryAccountBalance.RequestId");
			queryAccountBalanceResponse.Success = context.BooleanValue("QueryAccountBalance.Success");
			queryAccountBalanceResponse.Code = context.StringValue("QueryAccountBalance.Code");
			queryAccountBalanceResponse.Message = context.StringValue("QueryAccountBalance.Message");

			QueryAccountBalanceResponse.QueryAccountBalance_Data data = new QueryAccountBalanceResponse.QueryAccountBalance_Data();
			data.AvailableAmount = context.StringValue("QueryAccountBalance.Data.AvailableAmount");
			data.AvailableCashAmount = context.StringValue("QueryAccountBalance.Data.AvailableCashAmount");
			data.CreditAmount = context.StringValue("QueryAccountBalance.Data.CreditAmount");
			data.MybankCreditAmount = context.StringValue("QueryAccountBalance.Data.MybankCreditAmount");
			data.Currency = context.StringValue("QueryAccountBalance.Data.Currency");
			queryAccountBalanceResponse.Data = data;
        
			return queryAccountBalanceResponse;
        }
    }
}
