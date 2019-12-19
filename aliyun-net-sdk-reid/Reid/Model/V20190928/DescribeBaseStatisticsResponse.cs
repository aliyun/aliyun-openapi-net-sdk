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

namespace Aliyun.Acs.reid.Model.V20190928
{
	public class DescribeBaseStatisticsResponse : AcsResponse
	{

		private string errorCode;

		private string cursorTime;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private List<DescribeBaseStatistics_BaseStatisticsItem> baseStatistics;

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string CursorTime
		{
			get
			{
				return cursorTime;
			}
			set	
			{
				cursorTime = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<DescribeBaseStatistics_BaseStatisticsItem> BaseStatistics
		{
			get
			{
				return baseStatistics;
			}
			set	
			{
				baseStatistics = value;
			}
		}

		public class DescribeBaseStatistics_BaseStatisticsItem
		{

			private long? storeId;

			private int? femaleUvCount;

			private int? oldCount;

			private int? newCount;

			private string summaryType;

			private int? maleUvCount;

			private string time;

			private long? locationId;

			private long? stayPeriod;

			private int? uvCount;

			private int? onlyBodyUvCount;

			private List<DescribeBaseStatistics_AgeItem> ageItems;

			private List<DescribeBaseStatistics_StayDistributionItem> stayDistributionItems;

			private List<DescribeBaseStatistics_AgeItem> maleAgeItems;

			private List<DescribeBaseStatistics_AgeItem> femaleAgeItems;

			public long? StoreId
			{
				get
				{
					return storeId;
				}
				set	
				{
					storeId = value;
				}
			}

			public int? FemaleUvCount
			{
				get
				{
					return femaleUvCount;
				}
				set	
				{
					femaleUvCount = value;
				}
			}

			public int? OldCount
			{
				get
				{
					return oldCount;
				}
				set	
				{
					oldCount = value;
				}
			}

			public int? NewCount
			{
				get
				{
					return newCount;
				}
				set	
				{
					newCount = value;
				}
			}

			public string SummaryType
			{
				get
				{
					return summaryType;
				}
				set	
				{
					summaryType = value;
				}
			}

			public int? MaleUvCount
			{
				get
				{
					return maleUvCount;
				}
				set	
				{
					maleUvCount = value;
				}
			}

			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public long? LocationId
			{
				get
				{
					return locationId;
				}
				set	
				{
					locationId = value;
				}
			}

			public long? StayPeriod
			{
				get
				{
					return stayPeriod;
				}
				set	
				{
					stayPeriod = value;
				}
			}

			public int? UvCount
			{
				get
				{
					return uvCount;
				}
				set	
				{
					uvCount = value;
				}
			}

			public int? OnlyBodyUvCount
			{
				get
				{
					return onlyBodyUvCount;
				}
				set	
				{
					onlyBodyUvCount = value;
				}
			}

			public List<DescribeBaseStatistics_AgeItem> AgeItems
			{
				get
				{
					return ageItems;
				}
				set	
				{
					ageItems = value;
				}
			}

			public List<DescribeBaseStatistics_StayDistributionItem> StayDistributionItems
			{
				get
				{
					return stayDistributionItems;
				}
				set	
				{
					stayDistributionItems = value;
				}
			}

			public List<DescribeBaseStatistics_AgeItem> MaleAgeItems
			{
				get
				{
					return maleAgeItems;
				}
				set	
				{
					maleAgeItems = value;
				}
			}

			public List<DescribeBaseStatistics_AgeItem> FemaleAgeItems
			{
				get
				{
					return femaleAgeItems;
				}
				set	
				{
					femaleAgeItems = value;
				}
			}

			public class DescribeBaseStatistics_AgeItem
			{

				private string name;

				private int? count;

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

				public int? Count
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

			public class DescribeBaseStatistics_StayDistributionItem
			{

				private long? startTs;

				private long? endTs;

				private int? count;

				public long? StartTs
				{
					get
					{
						return startTs;
					}
					set	
					{
						startTs = value;
					}
				}

				public long? EndTs
				{
					get
					{
						return endTs;
					}
					set	
					{
						endTs = value;
					}
				}

				public int? Count
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
