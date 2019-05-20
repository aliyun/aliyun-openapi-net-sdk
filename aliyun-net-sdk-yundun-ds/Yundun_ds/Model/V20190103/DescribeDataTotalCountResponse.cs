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
	public class DescribeDataTotalCountResponse : AcsResponse
	{

		private string requestId;

		private DescribeDataTotalCount_DataCount dataCount;

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

		public DescribeDataTotalCount_DataCount DataCount
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

		public class DescribeDataTotalCount_DataCount
		{

			private DescribeDataTotalCount_Instance instance;

			private DescribeDataTotalCount_Table table;

			private DescribeDataTotalCount_Package package;

			private DescribeDataTotalCount_Column column;

			private DescribeDataTotalCount_Oss oss;

			public DescribeDataTotalCount_Instance Instance
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

			public DescribeDataTotalCount_Table Table
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

			public DescribeDataTotalCount_Package Package
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

			public DescribeDataTotalCount_Column Column
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

			public DescribeDataTotalCount_Oss Oss
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

			public class DescribeDataTotalCount_Instance
			{

				private long? totalCount;

				private long? count;

				private long? sensitiveCount;

				private long? lastCount;

				private long? lastSensitiveCount;

				private List<DescribeDataTotalCount_RiskCount> riskCountList;

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

				public List<DescribeDataTotalCount_RiskCount> RiskCountList
				{
					get
					{
						return riskCountList;
					}
					set	
					{
						riskCountList = value;
					}
				}

				public class DescribeDataTotalCount_RiskCount
				{

					private long? id;

					private string name;

					private long? count;

					public long? Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
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
				}
			}

			public class DescribeDataTotalCount_Table
			{

				private long? totalCount;

				private long? count;

				private long? sensitiveCount;

				private long? lastCount;

				private long? lastSensitiveCount;

				private List<DescribeDataTotalCount_RiskCount2> riskCountList1;

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

				public List<DescribeDataTotalCount_RiskCount2> RiskCountList1
				{
					get
					{
						return riskCountList1;
					}
					set	
					{
						riskCountList1 = value;
					}
				}

				public class DescribeDataTotalCount_RiskCount2
				{

					private long? id;

					private string name;

					private long? count;

					public long? Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
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
				}
			}

			public class DescribeDataTotalCount_Package
			{

				private long? totalCount;

				private long? count;

				private long? sensitiveCount;

				private long? lastCount;

				private long? lastSensitiveCount;

				private List<DescribeDataTotalCount_RiskCount4> riskCountList3;

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

				public List<DescribeDataTotalCount_RiskCount4> RiskCountList3
				{
					get
					{
						return riskCountList3;
					}
					set	
					{
						riskCountList3 = value;
					}
				}

				public class DescribeDataTotalCount_RiskCount4
				{

					private long? id;

					private string name;

					private long? count;

					public long? Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
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
				}
			}

			public class DescribeDataTotalCount_Column
			{

				private long? totalCount;

				private long? count;

				private long? sensitiveCount;

				private long? lastCount;

				private long? lastSensitiveCount;

				private List<DescribeDataTotalCount_RiskCount6> riskCountList5;

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

				public List<DescribeDataTotalCount_RiskCount6> RiskCountList5
				{
					get
					{
						return riskCountList5;
					}
					set	
					{
						riskCountList5 = value;
					}
				}

				public class DescribeDataTotalCount_RiskCount6
				{

					private long? id;

					private string name;

					private long? count;

					public long? Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
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
				}
			}

			public class DescribeDataTotalCount_Oss
			{

				private long? totalCount;

				private long? count;

				private long? sensitiveCount;

				private long? lastCount;

				private long? lastSensitiveCount;

				private List<DescribeDataTotalCount_RiskCount8> riskCountList7;

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

				public List<DescribeDataTotalCount_RiskCount8> RiskCountList7
				{
					get
					{
						return riskCountList7;
					}
					set	
					{
						riskCountList7 = value;
					}
				}

				public class DescribeDataTotalCount_RiskCount8
				{

					private long? id;

					private string name;

					private long? count;

					public long? Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
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
				}
			}
		}
	}
}
