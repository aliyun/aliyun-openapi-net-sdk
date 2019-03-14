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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class CreateScalingTaskGroupRequest : RpcAcsRequest<CreateScalingTaskGroupResponse>
    {
        public CreateScalingTaskGroupRequest()
            : base("Emr", "2016-04-08", "CreateScalingTaskGroup", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string dataDiskCategory;

		private string clusterId;

		private int? minSize;

		private string accessKeyId;

		private string spotStrategy;

		private int? dataDiskSize;

		private List<SpotPriceLimits> spotPriceLimitss;

		private string regionId;

		private List<ScalingRule> scalingRules;

		private string activeRuleCategory;

		private int? maxSize;

		private int? dataDiskCount;

		private int? defaultCooldown;

		private string payType;

		private List<string> instanceTypeLists;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string DataDiskCategory
		{
			get
			{
				return dataDiskCategory;
			}
			set	
			{
				dataDiskCategory = value;
				DictionaryUtil.Add(QueryParameters, "DataDiskCategory", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public int? MinSize
		{
			get
			{
				return minSize;
			}
			set	
			{
				minSize = value;
				DictionaryUtil.Add(QueryParameters, "MinSize", value.ToString());
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string SpotStrategy
		{
			get
			{
				return spotStrategy;
			}
			set	
			{
				spotStrategy = value;
				DictionaryUtil.Add(QueryParameters, "SpotStrategy", value);
			}
		}

		public int? DataDiskSize
		{
			get
			{
				return dataDiskSize;
			}
			set	
			{
				dataDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "DataDiskSize", value.ToString());
			}
		}

		public List<SpotPriceLimits> SpotPriceLimitss
		{
			get
			{
				return spotPriceLimitss;
			}

			set
			{
				spotPriceLimitss = value;
				for (int i = 0; i < spotPriceLimitss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SpotPriceLimits." + (i + 1) + ".InstanceType", spotPriceLimitss[i].InstanceType);
					DictionaryUtil.Add(QueryParameters,"SpotPriceLimits." + (i + 1) + ".PriceLimit", spotPriceLimitss[i].PriceLimit);
				}
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public List<ScalingRule> ScalingRules
		{
			get
			{
				return scalingRules;
			}

			set
			{
				scalingRules = value;
				for (int i = 0; i < scalingRules.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ScalingRule." + (i + 1) + ".LaunchTime", scalingRules[i].LaunchTime);
					DictionaryUtil.Add(QueryParameters,"ScalingRule." + (i + 1) + ".RuleCategory", scalingRules[i].RuleCategory);
					DictionaryUtil.Add(QueryParameters,"ScalingRule." + (i + 1) + ".AdjustmentValue", scalingRules[i].AdjustmentValue);
					for (int j = 0; j < scalingRules[i].SchedulerTriggers.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"ScalingRule." + (i + 1) + ".SchedulerTrigger." +(j + 1), scalingRules[i].SchedulerTriggers[j]);
					}
					DictionaryUtil.Add(QueryParameters,"ScalingRule." + (i + 1) + ".AdjustmentType", scalingRules[i].AdjustmentType);
					DictionaryUtil.Add(QueryParameters,"ScalingRule." + (i + 1) + ".Cooldown", scalingRules[i].Cooldown);
					DictionaryUtil.Add(QueryParameters,"ScalingRule." + (i + 1) + ".RuleName", scalingRules[i].RuleName);
					DictionaryUtil.Add(QueryParameters,"ScalingRule." + (i + 1) + ".LaunchExpirationTime", scalingRules[i].LaunchExpirationTime);
					DictionaryUtil.Add(QueryParameters,"ScalingRule." + (i + 1) + ".RecurrenceValue", scalingRules[i].RecurrenceValue);
					DictionaryUtil.Add(QueryParameters,"ScalingRule." + (i + 1) + ".RecurrenceEndTime", scalingRules[i].RecurrenceEndTime);
					for (int j = 0; j < scalingRules[i].CloudWatchTriggers.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"ScalingRule." + (i + 1) + ".CloudWatchTrigger." +(j + 1), scalingRules[i].CloudWatchTriggers[j]);
					}
					DictionaryUtil.Add(QueryParameters,"ScalingRule." + (i + 1) + ".RecurrenceType", scalingRules[i].RecurrenceType);
				}
			}
		}

		public string ActiveRuleCategory
		{
			get
			{
				return activeRuleCategory;
			}
			set	
			{
				activeRuleCategory = value;
				DictionaryUtil.Add(QueryParameters, "ActiveRuleCategory", value);
			}
		}

		public int? MaxSize
		{
			get
			{
				return maxSize;
			}
			set	
			{
				maxSize = value;
				DictionaryUtil.Add(QueryParameters, "MaxSize", value.ToString());
			}
		}

		public int? DataDiskCount
		{
			get
			{
				return dataDiskCount;
			}
			set	
			{
				dataDiskCount = value;
				DictionaryUtil.Add(QueryParameters, "DataDiskCount", value.ToString());
			}
		}

		public int? DefaultCooldown
		{
			get
			{
				return defaultCooldown;
			}
			set	
			{
				defaultCooldown = value;
				DictionaryUtil.Add(QueryParameters, "DefaultCooldown", value.ToString());
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
				DictionaryUtil.Add(QueryParameters, "PayType", value);
			}
		}

		public List<string> InstanceTypeLists
		{
			get
			{
				return instanceTypeLists;
			}

			set
			{
				instanceTypeLists = value;
				for (int i = 0; i < instanceTypeLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceTypeList." + (i + 1) , instanceTypeLists[i]);
				}
			}
		}

		public class SpotPriceLimits
		{

			private string instanceType;

			private float? priceLimit;

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public float? PriceLimit
			{
				get
				{
					return priceLimit;
				}
				set	
				{
					priceLimit = value;
				}
			}
		}

		public class ScalingRule
		{

			private string launchTime;

			private string ruleCategory;

			private int? adjustmentValue;

			private List<SchedulerTrigger> schedulerTriggers;

			private string adjustmentType;

			private int? cooldown;

			private string ruleName;

			private int? launchExpirationTime;

			private string recurrenceValue;

			private string recurrenceEndTime;

			private List<CloudWatchTrigger> cloudWatchTriggers;

			private string recurrenceType;

			public string LaunchTime
			{
				get
				{
					return launchTime;
				}
				set	
				{
					launchTime = value;
				}
			}

			public string RuleCategory
			{
				get
				{
					return ruleCategory;
				}
				set	
				{
					ruleCategory = value;
				}
			}

			public int? AdjustmentValue
			{
				get
				{
					return adjustmentValue;
				}
				set	
				{
					adjustmentValue = value;
				}
			}

			public List<SchedulerTrigger> SchedulerTriggers
			{
				get
				{
					return schedulerTriggers;
				}
				set	
				{
					schedulerTriggers = value;
				}
			}

			public string AdjustmentType
			{
				get
				{
					return adjustmentType;
				}
				set	
				{
					adjustmentType = value;
				}
			}

			public int? Cooldown
			{
				get
				{
					return cooldown;
				}
				set	
				{
					cooldown = value;
				}
			}

			public string RuleName
			{
				get
				{
					return ruleName;
				}
				set	
				{
					ruleName = value;
				}
			}

			public int? LaunchExpirationTime
			{
				get
				{
					return launchExpirationTime;
				}
				set	
				{
					launchExpirationTime = value;
				}
			}

			public string RecurrenceValue
			{
				get
				{
					return recurrenceValue;
				}
				set	
				{
					recurrenceValue = value;
				}
			}

			public string RecurrenceEndTime
			{
				get
				{
					return recurrenceEndTime;
				}
				set	
				{
					recurrenceEndTime = value;
				}
			}

			public List<CloudWatchTrigger> CloudWatchTriggers
			{
				get
				{
					return cloudWatchTriggers;
				}
				set	
				{
					cloudWatchTriggers = value;
				}
			}

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

			public class SchedulerTrigger
			{

				private string launchTime;

				private int? launchExpirationTime;

				private string recurrenceValue;

				private string recurrenceEndTime;

				private string recurrenceType;

				public string LaunchTime
				{
					get
					{
						return launchTime;
					}
					set	
					{
						launchTime = value;
					}
				}

				public int? LaunchExpirationTime
				{
					get
					{
						return launchExpirationTime;
					}
					set	
					{
						launchExpirationTime = value;
					}
				}

				public string RecurrenceValue
				{
					get
					{
						return recurrenceValue;
					}
					set	
					{
						recurrenceValue = value;
					}
				}

				public string RecurrenceEndTime
				{
					get
					{
						return recurrenceEndTime;
					}
					set	
					{
						recurrenceEndTime = value;
					}
				}

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
			}

			public class CloudWatchTrigger
			{

				private int? period;

				private string evaluationCount;

				private string threshold;

				private string metricName;

				private string comparisonOperator;

				private string statistics;

				public int? Period
				{
					get
					{
						return period;
					}
					set	
					{
						period = value;
					}
				}

				public string EvaluationCount
				{
					get
					{
						return evaluationCount;
					}
					set	
					{
						evaluationCount = value;
					}
				}

				public string Threshold
				{
					get
					{
						return threshold;
					}
					set	
					{
						threshold = value;
					}
				}

				public string MetricName
				{
					get
					{
						return metricName;
					}
					set	
					{
						metricName = value;
					}
				}

				public string ComparisonOperator
				{
					get
					{
						return comparisonOperator;
					}
					set	
					{
						comparisonOperator = value;
					}
				}

				public string Statistics
				{
					get
					{
						return statistics;
					}
					set	
					{
						statistics = value;
					}
				}
			}
		}

        public override CreateScalingTaskGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateScalingTaskGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
