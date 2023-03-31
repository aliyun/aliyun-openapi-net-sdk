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

			[JsonProperty(PropertyName = "AccountID")]
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

			[JsonProperty(PropertyName = "Items")]
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

				[JsonProperty(PropertyName = "BucketOwnerId")]
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

				[JsonProperty(PropertyName = "SubscribeType")]
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

				[JsonProperty(PropertyName = "SubscribeBucket")]
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

				[JsonProperty(PropertyName = "SubscribeTime")]
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

				[JsonProperty(PropertyName = "SubscribeLanguage")]
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

				[JsonProperty(PropertyName = "MultAccountRelSubscribe")]
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

				[JsonProperty(PropertyName = "BucketPath")]
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

				[JsonProperty(PropertyName = "RowLimitPerFile")]
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
