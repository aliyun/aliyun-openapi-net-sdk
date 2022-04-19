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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class GetHoneypotNodeResponse : AcsResponse
	{

		private bool? success;

		private string code;

		private string message;

		private string requestId;

		private int? httpStatusCode;

		private GetHoneypotNode_HoneypotNode honeypotNode;

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

		public GetHoneypotNode_HoneypotNode HoneypotNode
		{
			get
			{
				return honeypotNode;
			}
			set	
			{
				honeypotNode = value;
			}
		}

		public class GetHoneypotNode_HoneypotNode
		{

			private string nodeId;

			private string nodeName;

			private int? honeypotTotalCount;

			private int? honeypotUsedCount;

			private int? probeTotalCount;

			private int? probeUsedCount;

			private int? totalStatus;

			private string ecsInstanceId;

			private string createTime;

			private bool? allowHoneypotAccessInternet;

			private string ip;

			private List<string> securityGroupProbeIpList;

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

			public int? HoneypotTotalCount
			{
				get
				{
					return honeypotTotalCount;
				}
				set	
				{
					honeypotTotalCount = value;
				}
			}

			public int? HoneypotUsedCount
			{
				get
				{
					return honeypotUsedCount;
				}
				set	
				{
					honeypotUsedCount = value;
				}
			}

			public int? ProbeTotalCount
			{
				get
				{
					return probeTotalCount;
				}
				set	
				{
					probeTotalCount = value;
				}
			}

			public int? ProbeUsedCount
			{
				get
				{
					return probeUsedCount;
				}
				set	
				{
					probeUsedCount = value;
				}
			}

			public int? TotalStatus
			{
				get
				{
					return totalStatus;
				}
				set	
				{
					totalStatus = value;
				}
			}

			public string EcsInstanceId
			{
				get
				{
					return ecsInstanceId;
				}
				set	
				{
					ecsInstanceId = value;
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

			public bool? AllowHoneypotAccessInternet
			{
				get
				{
					return allowHoneypotAccessInternet;
				}
				set	
				{
					allowHoneypotAccessInternet = value;
				}
			}

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}

			public List<string> SecurityGroupProbeIpList
			{
				get
				{
					return securityGroupProbeIpList;
				}
				set	
				{
					securityGroupProbeIpList = value;
				}
			}
		}
	}
}
