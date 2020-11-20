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
using Aliyun.Acs.Ess.Transform;
using Aliyun.Acs.Ess.Transform.V20140828;

namespace Aliyun.Acs.Ess.Model.V20140828
{
    public class ModifyAlarmRequest : RpcAcsRequest<ModifyAlarmResponse>
    {
        public ModifyAlarmRequest()
            : base("Ess", "2014-08-28", "ModifyAlarm", "ess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string metricType;

		private string description;

		private List<string> alarmActions = new List<string>(){ };

		private float? threshold;

		private string effective;

		private int? evaluationCount;

		private string metricName;

		private List<Dimension> dimensions = new List<Dimension>(){ };

		private int? period;

		private string resourceOwnerAccount;

		private int? groupId;

		private long? ownerId;

		private string alarmTaskId;

		private string name;

		private string comparisonOperator;

		private string statistics;

		public string MetricType
		{
			get
			{
				return metricType;
			}
			set	
			{
				metricType = value;
				DictionaryUtil.Add(QueryParameters, "MetricType", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public List<string> AlarmActions
		{
			get
			{
				return alarmActions;
			}

			set
			{
				alarmActions = value;
				for (int i = 0; i < alarmActions.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AlarmAction." + (i + 1) , alarmActions[i]);
				}
			}
		}

		public float? Threshold
		{
			get
			{
				return threshold;
			}
			set	
			{
				threshold = value;
				DictionaryUtil.Add(QueryParameters, "Threshold", value.ToString());
			}
		}

		public string Effective
		{
			get
			{
				return effective;
			}
			set	
			{
				effective = value;
				DictionaryUtil.Add(QueryParameters, "Effective", value);
			}
		}

		public int? EvaluationCount
		{
			get
			{
				return evaluationCount;
			}
			set	
			{
				evaluationCount = value;
				DictionaryUtil.Add(QueryParameters, "EvaluationCount", value.ToString());
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

		public List<Dimension> Dimensions
		{
			get
			{
				return dimensions;
			}

			set
			{
				dimensions = value;
				for (int i = 0; i < dimensions.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Dimension." + (i + 1) + ".DimensionValue", dimensions[i].DimensionValue);
					DictionaryUtil.Add(QueryParameters,"Dimension." + (i + 1) + ".DimensionKey", dimensions[i].DimensionKey);
				}
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

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

		public int? GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value.ToString());
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

		public string AlarmTaskId
		{
			get
			{
				return alarmTaskId;
			}
			set	
			{
				alarmTaskId = value;
				DictionaryUtil.Add(QueryParameters, "AlarmTaskId", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
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
				DictionaryUtil.Add(QueryParameters, "ComparisonOperator", value);
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
				DictionaryUtil.Add(QueryParameters, "Statistics", value);
			}
		}

		public class Dimension
		{

			private string dimensionValue;

			private string dimensionKey;

			public string DimensionValue
			{
				get
				{
					return dimensionValue;
				}
				set	
				{
					dimensionValue = value;
				}
			}

			public string DimensionKey
			{
				get
				{
					return dimensionKey;
				}
				set	
				{
					dimensionKey = value;
				}
			}
		}

        public override ModifyAlarmResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyAlarmResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
