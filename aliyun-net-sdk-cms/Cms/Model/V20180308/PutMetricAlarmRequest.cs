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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class PutMetricAlarmRequest : RpcAcsRequest<PutMetricAlarmResponse>
    {
        public PutMetricAlarmRequest()
            : base("Cms", "2018-03-08", "PutMetricAlarm", "cms", "openAPI")
        {
        }

		private string period;

		private string webhook;

		private string contactGroups;

		private int? level;

		private string subject;

		private string alertName;

		private string groupId;

		private string description;

		private string resources;

		private string threshold;

		private string effectiveInterval;

		private string groupName;

		private string filter;

		private string noEffectiveInterval;

		private string displayName;

		private string _namespace;

		private int? evaluationCount;

		private int? silenceTime;

		private string interval;

		private string metricName;

		private string deepDive;

		private string comparisonOperator;

		private string dimensions;

		private string statistics;

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value);
			}
		}

		public string Webhook
		{
			get
			{
				return webhook;
			}
			set	
			{
				webhook = value;
				DictionaryUtil.Add(QueryParameters, "Webhook", value);
			}
		}

		public string ContactGroups
		{
			get
			{
				return contactGroups;
			}
			set	
			{
				contactGroups = value;
				DictionaryUtil.Add(QueryParameters, "ContactGroups", value);
			}
		}

		public int? Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
				DictionaryUtil.Add(QueryParameters, "Level", value.ToString());
			}
		}

		public string Subject
		{
			get
			{
				return subject;
			}
			set	
			{
				subject = value;
				DictionaryUtil.Add(QueryParameters, "Subject", value);
			}
		}

		public string AlertName
		{
			get
			{
				return alertName;
			}
			set	
			{
				alertName = value;
				DictionaryUtil.Add(QueryParameters, "AlertName", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
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

		public string Resources
		{
			get
			{
				return resources;
			}
			set	
			{
				resources = value;
				DictionaryUtil.Add(QueryParameters, "Resources", value);
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
				DictionaryUtil.Add(QueryParameters, "Threshold", value);
			}
		}

		public string EffectiveInterval
		{
			get
			{
				return effectiveInterval;
			}
			set	
			{
				effectiveInterval = value;
				DictionaryUtil.Add(QueryParameters, "EffectiveInterval", value);
			}
		}

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
				DictionaryUtil.Add(QueryParameters, "GroupName", value);
			}
		}

		public string Filter
		{
			get
			{
				return filter;
			}
			set	
			{
				filter = value;
				DictionaryUtil.Add(QueryParameters, "Filter", value);
			}
		}

		public string NoEffectiveInterval
		{
			get
			{
				return noEffectiveInterval;
			}
			set	
			{
				noEffectiveInterval = value;
				DictionaryUtil.Add(QueryParameters, "NoEffectiveInterval", value);
			}
		}

		public string DisplayName
		{
			get
			{
				return displayName;
			}
			set	
			{
				displayName = value;
				DictionaryUtil.Add(QueryParameters, "DisplayName", value);
			}
		}

		public string _Namespace
		{
			get
			{
				return _namespace;
			}
			set	
			{
				_namespace = value;
				DictionaryUtil.Add(QueryParameters, "Namespace", value);
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

		public int? SilenceTime
		{
			get
			{
				return silenceTime;
			}
			set	
			{
				silenceTime = value;
				DictionaryUtil.Add(QueryParameters, "SilenceTime", value.ToString());
			}
		}

		public string Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value);
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

		public string DeepDive
		{
			get
			{
				return deepDive;
			}
			set	
			{
				deepDive = value;
				DictionaryUtil.Add(QueryParameters, "DeepDive", value);
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

		public string Dimensions
		{
			get
			{
				return dimensions;
			}
			set	
			{
				dimensions = value;
				DictionaryUtil.Add(QueryParameters, "Dimensions", value);
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

        public override PutMetricAlarmResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return PutMetricAlarmResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}