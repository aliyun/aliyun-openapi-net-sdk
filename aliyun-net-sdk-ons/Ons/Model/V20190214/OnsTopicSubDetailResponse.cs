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

namespace Aliyun.Acs.Ons.Model.V20190214
{
	public class OnsTopicSubDetailResponse : AcsResponse
	{

		private string requestId;

		private OnsTopicSubDetail_Data data;

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

		public OnsTopicSubDetail_Data Data
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

		public class OnsTopicSubDetail_Data
		{

			private string topic;

			private List<OnsTopicSubDetail_SubscriptionDataListItem> subscriptionDataList;

			public string Topic
			{
				get
				{
					return topic;
				}
				set	
				{
					topic = value;
				}
			}

			public List<OnsTopicSubDetail_SubscriptionDataListItem> SubscriptionDataList
			{
				get
				{
					return subscriptionDataList;
				}
				set	
				{
					subscriptionDataList = value;
				}
			}

			public class OnsTopicSubDetail_SubscriptionDataListItem
			{

				private string groupId;

				private string messageModel;

				private string subString;

				public string GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
					}
				}

				public string MessageModel
				{
					get
					{
						return messageModel;
					}
					set	
					{
						messageModel = value;
					}
				}

				public string SubString
				{
					get
					{
						return subString;
					}
					set	
					{
						subString = value;
					}
				}
			}
		}
	}
}
