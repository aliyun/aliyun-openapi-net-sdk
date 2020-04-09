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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class DescribeServiceDetailResponse : AcsResponse
	{

		private int? code;

		private string errMsg;

		private string requestId;

		private bool? success;

		private DescribeServiceDetail_Result result;

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

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
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

		public DescribeServiceDetail_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeServiceDetail_Result
		{

			private long? appId;

			private long? envId;

			private bool? headless;

			private string k8sServiceId;

			private string name;

			private long? serviceId;

			private string serviceType;

			private string clusterIP;

			private List<DescribeServiceDetail_ServicePortMapping> portMappings;

			public long? AppId
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

			public long? EnvId
			{
				get
				{
					return envId;
				}
				set	
				{
					envId = value;
				}
			}

			public bool? Headless
			{
				get
				{
					return headless;
				}
				set	
				{
					headless = value;
				}
			}

			public string K8sServiceId
			{
				get
				{
					return k8sServiceId;
				}
				set	
				{
					k8sServiceId = value;
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

			public long? ServiceId
			{
				get
				{
					return serviceId;
				}
				set	
				{
					serviceId = value;
				}
			}

			public string ServiceType
			{
				get
				{
					return serviceType;
				}
				set	
				{
					serviceType = value;
				}
			}

			public string ClusterIP
			{
				get
				{
					return clusterIP;
				}
				set	
				{
					clusterIP = value;
				}
			}

			public List<DescribeServiceDetail_ServicePortMapping> PortMappings
			{
				get
				{
					return portMappings;
				}
				set	
				{
					portMappings = value;
				}
			}

			public class DescribeServiceDetail_ServicePortMapping
			{

				private string name;

				private int? nodePort;

				private int? port;

				private string protocol;

				private string targetPort;

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

				public int? NodePort
				{
					get
					{
						return nodePort;
					}
					set	
					{
						nodePort = value;
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

				public string TargetPort
				{
					get
					{
						return targetPort;
					}
					set	
					{
						targetPort = value;
					}
				}
			}
		}
	}
}
