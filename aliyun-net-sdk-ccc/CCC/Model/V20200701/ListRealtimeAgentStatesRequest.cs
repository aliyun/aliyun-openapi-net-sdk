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
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20200701;

namespace Aliyun.Acs.CCC.Model.V20200701
{
    public class ListRealtimeAgentStatesRequest : RpcAcsRequest<ListRealtimeAgentStatesResponse>
    {
        public ListRealtimeAgentStatesRequest()
            : base("CCC", "2020-07-01", "ListRealtimeAgentStates", "CCC", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? pageNumber;

		private string instanceId;

		private string agentIdList;

		private string skillGroupId;

		private string agentName;

		private int? pageSize;

		private string stateList;

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
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

		public string AgentIdList
		{
			get
			{
				return agentIdList;
			}
			set	
			{
				agentIdList = value;
				DictionaryUtil.Add(BodyParameters, "AgentIdList", value);
			}
		}

		public string SkillGroupId
		{
			get
			{
				return skillGroupId;
			}
			set	
			{
				skillGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SkillGroupId", value);
			}
		}

		public string AgentName
		{
			get
			{
				return agentName;
			}
			set	
			{
				agentName = value;
				DictionaryUtil.Add(QueryParameters, "AgentName", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string StateList
		{
			get
			{
				return stateList;
			}
			set	
			{
				stateList = value;
				DictionaryUtil.Add(BodyParameters, "StateList", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListRealtimeAgentStatesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListRealtimeAgentStatesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
