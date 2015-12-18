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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20151101
{
	public class OpsDescribeGroupAttributeResponse : AcsResponse
	{

		private List<GroupPermission> groupPermissions;

		public List<GroupPermission> GroupPermissions
		{
			get
			{
				return groupPermissions;
			}
			set	
			{
				groupPermissions = value;
			}
		}

		public class GroupPermission{

			private string ipProtocal;

			private string portRange;

			private string sourceGroupId;

			private string destGroupId;

			private string sourceCidrIp;

			private string destCidrIp;

			private string nicType;

			private string policy;

			private int? level;

			private string sourceGroupOwnerUserAccount;

			private string destGroupOwnerUserAccount;

			private string direction;

			public string IpProtocal
			{
				get
				{
					return ipProtocal;
				}
				set	
				{
					ipProtocal = value;
				}
			}

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

			public string SourceGroupId
			{
				get
				{
					return sourceGroupId;
				}
				set	
				{
					sourceGroupId = value;
				}
			}

			public string DestGroupId
			{
				get
				{
					return destGroupId;
				}
				set	
				{
					destGroupId = value;
				}
			}

			public string SourceCidrIp
			{
				get
				{
					return sourceCidrIp;
				}
				set	
				{
					sourceCidrIp = value;
				}
			}

			public string DestCidrIp
			{
				get
				{
					return destCidrIp;
				}
				set	
				{
					destCidrIp = value;
				}
			}

			public string NicType
			{
				get
				{
					return nicType;
				}
				set	
				{
					nicType = value;
				}
			}

			public string Policy
			{
				get
				{
					return policy;
				}
				set	
				{
					policy = value;
				}
			}

			public int? Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public string SourceGroupOwnerUserAccount
			{
				get
				{
					return sourceGroupOwnerUserAccount;
				}
				set	
				{
					sourceGroupOwnerUserAccount = value;
				}
			}

			public string DestGroupOwnerUserAccount
			{
				get
				{
					return destGroupOwnerUserAccount;
				}
				set	
				{
					destGroupOwnerUserAccount = value;
				}
			}

			public string Direction
			{
				get
				{
					return direction;
				}
				set	
				{
					direction = value;
				}
			}
		}
	}
}