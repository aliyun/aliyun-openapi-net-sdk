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
using Aliyun.Acs.Trademark.Transform;
using Aliyun.Acs.Trademark.Transform.V20180724;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
    public class InsertTmMonitorRuleRequest : RpcAcsRequest<InsertTmMonitorRuleResponse>
    {
        public InsertTmMonitorRuleRequest()
            : base("Trademark", "2018-07-24", "InsertTmMonitorRule", "trademark", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string startApplyDate;

		private int? ruleType;

		private string ruleSource;

		private string ruleName;

		private string classification;

		private string notifyStatus;

		private string endApplyDate;

		private string ruleKeyword;

		public string StartApplyDate
		{
			get
			{
				return startApplyDate;
			}
			set	
			{
				startApplyDate = value;
				DictionaryUtil.Add(QueryParameters, "StartApplyDate", value);
			}
		}

		public int? RuleType
		{
			get
			{
				return ruleType;
			}
			set	
			{
				ruleType = value;
				DictionaryUtil.Add(QueryParameters, "RuleType", value.ToString());
			}
		}

		public string RuleSource
		{
			get
			{
				return ruleSource;
			}
			set	
			{
				ruleSource = value;
				DictionaryUtil.Add(QueryParameters, "RuleSource", value);
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

		public string Classification
		{
			get
			{
				return classification;
			}
			set	
			{
				classification = value;
				DictionaryUtil.Add(QueryParameters, "Classification", value);
			}
		}

		public string NotifyStatus
		{
			get
			{
				return notifyStatus;
			}
			set	
			{
				notifyStatus = value;
				DictionaryUtil.Add(QueryParameters, "NotifyStatus", value);
			}
		}

		public string EndApplyDate
		{
			get
			{
				return endApplyDate;
			}
			set	
			{
				endApplyDate = value;
				DictionaryUtil.Add(QueryParameters, "EndApplyDate", value);
			}
		}

		public string RuleKeyword
		{
			get
			{
				return ruleKeyword;
			}
			set	
			{
				ruleKeyword = value;
				DictionaryUtil.Add(QueryParameters, "RuleKeyword", value);
			}
		}

        public override InsertTmMonitorRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InsertTmMonitorRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
