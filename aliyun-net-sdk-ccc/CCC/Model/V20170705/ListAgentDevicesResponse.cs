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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class ListAgentDevicesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private List<ListAgentDevices_AgentDevice> agentDeviceList;

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

		public List<ListAgentDevices_AgentDevice> AgentDeviceList
		{
			get
			{
				return agentDeviceList;
			}
			set	
			{
				agentDeviceList = value;
			}
		}

		public class ListAgentDevices_AgentDevice
		{

			private string instanceId;

			private long? ramId;

			private long? loginTime;

			private string clientIp;

			private string clientPort;

			private string browserVersion;

			private int? isLogin;

			private string remark;

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

			public long? RamId
			{
				get
				{
					return ramId;
				}
				set	
				{
					ramId = value;
				}
			}

			public long? LoginTime
			{
				get
				{
					return loginTime;
				}
				set	
				{
					loginTime = value;
				}
			}

			public string ClientIp
			{
				get
				{
					return clientIp;
				}
				set	
				{
					clientIp = value;
				}
			}

			public string ClientPort
			{
				get
				{
					return clientPort;
				}
				set	
				{
					clientPort = value;
				}
			}

			public string BrowserVersion
			{
				get
				{
					return browserVersion;
				}
				set	
				{
					browserVersion = value;
				}
			}

			public int? IsLogin
			{
				get
				{
					return isLogin;
				}
				set	
				{
					isLogin = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}
		}
	}
}
