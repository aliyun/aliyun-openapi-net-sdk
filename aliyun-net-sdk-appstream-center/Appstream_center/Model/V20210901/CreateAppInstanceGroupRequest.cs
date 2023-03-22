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
    public class CreateAppInstanceGroupRequest : RpcAcsRequest<CreateAppInstanceGroupResponse>
    {
        public CreateAppInstanceGroupRequest()
            : base("appstream-center", "2021-09-01", "CreateAppInstanceGroup")
        {
			Method = MethodType.POST;
        }

		private RuntimePolicy runtimePolicy_;

		private string bizRegionId;

		private string productType;

		private Network network_;

		private int? sessionTimeout;

		private string chargeResourceMode;

		private string appCenterImageId;

		private UserInfo userInfo_;

		private string preOpenAppId;

		private int? period;

		private bool? autoPay;

		private NodePool nodePool_;

		private string promotionId;

		private List<string> userss = new List<string>(){ };

		private string appInstanceGroupName;

		private string periodUnit;

		private bool? autoRenew;

		private string chargeType;

		[JsonProperty(PropertyName = "RuntimePolicy")]
		public RuntimePolicy RuntimePolicy_
		{
			get
			{
				return runtimePolicy_;
			}

			set
			{
				runtimePolicy_ = value;
				DictionaryUtil.Add(BodyParameters, "RuntimePolicy", JsonConvert.SerializeObject(value));

			}
		}

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

		[JsonProperty(PropertyName = "Network")]
		public Network Network_
		{
			get
			{
				return network_;
			}

			set
			{
				network_ = value;
				DictionaryUtil.Add(BodyParameters, "Network", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "SessionTimeout")]
		public int? SessionTimeout
		{
			get
			{
				return sessionTimeout;
			}
			set	
			{
				sessionTimeout = value;
				DictionaryUtil.Add(BodyParameters, "SessionTimeout", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ChargeResourceMode")]
		public string ChargeResourceMode
		{
			get
			{
				return chargeResourceMode;
			}
			set	
			{
				chargeResourceMode = value;
				DictionaryUtil.Add(BodyParameters, "ChargeResourceMode", value);
			}
		}

		[JsonProperty(PropertyName = "AppCenterImageId")]
		public string AppCenterImageId
		{
			get
			{
				return appCenterImageId;
			}
			set	
			{
				appCenterImageId = value;
				DictionaryUtil.Add(BodyParameters, "AppCenterImageId", value);
			}
		}

		[JsonProperty(PropertyName = "UserInfo")]
		public UserInfo UserInfo_
		{
			get
			{
				return userInfo_;
			}

			set
			{
				userInfo_ = value;
				DictionaryUtil.Add(BodyParameters, "UserInfo", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "PreOpenAppId")]
		public string PreOpenAppId
		{
			get
			{
				return preOpenAppId;
			}
			set	
			{
				preOpenAppId = value;
				DictionaryUtil.Add(BodyParameters, "PreOpenAppId", value);
			}
		}

		[JsonProperty(PropertyName = "Period")]
		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(BodyParameters, "Period", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AutoPay")]
		public bool? AutoPay
		{
			get
			{
				return autoPay;
			}
			set	
			{
				autoPay = value;
				DictionaryUtil.Add(BodyParameters, "AutoPay", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "NodePool")]
		public NodePool NodePool_
		{
			get
			{
				return nodePool_;
			}

			set
			{
				nodePool_ = value;
				DictionaryUtil.Add(BodyParameters, "NodePool", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "PromotionId")]
		public string PromotionId
		{
			get
			{
				return promotionId;
			}
			set	
			{
				promotionId = value;
				DictionaryUtil.Add(BodyParameters, "PromotionId", value);
			}
		}

		[JsonProperty(PropertyName = "Users")]
		public List<string> Userss
		{
			get
			{
				return userss;
			}

			set
			{
				userss = value;
			}
		}

		[JsonProperty(PropertyName = "AppInstanceGroupName")]
		public string AppInstanceGroupName
		{
			get
			{
				return appInstanceGroupName;
			}
			set	
			{
				appInstanceGroupName = value;
				DictionaryUtil.Add(BodyParameters, "AppInstanceGroupName", value);
			}
		}

		[JsonProperty(PropertyName = "PeriodUnit")]
		public string PeriodUnit
		{
			get
			{
				return periodUnit;
			}
			set	
			{
				periodUnit = value;
				DictionaryUtil.Add(BodyParameters, "PeriodUnit", value);
			}
		}

		[JsonProperty(PropertyName = "AutoRenew")]
		public bool? AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(BodyParameters, "AutoRenew", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ChargeType")]
		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
				DictionaryUtil.Add(BodyParameters, "ChargeType", value);
			}
		}

		public class RuntimePolicy
		{

			private string sessionType;

			private string debugMode;

			[JsonProperty(PropertyName = "SessionType")]
			public string SessionType
			{
				get
				{
					return sessionType;
				}
				set	
				{
					sessionType = value;
				}
			}

			[JsonProperty(PropertyName = "DebugMode")]
			public string DebugMode
			{
				get
				{
					return debugMode;
				}
				set	
				{
					debugMode = value;
				}
			}
		}

		public class Network
		{

			private List<RoutesItem> routes = new List<RoutesItem>(){ };

			private string strategyType;

			[JsonProperty(PropertyName = "Routes")]
			public List<RoutesItem> Routes
			{
				get
				{
					return routes;
				}
				set	
				{
					routes = value;
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

			public class RoutesItem
			{

				private string mode;

				private string destination;

				[JsonProperty(PropertyName = "Mode")]
				public string Mode
				{
					get
					{
						return mode;
					}
					set	
					{
						mode = value;
					}
				}

				[JsonProperty(PropertyName = "Destination")]
				public string Destination
				{
					get
					{
						return destination;
					}
					set	
					{
						destination = value;
					}
				}
			}
		}

		public class UserInfo
		{

			private string type;

			[JsonProperty(PropertyName = "Type")]
			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}
		}

		public class NodePool
		{

			private List<RecurrenceSchedulesItem> recurrenceSchedules = new List<RecurrenceSchedulesItem>(){ };

			private int? nodeAmount;

			private int? scalingStep;

			private string strategyDisableDate;

			private string nodeInstanceType;

			private int? scalingDownAfterIdleMinutes;

			private string strategyType;

			private int? maxScalingAmount;

			private bool? warmUp;

			private string scalingUsageThreshold;

			private int? nodeCapacity;

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

			[JsonProperty(PropertyName = "NodeAmount")]
			public int? NodeAmount
			{
				get
				{
					return nodeAmount;
				}
				set	
				{
					nodeAmount = value;
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

			[JsonProperty(PropertyName = "NodeInstanceType")]
			public string NodeInstanceType
			{
				get
				{
					return nodeInstanceType;
				}
				set	
				{
					nodeInstanceType = value;
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

        public override CreateAppInstanceGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAppInstanceGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
