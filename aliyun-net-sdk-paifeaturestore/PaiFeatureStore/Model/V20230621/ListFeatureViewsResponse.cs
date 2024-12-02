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
	public class ListFeatureViewsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private List<ListFeatureViews_FeatureViewsItem> featureViews;

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

		public long? TotalCount
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

		public List<ListFeatureViews_FeatureViewsItem> FeatureViews
		{
			get
			{
				return featureViews;
			}
			set	
			{
				featureViews = value;
			}
		}

		public class ListFeatureViews_FeatureViewsItem
		{

			private string featureViewId;

			private string projectId;

			private string projectName;

			private string featureEntityName;

			private string name;

			private string owner;

			private string type;

			private bool? writeToFeatureDB;

			private string gmtCreateTime;

			private string gmtModifiedTime;

			private string registerTable;

			private string registerDatasourceName;

			private int? tTL;

			private string registerDatasourceId;

			public string FeatureViewId
			{
				get
				{
					return featureViewId;
				}
				set	
				{
					featureViewId = value;
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

			public string FeatureEntityName
			{
				get
				{
					return featureEntityName;
				}
				set	
				{
					featureEntityName = value;
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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public bool? WriteToFeatureDB
			{
				get
				{
					return writeToFeatureDB;
				}
				set	
				{
					writeToFeatureDB = value;
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

			public string GmtModifiedTime
			{
				get
				{
					return gmtModifiedTime;
				}
				set	
				{
					gmtModifiedTime = value;
				}
			}

			public string RegisterTable
			{
				get
				{
					return registerTable;
				}
				set	
				{
					registerTable = value;
				}
			}

			public string RegisterDatasourceName
			{
				get
				{
					return registerDatasourceName;
				}
				set	
				{
					registerDatasourceName = value;
				}
			}

			public int? TTL
			{
				get
				{
					return tTL;
				}
				set	
				{
					tTL = value;
				}
			}

			public string RegisterDatasourceId
			{
				get
				{
					return registerDatasourceId;
				}
				set	
				{
					registerDatasourceId = value;
				}
			}
		}
	}
}
