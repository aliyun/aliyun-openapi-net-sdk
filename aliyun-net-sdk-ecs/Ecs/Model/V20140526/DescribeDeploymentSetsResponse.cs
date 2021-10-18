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
	public class DescribeDeploymentSetsResponse : AcsResponse
	{

		private int? pageSize;

		private int? pageNumber;

		private string requestId;

		private int? totalCount;

		private string regionId;

		private List<DescribeDeploymentSets_DeploymentSet> deploymentSets;

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

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

		public List<DescribeDeploymentSets_DeploymentSet> DeploymentSets
		{
			get
			{
				return deploymentSets;
			}
			set	
			{
				deploymentSets = value;
			}
		}

		public class DescribeDeploymentSets_DeploymentSet
		{

			private string creationTime;

			private string strategy;

			private string deploymentSetId;

			private string deploymentStrategy;

			private string deploymentSetDescription;

			private string domain;

			private int? groupCount;

			private string granularity;

			private string deploymentSetName;

			private int? instanceAmount;

			private List<string> instanceIds;

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

			public string Strategy
			{
				get
				{
					return strategy;
				}
				set	
				{
					strategy = value;
				}
			}

			public string DeploymentSetId
			{
				get
				{
					return deploymentSetId;
				}
				set	
				{
					deploymentSetId = value;
				}
			}

			public string DeploymentStrategy
			{
				get
				{
					return deploymentStrategy;
				}
				set	
				{
					deploymentStrategy = value;
				}
			}

			public string DeploymentSetDescription
			{
				get
				{
					return deploymentSetDescription;
				}
				set	
				{
					deploymentSetDescription = value;
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

			public int? GroupCount
			{
				get
				{
					return groupCount;
				}
				set	
				{
					groupCount = value;
				}
			}

			public string Granularity
			{
				get
				{
					return granularity;
				}
				set	
				{
					granularity = value;
				}
			}

			public string DeploymentSetName
			{
				get
				{
					return deploymentSetName;
				}
				set	
				{
					deploymentSetName = value;
				}
			}

			public int? InstanceAmount
			{
				get
				{
					return instanceAmount;
				}
				set	
				{
					instanceAmount = value;
				}
			}

			public List<string> InstanceIds
			{
				get
				{
					return instanceIds;
				}
				set	
				{
					instanceIds = value;
				}
			}
		}
	}
}
