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
using Aliyun.Acs.ddosbgp;
using Aliyun.Acs.ddosbgp.Transform;
using Aliyun.Acs.ddosbgp.Transform.V20180720;

namespace Aliyun.Acs.ddosbgp.Model.V20180720
{
    public class ConfigSchedruleOnDemandRequest : RpcAcsRequest<ConfigSchedruleOnDemandResponse>
    {
        public ConfigSchedruleOnDemandRequest()
            : base("ddosbgp", "2018-07-20", "ConfigSchedruleOnDemand")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ddosbgp.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ddosbgp.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string timeZone;

		private string ruleName;

		private string ruleConditionMbps;

		private string ruleAction;

		private string ruleUndoMode;

		private string ruleUndoEndTime;

		private string instanceId;

		private string ruleUndoBeginTime;

		private string ruleConditionCnt;

		private string ruleSwitch;

		private string ruleConditionKpps;

		public string TimeZone
		{
			get
			{
				return timeZone;
			}
			set	
			{
				timeZone = value;
				DictionaryUtil.Add(QueryParameters, "TimeZone", value);
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

		public string RuleConditionMbps
		{
			get
			{
				return ruleConditionMbps;
			}
			set	
			{
				ruleConditionMbps = value;
				DictionaryUtil.Add(QueryParameters, "RuleConditionMbps", value);
			}
		}

		public string RuleAction
		{
			get
			{
				return ruleAction;
			}
			set	
			{
				ruleAction = value;
				DictionaryUtil.Add(QueryParameters, "RuleAction", value);
			}
		}

		public string RuleUndoMode
		{
			get
			{
				return ruleUndoMode;
			}
			set	
			{
				ruleUndoMode = value;
				DictionaryUtil.Add(QueryParameters, "RuleUndoMode", value);
			}
		}

		public string RuleUndoEndTime
		{
			get
			{
				return ruleUndoEndTime;
			}
			set	
			{
				ruleUndoEndTime = value;
				DictionaryUtil.Add(QueryParameters, "RuleUndoEndTime", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string RuleUndoBeginTime
		{
			get
			{
				return ruleUndoBeginTime;
			}
			set	
			{
				ruleUndoBeginTime = value;
				DictionaryUtil.Add(QueryParameters, "RuleUndoBeginTime", value);
			}
		}

		public string RuleConditionCnt
		{
			get
			{
				return ruleConditionCnt;
			}
			set	
			{
				ruleConditionCnt = value;
				DictionaryUtil.Add(QueryParameters, "RuleConditionCnt", value);
			}
		}

		public string RuleSwitch
		{
			get
			{
				return ruleSwitch;
			}
			set	
			{
				ruleSwitch = value;
				DictionaryUtil.Add(QueryParameters, "RuleSwitch", value);
			}
		}

		public string RuleConditionKpps
		{
			get
			{
				return ruleConditionKpps;
			}
			set	
			{
				ruleConditionKpps = value;
				DictionaryUtil.Add(QueryParameters, "RuleConditionKpps", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ConfigSchedruleOnDemandResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConfigSchedruleOnDemandResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
