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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeInstanceRamRoleResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private string regionId;

		private List<DescribeInstanceRamRole_InstanceRamRoleSet> instanceRamRoleSets;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
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

		public List<DescribeInstanceRamRole_InstanceRamRoleSet> InstanceRamRoleSets
		{
			get
			{
				return instanceRamRoleSets;
			}
			set	
			{
				instanceRamRoleSets = value;
			}
		}

		public class DescribeInstanceRamRole_InstanceRamRoleSet
		{

			private string ramRoleName;

			private string instanceId;

			public string RamRoleName
			{
				get
				{
					return ramRoleName;
				}
				set	
				{
					ramRoleName = value;
				}
			}

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
		}
	}
}
