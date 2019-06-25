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
using Aliyun.Acs.Ess.Transform;
using Aliyun.Acs.Ess.Transform.V20140828;

namespace Aliyun.Acs.Ess.Model.V20140828
{
    public class CreateScalingRuleRequest : RpcAcsRequest<CreateScalingRuleResponse>
    {
        public CreateScalingRuleRequest()
            : base("Ess", "2014-08-28", "CreateScalingRule", "ess", "openAPI")
        {
        }

		private string resourceOwnerAccount;

		private int? adjustmentValue;

		private List<StepAdjustment> stepAdjustments;

		private string scalingGroupId;

		private int? estimatedInstanceWarmup;

		private string ownerAccount;

		private int? predictiveTaskBufferTime;

		private string adjustmentType;

		private bool? disableScaleIn;

		private long? ownerId;

		private int? initialMaxSize;

		private int? predictiveValueBuffer;

		private string scalingRuleName;

		private int? cooldown;

		private int? minAdjustmentMagnitude;

		private string predictiveValueBehavior;

		private float? targetValue;

		private string scalingRuleType;

		private string metricName;

		private string predictiveScalingMode;

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
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

		public List<StepAdjustment> StepAdjustments
		{
			get
			{
				return stepAdjustments;
			}

			set
			{
				stepAdjustments = value;
				for (int i = 0; i < stepAdjustments.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"StepAdjustment." + (i + 1) + ".MetricIntervalLowerBound", stepAdjustments[i].MetricIntervalLowerBound);
					DictionaryUtil.Add(QueryParameters,"StepAdjustment." + (i + 1) + ".MetricIntervalUpperBound", stepAdjustments[i].MetricIntervalUpperBound);
					DictionaryUtil.Add(QueryParameters,"StepAdjustment." + (i + 1) + ".ScalingAdjustment", stepAdjustments[i].ScalingAdjustment);
				}
			}
		}

		public string ScalingGroupId
		{
			get
			{
				return scalingGroupId;
			}
			set	
			{
				scalingGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId", value);
			}
		}

		public int? EstimatedInstanceWarmup
		{
			get
			{
				return estimatedInstanceWarmup;
			}
			set	
			{
				estimatedInstanceWarmup = value;
				DictionaryUtil.Add(QueryParameters, "EstimatedInstanceWarmup", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public int? PredictiveTaskBufferTime
		{
			get
			{
				return predictiveTaskBufferTime;
			}
			set	
			{
				predictiveTaskBufferTime = value;
				DictionaryUtil.Add(QueryParameters, "PredictiveTaskBufferTime", value.ToString());
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

		public bool? DisableScaleIn
		{
			get
			{
				return disableScaleIn;
			}
			set	
			{
				disableScaleIn = value;
				DictionaryUtil.Add(QueryParameters, "DisableScaleIn", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public int? InitialMaxSize
		{
			get
			{
				return initialMaxSize;
			}
			set	
			{
				initialMaxSize = value;
				DictionaryUtil.Add(QueryParameters, "InitialMaxSize", value.ToString());
			}
		}

		public int? PredictiveValueBuffer
		{
			get
			{
				return predictiveValueBuffer;
			}
			set	
			{
				predictiveValueBuffer = value;
				DictionaryUtil.Add(QueryParameters, "PredictiveValueBuffer", value.ToString());
			}
		}

		public string ScalingRuleName
		{
			get
			{
				return scalingRuleName;
			}
			set	
			{
				scalingRuleName = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleName", value);
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

		public int? MinAdjustmentMagnitude
		{
			get
			{
				return minAdjustmentMagnitude;
			}
			set	
			{
				minAdjustmentMagnitude = value;
				DictionaryUtil.Add(QueryParameters, "MinAdjustmentMagnitude", value.ToString());
			}
		}

		public string PredictiveValueBehavior
		{
			get
			{
				return predictiveValueBehavior;
			}
			set	
			{
				predictiveValueBehavior = value;
				DictionaryUtil.Add(QueryParameters, "PredictiveValueBehavior", value);
			}
		}

		public float? TargetValue
		{
			get
			{
				return targetValue;
			}
			set	
			{
				targetValue = value;
				DictionaryUtil.Add(QueryParameters, "TargetValue", value.ToString());
			}
		}

		public string ScalingRuleType
		{
			get
			{
				return scalingRuleType;
			}
			set	
			{
				scalingRuleType = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleType", value);
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
				DictionaryUtil.Add(QueryParameters, "MetricName", value);
			}
		}

		public string PredictiveScalingMode
		{
			get
			{
				return predictiveScalingMode;
			}
			set	
			{
				predictiveScalingMode = value;
				DictionaryUtil.Add(QueryParameters, "PredictiveScalingMode", value);
			}
		}

		public class StepAdjustment
		{

			private float? metricIntervalLowerBound;

			private float? metricIntervalUpperBound;

			private int? scalingAdjustment;

			public float? MetricIntervalLowerBound
			{
				get
				{
					return metricIntervalLowerBound;
				}
				set	
				{
					metricIntervalLowerBound = value;
				}
			}

			public float? MetricIntervalUpperBound
			{
				get
				{
					return metricIntervalUpperBound;
				}
				set	
				{
					metricIntervalUpperBound = value;
				}
			}

			public int? ScalingAdjustment
			{
				get
				{
					return scalingAdjustment;
				}
				set	
				{
					scalingAdjustment = value;
				}
			}
		}

        public override CreateScalingRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateScalingRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
