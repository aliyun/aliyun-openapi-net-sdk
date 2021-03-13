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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeElasticPlanResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeElasticPlan_ElasticPlanInfo> elasticPlanList;

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

		public List<DescribeElasticPlan_ElasticPlanInfo> ElasticPlanList
		{
			get
			{
				return elasticPlanList;
			}
			set	
			{
				elasticPlanList = value;
			}
		}

		public class DescribeElasticPlan_ElasticPlanInfo
		{

			private string planName;

			private string resourcePoolName;

			private int? elasticNodeNum;

			private string startTime;

			private string endTime;

			private string weeklyRepeat;

			private string startDay;

			private string endDay;

			private bool? enable;

			public string PlanName
			{
				get
				{
					return planName;
				}
				set	
				{
					planName = value;
				}
			}

			public string ResourcePoolName
			{
				get
				{
					return resourcePoolName;
				}
				set	
				{
					resourcePoolName = value;
				}
			}

			public int? ElasticNodeNum
			{
				get
				{
					return elasticNodeNum;
				}
				set	
				{
					elasticNodeNum = value;
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

			public string WeeklyRepeat
			{
				get
				{
					return weeklyRepeat;
				}
				set	
				{
					weeklyRepeat = value;
				}
			}

			public string StartDay
			{
				get
				{
					return startDay;
				}
				set	
				{
					startDay = value;
				}
			}

			public string EndDay
			{
				get
				{
					return endDay;
				}
				set	
				{
					endDay = value;
				}
			}

			public bool? Enable
			{
				get
				{
					return enable;
				}
				set	
				{
					enable = value;
				}
			}
		}
	}
}
