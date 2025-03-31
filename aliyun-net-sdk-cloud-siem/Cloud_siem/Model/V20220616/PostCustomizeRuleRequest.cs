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
using Aliyun.Acs.cloud_siem.Transform;
using Aliyun.Acs.cloud_siem.Transform.V20220616;

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
    public class PostCustomizeRuleRequest : RpcAcsRequest<PostCustomizeRuleResponse>
    {
        public PostCustomizeRuleRequest()
            : base("cloud-siem", "2022-06-16", "PostCustomizeRule", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private long? roleFor;

		private string attCk;

		private string ruleDesc;

		private string ruleName;

		private string alertTypeMds;

		private string ruleThreshold;

		private string logSourceMds;

		private string logType;

		private string logTypeMds;

		private int? roleType;

		private long? id;

		private int? eventTransferSwitch;

		private string queryCycle;

		private string logSource;

		private string alertType;

		private string eventTransferType;

		private string ruleCondition;

		private string eventTransferExt;

		private string threatLevel;

		private string ruleGroup;

		public long? RoleFor
		{
			get
			{
				return roleFor;
			}
			set	
			{
				roleFor = value;
				DictionaryUtil.Add(BodyParameters, "RoleFor", value.ToString());
			}
		}

		public string AttCk
		{
			get
			{
				return attCk;
			}
			set	
			{
				attCk = value;
				DictionaryUtil.Add(BodyParameters, "AttCk", value);
			}
		}

		public string RuleDesc
		{
			get
			{
				return ruleDesc;
			}
			set	
			{
				ruleDesc = value;
				DictionaryUtil.Add(BodyParameters, "RuleDesc", value);
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
				DictionaryUtil.Add(BodyParameters, "RuleName", value);
			}
		}

		public string AlertTypeMds
		{
			get
			{
				return alertTypeMds;
			}
			set	
			{
				alertTypeMds = value;
				DictionaryUtil.Add(BodyParameters, "AlertTypeMds", value);
			}
		}

		public string RuleThreshold
		{
			get
			{
				return ruleThreshold;
			}
			set	
			{
				ruleThreshold = value;
				DictionaryUtil.Add(BodyParameters, "RuleThreshold", value);
			}
		}

		public string LogSourceMds
		{
			get
			{
				return logSourceMds;
			}
			set	
			{
				logSourceMds = value;
				DictionaryUtil.Add(BodyParameters, "LogSourceMds", value);
			}
		}

		public string LogType
		{
			get
			{
				return logType;
			}
			set	
			{
				logType = value;
				DictionaryUtil.Add(BodyParameters, "LogType", value);
			}
		}

		public string LogTypeMds
		{
			get
			{
				return logTypeMds;
			}
			set	
			{
				logTypeMds = value;
				DictionaryUtil.Add(BodyParameters, "LogTypeMds", value);
			}
		}

		public int? RoleType
		{
			get
			{
				return roleType;
			}
			set	
			{
				roleType = value;
				DictionaryUtil.Add(BodyParameters, "RoleType", value.ToString());
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(BodyParameters, "Id", value.ToString());
			}
		}

		public int? EventTransferSwitch
		{
			get
			{
				return eventTransferSwitch;
			}
			set	
			{
				eventTransferSwitch = value;
				DictionaryUtil.Add(BodyParameters, "EventTransferSwitch", value.ToString());
			}
		}

		public string QueryCycle
		{
			get
			{
				return queryCycle;
			}
			set	
			{
				queryCycle = value;
				DictionaryUtil.Add(BodyParameters, "QueryCycle", value);
			}
		}

		public string LogSource
		{
			get
			{
				return logSource;
			}
			set	
			{
				logSource = value;
				DictionaryUtil.Add(BodyParameters, "LogSource", value);
			}
		}

		public string AlertType
		{
			get
			{
				return alertType;
			}
			set	
			{
				alertType = value;
				DictionaryUtil.Add(BodyParameters, "AlertType", value);
			}
		}

		public string EventTransferType
		{
			get
			{
				return eventTransferType;
			}
			set	
			{
				eventTransferType = value;
				DictionaryUtil.Add(BodyParameters, "EventTransferType", value);
			}
		}

		public string RuleCondition
		{
			get
			{
				return ruleCondition;
			}
			set	
			{
				ruleCondition = value;
				DictionaryUtil.Add(BodyParameters, "RuleCondition", value);
			}
		}

		public string EventTransferExt
		{
			get
			{
				return eventTransferExt;
			}
			set	
			{
				eventTransferExt = value;
				DictionaryUtil.Add(BodyParameters, "EventTransferExt", value);
			}
		}

		public string ThreatLevel
		{
			get
			{
				return threatLevel;
			}
			set	
			{
				threatLevel = value;
				DictionaryUtil.Add(BodyParameters, "ThreatLevel", value);
			}
		}

		public string RuleGroup
		{
			get
			{
				return ruleGroup;
			}
			set	
			{
				ruleGroup = value;
				DictionaryUtil.Add(BodyParameters, "RuleGroup", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PostCustomizeRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PostCustomizeRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
