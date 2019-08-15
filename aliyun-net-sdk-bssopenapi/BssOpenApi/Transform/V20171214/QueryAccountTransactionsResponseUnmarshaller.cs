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
        public static QueryAccountTransactionsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAccountTransactionsResponse queryAccountTransactionsResponse = new QueryAccountTransactionsResponse();

			queryAccountTransactionsResponse.HttpResponse = context.HttpResponse;
			queryAccountTransactionsResponse.RequestId = context.StringValue("QueryAccountTransactions.RequestId");
			queryAccountTransactionsResponse.Success = context.BooleanValue("QueryAccountTransactions.Success");
			queryAccountTransactionsResponse.Code = context.StringValue("QueryAccountTransactions.Code");
			queryAccountTransactionsResponse.Message = context.StringValue("QueryAccountTransactions.Message");

			QueryAccountTransactionsResponse.QueryAccountTransactions_Data data = new QueryAccountTransactionsResponse.QueryAccountTransactions_Data();
			data.AccountName = context.StringValue("QueryAccountTransactions.Data.AccountName");
			data.TotalCount = context.IntegerValue("QueryAccountTransactions.Data.TotalCount");
			data.PageNum = context.IntegerValue("QueryAccountTransactions.Data.PageNum");
			data.PageSize = context.IntegerValue("QueryAccountTransactions.Data.PageSize");

			List<QueryAccountTransactionsResponse.QueryAccountTransactions_Data.QueryAccountTransactions_AccountTransactionsListItem> data_accountTransactionsList = new List<QueryAccountTransactionsResponse.QueryAccountTransactions_Data.QueryAccountTransactions_AccountTransactionsListItem>();
			for (int i = 0; i < context.Length("QueryAccountTransactions.Data.AccountTransactionsList.Length"); i++) {
				QueryAccountTransactionsResponse.QueryAccountTransactions_Data.QueryAccountTransactions_AccountTransactionsListItem accountTransactionsListItem = new QueryAccountTransactionsResponse.QueryAccountTransactions_Data.QueryAccountTransactions_AccountTransactionsListItem();
				accountTransactionsListItem.TransactionNumber = context.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionNumber");
				accountTransactionsListItem.TransactionTime = context.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionTime");
				accountTransactionsListItem.TransactionFlow = context.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionFlow");
				accountTransactionsListItem.TransactionType = context.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionType");
				accountTransactionsListItem.TransactionChannel = context.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionChannel");
				accountTransactionsListItem.TransactionChannelSN = context.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionChannelSN");
				accountTransactionsListItem.FundType = context.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].FundType");
				accountTransactionsListItem.RecordID = context.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].RecordID");
				accountTransactionsListItem.Remarks = context.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].Remarks");
				accountTransactionsListItem.BillingCycle = context.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].BillingCycle");
				accountTransactionsListItem.Amount = context.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].Amount");
				accountTransactionsListItem.Balance = context.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].Balance");
				accountTransactionsListItem.TransactionAccount = context.StringValue("QueryAccountTransactions.Data.AccountTransactionsList["+ i +"].TransactionAccount");

				data_accountTransactionsList.Add(accountTransactionsListItem);
			}
			data.AccountTransactionsList = data_accountTransactionsList;
			queryAccountTransactionsResponse.Data = data;
        
			return queryAccountTransactionsResponse;
        }
    }
}
