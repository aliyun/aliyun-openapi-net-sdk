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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeSecurityGroupAttributeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSecurityGroupAttribute_SecurityGroup> availableGroupList;

		private List<DescribeSecurityGroupAttribute_SecurityGroupAttribute> securityGroupAttributeList;

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

		public List<DescribeSecurityGroupAttribute_SecurityGroup> AvailableGroupList
		{
			get
			{
				return availableGroupList;
			}
			set	
			{
				availableGroupList = value;
			}
		}

		public List<DescribeSecurityGroupAttribute_SecurityGroupAttribute> SecurityGroupAttributeList
		{
			get
			{
				return securityGroupAttributeList;
			}
			set	
			{
				securityGroupAttributeList = value;
			}
		}

		public class DescribeSecurityGroupAttribute_SecurityGroup
		{

			private string securityGroupId;

			private string description;

			private string securityGroupName;

			private string vpcId;

			private string creationTime;

			private int? availableInstanceAmount;

			private int? ecsCount;

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

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public int? AvailableInstanceAmount
			{
				get
				{
					return availableInstanceAmount;
				}
				set	
				{
					availableInstanceAmount = value;
				}
			}

			public int? EcsCount
			{
				get
				{
					return ecsCount;
				}
				set	
				{
					ecsCount = value;
				}
			}
		}

		public class DescribeSecurityGroupAttribute_SecurityGroupAttribute
		{

			private string bizType;

			private string bizContent;

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string BizContent
			{
				get
				{
					return bizContent;
				}
				set	
				{
					bizContent = value;
				}
			}
		}
	}
}
