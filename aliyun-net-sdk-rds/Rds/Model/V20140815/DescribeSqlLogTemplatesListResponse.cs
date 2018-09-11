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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeSqlLogTemplatesListResponse : AcsResponse
	{

		private string requestId;

		private int? dBInstanceID;

		private string dBInstanceName;

		private string startTime;

		private string endTime;

		private int? totalRecords;

		private string pagingID;

		private int? maxRecordsPerPage;

		private int? pageNumbers;

		private int? itemsNumbers;

		private List<DescribeSqlLogTemplatesList_Template> items;

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

		public int? DBInstanceID
		{
			get
			{
				return dBInstanceID;
			}
			set	
			{
				dBInstanceID = value;
			}
		}

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

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public int? TotalRecords
		{
			get
			{
				return totalRecords;
			}
			set	
			{
				totalRecords = value;
			}
		}

		public string PagingID
		{
			get
			{
				return pagingID;
			}
			set	
			{
				pagingID = value;
			}
		}

		public int? MaxRecordsPerPage
		{
			get
			{
				return maxRecordsPerPage;
			}
			set	
			{
				maxRecordsPerPage = value;
			}
		}

		public int? PageNumbers
		{
			get
			{
				return pageNumbers;
			}
			set	
			{
				pageNumbers = value;
			}
		}

		public int? ItemsNumbers
		{
			get
			{
				return itemsNumbers;
			}
			set	
			{
				itemsNumbers = value;
			}
		}

		public List<DescribeSqlLogTemplatesList_Template> Items
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

		public class DescribeSqlLogTemplatesList_Template
		{

			private string template;

			private long? totalConsume;

			private float? avgConsume;

			private long? totalCounts;

			private float? avgScanRows;

			private long? totalScanRows;

			private long? totalUpdateRows;

			private float? avgUpdateRows;

			private string sqlType;

			private string templateHash;

			public string Template
			{
				get
				{
					return template;
				}
				set	
				{
					template = value;
				}
			}

			public long? TotalConsume
			{
				get
				{
					return totalConsume;
				}
				set	
				{
					totalConsume = value;
				}
			}

			public float? AvgConsume
			{
				get
				{
					return avgConsume;
				}
				set	
				{
					avgConsume = value;
				}
			}

			public long? TotalCounts
			{
				get
				{
					return totalCounts;
				}
				set	
				{
					totalCounts = value;
				}
			}

			public float? AvgScanRows
			{
				get
				{
					return avgScanRows;
				}
				set	
				{
					avgScanRows = value;
				}
			}

			public long? TotalScanRows
			{
				get
				{
					return totalScanRows;
				}
				set	
				{
					totalScanRows = value;
				}
			}

			public long? TotalUpdateRows
			{
				get
				{
					return totalUpdateRows;
				}
				set	
				{
					totalUpdateRows = value;
				}
			}

			public float? AvgUpdateRows
			{
				get
				{
					return avgUpdateRows;
				}
				set	
				{
					avgUpdateRows = value;
				}
			}

			public string SqlType
			{
				get
				{
					return sqlType;
				}
				set	
				{
					sqlType = value;
				}
			}

			public string TemplateHash
			{
				get
				{
					return templateHash;
				}
				set	
				{
					templateHash = value;
				}
			}
		}
	}
}