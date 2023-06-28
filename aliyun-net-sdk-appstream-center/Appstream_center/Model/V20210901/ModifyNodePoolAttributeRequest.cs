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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.appstream_center;
using Aliyun.Acs.appstream_center.Transform;
using Aliyun.Acs.appstream_center.Transform.V20210901;

namespace Aliyun.Acs.appstream_center.Model.V20210901
{
    public class ModifyNodePoolAttributeRequest : RpcAcsRequest<ModifyNodePoolAttributeResponse>
    {
        public ModifyNodePoolAttributeRequest()
            : base("appstream-center", "2021-09-01", "ModifyNodePoolAttribute")
        {
			Method = MethodType.POST;
        }

		private string bizRegionId;

		private string productType;

		private string poolId;

		private NodePoolStrategy nodePoolStrategy_;

		private int? nodeCapacity;

		[JsonProperty(PropertyName = "BizRegionId")]
		public string BizRegionId
		{
			get
			{
				return bizRegionId;
			}
			set	
			{
				bizRegionId = value;
				DictionaryUtil.Add(BodyParameters, "BizRegionId", value);
			}
		}

		[JsonProperty(PropertyName = "ProductType")]
		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(BodyParameters, "ProductType", value);
			}
		}

		[JsonProperty(PropertyName = "PoolId")]
		public string PoolId
		{
			get
			{
				return poolId;
			}
			set	
			{
				poolId = value;
				DictionaryUtil.Add(BodyParameters, "PoolId", value);
			}
		}

		[JsonProperty(PropertyName = "NodePoolStrategy")]
		public NodePoolStrategy NodePoolStrategy_
		{
			get
			{
				return nodePoolStrategy_;
			}

			set
			{
				nodePoolStrategy_ = value;
				DictionaryUtil.Add(BodyParameters, "NodePoolStrategy", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "NodeCapacity")]
		public int? NodeCapacity
		{
			get
			{
				return nodeCapacity;
			}
			set	
			{
				nodeCapacity = value;
				DictionaryUtil.Add(BodyParameters, "NodeCapacity", value.ToString());
			}
		}

		public class NodePoolStrategy
		{

			private List<RecurrenceSchedulesItem> recurrenceSchedules = new List<RecurrenceSchedulesItem>(){ };

			private int? scalingStep;

			private string strategyDisableDate;

			private int? scalingDownAfterIdleMinutes;

			private string strategyType;

			private int? maxScalingAmount;

			private bool? warmUp;

			private string scalingUsageThreshold;

			private string strategyEnableDate;

			[JsonProperty(PropertyName = "RecurrenceSchedules")]
			public List<RecurrenceSchedulesItem> RecurrenceSchedules
			{
				get
				{
					return recurrenceSchedules;
				}
				set	
				{
					recurrenceSchedules = value;
				}
			}

			[JsonProperty(PropertyName = "ScalingStep")]
			public int? ScalingStep
			{
				get
				{
					return scalingStep;
				}
				set	
				{
					scalingStep = value;
				}
			}

			[JsonProperty(PropertyName = "StrategyDisableDate")]
			public string StrategyDisableDate
			{
				get
				{
					return strategyDisableDate;
				}
				set	
				{
					strategyDisableDate = value;
				}
			}

			[JsonProperty(PropertyName = "ScalingDownAfterIdleMinutes")]
			public int? ScalingDownAfterIdleMinutes
			{
				get
				{
					return scalingDownAfterIdleMinutes;
				}
				set	
				{
					scalingDownAfterIdleMinutes = value;
				}
			}

			[JsonProperty(PropertyName = "StrategyType")]
			public string StrategyType
			{
				get
				{
					return strategyType;
				}
				set	
				{
					strategyType = value;
				}
			}

			[JsonProperty(PropertyName = "MaxScalingAmount")]
			public int? MaxScalingAmount
			{
				get
				{
					return maxScalingAmount;
				}
				set	
				{
					maxScalingAmount = value;
				}
			}

			[JsonProperty(PropertyName = "WarmUp")]
			public bool? WarmUp
			{
				get
				{
					return warmUp;
				}
				set	
				{
					warmUp = value;
				}
			}

			[JsonProperty(PropertyName = "ScalingUsageThreshold")]
			public string ScalingUsageThreshold
			{
				get
				{
					return scalingUsageThreshold;
				}
				set	
				{
					scalingUsageThreshold = value;
				}
			}

			[JsonProperty(PropertyName = "StrategyEnableDate")]
			public string StrategyEnableDate
			{
				get
				{
					return strategyEnableDate;
				}
				set	
				{
					strategyEnableDate = value;
				}
			}

			public class RecurrenceSchedulesItem
			{

				private List<int?> recurrenceValues = new List<int?>(){ };

				private string recurrenceType;

				private List<TimerPeriodsItem> timerPeriods = new List<TimerPeriodsItem>(){ };

				[JsonProperty(PropertyName = "RecurrenceValues")]
				public List<int?> RecurrenceValues
				{
					get
					{
						return recurrenceValues;
					}
					set	
					{
						recurrenceValues = value;
					}
				}

				[JsonProperty(PropertyName = "RecurrenceType")]
				public string RecurrenceType
				{
					get
					{
						return recurrenceType;
					}
					set	
					{
						recurrenceType = value;
					}
				}

				[JsonProperty(PropertyName = "TimerPeriods")]
				public List<TimerPeriodsItem> TimerPeriods
				{
					get
					{
						return timerPeriods;
					}
					set	
					{
						timerPeriods = value;
					}
				}

				public class TimerPeriodsItem
				{

					private int? amount;

					private string endTime;

					private string startTime;

					[JsonProperty(PropertyName = "Amount")]
					public int? Amount
					{
						get
						{
							return amount;
						}
						set	
						{
							amount = value;
						}
					}

					[JsonProperty(PropertyName = "EndTime")]
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

					[JsonProperty(PropertyName = "StartTime")]
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyNodePoolAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyNodePoolAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
