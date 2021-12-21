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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20200701;

namespace Aliyun.Acs.CCC.Model.V20200701
{
    public class CreateCampaignRequest : RpcAcsRequest<CreateCampaignResponse>
    {
        public CreateCampaignRequest()
            : base("CCC", "2020-07-01", "CreateCampaign")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string queueId;

		private string contactFlowId;

		private bool? simulation;

		private string endTime;

		private string startTime;

		private long? maxAttemptCount;

		private string strategyParameters;

		private string caseFileKey;

		private long? minAttemptInterval;

		private string instanceId;

		private string simulationParameters;

		private string name;

		private string strategyType;

		private string caseList;

		private string callableTime;

		public string QueueId
		{
			get
			{
				return queueId;
			}
			set	
			{
				queueId = value;
				DictionaryUtil.Add(QueryParameters, "QueueId", value);
			}
		}

		public string ContactFlowId
		{
			get
			{
				return contactFlowId;
			}
			set	
			{
				contactFlowId = value;
				DictionaryUtil.Add(QueryParameters, "ContactFlowId", value);
			}
		}

		public bool? Simulation
		{
			get
			{
				return simulation;
			}
			set	
			{
				simulation = value;
				DictionaryUtil.Add(QueryParameters, "Simulation", value.ToString());
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public long? MaxAttemptCount
		{
			get
			{
				return maxAttemptCount;
			}
			set	
			{
				maxAttemptCount = value;
				DictionaryUtil.Add(QueryParameters, "MaxAttemptCount", value.ToString());
			}
		}

		public string StrategyParameters
		{
			get
			{
				return strategyParameters;
			}
			set	
			{
				strategyParameters = value;
				DictionaryUtil.Add(QueryParameters, "StrategyParameters", value);
			}
		}

		public string CaseFileKey
		{
			get
			{
				return caseFileKey;
			}
			set	
			{
				caseFileKey = value;
				DictionaryUtil.Add(QueryParameters, "CaseFileKey", value);
			}
		}

		public long? MinAttemptInterval
		{
			get
			{
				return minAttemptInterval;
			}
			set	
			{
				minAttemptInterval = value;
				DictionaryUtil.Add(QueryParameters, "MinAttemptInterval", value.ToString());
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

		public string SimulationParameters
		{
			get
			{
				return simulationParameters;
			}
			set	
			{
				simulationParameters = value;
				DictionaryUtil.Add(QueryParameters, "SimulationParameters", value);
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

		public string StrategyType
		{
			get
			{
				return strategyType;
			}
			set	
			{
				strategyType = value;
				DictionaryUtil.Add(QueryParameters, "StrategyType", value);
			}
		}

		public string CaseList
		{
			get
			{
				return caseList;
			}
			set	
			{
				caseList = value;
				DictionaryUtil.Add(QueryParameters, "CaseList", value);
			}
		}

		public string CallableTime
		{
			get
			{
				return callableTime;
			}
			set	
			{
				callableTime = value;
				DictionaryUtil.Add(QueryParameters, "CallableTime", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateCampaignResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateCampaignResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
