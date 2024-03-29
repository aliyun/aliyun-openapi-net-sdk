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
    public class QueryAccountTransactionDetailsResponseUnmarshaller
    {
        public static QueryAccountTransactionDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAccountTransactionDetailsResponse queryAccountTransactionDetailsResponse = new QueryAccountTransactionDetailsResponse();

			queryAccountTransactionDetailsResponse.HttpResponse = _ctx.HttpResponse;
			queryAccountTransactionDetailsResponse.Code = _ctx.StringValue("QueryAccountTransactionDetails.Code");
			queryAccountTransactionDetailsResponse.Message = _ctx.StringValue("QueryAccountTransactionDetails.Message");
			queryAccountTransactionDetailsResponse.RequestId = _ctx.StringValue("QueryAccountTransactionDetails.RequestId");
			queryAccountTransactionDetailsResponse.Success = _ctx.BooleanValue("QueryAccountTransactionDetails.Success");

			QueryAccountTransactionDetailsResponse.QueryAccountTransactionDetails_Data data = new QueryAccountTransactionDetailsResponse.QueryAccountTransactionDetails_Data();
			data.NextToken = _ctx.StringValue("QueryAccountTransactionDetails.Data.NextToken");
			data.TotalCount = _ctx.IntegerValue("QueryAccountTransactionDetails.Data.TotalCount");
			data.MaxResults = _ctx.IntegerValue("QueryAccountTransactionDetails.Data.MaxResults");
			data.AccountName = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountName");

			List<QueryAccountTransactionDetailsResponse.QueryAccountTransactionDetails_Data.QueryAccountTransactionDetails_AccountTransactionsListItem> data_accountTransactionsList = new List<QueryAccountTransactionDetailsResponse.QueryAccountTransactionDetails_Data.QueryAccountTransactionDetails_AccountTransactionsListItem>();
			for (int i = 0; i < _ctx.Length("QueryAccountTransactionDetails.Data.AccountTransactionsList.Length"); i++) {
				QueryAccountTransactionDetailsResponse.QueryAccountTransactionDetails_Data.QueryAccountTransactionDetails_AccountTransactionsListItem accountTransactionsListItem = new QueryAccountTransactionDetailsResponse.QueryAccountTransactionDetails_Data.QueryAccountTransactionDetails_AccountTransactionsListItem();
				accountTransactionsListItem.BillingCycle = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountTransactionsList["+ i +"].BillingCycle");
				accountTransactionsListItem.TransactionChannel = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountTransactionsList["+ i +"].TransactionChannel");
				accountTransactionsListItem.RecordID = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountTransactionsList["+ i +"].RecordID");
				accountTransactionsListItem.Remarks = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountTransactionsList["+ i +"].Remarks");
				accountTransactionsListItem.Amount = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountTransactionsList["+ i +"].Amount");
				accountTransactionsListItem.TransactionAccount = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountTransactionsList["+ i +"].TransactionAccount");
				accountTransactionsListItem.TransactionTime = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountTransactionsList["+ i +"].TransactionTime");
				accountTransactionsListItem.TransactionType = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountTransactionsList["+ i +"].TransactionType");
				accountTransactionsListItem.TransactionFlow = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountTransactionsList["+ i +"].TransactionFlow");
				accountTransactionsListItem.FundType = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountTransactionsList["+ i +"].FundType");
				accountTransactionsListItem.TransactionChannelSN = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountTransactionsList["+ i +"].TransactionChannelSN");
				accountTransactionsListItem.TransactionNumber = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountTransactionsList["+ i +"].TransactionNumber");
				accountTransactionsListItem.Balance = _ctx.StringValue("QueryAccountTransactionDetails.Data.AccountTransactionsList["+ i +"].Balance");

				data_accountTransactionsList.Add(accountTransactionsListItem);
			}
			data.AccountTransactionsList = data_accountTransactionsList;
			queryAccountTransactionDetailsResponse.Data = data;
        
			return queryAccountTransactionDetailsResponse;
        }
    }
}
