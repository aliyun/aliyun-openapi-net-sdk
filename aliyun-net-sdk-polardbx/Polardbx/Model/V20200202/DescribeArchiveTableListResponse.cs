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

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class DescribeArchiveTableListResponse : AcsResponse
	{

		private string requestId;

		private DescribeArchiveTableList_Data data;

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

		public DescribeArchiveTableList_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeArchiveTableList_Data
		{

			private long? total;

			private long? pageIndex;

			private long? pageSize;

			private int? tobeArchivedConut;

			private int? runningCount;

			private int? successCount;

			private int? pausedCount;

			private List<DescribeArchiveTableList_ArchiveTable> tables;

			public long? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public long? PageIndex
			{
				get
				{
					return pageIndex;
				}
				set	
				{
					pageIndex = value;
				}
			}

			public long? PageSize
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

			public int? TobeArchivedConut
			{
				get
				{
					return tobeArchivedConut;
				}
				set	
				{
					tobeArchivedConut = value;
				}
			}

			public int? RunningCount
			{
				get
				{
					return runningCount;
				}
				set	
				{
					runningCount = value;
				}
			}

			public int? SuccessCount
			{
				get
				{
					return successCount;
				}
				set	
				{
					successCount = value;
				}
			}

			public int? PausedCount
			{
				get
				{
					return pausedCount;
				}
				set	
				{
					pausedCount = value;
				}
			}

			public List<DescribeArchiveTableList_ArchiveTable> Tables
			{
				get
				{
					return tables;
				}
				set	
				{
					tables = value;
				}
			}

			public class DescribeArchiveTableList_ArchiveTable
			{

				private string schemaName;

				private string tableName;

				private long? createdDate;

				private double? spaceSize;

				private int? fileCount;

				private long? lastSuccessArchiveTime;

				private string archiveStatus;

				public string SchemaName
				{
					get
					{
						return schemaName;
					}
					set	
					{
						schemaName = value;
					}
				}

				public string TableName
				{
					get
					{
						return tableName;
					}
					set	
					{
						tableName = value;
					}
				}

				public long? CreatedDate
				{
					get
					{
						return createdDate;
					}
					set	
					{
						createdDate = value;
					}
				}

				public double? SpaceSize
				{
					get
					{
						return spaceSize;
					}
					set	
					{
						spaceSize = value;
					}
				}

				public int? FileCount
				{
					get
					{
						return fileCount;
					}
					set	
					{
						fileCount = value;
					}
				}

				public long? LastSuccessArchiveTime
				{
					get
					{
						return lastSuccessArchiveTime;
					}
					set	
					{
						lastSuccessArchiveTime = value;
					}
				}

				public string ArchiveStatus
				{
					get
					{
						return archiveStatus;
					}
					set	
					{
						archiveStatus = value;
					}
				}
			}
		}
	}
}
