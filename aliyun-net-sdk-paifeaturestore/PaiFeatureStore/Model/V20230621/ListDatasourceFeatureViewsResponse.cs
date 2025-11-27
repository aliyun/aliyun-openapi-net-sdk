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
	public class ListDatasourceFeatureViewsResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private List<ListDatasourceFeatureViews_DatasourceFeatureViews> featureViews;

		private ListDatasourceFeatureViews_TotalUsageStatistics totalUsageStatistics;

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

		public List<ListDatasourceFeatureViews_DatasourceFeatureViews> FeatureViews
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

		public ListDatasourceFeatureViews_TotalUsageStatistics TotalUsageStatistics
		{
			get
			{
				return totalUsageStatistics;
			}
			set	
			{
				totalUsageStatistics = value;
			}
		}

		public class ListDatasourceFeatureViews_DatasourceFeatureViews
		{

			private string featureViewId;

			private string name;

			private string projectName;

			private string type;

			private string featureEntityName;

			private int? tTL;

			private string config;

			private ListDatasourceFeatureViews_UsageStatistics usageStatistics;

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

			public string Config
			{
				get
				{
					return config;
				}
				set	
				{
					config = value;
				}
			}

			public ListDatasourceFeatureViews_UsageStatistics UsageStatistics
			{
				get
				{
					return usageStatistics;
				}
				set	
				{
					usageStatistics = value;
				}
			}

			public class ListDatasourceFeatureViews_UsageStatistics
			{

				private long? rowCount;

				private double? diskUsage;

				private double? memoryUsage;

				private List<ListDatasourceFeatureViews_ReadWriteCountItem> readWriteCount;

				public long? RowCount
				{
					get
					{
						return rowCount;
					}
					set	
					{
						rowCount = value;
					}
				}

				public double? DiskUsage
				{
					get
					{
						return diskUsage;
					}
					set	
					{
						diskUsage = value;
					}
				}

				public double? MemoryUsage
				{
					get
					{
						return memoryUsage;
					}
					set	
					{
						memoryUsage = value;
					}
				}

				public List<ListDatasourceFeatureViews_ReadWriteCountItem> ReadWriteCount
				{
					get
					{
						return readWriteCount;
					}
					set	
					{
						readWriteCount = value;
					}
				}

				public class ListDatasourceFeatureViews_ReadWriteCountItem
				{

					private string date;

					private long? writeCount;

					private long? readCount;

					public string Date
					{
						get
						{
							return date;
						}
						set	
						{
							date = value;
						}
					}

					public long? WriteCount
					{
						get
						{
							return writeCount;
						}
						set	
						{
							writeCount = value;
						}
					}

					public long? ReadCount
					{
						get
						{
							return readCount;
						}
						set	
						{
							readCount = value;
						}
					}
				}
			}
		}

		public class ListDatasourceFeatureViews_TotalUsageStatistics
		{

			private double? totalDiskUsage;

			private double? totalMemoryUsage;

			private List<ListDatasourceFeatureViews_TotalReadWriteCountItem> totalReadWriteCount;

			public double? TotalDiskUsage
			{
				get
				{
					return totalDiskUsage;
				}
				set	
				{
					totalDiskUsage = value;
				}
			}

			public double? TotalMemoryUsage
			{
				get
				{
					return totalMemoryUsage;
				}
				set	
				{
					totalMemoryUsage = value;
				}
			}

			public List<ListDatasourceFeatureViews_TotalReadWriteCountItem> TotalReadWriteCount
			{
				get
				{
					return totalReadWriteCount;
				}
				set	
				{
					totalReadWriteCount = value;
				}
			}

			public class ListDatasourceFeatureViews_TotalReadWriteCountItem
			{

				private string date;

				private long? totalWriteCount;

				private long? totalReadCount;

				public string Date
				{
					get
					{
						return date;
					}
					set	
					{
						date = value;
					}
				}

				public long? TotalWriteCount
				{
					get
					{
						return totalWriteCount;
					}
					set	
					{
						totalWriteCount = value;
					}
				}

				public long? TotalReadCount
				{
					get
					{
						return totalReadCount;
					}
					set	
					{
						totalReadCount = value;
					}
				}
			}
		}
	}
}
