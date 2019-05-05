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

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class DescribeVServerGroupsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeVServerGroups_VServerGroup> vServerGroups;

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

		public List<DescribeVServerGroups_VServerGroup> VServerGroups
		{
			get
			{
				return vServerGroups;
			}
			set	
			{
				vServerGroups = value;
			}
		}

		public class DescribeVServerGroups_VServerGroup
		{

			private string vServerGroupId;

			private string vServerGroupName;

			private DescribeVServerGroups_AssociatedObjects associatedObjects;

			public string VServerGroupId
			{
				get
				{
					return vServerGroupId;
				}
				set	
				{
					vServerGroupId = value;
				}
			}

			public string VServerGroupName
			{
				get
				{
					return vServerGroupName;
				}
				set	
				{
					vServerGroupName = value;
				}
			}

			public DescribeVServerGroups_AssociatedObjects AssociatedObjects
			{
				get
				{
					return associatedObjects;
				}
				set	
				{
					associatedObjects = value;
				}
			}

			public class DescribeVServerGroups_AssociatedObjects
			{

				private List<DescribeVServerGroups_Listener> listeners;

				private List<DescribeVServerGroups_Rule> rules;

				public List<DescribeVServerGroups_Listener> Listeners
				{
					get
					{
						return listeners;
					}
					set	
					{
						listeners = value;
					}
				}

				public List<DescribeVServerGroups_Rule> Rules
				{
					get
					{
						return rules;
					}
					set	
					{
						rules = value;
					}
				}

				public class DescribeVServerGroups_Listener
				{

					private string protocol;

					private int? port;

					public string Protocol
					{
						get
						{
							return protocol;
						}
						set	
						{
							protocol = value;
						}
					}

					public int? Port
					{
						get
						{
							return port;
						}
						set	
						{
							port = value;
						}
					}
				}

				public class DescribeVServerGroups_Rule
				{

					private string ruleId;

					private string domain;

					private string url;

					private string ruleName;

					public string RuleId
					{
						get
						{
							return ruleId;
						}
						set	
						{
							ruleId = value;
						}
					}

					public string Domain
					{
						get
						{
							return domain;
						}
						set	
						{
							domain = value;
						}
					}

					public string Url
					{
						get
						{
							return url;
						}
						set	
						{
							url = value;
						}
					}

					public string RuleName
					{
						get
						{
							return ruleName;
						}
						set	
						{
							ruleName = value;
						}
					}
				}
			}
		}
	}
}
