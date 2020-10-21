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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeApplicationInstancesResponse : AcsResponse
	{

		private string code;

		private string message;

		private string traceId;

		private string requestId;

		private bool? success;

		private string errorCode;

		private DescribeApplicationInstances_Data data;

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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public DescribeApplicationInstances_Data Data
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

		public class DescribeApplicationInstances_Data
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalSize;

			private List<DescribeApplicationInstances_Instance> instances;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
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

			public int? TotalSize
			{
				get
				{
					return totalSize;
				}
				set	
				{
					totalSize = value;
				}
			}

			public List<DescribeApplicationInstances_Instance> Instances
			{
				get
				{
					return instances;
				}
				set	
				{
					instances = value;
				}
			}

			public class DescribeApplicationInstances_Instance
			{

				private string groupId;

				private string instanceId;

				private string instanceContainerStatus;

				private string instanceContainerIp;

				private long? createTimeStamp;

				private string groupId1;

				private string vSwitchId;

				private long? instanceContainerRestarts;

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

				public string InstanceContainerStatus
				{
					get
					{
						return instanceContainerStatus;
					}
					set	
					{
						instanceContainerStatus = value;
					}
				}

				public string InstanceContainerIp
				{
					get
					{
						return instanceContainerIp;
					}
					set	
					{
						instanceContainerIp = value;
					}
				}

				public long? CreateTimeStamp
				{
					get
					{
						return createTimeStamp;
					}
					set	
					{
						createTimeStamp = value;
					}
				}

				public string GroupId1
				{
					get
					{
						return groupId1;
					}
					set	
					{
						groupId1 = value;
					}
				}

				public string VSwitchId
				{
					get
					{
						return vSwitchId;
					}
					set	
					{
						vSwitchId = value;
					}
				}

				public long? InstanceContainerRestarts
				{
					get
					{
						return instanceContainerRestarts;
					}
					set	
					{
						instanceContainerRestarts = value;
					}
				}
			}
		}
	}
}
