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

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
	public class ListFeatureEntitiesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<ListFeatureEntities_FeatureEntitiesItem> featureEntities;

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

		public List<ListFeatureEntities_FeatureEntitiesItem> FeatureEntities
		{
			get
			{
				return featureEntities;
			}
			set	
			{
				featureEntities = value;
			}
		}

		public class ListFeatureEntities_FeatureEntitiesItem
		{

			private string featureEntityId;

			private string gmtCreateTime;

			private string joinId;

			private string name;

			private string owner;

			private string projectId;

			private string projectName;

			private string parentFeatureEntityId;

			private string parentFeatureEntityName;

			private string parentJoinId;

			public string FeatureEntityId
			{
				get
				{
					return featureEntityId;
				}
				set	
				{
					featureEntityId = value;
				}
			}

			public string GmtCreateTime
			{
				get
				{
					return gmtCreateTime;
				}
				set	
				{
					gmtCreateTime = value;
				}
			}

			public string JoinId
			{
				get
				{
					return joinId;
				}
				set	
				{
					joinId = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public string ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
				}
			}

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
				}
			}

			public string ParentFeatureEntityId
			{
				get
				{
					return parentFeatureEntityId;
				}
				set	
				{
					parentFeatureEntityId = value;
				}
			}

			public string ParentFeatureEntityName
			{
				get
				{
					return parentFeatureEntityName;
				}
				set	
				{
					parentFeatureEntityName = value;
				}
			}

			public string ParentJoinId
			{
				get
				{
					return parentJoinId;
				}
				set	
				{
					parentJoinId = value;
				}
			}
		}
	}
}
