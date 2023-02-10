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

namespace Aliyun.Acs.PTS.Model.V20201020
{
	public class GetUserVpcVSwitchResponse : AcsResponse
	{

		private int? vSwitchCount;

		private string requestId;

		private string message;

		private int? pageSize;

		private int? pageNumber;

		private int? httpStatusCode;

		private string code;

		private bool? success;

		private List<GetUserVpcVSwitch_VSwitch> vSwitchList;

		public int? VSwitchCount
		{
			get
			{
				return vSwitchCount;
			}
			set	
			{
				vSwitchCount = value;
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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
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

		public List<GetUserVpcVSwitch_VSwitch> VSwitchList
		{
			get
			{
				return vSwitchList;
			}
			set	
			{
				vSwitchList = value;
			}
		}

		public class GetUserVpcVSwitch_VSwitch
		{

			private string vpcId;

			private int? maxAgentCount;

			private long? availableIpAddressCount;

			private string vSwitchId;

			private string vSwitchName;

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public int? MaxAgentCount
			{
				get
				{
					return maxAgentCount;
				}
				set	
				{
					maxAgentCount = value;
				}
			}

			public long? AvailableIpAddressCount
			{
				get
				{
					return availableIpAddressCount;
				}
				set	
				{
					availableIpAddressCount = value;
				}
			}

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public string VSwitchName
			{
				get
				{
					return vSwitchName;
				}
				set	
				{
					vSwitchName = value;
				}
			}
		}
	}
}
