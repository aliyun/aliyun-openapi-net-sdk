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
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class CreateSurveyRequest : RpcAcsRequest<CreateSurveyResponse>
    {
        public CreateSurveyRequest()
            : base("CCC", "2017-07-05", "CreateSurvey")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string role;

		private string description;

		private string speechOptimizationParam;

		private string instanceId;

		private int? round;

		private string flowJson;

		private string name;

		private string globalQuestions;

		private string corpora;

		private string scenarioId;

		public string Role
		{
			get
			{
				return role;
			}
			set	
			{
				role = value;
				DictionaryUtil.Add(QueryParameters, "Role", value);
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

		public string SpeechOptimizationParam
		{
			get
			{
				return speechOptimizationParam;
			}
			set	
			{
				speechOptimizationParam = value;
				DictionaryUtil.Add(QueryParameters, "SpeechOptimizationParam", value);
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

		public int? Round
		{
			get
			{
				return round;
			}
			set	
			{
				round = value;
				DictionaryUtil.Add(QueryParameters, "Round", value.ToString());
			}
		}

		public string FlowJson
		{
			get
			{
				return flowJson;
			}
			set	
			{
				flowJson = value;
				DictionaryUtil.Add(QueryParameters, "FlowJson", value);
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

		public string GlobalQuestions
		{
			get
			{
				return globalQuestions;
			}
			set	
			{
				globalQuestions = value;
				DictionaryUtil.Add(QueryParameters, "GlobalQuestions", value);
			}
		}

		public string Corpora
		{
			get
			{
				return corpora;
			}
			set	
			{
				corpora = value;
				DictionaryUtil.Add(QueryParameters, "Corpora", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateSurveyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSurveyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
