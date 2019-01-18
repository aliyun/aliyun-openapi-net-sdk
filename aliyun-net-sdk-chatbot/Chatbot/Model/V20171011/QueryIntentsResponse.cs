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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Model.V20171011
{
	public class QueryIntentsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<QueryIntents_Intent> intents;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
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

		public List<QueryIntents_Intent> Intents
		{
			get
			{
				return intents;
			}
			set	
			{
				intents = value;
			}
		}

		public class QueryIntents_Intent
		{

			private long? intentId;

			private string name;

			private string createTime;

			private string modifyTime;

			private string createUserId;

			private string createUserName;

			private string modifyUserId;

			private string modifyUserName;

			private List<QueryIntents_UserSayItem> userSay;

			private List<QueryIntents_RuleCheckItem> ruleCheck;

			private List<QueryIntents_SlotItem> slot;

			public long? IntentId
			{
				get
				{
					return intentId;
				}
				set	
				{
					intentId = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public string CreateUserId
			{
				get
				{
					return createUserId;
				}
				set	
				{
					createUserId = value;
				}
			}

			public string CreateUserName
			{
				get
				{
					return createUserName;
				}
				set	
				{
					createUserName = value;
				}
			}

			public string ModifyUserId
			{
				get
				{
					return modifyUserId;
				}
				set	
				{
					modifyUserId = value;
				}
			}

			public string ModifyUserName
			{
				get
				{
					return modifyUserName;
				}
				set	
				{
					modifyUserName = value;
				}
			}

			public List<QueryIntents_UserSayItem> UserSay
			{
				get
				{
					return userSay;
				}
				set	
				{
					userSay = value;
				}
			}

			public List<QueryIntents_RuleCheckItem> RuleCheck
			{
				get
				{
					return ruleCheck;
				}
				set	
				{
					ruleCheck = value;
				}
			}

			public List<QueryIntents_SlotItem> Slot
			{
				get
				{
					return slot;
				}
				set	
				{
					slot = value;
				}
			}

			public class QueryIntents_UserSayItem
			{

				private bool? strict;

				private List<QueryIntents_DataItem> data;

				public bool? Strict
				{
					get
					{
						return strict;
					}
					set	
					{
						strict = value;
					}
				}

				public List<QueryIntents_DataItem> Data
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

				public class QueryIntents_DataItem
				{

					private string text;

					private string slotId;

					public string Text
					{
						get
						{
							return text;
						}
						set	
						{
							text = value;
						}
					}

					public string SlotId
					{
						get
						{
							return slotId;
						}
						set	
						{
							slotId = value;
						}
					}
				}
			}

			public class QueryIntents_RuleCheckItem
			{

				private string text;

				private bool? strict;

				private List<string> warning;

				private List<string> error;

				public string Text
				{
					get
					{
						return text;
					}
					set	
					{
						text = value;
					}
				}

				public bool? Strict
				{
					get
					{
						return strict;
					}
					set	
					{
						strict = value;
					}
				}

				public List<string> Warning
				{
					get
					{
						return warning;
					}
					set	
					{
						warning = value;
					}
				}

				public List<string> Error
				{
					get
					{
						return error;
					}
					set	
					{
						error = value;
					}
				}
			}

			public class QueryIntents_SlotItem
			{

				private string name;

				private string _value;

				private bool? isNecessary;

				private bool? isArray;

				private int? lifeSpan;

				private List<QueryIntents_TagsItem> tags;

				private List<string> question;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}

				public bool? IsNecessary
				{
					get
					{
						return isNecessary;
					}
					set	
					{
						isNecessary = value;
					}
				}

				public bool? IsArray
				{
					get
					{
						return isArray;
					}
					set	
					{
						isArray = value;
					}
				}

				public int? LifeSpan
				{
					get
					{
						return lifeSpan;
					}
					set	
					{
						lifeSpan = value;
					}
				}

				public List<QueryIntents_TagsItem> Tags
				{
					get
					{
						return tags;
					}
					set	
					{
						tags = value;
					}
				}

				public List<string> Question
				{
					get
					{
						return question;
					}
					set	
					{
						question = value;
					}
				}

				public class QueryIntents_TagsItem
				{

					private string _value;

					private string userSayId;

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}

					public string UserSayId
					{
						get
						{
							return userSayId;
						}
						set	
						{
							userSayId = value;
						}
					}
				}
			}
		}
	}
}