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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryAccountTransactionDetailsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private QueryAccountTransactionDetails_Data data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public QueryAccountTransactionDetails_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryAccountTransactionDetails_Data
		{

			private string accountName;

			private int? totalCount;

			private string nextToken;

			private int? maxResults;

			private List<QueryAccountTransactionDetails_AccountTransactionsListItem> accountTransactionsList;

			public string AccountName
			{
				get
				{
					return accountName;
				}
				set	
				{
					accountName = value;
				}
			}

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public string NextToken
			{
				get
				{
					return nextToken;
				}
				set	
				{
					nextToken = value;
				}
			}

			public int? MaxResults
			{
				get
				{
					return maxResults;
				}
				set	
				{
					maxResults = value;
				}
			}

			public List<QueryAccountTransactionDetails_AccountTransactionsListItem> AccountTransactionsList
			{
				get
				{
					return accountTransactionsList;
				}
				set	
				{
					accountTransactionsList = value;
				}
			}

			public class QueryAccountTransactionDetails_AccountTransactionsListItem
			{

				private string transactionNumber;

				private string transactionTime;

				private string transactionFlow;

				private string transactionType;

				private string transactionChannel;

				private string transactionChannelSN;

				private string fundType;

				private string recordID;

				private string remarks;

				private string billingCycle;

				private string amount;

				private string balance;

				private string transactionAccount;

				public string TransactionNumber
				{
					get
					{
						return transactionNumber;
					}
					set	
					{
						transactionNumber = value;
					}
				}

				public string TransactionTime
				{
					get
					{
						return transactionTime;
					}
					set	
					{
						transactionTime = value;
					}
				}

				public string TransactionFlow
				{
					get
					{
						return transactionFlow;
					}
					set	
					{
						transactionFlow = value;
					}
				}

				public string TransactionType
				{
					get
					{
						return transactionType;
					}
					set	
					{
						transactionType = value;
					}
				}

				public string TransactionChannel
				{
					get
					{
						return transactionChannel;
					}
					set	
					{
						transactionChannel = value;
					}
				}

				public string TransactionChannelSN
				{
					get
					{
						return transactionChannelSN;
					}
					set	
					{
						transactionChannelSN = value;
					}
				}

				public string FundType
				{
					get
					{
						return fundType;
					}
					set	
					{
						fundType = value;
					}
				}

				public string RecordID
				{
					get
					{
						return recordID;
					}
					set	
					{
						recordID = value;
					}
				}

				public string Remarks
				{
					get
					{
						return remarks;
					}
					set	
					{
						remarks = value;
					}
				}

				public string BillingCycle
				{
					get
					{
						return billingCycle;
					}
					set	
					{
						billingCycle = value;
					}
				}

				public string Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public string Balance
				{
					get
					{
						return balance;
					}
					set	
					{
						balance = value;
					}
				}

				public string TransactionAccount
				{
					get
					{
						return transactionAccount;
					}
					set	
					{
						transactionAccount = value;
					}
				}
			}
		}
	}
}
