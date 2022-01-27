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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeSQLLogTemplatesResponse : AcsResponse
	{

		private int? maxRecordsPerPage;

		private int? itemsNumbers;

		private string requestId;

		private string endTime;

		private int? dBInstanceID;

		private string startTime;

		private int? totalRecords;

		private string finish;

		private int? pageNumbers;

		private string jobId;

		private string pagingID;

		private string dBInstanceName;

		private List<DescribeSQLLogTemplates_Template> items;

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

		public string Finish
		{
			get
			{
				return finish;
			}
			set	
			{
				finish = value;
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

		public string JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
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

		public List<DescribeSQLLogTemplates_Template> Items
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

		public class DescribeSQLLogTemplates_Template
		{

			private float? avgScanRows;

			private string templateHash;

			private float? avgConsume;

			private long? totalScanRows;

			private long? totalUpdateRows;

			private long? totalCounts;

			private string sqlType;

			private float? avgUpdateRows;

			private int? itemID;

			private string template;

			private long? totalConsume;

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

			public int? ItemID
			{
				get
				{
					return itemID;
				}
				set	
				{
					itemID = value;
				}
			}

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
		}
	}
}
