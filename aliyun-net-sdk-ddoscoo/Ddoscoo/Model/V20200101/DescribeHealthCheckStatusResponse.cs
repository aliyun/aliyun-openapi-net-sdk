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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeHealthCheckStatusResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeHealthCheckStatus_Status> healthCheckStatus;

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

		public List<DescribeHealthCheckStatus_Status> HealthCheckStatus
		{
			get
			{
				return healthCheckStatus;
			}
			set	
			{
				healthCheckStatus = value;
			}
		}

		public class DescribeHealthCheckStatus_Status
		{

			private string instanceId;

			private string protocol;

			private int? frontendPort;

			private string status;

			private List<DescribeHealthCheckStatus_RealServerStatus> realServerStatusList;

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

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public int? FrontendPort
			{
				get
				{
					return frontendPort;
				}
				set	
				{
					frontendPort = value;
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

			public List<DescribeHealthCheckStatus_RealServerStatus> RealServerStatusList
			{
				get
				{
					return realServerStatusList;
				}
				set	
				{
					realServerStatusList = value;
				}
			}

			public class DescribeHealthCheckStatus_RealServerStatus
			{

				private string address;

				private string status;

				public string Address
				{
					get
					{
						return address;
					}
					set	
					{
						address = value;
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
			}
		}
	}
}
