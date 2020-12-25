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
    public class CreateScalingRuleRequest : RpcAcsRequest<CreateScalingRuleResponse>
    {
        public CreateScalingRuleRequest()
            : base("Emr", "2016-04-08", "CreateScalingRule", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string ruleName;

		private string recurrenceEndTime;

		private List<CloudWatchTrigger> cloudWatchTriggers = new List<CloudWatchTrigger>(){ };

		private long? timeoutWithGrace;

		private int? cooldown;

		private string launchTime;

		private bool? withGrace;

		private string ruleCategory;

		private int? adjustmentValue;

		private string adjustmentType;

		private string clusterId;

		private int? launchExpirationTime;

		private string recurrenceValue;

		private string hostGroupId;

		private List<SchedulerTrigger> schedulerTriggers = new List<SchedulerTrigger>(){ };

		private string recurrenceType;

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

		public string RuleName
		{
			get
			{
				return ruleName;
			}
			set	
			{
				ruleName = value;
				DictionaryUtil.Add(QueryParameters, "RuleName", value);
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
				DictionaryUtil.Add(QueryParameters, "RecurrenceEndTime", value);
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
				for (int i = 0; i < cloudWatchTriggers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"CloudWatchTrigger." + (i + 1) + ".Period", cloudWatchTriggers[i].Period);
					DictionaryUtil.Add(QueryParameters,"CloudWatchTrigger." + (i + 1) + ".EvaluationCount", cloudWatchTriggers[i].EvaluationCount);
					DictionaryUtil.Add(QueryParameters,"CloudWatchTrigger." + (i + 1) + ".Threshold", cloudWatchTriggers[i].Threshold);
					DictionaryUtil.Add(QueryParameters,"CloudWatchTrigger." + (i + 1) + ".MetricName", cloudWatchTriggers[i].MetricName);
					DictionaryUtil.Add(QueryParameters,"CloudWatchTrigger." + (i + 1) + ".ComparisonOperator", cloudWatchTriggers[i].ComparisonOperator);
					DictionaryUtil.Add(QueryParameters,"CloudWatchTrigger." + (i + 1) + ".Statistics", cloudWatchTriggers[i].Statistics);
				}
			}
		}

		public long? TimeoutWithGrace
		{
			get
			{
				return timeoutWithGrace;
			}
			set	
			{
				timeoutWithGrace = value;
				DictionaryUtil.Add(QueryParameters, "TimeoutWithGrace", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Cooldown", value.ToString());
			}
		}

		public string LaunchTime
		{
			get
			{
				return launchTime;
			}
			set	
			{
				launchTime = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTime", value);
			}
		}

		public bool? WithGrace
		{
			get
			{
				return withGrace;
			}
			set	
			{
				withGrace = value;
				DictionaryUtil.Add(QueryParameters, "WithGrace", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "RuleCategory", value);
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
				DictionaryUtil.Add(QueryParameters, "AdjustmentValue", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "AdjustmentType", value);
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

		public int? LaunchExpirationTime
		{
			get
			{
				return launchExpirationTime;
			}
			set	
			{
				launchExpirationTime = value;
				DictionaryUtil.Add(QueryParameters, "LaunchExpirationTime", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "RecurrenceValue", value);
			}
		}

		public string HostGroupId
		{
			get
			{
				return hostGroupId;
			}
			set	
			{
				hostGroupId = value;
				DictionaryUtil.Add(QueryParameters, "HostGroupId", value);
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
				for (int i = 0; i < schedulerTriggers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SchedulerTrigger." + (i + 1) + ".LaunchTime", schedulerTriggers[i].LaunchTime);
					DictionaryUtil.Add(QueryParameters,"SchedulerTrigger." + (i + 1) + ".LaunchExpirationTime", schedulerTriggers[i].LaunchExpirationTime);
					DictionaryUtil.Add(QueryParameters,"SchedulerTrigger." + (i + 1) + ".RecurrenceValue", schedulerTriggers[i].RecurrenceValue);
					DictionaryUtil.Add(QueryParameters,"SchedulerTrigger." + (i + 1) + ".RecurrenceEndTime", schedulerTriggers[i].RecurrenceEndTime);
					DictionaryUtil.Add(QueryParameters,"SchedulerTrigger." + (i + 1) + ".RecurrenceType", schedulerTriggers[i].RecurrenceType);
				}
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
				DictionaryUtil.Add(QueryParameters, "RecurrenceType", value);
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

        public override CreateScalingRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateScalingRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
