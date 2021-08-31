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
	public class ListSlbResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<ListSlb_SlbEntity> slbList;

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

		public List<ListSlb_SlbEntity> SlbList
		{
			get
			{
				return slbList;
			}
			set	
			{
				slbList = value;
			}
		}

		public class ListSlb_SlbEntity
		{

			private string slbId;

			private string slbName;

			private string regionId;

			private string userId;

			private string address;

			private string slbStatus;

			private string addressType;

			private string vswitchId;

			private string vpcId;

			private string networkType;

			private int? groupId;

			private bool? expired;

			public string SlbId
			{
				get
				{
					return slbId;
				}
				set	
				{
					slbId = value;
				}
			}

			public string SlbName
			{
				get
				{
					return slbName;
				}
				set	
				{
					slbName = value;
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

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string SlbStatus
			{
				get
				{
					return slbStatus;
				}
				set	
				{
					slbStatus = value;
				}
			}

			public string AddressType
			{
				get
				{
					return addressType;
				}
				set	
				{
					addressType = value;
				}
			}

			public string VswitchId
			{
				get
				{
					return vswitchId;
				}
				set	
				{
					vswitchId = value;
				}
			}

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

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}

			public int? GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public bool? Expired
			{
				get
				{
					return expired;
				}
				set	
				{
					expired = value;
				}
			}
		}
	}
}
