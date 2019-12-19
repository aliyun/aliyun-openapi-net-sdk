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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBClusterAccessWhitelistResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDBClusterAccessWhitelist_DBClusterIPArray> items;

		private List<DescribeDBClusterAccessWhitelist_DBClusterSecurityGroup> dBClusterSecurityGroups;

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

		public List<DescribeDBClusterAccessWhitelist_DBClusterIPArray> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public List<DescribeDBClusterAccessWhitelist_DBClusterSecurityGroup> DBClusterSecurityGroups
		{
			get
			{
				return dBClusterSecurityGroups;
			}
			set	
			{
				dBClusterSecurityGroups = value;
			}
		}

		public class DescribeDBClusterAccessWhitelist_DBClusterIPArray
		{

			private string dBClusterIPArrayName;

			private string dBClusterIPArrayAttribute;

			private string securityIps;

			public string DBClusterIPArrayName
			{
				get
				{
					return dBClusterIPArrayName;
				}
				set	
				{
					dBClusterIPArrayName = value;
				}
			}

			public string DBClusterIPArrayAttribute
			{
				get
				{
					return dBClusterIPArrayAttribute;
				}
				set	
				{
					dBClusterIPArrayAttribute = value;
				}
			}

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

		public class DescribeDBClusterAccessWhitelist_DBClusterSecurityGroup
		{

			private string securityGroupId;

			private string securityGroupName;

			public string SecurityGroupId
			{
				get
				{
					return securityGroupId;
				}
				set	
				{
					securityGroupId = value;
				}
			}

			public string SecurityGroupName
			{
				get
				{
					return securityGroupName;
				}
				set	
				{
					securityGroupName = value;
				}
			}
		}
	}
}
