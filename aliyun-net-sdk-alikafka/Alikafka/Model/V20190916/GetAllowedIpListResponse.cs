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

namespace Aliyun.Acs.alikafka.Model.V20190916
{
	public class GetAllowedIpListResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private GetAllowedIpList_AllowedList allowedList;

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

		public GetAllowedIpList_AllowedList AllowedList
		{
			get
			{
				return allowedList;
			}
			set	
			{
				allowedList = value;
			}
		}

		public class GetAllowedIpList_AllowedList
		{

			private int? deployType;

			private List<GetAllowedIpList_IPListVO> vpcList;

			private List<GetAllowedIpList_IPListVO> internetList;

			public int? DeployType
			{
				get
				{
					return deployType;
				}
				set	
				{
					deployType = value;
				}
			}

			public List<GetAllowedIpList_IPListVO> VpcList
			{
				get
				{
					return vpcList;
				}
				set	
				{
					vpcList = value;
				}
			}

			public List<GetAllowedIpList_IPListVO> InternetList
			{
				get
				{
					return internetList;
				}
				set	
				{
					internetList = value;
				}
			}

			public class GetAllowedIpList_IPListVO
			{

				private string portRange;

				private string allowedIpGroup;

				private List<string> allowedIpList;

				public string PortRange
				{
					get
					{
						return portRange;
					}
					set	
					{
						portRange = value;
					}
				}

				public string AllowedIpGroup
				{
					get
					{
						return allowedIpGroup;
					}
					set	
					{
						allowedIpGroup = value;
					}
				}

				public List<string> AllowedIpList
				{
					get
					{
						return allowedIpList;
					}
					set	
					{
						allowedIpList = value;
					}
				}
			}
		}
	}
}
