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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class ModifyGlobalSecurityIPGroupNameResponse : AcsResponse
	{

		private string requestId;

		private List<ModifyGlobalSecurityIPGroupName_GlobalSecurityIPGroupItem> globalSecurityIPGroup;

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

		public List<ModifyGlobalSecurityIPGroupName_GlobalSecurityIPGroupItem> GlobalSecurityIPGroup
		{
			get
			{
				return globalSecurityIPGroup;
			}
			set	
			{
				globalSecurityIPGroup = value;
			}
		}

		public class ModifyGlobalSecurityIPGroupName_GlobalSecurityIPGroupItem
		{

			private string globalSecurityGroupId;

			private string globalIgName;

			private string securityIPType;

			private string gIpList;

			private string whitelistNetType;

			private string regionId;

			public string GlobalSecurityGroupId
			{
				get
				{
					return globalSecurityGroupId;
				}
				set	
				{
					globalSecurityGroupId = value;
				}
			}

			public string GlobalIgName
			{
				get
				{
					return globalIgName;
				}
				set	
				{
					globalIgName = value;
				}
			}

			public string SecurityIPType
			{
				get
				{
					return securityIPType;
				}
				set	
				{
					securityIPType = value;
				}
			}

			public string GIpList
			{
				get
				{
					return gIpList;
				}
				set	
				{
					gIpList = value;
				}
			}

			public string WhitelistNetType
			{
				get
				{
					return whitelistNetType;
				}
				set	
				{
					whitelistNetType = value;
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
		}
	}
}
