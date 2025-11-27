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
	public class ListKibanaPvlNetworkResponse : AcsResponse
	{

		private string requestId;

		private List<ListKibanaPvlNetwork_ResultItem> result;

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

		public List<ListKibanaPvlNetwork_ResultItem> Result
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

		public class ListKibanaPvlNetwork_ResultItem
		{

			private string endpointName;

			private string vpcId;

			private string endpointId;

			private string endpointStatus;

			private string createTime;

			private string pvlId;

			private List<ListKibanaPvlNetwork_VSwitchIdsZoneItem> vSwitchIdsZone;

			private List<string> securityGroups;

			public string EndpointName
			{
				get
				{
					return endpointName;
				}
				set	
				{
					endpointName = value;
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

			public string EndpointId
			{
				get
				{
					return endpointId;
				}
				set	
				{
					endpointId = value;
				}
			}

			public string EndpointStatus
			{
				get
				{
					return endpointStatus;
				}
				set	
				{
					endpointStatus = value;
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

			public string PvlId
			{
				get
				{
					return pvlId;
				}
				set	
				{
					pvlId = value;
				}
			}

			public List<ListKibanaPvlNetwork_VSwitchIdsZoneItem> VSwitchIdsZone
			{
				get
				{
					return vSwitchIdsZone;
				}
				set	
				{
					vSwitchIdsZone = value;
				}
			}

			public List<string> SecurityGroups
			{
				get
				{
					return securityGroups;
				}
				set	
				{
					securityGroups = value;
				}
			}

			public class ListKibanaPvlNetwork_VSwitchIdsZoneItem
			{

				private string zoneId;

				private string vswitchId;

				public string ZoneId
				{
					get
					{
						return zoneId;
					}
					set	
					{
						zoneId = value;
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
			}
		}
	}
}
