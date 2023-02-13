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
	public class QueryBillToOSSSubscriptionResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryBillToOSSSubscription_Data data;

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

		public QueryBillToOSSSubscription_Data Data
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

		public class QueryBillToOSSSubscription_Data
		{

			private string accountName;

			private string accountID;

			private List<QueryBillToOSSSubscription_Item> items;

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

			public string AccountID
			{
				get
				{
					return accountID;
				}
				set	
				{
					accountID = value;
				}
			}

			public List<QueryBillToOSSSubscription_Item> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class QueryBillToOSSSubscription_Item
			{

				private long? bucketOwnerId;

				private string subscribeType;

				private string subscribeBucket;

				private string subscribeTime;

				private string subscribeLanguage;

				private string multAccountRelSubscribe;

				private string bucketPath;

				private int? rowLimitPerFile;

				public long? BucketOwnerId
				{
					get
					{
						return bucketOwnerId;
					}
					set	
					{
						bucketOwnerId = value;
					}
				}

				public string SubscribeType
				{
					get
					{
						return subscribeType;
					}
					set	
					{
						subscribeType = value;
					}
				}

				public string SubscribeBucket
				{
					get
					{
						return subscribeBucket;
					}
					set	
					{
						subscribeBucket = value;
					}
				}

				public string SubscribeTime
				{
					get
					{
						return subscribeTime;
					}
					set	
					{
						subscribeTime = value;
					}
				}

				public string SubscribeLanguage
				{
					get
					{
						return subscribeLanguage;
					}
					set	
					{
						subscribeLanguage = value;
					}
				}

				public string MultAccountRelSubscribe
				{
					get
					{
						return multAccountRelSubscribe;
					}
					set	
					{
						multAccountRelSubscribe = value;
					}
				}

				public string BucketPath
				{
					get
					{
						return bucketPath;
					}
					set	
					{
						bucketPath = value;
					}
				}

				public int? RowLimitPerFile
				{
					get
					{
						return rowLimitPerFile;
					}
					set	
					{
						rowLimitPerFile = value;
					}
				}
			}
		}
	}
}
