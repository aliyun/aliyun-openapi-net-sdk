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

namespace Aliyun.Acs.Yundun_ds.Model.V20190103
{
	public class DescribeDataCountsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDataCounts_DataCount> dataCountList;

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

		public List<DescribeDataCounts_DataCount> DataCountList
		{
			get
			{
				return dataCountList;
			}
			set	
			{
				dataCountList = value;
			}
		}

		public class DescribeDataCounts_DataCount
		{

			private long? productId;

			private string productCode;

			private DescribeDataCounts_Instance instance;

			private DescribeDataCounts_Table table;

			private DescribeDataCounts_Package package;

			private DescribeDataCounts_Column column;

			private DescribeDataCounts_Oss oss;

			public long? ProductId
			{
				get
				{
					return productId;
				}
				set	
				{
					productId = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public DescribeDataCounts_Instance Instance
			{
				get
				{
					return instance;
				}
				set	
				{
					instance = value;
				}
			}

			public DescribeDataCounts_Table Table
			{
				get
				{
					return table;
				}
				set	
				{
					table = value;
				}
			}

			public DescribeDataCounts_Package Package
			{
				get
				{
					return package;
				}
				set	
				{
					package = value;
				}
			}

			public DescribeDataCounts_Column Column
			{
				get
				{
					return column;
				}
				set	
				{
					column = value;
				}
			}

			public DescribeDataCounts_Oss Oss
			{
				get
				{
					return oss;
				}
				set	
				{
					oss = value;
				}
			}

			public class DescribeDataCounts_Instance
			{

				private long? totalCount;

				private long? count;

				private long? sensitiveCount;

				private long? lastCount;

				private long? lastSensitiveCount;

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

				public long? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public long? SensitiveCount
				{
					get
					{
						return sensitiveCount;
					}
					set	
					{
						sensitiveCount = value;
					}
				}

				public long? LastCount
				{
					get
					{
						return lastCount;
					}
					set	
					{
						lastCount = value;
					}
				}

				public long? LastSensitiveCount
				{
					get
					{
						return lastSensitiveCount;
					}
					set	
					{
						lastSensitiveCount = value;
					}
				}
			}

			public class DescribeDataCounts_Table
			{

				private long? totalCount;

				private long? count;

				private long? sensitiveCount;

				private long? lastCount;

				private long? lastSensitiveCount;

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

				public long? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public long? SensitiveCount
				{
					get
					{
						return sensitiveCount;
					}
					set	
					{
						sensitiveCount = value;
					}
				}

				public long? LastCount
				{
					get
					{
						return lastCount;
					}
					set	
					{
						lastCount = value;
					}
				}

				public long? LastSensitiveCount
				{
					get
					{
						return lastSensitiveCount;
					}
					set	
					{
						lastSensitiveCount = value;
					}
				}
			}

			public class DescribeDataCounts_Package
			{

				private long? totalCount;

				private long? count;

				private long? sensitiveCount;

				private long? lastCount;

				private long? lastSensitiveCount;

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

				public long? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public long? SensitiveCount
				{
					get
					{
						return sensitiveCount;
					}
					set	
					{
						sensitiveCount = value;
					}
				}

				public long? LastCount
				{
					get
					{
						return lastCount;
					}
					set	
					{
						lastCount = value;
					}
				}

				public long? LastSensitiveCount
				{
					get
					{
						return lastSensitiveCount;
					}
					set	
					{
						lastSensitiveCount = value;
					}
				}
			}

			public class DescribeDataCounts_Column
			{

				private long? totalCount;

				private long? count;

				private long? sensitiveCount;

				private long? lastCount;

				private long? lastSensitiveCount;

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

				public long? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public long? SensitiveCount
				{
					get
					{
						return sensitiveCount;
					}
					set	
					{
						sensitiveCount = value;
					}
				}

				public long? LastCount
				{
					get
					{
						return lastCount;
					}
					set	
					{
						lastCount = value;
					}
				}

				public long? LastSensitiveCount
				{
					get
					{
						return lastSensitiveCount;
					}
					set	
					{
						lastSensitiveCount = value;
					}
				}
			}

			public class DescribeDataCounts_Oss
			{

				private long? totalCount;

				private long? count;

				private long? sensitiveCount;

				private long? lastCount;

				private long? lastSensitiveCount;

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

				public long? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public long? SensitiveCount
				{
					get
					{
						return sensitiveCount;
					}
					set	
					{
						sensitiveCount = value;
					}
				}

				public long? LastCount
				{
					get
					{
						return lastCount;
					}
					set	
					{
						lastCount = value;
					}
				}

				public long? LastSensitiveCount
				{
					get
					{
						return lastSensitiveCount;
					}
					set	
					{
						lastSensitiveCount = value;
					}
				}
			}
		}
	}
}
