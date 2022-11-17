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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class ModifySecurityIpsResponse : AcsResponse
	{

		private string requestId;

		private ModifySecurityIps_SecurityIpGroup securityIpGroup;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "SecurityIpGroup")]
		public ModifySecurityIps_SecurityIpGroup SecurityIpGroup
		{
			get
			{
				return securityIpGroup;
			}
			set	
			{
				securityIpGroup = value;
			}
		}

		public class ModifySecurityIps_SecurityIpGroup
		{

			private string instanceId;

			private string securityIpGroupName;

			private string securityIps;

			[JsonProperty(PropertyName = "InstanceId")]
			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			[JsonProperty(PropertyName = "SecurityIpGroupName")]
			public string SecurityIpGroupName
			{
				get
				{
					return securityIpGroupName;
				}
				set	
				{
					securityIpGroupName = value;
				}
			}

			[JsonProperty(PropertyName = "SecurityIps")]
			public string SecurityIps
			{
				get
				{
					return securityIps;
				}
				set	
				{
					securityIps = value;
				}
			}
		}
	}
}
