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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListUserStatisticsResponse : AcsResponse
	{

		private long? total;

		private List<ListUserStatistics_UserStatistics> userStatisticsList;

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

		public List<ListUserStatistics_UserStatistics> UserStatisticsList
		{
			get
			{
				return userStatisticsList;
			}
			set	
			{
				userStatisticsList = value;
			}
		}

		public class ListUserStatistics_UserStatistics
		{

			private long? id;

			private string userId;

			private int? jobNum;

			private int? executePlanNum;

			private int? interactionJobNum;

			private int? jobMigratedNum;

			private int? executePlanMigratedNum;

			private int? interactionJobMigratedNum;

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

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public int? JobNum
			{
				get
				{
					return jobNum;
				}
				set	
				{
					jobNum = value;
				}
			}

			public int? ExecutePlanNum
			{
				get
				{
					return executePlanNum;
				}
				set	
				{
					executePlanNum = value;
				}
			}

			public int? InteractionJobNum
			{
				get
				{
					return interactionJobNum;
				}
				set	
				{
					interactionJobNum = value;
				}
			}

			public int? JobMigratedNum
			{
				get
				{
					return jobMigratedNum;
				}
				set	
				{
					jobMigratedNum = value;
				}
			}

			public int? ExecutePlanMigratedNum
			{
				get
				{
					return executePlanMigratedNum;
				}
				set	
				{
					executePlanMigratedNum = value;
				}
			}

			public int? InteractionJobMigratedNum
			{
				get
				{
					return interactionJobMigratedNum;
				}
				set	
				{
					interactionJobMigratedNum = value;
				}
			}
		}
	}
}
