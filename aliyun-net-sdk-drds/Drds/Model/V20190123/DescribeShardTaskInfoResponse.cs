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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeShardTaskInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private DescribeShardTaskInfo_Data data;

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

		public DescribeShardTaskInfo_Data Data
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

		public class DescribeShardTaskInfo_Data
		{

			private string sourceTableName;

			private string targetTableName;

			private string status;

			private string stage;

			private string progress;

			private string expired;

			private DescribeShardTaskInfo_Full full;

			private DescribeShardTaskInfo_FullCheck fullCheck;

			private DescribeShardTaskInfo_FullRevise fullRevise;

			private DescribeShardTaskInfo_Review review;

			private DescribeShardTaskInfo_Increment increment;

			public string SourceTableName
			{
				get
				{
					return sourceTableName;
				}
				set	
				{
					sourceTableName = value;
				}
			}

			public string TargetTableName
			{
				get
				{
					return targetTableName;
				}
				set	
				{
					targetTableName = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string Stage
			{
				get
				{
					return stage;
				}
				set	
				{
					stage = value;
				}
			}

			public string Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public string Expired
			{
				get
				{
					return expired;
				}
				set	
				{
					expired = value;
				}
			}

			public DescribeShardTaskInfo_Full Full
			{
				get
				{
					return full;
				}
				set	
				{
					full = value;
				}
			}

			public DescribeShardTaskInfo_FullCheck FullCheck
			{
				get
				{
					return fullCheck;
				}
				set	
				{
					fullCheck = value;
				}
			}

			public DescribeShardTaskInfo_FullRevise FullRevise
			{
				get
				{
					return fullRevise;
				}
				set	
				{
					fullRevise = value;
				}
			}

			public DescribeShardTaskInfo_Review Review
			{
				get
				{
					return review;
				}
				set	
				{
					review = value;
				}
			}

			public DescribeShardTaskInfo_Increment Increment
			{
				get
				{
					return increment;
				}
				set	
				{
					increment = value;
				}
			}

			public class DescribeShardTaskInfo_Full
			{

				private int? expired;

				private int? progress;

				private int? total;

				private int? tps;

				private string startTime;

				public int? Expired
				{
					get
					{
						return expired;
					}
					set	
					{
						expired = value;
					}
				}

				public int? Progress
				{
					get
					{
						return progress;
					}
					set	
					{
						progress = value;
					}
				}

				public int? Total
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

				public int? Tps
				{
					get
					{
						return tps;
					}
					set	
					{
						tps = value;
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
			}

			public class DescribeShardTaskInfo_FullCheck
			{

				private int? expired;

				private int? progress;

				private int? total;

				private int? tps;

				private string startTime;

				public int? Expired
				{
					get
					{
						return expired;
					}
					set	
					{
						expired = value;
					}
				}

				public int? Progress
				{
					get
					{
						return progress;
					}
					set	
					{
						progress = value;
					}
				}

				public int? Total
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

				public int? Tps
				{
					get
					{
						return tps;
					}
					set	
					{
						tps = value;
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
			}

			public class DescribeShardTaskInfo_FullRevise
			{

				private int? expired;

				private int? progress;

				private int? total;

				private int? tps;

				private string startTime;

				public int? Expired
				{
					get
					{
						return expired;
					}
					set	
					{
						expired = value;
					}
				}

				public int? Progress
				{
					get
					{
						return progress;
					}
					set	
					{
						progress = value;
					}
				}

				public int? Total
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

				public int? Tps
				{
					get
					{
						return tps;
					}
					set	
					{
						tps = value;
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
			}

			public class DescribeShardTaskInfo_Review
			{

				private int? expired;

				private int? progress;

				private int? total;

				private int? tps;

				private string startTime;

				public int? Expired
				{
					get
					{
						return expired;
					}
					set	
					{
						expired = value;
					}
				}

				public int? Progress
				{
					get
					{
						return progress;
					}
					set	
					{
						progress = value;
					}
				}

				public int? Total
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

				public int? Tps
				{
					get
					{
						return tps;
					}
					set	
					{
						tps = value;
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
			}

			public class DescribeShardTaskInfo_Increment
			{

				private int? delay;

				private int? tps;

				private string startTime;

				public int? Delay
				{
					get
					{
						return delay;
					}
					set	
					{
						delay = value;
					}
				}

				public int? Tps
				{
					get
					{
						return tps;
					}
					set	
					{
						tps = value;
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
			}
		}
	}
}
