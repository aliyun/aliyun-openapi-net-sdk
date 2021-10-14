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
    public class ListCampaignsRequest : RpcAcsRequest<ListCampaignsResponse>
    {
        public ListCampaignsRequest()
            : base("CCC", "2020-07-01", "ListCampaigns", "CCC", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string actualStartTimeTo;

		private string queueId;

		private string actualStartTimeFrom;

		private long? pageNumber;

		private string planedStartTimeFrom;

		private string instanceId;

		private string name;

		private long? pageSize;

		private string planedStartTimeTo;

		private string state;

		public string ActualStartTimeTo
		{
			get
			{
				return actualStartTimeTo;
			}
			set	
			{
				actualStartTimeTo = value;
				DictionaryUtil.Add(QueryParameters, "ActualStartTimeTo", value);
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

		public string ActualStartTimeFrom
		{
			get
			{
				return actualStartTimeFrom;
			}
			set	
			{
				actualStartTimeFrom = value;
				DictionaryUtil.Add(QueryParameters, "ActualStartTimeFrom", value);
			}
		}

		public long? PageNumber
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

		public string PlanedStartTimeFrom
		{
			get
			{
				return planedStartTimeFrom;
			}
			set	
			{
				planedStartTimeFrom = value;
				DictionaryUtil.Add(QueryParameters, "PlanedStartTimeFrom", value);
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

		public long? PageSize
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

		public string PlanedStartTimeTo
		{
			get
			{
				return planedStartTimeTo;
			}
			set	
			{
				planedStartTimeTo = value;
				DictionaryUtil.Add(QueryParameters, "PlanedStartTimeTo", value);
			}
		}

		public string State
		{
			get
			{
				return state;
			}
			set	
			{
				state = value;
				DictionaryUtil.Add(QueryParameters, "State", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListCampaignsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListCampaignsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
