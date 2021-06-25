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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class DescribeIntentStatisticsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private string instanceId;

		private string groupId;

		private int? processIntentNum;

		private int? globalIntentNum;

		private List<DescribeIntentStatistics_IntentStatisticsItem> processIntents;

		private List<DescribeIntentStatistics_IntentStatisticsItem> globalIntents;

		private List<DescribeIntentStatistics_IntentStatisticsItem1> intentsAfterNoAnswer;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
			}
		}

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

		public int? ProcessIntentNum
		{
			get
			{
				return processIntentNum;
			}
			set	
			{
				processIntentNum = value;
			}
		}

		public int? GlobalIntentNum
		{
			get
			{
				return globalIntentNum;
			}
			set	
			{
				globalIntentNum = value;
			}
		}

		public List<DescribeIntentStatistics_IntentStatisticsItem> ProcessIntents
		{
			get
			{
				return processIntents;
			}
			set	
			{
				processIntents = value;
			}
		}

		public List<DescribeIntentStatistics_IntentStatisticsItem> GlobalIntents
		{
			get
			{
				return globalIntents;
			}
			set	
			{
				globalIntents = value;
			}
		}

		public List<DescribeIntentStatistics_IntentStatisticsItem1> IntentsAfterNoAnswer
		{
			get
			{
				return intentsAfterNoAnswer;
			}
			set	
			{
				intentsAfterNoAnswer = value;
			}
		}

		public class DescribeIntentStatistics_IntentStatisticsItem
		{

			private string instanceId;

			private string groupId;

			private string intentId;

			private string intentName;

			private string type;

			private int? hitNum;

			private int? hitAfterNoAnswer;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

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

			public string IntentId
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

			public string IntentName
			{
				get
				{
					return intentName;
				}
				set	
				{
					intentName = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public int? HitNum
			{
				get
				{
					return hitNum;
				}
				set	
				{
					hitNum = value;
				}
			}

			public int? HitAfterNoAnswer
			{
				get
				{
					return hitAfterNoAnswer;
				}
				set	
				{
					hitAfterNoAnswer = value;
				}
			}
		}

		public class DescribeIntentStatistics_IntentStatisticsItem1
		{

			private string instanceId;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}
		}
	}
}
