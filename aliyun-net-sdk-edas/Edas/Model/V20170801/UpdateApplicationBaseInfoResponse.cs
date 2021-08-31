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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class UpdateApplicationBaseInfoResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private UpdateApplicationBaseInfo_Applcation applcation;

		public int? Code
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

		public UpdateApplicationBaseInfo_Applcation Applcation
		{
			get
			{
				return applcation;
			}
			set	
			{
				applcation = value;
			}
		}

		public class UpdateApplicationBaseInfo_Applcation
		{

			private string appId;

			private string name;

			private string regionId;

			private string description;

			private string owner;

			private int? instanceCount;

			private int? runningInstanceCount;

			private int? port;

			private string userId;

			private string slbId;

			private string slbIp;

			private int? slbPort;

			private string extSlbId;

			private string extSlbIp;

			private string slbName;

			private string extSlbName;

			private string applicationType;

			private int? clusterType;

			private string clusterId;

			private bool? dockerize;

			private int? cpu;

			private int? memory;

			private string healthCheckUrl;

			private long? buildPackageId;

			private long? createTime;

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
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

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
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

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public int? InstanceCount
			{
				get
				{
					return instanceCount;
				}
				set	
				{
					instanceCount = value;
				}
			}

			public int? RunningInstanceCount
			{
				get
				{
					return runningInstanceCount;
				}
				set	
				{
					runningInstanceCount = value;
				}
			}

			public int? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string SlbId
			{
				get
				{
					return slbId;
				}
				set	
				{
					slbId = value;
				}
			}

			public string SlbIp
			{
				get
				{
					return slbIp;
				}
				set	
				{
					slbIp = value;
				}
			}

			public int? SlbPort
			{
				get
				{
					return slbPort;
				}
				set	
				{
					slbPort = value;
				}
			}

			public string ExtSlbId
			{
				get
				{
					return extSlbId;
				}
				set	
				{
					extSlbId = value;
				}
			}

			public string ExtSlbIp
			{
				get
				{
					return extSlbIp;
				}
				set	
				{
					extSlbIp = value;
				}
			}

			public string SlbName
			{
				get
				{
					return slbName;
				}
				set	
				{
					slbName = value;
				}
			}

			public string ExtSlbName
			{
				get
				{
					return extSlbName;
				}
				set	
				{
					extSlbName = value;
				}
			}

			public string ApplicationType
			{
				get
				{
					return applicationType;
				}
				set	
				{
					applicationType = value;
				}
			}

			public int? ClusterType
			{
				get
				{
					return clusterType;
				}
				set	
				{
					clusterType = value;
				}
			}

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public bool? Dockerize
			{
				get
				{
					return dockerize;
				}
				set	
				{
					dockerize = value;
				}
			}

			public int? Cpu
			{
				get
				{
					return cpu;
				}
				set	
				{
					cpu = value;
				}
			}

			public int? Memory
			{
				get
				{
					return memory;
				}
				set	
				{
					memory = value;
				}
			}

			public string HealthCheckUrl
			{
				get
				{
					return healthCheckUrl;
				}
				set	
				{
					healthCheckUrl = value;
				}
			}

			public long? BuildPackageId
			{
				get
				{
					return buildPackageId;
				}
				set	
				{
					buildPackageId = value;
				}
			}

			public long? CreateTime
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
		}
	}
}
