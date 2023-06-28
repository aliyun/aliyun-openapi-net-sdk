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

namespace Aliyun.Acs.appstream_center.Model.V20210901
{
	public class GetAppInstanceGroupResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private GetAppInstanceGroup_AppInstanceGroupModels appInstanceGroupModels;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "TotalCount")]
		public int? TotalCount
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

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		[JsonProperty(PropertyName = "AppInstanceGroupModels")]
		public GetAppInstanceGroup_AppInstanceGroupModels AppInstanceGroupModels
		{
			get
			{
				return appInstanceGroupModels;
			}
			set	
			{
				appInstanceGroupModels = value;
			}
		}

		public class GetAppInstanceGroup_AppInstanceGroupModels
		{

			private string appCenterImageId;

			private string aliyunImageId;

			private string regionId;

			private string productType;

			private string appInstanceType;

			private string appInstanceGroupId;

			private string cpu;

			private string gpu;

			private long? memory;

			private int? amount;

			private int? minAmount;

			private int? maxAmount;

			private string chargeType;

			private string gmtCreate;

			private string status;

			private string specId;

			private string sessionTimeout;

			private string appInstanceGroupName;

			private string expiredTime;

			private string osType;

			private string appCenterImageName;

			private string resourceStatus;

			private List<GetAppInstanceGroup_AppsItem> apps;

			private List<GetAppInstanceGroup_Node> nodePool;

			private GetAppInstanceGroup_OtaInfo otaInfo;

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
				}
			}

			[JsonProperty(PropertyName = "AliyunImageId")]
			public string AliyunImageId
			{
				get
				{
					return aliyunImageId;
				}
				set	
				{
					aliyunImageId = value;
				}
			}

			[JsonProperty(PropertyName = "RegionId")]
			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
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
				}
			}

			[JsonProperty(PropertyName = "AppInstanceType")]
			public string AppInstanceType
			{
				get
				{
					return appInstanceType;
				}
				set	
				{
					appInstanceType = value;
				}
			}

			[JsonProperty(PropertyName = "AppInstanceGroupId")]
			public string AppInstanceGroupId
			{
				get
				{
					return appInstanceGroupId;
				}
				set	
				{
					appInstanceGroupId = value;
				}
			}

			[JsonProperty(PropertyName = "Cpu")]
			public string Cpu
			{
				get
				{
					return cpu;
				}
				set	
				{
					cpu = value;
				}
			}

			[JsonProperty(PropertyName = "Gpu")]
			public string Gpu
			{
				get
				{
					return gpu;
				}
				set	
				{
					gpu = value;
				}
			}

			[JsonProperty(PropertyName = "Memory")]
			public long? Memory
			{
				get
				{
					return memory;
				}
				set	
				{
					memory = value;
				}
			}

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

			[JsonProperty(PropertyName = "MinAmount")]
			public int? MinAmount
			{
				get
				{
					return minAmount;
				}
				set	
				{
					minAmount = value;
				}
			}

			[JsonProperty(PropertyName = "MaxAmount")]
			public int? MaxAmount
			{
				get
				{
					return maxAmount;
				}
				set	
				{
					maxAmount = value;
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
				}
			}

			[JsonProperty(PropertyName = "GmtCreate")]
			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "SpecId")]
			public string SpecId
			{
				get
				{
					return specId;
				}
				set	
				{
					specId = value;
				}
			}

			[JsonProperty(PropertyName = "SessionTimeout")]
			public string SessionTimeout
			{
				get
				{
					return sessionTimeout;
				}
				set	
				{
					sessionTimeout = value;
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
				}
			}

			[JsonProperty(PropertyName = "ExpiredTime")]
			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			[JsonProperty(PropertyName = "OsType")]
			public string OsType
			{
				get
				{
					return osType;
				}
				set	
				{
					osType = value;
				}
			}

			[JsonProperty(PropertyName = "AppCenterImageName")]
			public string AppCenterImageName
			{
				get
				{
					return appCenterImageName;
				}
				set	
				{
					appCenterImageName = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceStatus")]
			public string ResourceStatus
			{
				get
				{
					return resourceStatus;
				}
				set	
				{
					resourceStatus = value;
				}
			}

			[JsonProperty(PropertyName = "Apps")]
			public List<GetAppInstanceGroup_AppsItem> Apps
			{
				get
				{
					return apps;
				}
				set	
				{
					apps = value;
				}
			}

			[JsonProperty(PropertyName = "NodePool")]
			public List<GetAppInstanceGroup_Node> NodePool
			{
				get
				{
					return nodePool;
				}
				set	
				{
					nodePool = value;
				}
			}

			[JsonProperty(PropertyName = "OtaInfo")]
			public GetAppInstanceGroup_OtaInfo OtaInfo
			{
				get
				{
					return otaInfo;
				}
				set	
				{
					otaInfo = value;
				}
			}

			public class GetAppInstanceGroup_AppsItem
			{

				private string appId;

				private string appName;

				[JsonProperty(PropertyName = "AppId")]
				public string AppId
				{
					get
					{
						return appId;
					}
					set	
					{
						appId = value;
					}
				}

				[JsonProperty(PropertyName = "AppName")]
				public string AppName
				{
					get
					{
						return appName;
					}
					set	
					{
						appName = value;
					}
				}
			}

			public class GetAppInstanceGroup_Node
			{

				private string nodePoolId;

				private string nodeInstanceType;

				private int? nodeAmount;

				private int? nodeUsed;

				private int? nodeCapacity;

				private int? scalingNodeAmount;

				private int? scalingNodeUsed;

				private string strategyType;

				private int? amount;

				private int? maxScalingAmount;

				private int? scalingStep;

				private string scalingUsageThreshold;

				private int? scalingDownAfterIdleMinutes;

				private string strategyDisableDate;

				private string strategyEnableDate;

				private bool? warmUp;

				private string nodeTypeName;

				private List<GetAppInstanceGroup_RecurrenceSchedule> recurrenceSchedules;

				[JsonProperty(PropertyName = "NodePoolId")]
				public string NodePoolId
				{
					get
					{
						return nodePoolId;
					}
					set	
					{
						nodePoolId = value;
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

				[JsonProperty(PropertyName = "NodeUsed")]
				public int? NodeUsed
				{
					get
					{
						return nodeUsed;
					}
					set	
					{
						nodeUsed = value;
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

				[JsonProperty(PropertyName = "ScalingNodeAmount")]
				public int? ScalingNodeAmount
				{
					get
					{
						return scalingNodeAmount;
					}
					set	
					{
						scalingNodeAmount = value;
					}
				}

				[JsonProperty(PropertyName = "ScalingNodeUsed")]
				public int? ScalingNodeUsed
				{
					get
					{
						return scalingNodeUsed;
					}
					set	
					{
						scalingNodeUsed = value;
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

				[JsonProperty(PropertyName = "NodeTypeName")]
				public string NodeTypeName
				{
					get
					{
						return nodeTypeName;
					}
					set	
					{
						nodeTypeName = value;
					}
				}

				[JsonProperty(PropertyName = "RecurrenceSchedules")]
				public List<GetAppInstanceGroup_RecurrenceSchedule> RecurrenceSchedules
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

				public class GetAppInstanceGroup_RecurrenceSchedule
				{

					private string recurrenceType;

					private List<GetAppInstanceGroup_TimerPeriod> timerPeriods;

					private List<string> recurrenceValues;

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
					public List<GetAppInstanceGroup_TimerPeriod> TimerPeriods
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

					[JsonProperty(PropertyName = "RecurrenceValues")]
					public List<string> RecurrenceValues
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

					public class GetAppInstanceGroup_TimerPeriod
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

			public class GetAppInstanceGroup_OtaInfo
			{

				private string otaVersion;

				private string newOtaVersion;

				private string taskId;

				[JsonProperty(PropertyName = "OtaVersion")]
				public string OtaVersion
				{
					get
					{
						return otaVersion;
					}
					set	
					{
						otaVersion = value;
					}
				}

				[JsonProperty(PropertyName = "NewOtaVersion")]
				public string NewOtaVersion
				{
					get
					{
						return newOtaVersion;
					}
					set	
					{
						newOtaVersion = value;
					}
				}

				[JsonProperty(PropertyName = "TaskId")]
				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
					}
				}
			}
		}
	}
}
