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
	public class DescribeTotalCountResponse : AcsResponse
	{

		private string requestId;

		private DescribeTotalCount_DataCount dataCount;

		private DescribeTotalCount_EventCount eventCount;

		private DescribeTotalCount_DepartCount departCount;

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

		public DescribeTotalCount_DataCount DataCount
		{
			get
			{
				return dataCount;
			}
			set	
			{
				dataCount = value;
			}
		}

		public DescribeTotalCount_EventCount EventCount
		{
			get
			{
				return eventCount;
			}
			set	
			{
				eventCount = value;
			}
		}

		public DescribeTotalCount_DepartCount DepartCount
		{
			get
			{
				return departCount;
			}
			set	
			{
				departCount = value;
			}
		}

		public class DescribeTotalCount_DataCount
		{

			private DescribeTotalCount_Instance instance;

			private DescribeTotalCount_Table table;

			private DescribeTotalCount_Oss oss;

			public DescribeTotalCount_Instance Instance
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

			public DescribeTotalCount_Table Table
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

			public DescribeTotalCount_Oss Oss
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

			public class DescribeTotalCount_Instance
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

			public class DescribeTotalCount_Table
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

			public class DescribeTotalCount_Oss
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

		public class DescribeTotalCount_EventCount
		{

			private DescribeTotalCount_Total total;

			public DescribeTotalCount_Total Total
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

			public class DescribeTotalCount_Total
			{

				private long? totalCount;

				private long? undealCount;

				private long? confirmCount;

				private long? excludeCount;

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

				public long? UndealCount
				{
					get
					{
						return undealCount;
					}
					set	
					{
						undealCount = value;
					}
				}

				public long? ConfirmCount
				{
					get
					{
						return confirmCount;
					}
					set	
					{
						confirmCount = value;
					}
				}

				public long? ExcludeCount
				{
					get
					{
						return excludeCount;
					}
					set	
					{
						excludeCount = value;
					}
				}
			}
		}

		public class DescribeTotalCount_DepartCount
		{

			private long? departCount;

			private long? count;

			private long? userCount;

			private long? dtCount;

			private long? subCount;

			private long? sensitiveCount;

			public long? DepartCount
			{
				get
				{
					return departCount;
				}
				set	
				{
					departCount = value;
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

			public long? UserCount
			{
				get
				{
					return userCount;
				}
				set	
				{
					userCount = value;
				}
			}

			public long? DtCount
			{
				get
				{
					return dtCount;
				}
				set	
				{
					dtCount = value;
				}
			}

			public long? SubCount
			{
				get
				{
					return subCount;
				}
				set	
				{
					subCount = value;
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
		}
	}
}
