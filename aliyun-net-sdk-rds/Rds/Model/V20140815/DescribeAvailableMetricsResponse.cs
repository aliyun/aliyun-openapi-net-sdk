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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeAvailableMetricsResponse : AcsResponse
	{

		private int? totalRecordCount;

		private string requestId;

		private string dBInstanceName;

		private List<DescribeAvailableMetrics_Metrics> items;

		[JsonProperty(PropertyName = "TotalRecordCount")]
		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "DBInstanceName")]
		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
			}
		}

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeAvailableMetrics_Metrics> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeAvailableMetrics_Metrics
		{

			private string groupKey;

			private int? sortRule;

			private string description;

			private string unit;

			private string dbType;

			private string metricsKey;

			private string groupKeyType;

			private string metricsKeyAlias;

			private string method;

			private string dimension;

			[JsonProperty(PropertyName = "GroupKey")]
			public string GroupKey
			{
				get
				{
					return groupKey;
				}
				set	
				{
					groupKey = value;
				}
			}

			[JsonProperty(PropertyName = "SortRule")]
			public int? SortRule
			{
				get
				{
					return sortRule;
				}
				set	
				{
					sortRule = value;
				}
			}

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "Unit")]
			public string Unit
			{
				get
				{
					return unit;
				}
				set	
				{
					unit = value;
				}
			}

			[JsonProperty(PropertyName = "DbType")]
			public string DbType
			{
				get
				{
					return dbType;
				}
				set	
				{
					dbType = value;
				}
			}

			[JsonProperty(PropertyName = "MetricsKey")]
			public string MetricsKey
			{
				get
				{
					return metricsKey;
				}
				set	
				{
					metricsKey = value;
				}
			}

			[JsonProperty(PropertyName = "GroupKeyType")]
			public string GroupKeyType
			{
				get
				{
					return groupKeyType;
				}
				set	
				{
					groupKeyType = value;
				}
			}

			[JsonProperty(PropertyName = "MetricsKeyAlias")]
			public string MetricsKeyAlias
			{
				get
				{
					return metricsKeyAlias;
				}
				set	
				{
					metricsKeyAlias = value;
				}
			}

			[JsonProperty(PropertyName = "Method")]
			public string Method
			{
				get
				{
					return method;
				}
				set	
				{
					method = value;
				}
			}

			[JsonProperty(PropertyName = "Dimension")]
			public string Dimension
			{
				get
				{
					return dimension;
				}
				set	
				{
					dimension = value;
				}
			}
		}
	}
}
