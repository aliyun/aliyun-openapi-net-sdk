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

namespace Aliyun.Acs.Iot.Model.V20160530
{
	public class QueryTopicResponse : AcsResponse
	{

		private bool? success;

		private string errorMessage;

		private List<TopicInfo> topicList;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public List<TopicInfo> TopicList
		{
			get
			{
				return topicList;
			}
			set	
			{
				topicList = value;
			}
		}

		public class TopicInfo{

			private string topicName;

			private string productKey;

			private int? topicMessageCount;

			private string ownerUserId;

			public string TopicName
			{
				get
				{
					return topicName;
				}
				set	
				{
					topicName = value;
				}
			}

			public string ProductKey
			{
				get
				{
					return productKey;
				}
				set	
				{
					productKey = value;
				}
			}

			public int? TopicMessageCount
			{
				get
				{
					return topicMessageCount;
				}
				set	
				{
					topicMessageCount = value;
				}
			}

			public string OwnerUserId
			{
				get
				{
					return ownerUserId;
				}
				set	
				{
					ownerUserId = value;
				}
			}
		}
	}
}