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

namespace Aliyun.Acs.Cassandra.Model.V20190101
{
	public class DescribeIpWhitelistGroupsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeIpWhitelistGroups_Group> groups;

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

		public List<DescribeIpWhitelistGroups_Group> Groups
		{
			get
			{
				return groups;
			}
			set	
			{
				groups = value;
			}
		}

		public class DescribeIpWhitelistGroups_Group
		{

			private string groupName;

			private int? ipVersion;

			private List<string> ipList;

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

			public int? IpVersion
			{
				get
				{
					return ipVersion;
				}
				set	
				{
					ipVersion = value;
				}
			}

			public List<string> IpList
			{
				get
				{
					return ipList;
				}
				set	
				{
					ipList = value;
				}
			}
		}
	}
}
