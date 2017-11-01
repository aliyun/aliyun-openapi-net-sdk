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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeRecycleBinResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeRecycleBin_RecycleBinModel> recycleBinModels;

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

		public List<DescribeRecycleBin_RecycleBinModel> RecycleBinModels
		{
			get
			{
				return recycleBinModels;
			}
			set	
			{
				recycleBinModels = value;
			}
		}

		public class DescribeRecycleBin_RecycleBinModel
		{

			private string resourceId;

			private string regionId;

			private string resourceType;

			private string creationTime;

			private string status;

			private List<DescribeRecycleBin_RelationResource> relationResources;

			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
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

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
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

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public List<DescribeRecycleBin_RelationResource> RelationResources
			{
				get
				{
					return relationResources;
				}
				set	
				{
					relationResources = value;
				}
			}

			public class DescribeRecycleBin_RelationResource
			{

				private string relationResourceId;

				private string relationResourceType;

				public string RelationResourceId
				{
					get
					{
						return relationResourceId;
					}
					set	
					{
						relationResourceId = value;
					}
				}

				public string RelationResourceType
				{
					get
					{
						return relationResourceType;
					}
					set	
					{
						relationResourceType = value;
					}
				}
			}
		}
	}
}