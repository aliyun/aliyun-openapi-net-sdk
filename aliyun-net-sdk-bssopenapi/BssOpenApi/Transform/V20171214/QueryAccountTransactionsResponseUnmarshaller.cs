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
    public class QueryAccountTransactionsResponseUnmarshaller
    {
        public static QueryAccountTransactionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAccountTransactionsResponse queryAccountTransactionsResponse = new QueryAccountTransactionsResponse();

			queryAccountTransactionsResponse.HttpResponse = _ctx.HttpResponse;
			queryAccountTransactionsResponse.Code = _ctx.StringValue("QueryAccountTransactions.Code");
			queryAccountTransactionsResponse.Message = _ctx.StringValue("QueryAccountTransactions.Message");
			queryAccountTransactionsResponse.RequestId = _ctx.StringValue("QueryAccountTransactions.RequestId");
			queryAccountTransactionsResponse.Success = _ctx.BooleanValue("QueryAccountTransactions.Success");

			QueryAccountTransactionsResponse.QueryAccountTransactions_Data data = new QueryAccountTransactionsResponse.QueryAccountTransactions_Data();
			data.PageNum = _ctx.IntegerValue("QueryAccountTransactions.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QueryAccountTransactions.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QueryAccountTransactions.Data.TotalCount");
			data.AccountName = _ctx.StringValue("QueryAccountTransactions.Data.AccountName");

			List<QueryAccountTransactionsResponse.QueryAccountTransactions_Data.QueryAccountTransactions_AccountTransactionsListItem> data_accountTransactionsList = new List<QueryAccountTransactionsResponse.QueryAccountTransactions_Data.QueryAccountTransactions_AccountTransactionsListItem>();
			for (int i = 0; i < _ctx.Length("QueryAccountTransactions.Data.AccountTransactionsList.Length"); i++) {
				QueryAccountTransactionsResponse.QueryAccountTransactions_Data.QueryAccountTransactions_AccountTransactionsListItem accountTransactionsListItem = new QueryAccountTransactionsResponse.QueryAccountTransactions_Data.QueryAccountTransactions_AccountTransactionsListItem();
				accountTransactionsListItem.BillingCycle = _ctx.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].BillingCycle");
				accountTransactionsListItem.TransactionChannel = _ctx.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionChannel");
				accountTransactionsListItem.RecordID = _ctx.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].RecordID");
				accountTransactionsListItem.Remarks = _ctx.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].Remarks");
				accountTransactionsListItem.Amount = _ctx.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].Amount");
				accountTransactionsListItem.TransactionAccount = _ctx.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionAccount");
				accountTransactionsListItem.TransactionTime = _ctx.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionTime");
				accountTransactionsListItem.TransactionType = _ctx.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionType");
				accountTransactionsListItem.TransactionFlow = _ctx.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionFlow");
				accountTransactionsListItem.FundType = _ctx.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].FundType");
				accountTransactionsListItem.TransactionChannelSN = _ctx.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionChannelSN");
				accountTransactionsListItem.TransactionNumber = _ctx.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionNumber");
				accountTransactionsListItem.Balance = _ctx.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].Balance");

				data_accountTransactionsList.Add(accountTransactionsListItem);
			}
			data.AccountTransactionsList = data_accountTransactionsList;
			queryAccountTransactionsResponse.Data = data;
        
			return queryAccountTransactionsResponse;
        }
    }
}
