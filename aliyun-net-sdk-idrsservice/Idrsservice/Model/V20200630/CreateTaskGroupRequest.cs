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
using Aliyun.Acs.idrsservice.Transform;
using Aliyun.Acs.idrsservice.Transform.V20200630;

namespace Aliyun.Acs.idrsservice.Model.V20200630
{
    public class CreateTaskGroupRequest : RpcAcsRequest<CreateTaskGroupResponse>
    {
        public CreateTaskGroupRequest()
            : base("idrsservice", "2020-06-30", "CreateTaskGroup", "idrsservice", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.idrsservice.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.idrsservice.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string expireAt;

		private List<int?> days = new List<int?>(){ };

		private string runnableTimeTo;

		private string triggerPeriod;

		private string groupName;

		private List<string> videoUrls = new List<string>(){ };

		private string appId;

		private string runnableTimeFrom;

		private string ruleId;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string ExpireAt
		{
			get
			{
				return expireAt;
			}
			set	
			{
				expireAt = value;
				DictionaryUtil.Add(QueryParameters, "ExpireAt", value);
			}
		}

		public List<int?> Days
		{
			get
			{
				return days;
			}

			set
			{
				days = value;
				for (int i = 0; i < days.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Day." + (i + 1) , days[i]);
				}
			}
		}

		public string RunnableTimeTo
		{
			get
			{
				return runnableTimeTo;
			}
			set	
			{
				runnableTimeTo = value;
				DictionaryUtil.Add(QueryParameters, "RunnableTimeTo", value);
			}
		}

		public string TriggerPeriod
		{
			get
			{
				return triggerPeriod;
			}
			set	
			{
				triggerPeriod = value;
				DictionaryUtil.Add(QueryParameters, "TriggerPeriod", value);
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

		public List<string> VideoUrls
		{
			get
			{
				return videoUrls;
			}

			set
			{
				videoUrls = value;
				for (int i = 0; i < videoUrls.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"VideoUrl." + (i + 1) , videoUrls[i]);
				}
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string RunnableTimeFrom
		{
			get
			{
				return runnableTimeFrom;
			}
			set	
			{
				runnableTimeFrom = value;
				DictionaryUtil.Add(QueryParameters, "RunnableTimeFrom", value);
			}
		}

		public string RuleId
		{
			get
			{
				return ruleId;
			}
			set	
			{
				ruleId = value;
				DictionaryUtil.Add(QueryParameters, "RuleId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTaskGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTaskGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
