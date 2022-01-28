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
    public class ListAttemptsRequest : RpcAcsRequest<ListAttemptsResponse>
    {
        public ListAttemptsRequest()
            : base("CCC", "2020-07-01", "ListAttempts")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointRegionalType, null);
            }
        }

		private string contactId;

		private string campaignId;

		private string callee;

		private long? startTime;

		private int? pageNumber;

		private int? pageSize;

		private string queueId;

		private string agentId;

		private long? endTime;

		private string caller;

		private string instanceId;

		private string caseId;

		private string attemptId;

		public string ContactId
		{
			get
			{
				return contactId;
			}
			set	
			{
				contactId = value;
				DictionaryUtil.Add(QueryParameters, "ContactId", value);
			}
		}

		public string CampaignId
		{
			get
			{
				return campaignId;
			}
			set	
			{
				campaignId = value;
				DictionaryUtil.Add(QueryParameters, "CampaignId", value);
			}
		}

		public string Callee
		{
			get
			{
				return callee;
			}
			set	
			{
				callee = value;
				DictionaryUtil.Add(QueryParameters, "Callee", value);
			}
		}

		public long? StartTime
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

		public string AgentId
		{
			get
			{
				return agentId;
			}
			set	
			{
				agentId = value;
				DictionaryUtil.Add(QueryParameters, "AgentId", value);
			}
		}

		public long? EndTime
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

		public string Caller
		{
			get
			{
				return caller;
			}
			set	
			{
				caller = value;
				DictionaryUtil.Add(QueryParameters, "Caller", value);
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

		public string CaseId
		{
			get
			{
				return caseId;
			}
			set	
			{
				caseId = value;
				DictionaryUtil.Add(QueryParameters, "CaseId", value);
			}
		}

		public string AttemptId
		{
			get
			{
				return attemptId;
			}
			set	
			{
				attemptId = value;
				DictionaryUtil.Add(QueryParameters, "AttemptId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListAttemptsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListAttemptsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
