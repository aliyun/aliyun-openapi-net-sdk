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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeElasticDailyPlanResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeElasticDailyPlan_ElasticDailyPlanInfo> elasticDailyPlanList;

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

		public List<DescribeElasticDailyPlan_ElasticDailyPlanInfo> ElasticDailyPlanList
		{
			get
			{
				return elasticDailyPlanList;
			}
			set	
			{
				elasticDailyPlanList = value;
			}
		}

		public class DescribeElasticDailyPlan_ElasticDailyPlanInfo
		{

			private int? status;

			private string day;

			private string resourcePoolName;

			private string startTs;

			private string planEndTs;

			private string planStartTs;

			private int? elasticNodeNum;

			private string endTs;

			private string planName;

			private string elasticPlanType;

			private string elasticPlanWorkerSpec;

			public int? Status
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

			public string Day
			{
				get
				{
					return day;
				}
				set	
				{
					day = value;
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

			public string StartTs
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

			public string PlanEndTs
			{
				get
				{
					return planEndTs;
				}
				set	
				{
					planEndTs = value;
				}
			}

			public string PlanStartTs
			{
				get
				{
					return planStartTs;
				}
				set	
				{
					planStartTs = value;
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

			public string EndTs
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

			public string ElasticPlanType
			{
				get
				{
					return elasticPlanType;
				}
				set	
				{
					elasticPlanType = value;
				}
			}

			public string ElasticPlanWorkerSpec
			{
				get
				{
					return elasticPlanWorkerSpec;
				}
				set	
				{
					elasticPlanWorkerSpec = value;
				}
			}
		}
	}
}
