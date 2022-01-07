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

namespace Aliyun.Acs.Dypnsapi.Model.V20170525
{
	public class QueryGateVerifyBillingPublicResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private QueryGateVerifyBillingPublic_Data data;

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

		public QueryGateVerifyBillingPublic_Data Data
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

		public class QueryGateVerifyBillingPublic_Data
		{

			private string amountSum;

			private List<QueryGateVerifyBillingPublic_SceneBillingListItem> sceneBillingList;

			public string AmountSum
			{
				get
				{
					return amountSum;
				}
				set	
				{
					amountSum = value;
				}
			}

			public List<QueryGateVerifyBillingPublic_SceneBillingListItem> SceneBillingList
			{
				get
				{
					return sceneBillingList;
				}
				set	
				{
					sceneBillingList = value;
				}
			}

			public class QueryGateVerifyBillingPublic_SceneBillingListItem
			{

				private string _add;

				private string singlePrice;

				private string amount;

				private string itemName;

				private string sceneCode;

				private string appName;

				private string sceneName;

				public string _Add
				{
					get
					{
						return _add;
					}
					set	
					{
						_add = value;
					}
				}

				public string SinglePrice
				{
					get
					{
						return singlePrice;
					}
					set	
					{
						singlePrice = value;
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

				public string ItemName
				{
					get
					{
						return itemName;
					}
					set	
					{
						itemName = value;
					}
				}

				public string SceneCode
				{
					get
					{
						return sceneCode;
					}
					set	
					{
						sceneCode = value;
					}
				}

				public string AppName
				{
					get
					{
						return appName;
					}
					set	
					{
						appName = value;
					}
				}

				public string SceneName
				{
					get
					{
						return sceneName;
					}
					set	
					{
						sceneName = value;
					}
				}
			}
		}
	}
}
