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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class ListIvrTrackingDetailsResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private ListIvrTrackingDetails_Data data;

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

		public ListIvrTrackingDetails_Data Data
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

		public class ListIvrTrackingDetails_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListIvrTrackingDetails_IvrTracking> list;

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

			public List<ListIvrTrackingDetails_IvrTracking> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListIvrTrackingDetails_IvrTracking
			{

				private string instance;

				private string callee;

				private long? enterTime;

				private string nodeVariables;

				private string nodeExitCode;

				private string flowName;

				private string flowId;

				private string nodeProperties;

				private string nodeType;

				private string caller;

				private string nodeName;

				private string contactId;

				private long? leaveTime;

				private string channelVariables;

				private string channelId;

				private string nodeId;

				public string Instance
				{
					get
					{
						return instance;
					}
					set	
					{
						instance = value;
					}
				}

				public string Callee
				{
					get
					{
						return callee;
					}
					set	
					{
						callee = value;
					}
				}

				public long? EnterTime
				{
					get
					{
						return enterTime;
					}
					set	
					{
						enterTime = value;
					}
				}

				public string NodeVariables
				{
					get
					{
						return nodeVariables;
					}
					set	
					{
						nodeVariables = value;
					}
				}

				public string NodeExitCode
				{
					get
					{
						return nodeExitCode;
					}
					set	
					{
						nodeExitCode = value;
					}
				}

				public string FlowName
				{
					get
					{
						return flowName;
					}
					set	
					{
						flowName = value;
					}
				}

				public string FlowId
				{
					get
					{
						return flowId;
					}
					set	
					{
						flowId = value;
					}
				}

				public string NodeProperties
				{
					get
					{
						return nodeProperties;
					}
					set	
					{
						nodeProperties = value;
					}
				}

				public string NodeType
				{
					get
					{
						return nodeType;
					}
					set	
					{
						nodeType = value;
					}
				}

				public string Caller
				{
					get
					{
						return caller;
					}
					set	
					{
						caller = value;
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

				public string ContactId
				{
					get
					{
						return contactId;
					}
					set	
					{
						contactId = value;
					}
				}

				public long? LeaveTime
				{
					get
					{
						return leaveTime;
					}
					set	
					{
						leaveTime = value;
					}
				}

				public string ChannelVariables
				{
					get
					{
						return channelVariables;
					}
					set	
					{
						channelVariables = value;
					}
				}

				public string ChannelId
				{
					get
					{
						return channelId;
					}
					set	
					{
						channelId = value;
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
			}
		}
	}
}
