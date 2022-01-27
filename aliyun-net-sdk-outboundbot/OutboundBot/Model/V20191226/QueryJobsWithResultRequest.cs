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
    public class QueryJobsWithResultRequest : RpcAcsRequest<QueryJobsWithResultResponse>
    {
        public QueryJobsWithResultRequest()
            : base("OutboundBot", "2019-12-26", "QueryJobsWithResult", "outboundbot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? hasReachedEndOfFlowFilter;

		private bool? hasAnsweredFilter;

		private int? pageNumber;

		private string queryText;

		private bool? hasHangUpByRejectionFilter;

		private string instanceId;

		private string jobStatusFilter;

		private int? pageSize;

		private string jobGroupId;

		public bool? HasReachedEndOfFlowFilter
		{
			get
			{
				return hasReachedEndOfFlowFilter;
			}
			set	
			{
				hasReachedEndOfFlowFilter = value;
				DictionaryUtil.Add(QueryParameters, "HasReachedEndOfFlowFilter", value.ToString());
			}
		}

		public bool? HasAnsweredFilter
		{
			get
			{
				return hasAnsweredFilter;
			}
			set	
			{
				hasAnsweredFilter = value;
				DictionaryUtil.Add(QueryParameters, "HasAnsweredFilter", value.ToString());
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

		public string QueryText
		{
			get
			{
				return queryText;
			}
			set	
			{
				queryText = value;
				DictionaryUtil.Add(QueryParameters, "QueryText", value);
			}
		}

		public bool? HasHangUpByRejectionFilter
		{
			get
			{
				return hasHangUpByRejectionFilter;
			}
			set	
			{
				hasHangUpByRejectionFilter = value;
				DictionaryUtil.Add(QueryParameters, "HasHangUpByRejectionFilter", value.ToString());
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

		public string JobStatusFilter
		{
			get
			{
				return jobStatusFilter;
			}
			set	
			{
				jobStatusFilter = value;
				DictionaryUtil.Add(QueryParameters, "JobStatusFilter", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryJobsWithResultResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryJobsWithResultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
