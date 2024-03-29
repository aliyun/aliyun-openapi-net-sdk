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
	public class DescribeSQLLogReportListResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private List<DescribeSQLLogReportList_Item> items;

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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "PageRecordCount")]
		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

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

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeSQLLogReportList_Item> Items
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

		public class DescribeSQLLogReportList_Item
		{

			private string reportTime;

			private List<DescribeSQLLogReportList_LatencyTopNItem> latencyTopNItems;

			private List<DescribeSQLLogReportList_QPSTopNItem> qPSTopNItems;

			[JsonProperty(PropertyName = "ReportTime")]
			public string ReportTime
			{
				get
				{
					return reportTime;
				}
				set	
				{
					reportTime = value;
				}
			}

			[JsonProperty(PropertyName = "LatencyTopNItems")]
			public List<DescribeSQLLogReportList_LatencyTopNItem> LatencyTopNItems
			{
				get
				{
					return latencyTopNItems;
				}
				set	
				{
					latencyTopNItems = value;
				}
			}

			[JsonProperty(PropertyName = "QPSTopNItems")]
			public List<DescribeSQLLogReportList_QPSTopNItem> QPSTopNItems
			{
				get
				{
					return qPSTopNItems;
				}
				set	
				{
					qPSTopNItems = value;
				}
			}

			public class DescribeSQLLogReportList_LatencyTopNItem
			{

				private string sQLText;

				private long? sQLExecuteTimes;

				private long? avgLatency;

				[JsonProperty(PropertyName = "SQLText")]
				public string SQLText
				{
					get
					{
						return sQLText;
					}
					set	
					{
						sQLText = value;
					}
				}

				[JsonProperty(PropertyName = "SQLExecuteTimes")]
				public long? SQLExecuteTimes
				{
					get
					{
						return sQLExecuteTimes;
					}
					set	
					{
						sQLExecuteTimes = value;
					}
				}

				[JsonProperty(PropertyName = "AvgLatency")]
				public long? AvgLatency
				{
					get
					{
						return avgLatency;
					}
					set	
					{
						avgLatency = value;
					}
				}
			}

			public class DescribeSQLLogReportList_QPSTopNItem
			{

				private long? sQLExecuteTimes;

				private string sQLText;

				[JsonProperty(PropertyName = "SQLExecuteTimes")]
				public long? SQLExecuteTimes
				{
					get
					{
						return sQLExecuteTimes;
					}
					set	
					{
						sQLExecuteTimes = value;
					}
				}

				[JsonProperty(PropertyName = "SQLText")]
				public string SQLText
				{
					get
					{
						return sQLText;
					}
					set	
					{
						sQLText = value;
					}
				}
			}
		}
	}
}
