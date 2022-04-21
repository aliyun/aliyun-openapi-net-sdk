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
using Aliyun.Acs.OutboundBot.Transform;
using Aliyun.Acs.OutboundBot.Transform.V20191226;

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
    public class ModifyJobGroupRequest : RpcAcsRequest<ModifyJobGroupResponse>
    {
        public ModifyJobGroupRequest()
            : base("OutboundBot", "2019-12-26", "ModifyJobGroup", "outboundbot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string recallStrategyJson;

		private string description;

		private string scriptId;

		private string strategyJson;

		private long? ringingDuration;

		private string scenarioId;

		private string jobGroupStatus;

		private string priority;

		private List<string> callingNumbers = new List<string>(){ };

		private string instanceId;

		private string jobGroupId;

		private string name;

		private long? minConcurrency;

		public string RecallStrategyJson
		{
			get
			{
				return recallStrategyJson;
			}
			set	
			{
				recallStrategyJson = value;
				DictionaryUtil.Add(QueryParameters, "RecallStrategyJson", value);
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

		public string ScriptId
		{
			get
			{
				return scriptId;
			}
			set	
			{
				scriptId = value;
				DictionaryUtil.Add(QueryParameters, "ScriptId", value);
			}
		}

		public string StrategyJson
		{
			get
			{
				return strategyJson;
			}
			set	
			{
				strategyJson = value;
				DictionaryUtil.Add(QueryParameters, "StrategyJson", value);
			}
		}

		public long? RingingDuration
		{
			get
			{
				return ringingDuration;
			}
			set	
			{
				ringingDuration = value;
				DictionaryUtil.Add(QueryParameters, "RingingDuration", value.ToString());
			}
		}

		public string ScenarioId
		{
			get
			{
				return scenarioId;
			}
			set	
			{
				scenarioId = value;
				DictionaryUtil.Add(QueryParameters, "ScenarioId", value);
			}
		}

		public string JobGroupStatus
		{
			get
			{
				return jobGroupStatus;
			}
			set	
			{
				jobGroupStatus = value;
				DictionaryUtil.Add(QueryParameters, "JobGroupStatus", value);
			}
		}

		public string Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
				DictionaryUtil.Add(QueryParameters, "Priority", value);
			}
		}

		public List<string> CallingNumbers
		{
			get
			{
				return callingNumbers;
			}

			set
			{
				callingNumbers = value;
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

		public string JobGroupId
		{
			get
			{
				return jobGroupId;
			}
			set	
			{
				jobGroupId = value;
				DictionaryUtil.Add(QueryParameters, "JobGroupId", value);
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

		public long? MinConcurrency
		{
			get
			{
				return minConcurrency;
			}
			set	
			{
				minConcurrency = value;
				DictionaryUtil.Add(QueryParameters, "MinConcurrency", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyJobGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyJobGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
