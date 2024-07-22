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
	public class UpdateKibanaWhiteIpsResponse : AcsResponse
	{

		private string requestId;

		private UpdateKibanaWhiteIps_Result result;

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

		public UpdateKibanaWhiteIps_Result Result
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

		public class UpdateKibanaWhiteIps_Result
		{

			private List<string> kibanaPrivateIPWhitelist;

			private List<string> kibanaIPWhitelist;

			private UpdateKibanaWhiteIps_NetworkConfig networkConfig;

			public List<string> KibanaPrivateIPWhitelist
			{
				get
				{
					return kibanaPrivateIPWhitelist;
				}
				set	
				{
					kibanaPrivateIPWhitelist = value;
				}
			}

			public List<string> KibanaIPWhitelist
			{
				get
				{
					return kibanaIPWhitelist;
				}
				set	
				{
					kibanaIPWhitelist = value;
				}
			}

			public UpdateKibanaWhiteIps_NetworkConfig NetworkConfig
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

			public class UpdateKibanaWhiteIps_NetworkConfig
			{

				private string vpcId;

				private string vswitchId;

				private string vsArea;

				private string type;

				private List<UpdateKibanaWhiteIps_WhiteIpGroupListItem> whiteIpGroupList;

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

				public string VsArea
				{
					get
					{
						return vsArea;
					}
					set	
					{
						vsArea = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public List<UpdateKibanaWhiteIps_WhiteIpGroupListItem> WhiteIpGroupList
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

				public class UpdateKibanaWhiteIps_WhiteIpGroupListItem
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
