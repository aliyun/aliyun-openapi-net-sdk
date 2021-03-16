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

namespace Aliyun.Acs.reid_cloud.Model.V20201029
{
	public class DescribeDevicesResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string message;

		private string code;

		private string dynamicCode;

		private string requestId;

		private bool? success;

		private string dynamicMessage;

		private List<DescribeDevices_Device> devices;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
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

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public List<DescribeDevices_Device> Devices
		{
			get
			{
				return devices;
			}
			set	
			{
				devices = value;
			}
		}

		public class DescribeDevices_Device
		{

			private string agentStatus;

			private string ipcStatus;

			private string agentIp;

			private string ipcIp;

			private long? agentReceiveTime;

			private long? ipcId;

			private string agentMac;

			private string ipcName;

			private long? ipcReceiveTime;

			public string AgentStatus
			{
				get
				{
					return agentStatus;
				}
				set	
				{
					agentStatus = value;
				}
			}

			public string IpcStatus
			{
				get
				{
					return ipcStatus;
				}
				set	
				{
					ipcStatus = value;
				}
			}

			public string AgentIp
			{
				get
				{
					return agentIp;
				}
				set	
				{
					agentIp = value;
				}
			}

			public string IpcIp
			{
				get
				{
					return ipcIp;
				}
				set	
				{
					ipcIp = value;
				}
			}

			public long? AgentReceiveTime
			{
				get
				{
					return agentReceiveTime;
				}
				set	
				{
					agentReceiveTime = value;
				}
			}

			public long? IpcId
			{
				get
				{
					return ipcId;
				}
				set	
				{
					ipcId = value;
				}
			}

			public string AgentMac
			{
				get
				{
					return agentMac;
				}
				set	
				{
					agentMac = value;
				}
			}

			public string IpcName
			{
				get
				{
					return ipcName;
				}
				set	
				{
					ipcName = value;
				}
			}

			public long? IpcReceiveTime
			{
				get
				{
					return ipcReceiveTime;
				}
				set	
				{
					ipcReceiveTime = value;
				}
			}
		}
	}
}
