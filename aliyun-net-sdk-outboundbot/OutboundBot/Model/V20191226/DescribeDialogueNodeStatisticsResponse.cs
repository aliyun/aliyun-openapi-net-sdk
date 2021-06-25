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
	public class DescribeDialogueNodeStatisticsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private string groupId;

		private string instanceId;

		private int? totalCompleted;

		private List<DescribeDialogueNodeStatistics_NoAnswerDialogueNode> noAnswerDialogueNodes;

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

		public int? TotalCompleted
		{
			get
			{
				return totalCompleted;
			}
			set	
			{
				totalCompleted = value;
			}
		}

		public List<DescribeDialogueNodeStatistics_NoAnswerDialogueNode> NoAnswerDialogueNodes
		{
			get
			{
				return noAnswerDialogueNodes;
			}
			set	
			{
				noAnswerDialogueNodes = value;
			}
		}

		public class DescribeDialogueNodeStatistics_NoAnswerDialogueNode
		{

			private string id;

			private string instanceId;

			private string groupId;

			private string nodeId;

			private string nodeName;

			private int? hitNum;

			private int? hangUpNum;

			private int? noAnswerNum;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
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

			public string NodeId
			{
				get
				{
					return nodeId;
				}
				set	
				{
					nodeId = value;
				}
			}

			public string NodeName
			{
				get
				{
					return nodeName;
				}
				set	
				{
					nodeName = value;
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

			public int? HangUpNum
			{
				get
				{
					return hangUpNum;
				}
				set	
				{
					hangUpNum = value;
				}
			}

			public int? NoAnswerNum
			{
				get
				{
					return noAnswerNum;
				}
				set	
				{
					noAnswerNum = value;
				}
			}
		}
	}
}
