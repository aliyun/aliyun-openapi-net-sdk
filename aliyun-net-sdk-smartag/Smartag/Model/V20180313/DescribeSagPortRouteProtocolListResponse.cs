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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeSagPortRouteProtocolListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSagPortRouteProtocolList_Port> ports;

		private List<DescribeSagPortRouteProtocolList_TaskState> taskStates;

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

		public List<DescribeSagPortRouteProtocolList_Port> Ports
		{
			get
			{
				return ports;
			}
			set	
			{
				ports = value;
			}
		}

		public List<DescribeSagPortRouteProtocolList_TaskState> TaskStates
		{
			get
			{
				return taskStates;
			}
			set	
			{
				taskStates = value;
			}
		}

		public class DescribeSagPortRouteProtocolList_Port
		{

			private string portName;

			private string routeProtocol;

			private string remoteIp;

			private string remoteAs;

			private string vlan;

			private string status;

			private string neighborIp;

			public string PortName
			{
				get
				{
					return portName;
				}
				set	
				{
					portName = value;
				}
			}

			public string RouteProtocol
			{
				get
				{
					return routeProtocol;
				}
				set	
				{
					routeProtocol = value;
				}
			}

			public string RemoteIp
			{
				get
				{
					return remoteIp;
				}
				set	
				{
					remoteIp = value;
				}
			}

			public string RemoteAs
			{
				get
				{
					return remoteAs;
				}
				set	
				{
					remoteAs = value;
				}
			}

			public string Vlan
			{
				get
				{
					return vlan;
				}
				set	
				{
					vlan = value;
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

			public string NeighborIp
			{
				get
				{
					return neighborIp;
				}
				set	
				{
					neighborIp = value;
				}
			}
		}

		public class DescribeSagPortRouteProtocolList_TaskState
		{

			private string state;

			private string errorCode;

			private string errorMessage;

			private string createTime;

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
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

			public string CreateTime
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
