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
	public class DescribeHealthCheckListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeHealthCheckList_HealthCheckItem> healthCheckList;

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

		public List<DescribeHealthCheckList_HealthCheckItem> HealthCheckList
		{
			get
			{
				return healthCheckList;
			}
			set	
			{
				healthCheckList = value;
			}
		}

		public class DescribeHealthCheckList_HealthCheckItem
		{

			private string instanceId;

			private string protocol;

			private int? frontendPort;

			private DescribeHealthCheckList_HealthCheck healthCheck;

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

			public DescribeHealthCheckList_HealthCheck HealthCheck
			{
				get
				{
					return healthCheck;
				}
				set	
				{
					healthCheck = value;
				}
			}

			public class DescribeHealthCheckList_HealthCheck
			{

				private string type;

				private string domain;

				private string uri;

				private int? down;

				private int? interval;

				private int? port;

				private int? timeout;

				private int? up;

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

				public string Domain
				{
					get
					{
						return domain;
					}
					set	
					{
						domain = value;
					}
				}

				public string Uri
				{
					get
					{
						return uri;
					}
					set	
					{
						uri = value;
					}
				}

				public int? Down
				{
					get
					{
						return down;
					}
					set	
					{
						down = value;
					}
				}

				public int? Interval
				{
					get
					{
						return interval;
					}
					set	
					{
						interval = value;
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

				public int? Timeout
				{
					get
					{
						return timeout;
					}
					set	
					{
						timeout = value;
					}
				}

				public int? Up
				{
					get
					{
						return up;
					}
					set	
					{
						up = value;
					}
				}
			}
		}
	}
}
