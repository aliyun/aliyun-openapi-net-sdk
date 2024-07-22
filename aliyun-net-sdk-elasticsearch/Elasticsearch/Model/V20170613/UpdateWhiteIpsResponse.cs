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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class UpdateWhiteIpsResponse : AcsResponse
	{

		private string requestId;

		private UpdateWhiteIps_Result result;

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

		public UpdateWhiteIps_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class UpdateWhiteIps_Result
		{

			private List<string> esIPWhitelist;

			private UpdateWhiteIps_NetworkConfig networkConfig;

			public List<string> EsIPWhitelist
			{
				get
				{
					return esIPWhitelist;
				}
				set	
				{
					esIPWhitelist = value;
				}
			}

			public UpdateWhiteIps_NetworkConfig NetworkConfig
			{
				get
				{
					return networkConfig;
				}
				set	
				{
					networkConfig = value;
				}
			}

			public class UpdateWhiteIps_NetworkConfig
			{

				private List<UpdateWhiteIps_WhiteIpGroupListItem> whiteIpGroupList;

				public List<UpdateWhiteIps_WhiteIpGroupListItem> WhiteIpGroupList
				{
					get
					{
						return whiteIpGroupList;
					}
					set	
					{
						whiteIpGroupList = value;
					}
				}

				public class UpdateWhiteIps_WhiteIpGroupListItem
				{

					private string groupName;

					private string whiteIpType;

					private List<string> ips;

					public string GroupName
					{
						get
						{
							return groupName;
						}
						set	
						{
							groupName = value;
						}
					}

					public string WhiteIpType
					{
						get
						{
							return whiteIpType;
						}
						set	
						{
							whiteIpType = value;
						}
					}

					public List<string> Ips
					{
						get
						{
							return ips;
						}
						set	
						{
							ips = value;
						}
					}
				}
			}
		}
	}
}
