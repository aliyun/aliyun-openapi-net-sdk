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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DeregisterManagedInstanceResponse : AcsResponse
	{

		private string requestId;

		private DeregisterManagedInstance_Instance instance;

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

		public DeregisterManagedInstance_Instance Instance
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

		public class DeregisterManagedInstance_Instance
		{

			private string lastInvokedTime;

			private string internetIp;

			private string hostname;

			private string instanceId;

			private string activationId;

			private string intranetIp;

			private string agentVersion;

			private string registrationTime;

			private string instanceName;

			private string osType;

			private string osVersion;

			private long? invocationCount;

			private string machineId;

			public string LastInvokedTime
			{
				get
				{
					return lastInvokedTime;
				}
				set	
				{
					lastInvokedTime = value;
				}
			}

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string Hostname
			{
				get
				{
					return hostname;
				}
				set	
				{
					hostname = value;
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

			public string ActivationId
			{
				get
				{
					return activationId;
				}
				set	
				{
					activationId = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

			public string AgentVersion
			{
				get
				{
					return agentVersion;
				}
				set	
				{
					agentVersion = value;
				}
			}

			public string RegistrationTime
			{
				get
				{
					return registrationTime;
				}
				set	
				{
					registrationTime = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string OsType
			{
				get
				{
					return osType;
				}
				set	
				{
					osType = value;
				}
			}

			public string OsVersion
			{
				get
				{
					return osVersion;
				}
				set	
				{
					osVersion = value;
				}
			}

			public long? InvocationCount
			{
				get
				{
					return invocationCount;
				}
				set	
				{
					invocationCount = value;
				}
			}

			public string MachineId
			{
				get
				{
					return machineId;
				}
				set	
				{
					machineId = value;
				}
			}
		}
	}
}
