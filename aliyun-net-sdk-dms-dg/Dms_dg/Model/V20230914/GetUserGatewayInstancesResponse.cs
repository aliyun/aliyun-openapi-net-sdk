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

namespace Aliyun.Acs.dms_dg.Model.V20230914
{
	public class GetUserGatewayInstancesResponse : AcsResponse
	{

		private string code;

		private string errorMsg;

		private string requestId;

		private bool? success;

		private List<GetUserGatewayInstances_GatewayInstance> gatewayInstanceList;

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

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
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

		public List<GetUserGatewayInstances_GatewayInstance> GatewayInstanceList
		{
			get
			{
				return gatewayInstanceList;
			}
			set	
			{
				gatewayInstanceList = value;
			}
		}

		public class GetUserGatewayInstances_GatewayInstance
		{

			private string gatewayInstanceId;

			private string gatewayId;

			private long? lastUpdateTime;

			private string localIP;

			private string outputIP;

			private string message;

			private string endPoint;

			private string currentDaemonVersion;

			private string currentVersion;

			private string regionId;

			private string connectEndpointType;

			private string gatewayInstanceStatus;

			public string GatewayInstanceId
			{
				get
				{
					return gatewayInstanceId;
				}
				set	
				{
					gatewayInstanceId = value;
				}
			}

			public string GatewayId
			{
				get
				{
					return gatewayId;
				}
				set	
				{
					gatewayId = value;
				}
			}

			public long? LastUpdateTime
			{
				get
				{
					return lastUpdateTime;
				}
				set	
				{
					lastUpdateTime = value;
				}
			}

			public string LocalIP
			{
				get
				{
					return localIP;
				}
				set	
				{
					localIP = value;
				}
			}

			public string OutputIP
			{
				get
				{
					return outputIP;
				}
				set	
				{
					outputIP = value;
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

			public string EndPoint
			{
				get
				{
					return endPoint;
				}
				set	
				{
					endPoint = value;
				}
			}

			public string CurrentDaemonVersion
			{
				get
				{
					return currentDaemonVersion;
				}
				set	
				{
					currentDaemonVersion = value;
				}
			}

			public string CurrentVersion
			{
				get
				{
					return currentVersion;
				}
				set	
				{
					currentVersion = value;
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

			public string ConnectEndpointType
			{
				get
				{
					return connectEndpointType;
				}
				set	
				{
					connectEndpointType = value;
				}
			}

			public string GatewayInstanceStatus
			{
				get
				{
					return gatewayInstanceStatus;
				}
				set	
				{
					gatewayInstanceStatus = value;
				}
			}
		}
	}
}
