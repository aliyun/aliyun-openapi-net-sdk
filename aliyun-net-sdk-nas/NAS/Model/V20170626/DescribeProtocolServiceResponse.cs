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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeProtocolServiceResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<DescribeProtocolService_ProtocolService> protocolServices;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<DescribeProtocolService_ProtocolService> ProtocolServices
		{
			get
			{
				return protocolServices;
			}
			set	
			{
				protocolServices = value;
			}
		}

		public class DescribeProtocolService_ProtocolService
		{

			private string fileSystemId;

			private string protocolServiceId;

			private string protocolSpec;

			private int? protocolThroughput;

			private int? instanceRAM;

			private int? instanceBaseThroughput;

			private int? instanceBurstThroughput;

			private int? mountTargetCount;

			private string protocolType;

			private string status;

			private string description;

			private string createTime;

			private string modifyTime;

			public string FileSystemId
			{
				get
				{
					return fileSystemId;
				}
				set	
				{
					fileSystemId = value;
				}
			}

			public string ProtocolServiceId
			{
				get
				{
					return protocolServiceId;
				}
				set	
				{
					protocolServiceId = value;
				}
			}

			public string ProtocolSpec
			{
				get
				{
					return protocolSpec;
				}
				set	
				{
					protocolSpec = value;
				}
			}

			public int? ProtocolThroughput
			{
				get
				{
					return protocolThroughput;
				}
				set	
				{
					protocolThroughput = value;
				}
			}

			public int? InstanceRAM
			{
				get
				{
					return instanceRAM;
				}
				set	
				{
					instanceRAM = value;
				}
			}

			public int? InstanceBaseThroughput
			{
				get
				{
					return instanceBaseThroughput;
				}
				set	
				{
					instanceBaseThroughput = value;
				}
			}

			public int? InstanceBurstThroughput
			{
				get
				{
					return instanceBurstThroughput;
				}
				set	
				{
					instanceBurstThroughput = value;
				}
			}

			public int? MountTargetCount
			{
				get
				{
					return mountTargetCount;
				}
				set	
				{
					mountTargetCount = value;
				}
			}

			public string ProtocolType
			{
				get
				{
					return protocolType;
				}
				set	
				{
					protocolType = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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
		}
	}
}
