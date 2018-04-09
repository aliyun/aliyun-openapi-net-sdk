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
    public class CreateAlarmRequest : RpcAcsRequest<CreateAlarmResponse>
    {
        public CreateAlarmRequest()
            : base("Cms", "2018-03-08", "CreateAlarm", "cms", "openAPI")
        {
        }

		private string callby_cms_owner;

		private int? period;

		private string webhook;

		private string contactGroups;

		private int? endTime;

		private string threshold;

		private int? startTime;

		private string name;

		private string _namespace;

		private int? evaluationCount;

		private int? silenceTime;

		private string metricName;

		private int? notifyType;

		private string comparisonOperator;

		private string dimensions;

		private string statistics;

		public string Callby_cms_owner
		{
			get
			{
				return callby_cms_owner;
			}
			set	
			{
				callby_cms_owner = value;
				DictionaryUtil.Add(QueryParameters, "callby_cms_owner", value);
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

		public int? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
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

		public int? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value.ToString());
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

		public int? NotifyType
		{
			get
			{
				return notifyType;
			}
			set	
			{
				notifyType = value;
				DictionaryUtil.Add(QueryParameters, "NotifyType", value.ToString());
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

        public override CreateAlarmResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateAlarmResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}