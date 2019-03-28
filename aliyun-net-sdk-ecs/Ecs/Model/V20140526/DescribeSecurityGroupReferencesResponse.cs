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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeSecurityGroupReferencesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSecurityGroupReferences_SecurityGroupReference> securityGroupReferences;

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

		public List<DescribeSecurityGroupReferences_SecurityGroupReference> SecurityGroupReferences
		{
			get
			{
				return securityGroupReferences;
			}
			set	
			{
				securityGroupReferences = value;
			}
		}

		public class DescribeSecurityGroupReferences_SecurityGroupReference
		{

			private string securityGroupId;

			private List<DescribeSecurityGroupReferences_ReferencingSecurityGroup> referencingSecurityGroups;

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

			public List<DescribeSecurityGroupReferences_ReferencingSecurityGroup> ReferencingSecurityGroups
			{
				get
				{
					return referencingSecurityGroups;
				}
				set	
				{
					referencingSecurityGroups = value;
				}
			}

			public class DescribeSecurityGroupReferences_ReferencingSecurityGroup
			{

				private string aliUid;

				private string securityGroupId;

				public string AliUid
				{
					get
					{
						return aliUid;
					}
					set	
					{
						aliUid = value;
					}
				}

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
			}
		}
	}
}
