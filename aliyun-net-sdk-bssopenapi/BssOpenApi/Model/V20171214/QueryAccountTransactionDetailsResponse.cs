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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryAccountTransactionDetailsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryAccountTransactionDetails_Data data;

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "Data")]
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

			private string nextToken;

			private int? totalCount;

			private int? maxResults;

			private string accountName;

			private List<QueryAccountTransactionDetails_AccountTransactionsListItem> accountTransactionsList;

			[JsonProperty(PropertyName = "NextToken")]
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

			[JsonProperty(PropertyName = "TotalCount")]
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

			[JsonProperty(PropertyName = "MaxResults")]
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

			[JsonProperty(PropertyName = "AccountName")]
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

			[JsonProperty(PropertyName = "AccountTransactionsList")]
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

				private string billingCycle;

				private string transactionChannel;

				private string recordID;

				private string remarks;

				private string amount;

				private string transactionAccount;

				private string transactionTime;

				private string transactionType;

				private string transactionFlow;

				private string fundType;

				private string transactionChannelSN;

				private string transactionNumber;

				private string balance;

				[JsonProperty(PropertyName = "BillingCycle")]
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

				[JsonProperty(PropertyName = "TransactionChannel")]
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

				[JsonProperty(PropertyName = "RecordID")]
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

				[JsonProperty(PropertyName = "Remarks")]
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

				[JsonProperty(PropertyName = "Amount")]
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

				[JsonProperty(PropertyName = "TransactionAccount")]
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

				[JsonProperty(PropertyName = "TransactionTime")]
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

				[JsonProperty(PropertyName = "TransactionType")]
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

				[JsonProperty(PropertyName = "TransactionFlow")]
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

				[JsonProperty(PropertyName = "FundType")]
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

				[JsonProperty(PropertyName = "TransactionChannelSN")]
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

				[JsonProperty(PropertyName = "TransactionNumber")]
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

				[JsonProperty(PropertyName = "Balance")]
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
			}
		}
	}
}
