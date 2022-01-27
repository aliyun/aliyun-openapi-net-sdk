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
	public class GetK8sServicesResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<GetK8sServices_ServicesItem> services;

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

		public List<GetK8sServices_ServicesItem> Services
		{
			get
			{
				return services;
			}
			set	
			{
				services = value;
			}
		}

		public class GetK8sServices_ServicesItem
		{

			private string name;

			private string type;

			private string clusterIP;

			private List<GetK8sServices_ServicePortsItem> servicePorts;

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

			public List<GetK8sServices_ServicePortsItem> ServicePorts
			{
				get
				{
					return servicePorts;
				}
				set	
				{
					servicePorts = value;
				}
			}

			public class GetK8sServices_ServicePortsItem
			{

				private string protocol;

				private int? port;

				private string targetPort;

				private int? nodePort;

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
			}
		}
	}
}
