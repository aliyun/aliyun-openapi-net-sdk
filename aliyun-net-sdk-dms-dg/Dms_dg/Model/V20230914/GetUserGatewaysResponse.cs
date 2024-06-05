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
	public class GetUserGatewaysResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMsg;

		private int? count;

		private List<GetUserGateways_Gateway> gatewayList;

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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public List<GetUserGateways_Gateway> GatewayList
		{
			get
			{
				return gatewayList;
			}
			set	
			{
				gatewayList = value;
			}
		}

		public class GetUserGateways_Gateway
		{

			private string gatewayDesc;

			private string gatewayName;

			private string regionId;

			private string gatewayId;

			private string status;

			private string userId;

			private string creatorId;

			private string dgVersion;

			private string exceptionMsg;

			private int? numOfExceptionInstance;

			private int? numOfRunningInstance;

			public string GatewayDesc
			{
				get
				{
					return gatewayDesc;
				}
				set	
				{
					gatewayDesc = value;
				}
			}

			public string GatewayName
			{
				get
				{
					return gatewayName;
				}
				set	
				{
					gatewayName = value;
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

			public string CreatorId
			{
				get
				{
					return creatorId;
				}
				set	
				{
					creatorId = value;
				}
			}

			public string DgVersion
			{
				get
				{
					return dgVersion;
				}
				set	
				{
					dgVersion = value;
				}
			}

			public string ExceptionMsg
			{
				get
				{
					return exceptionMsg;
				}
				set	
				{
					exceptionMsg = value;
				}
			}

			public int? NumOfExceptionInstance
			{
				get
				{
					return numOfExceptionInstance;
				}
				set	
				{
					numOfExceptionInstance = value;
				}
			}

			public int? NumOfRunningInstance
			{
				get
				{
					return numOfRunningInstance;
				}
				set	
				{
					numOfRunningInstance = value;
				}
			}
		}
	}
}
