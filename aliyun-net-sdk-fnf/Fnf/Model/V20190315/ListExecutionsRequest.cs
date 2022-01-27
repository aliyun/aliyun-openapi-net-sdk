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
using Aliyun.Acs.fnf.Transform;
using Aliyun.Acs.fnf.Transform.V20190315;

namespace Aliyun.Acs.fnf.Model.V20190315
{
    public class ListExecutionsRequest : RpcAcsRequest<ListExecutionsResponse>
    {
        public ListExecutionsRequest()
            : base("fnf", "2019-03-15", "ListExecutions", "fnf", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.fnf.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.fnf.Endpoint.endpointRegionalType, null);
            }
        }

		private string startedTimeBegin;

		private string executionNamePrefix;

		private string nextToken;

		private string requestId;

		private int? limit;

		private string flowName;

		private string startedTimeEnd;

		private string status;

		public string StartedTimeBegin
		{
			get
			{
				return startedTimeBegin;
			}
			set	
			{
				startedTimeBegin = value;
				DictionaryUtil.Add(QueryParameters, "StartedTimeBegin", value);
			}
		}

		public string ExecutionNamePrefix
		{
			get
			{
				return executionNamePrefix;
			}
			set	
			{
				executionNamePrefix = value;
				DictionaryUtil.Add(QueryParameters, "ExecutionNamePrefix", value);
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
				DictionaryUtil.Add(QueryParameters, "RequestId", value);
			}
		}

		public int? Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(QueryParameters, "Limit", value.ToString());
			}
		}

		public string FlowName
		{
			get
			{
				return flowName;
			}
			set	
			{
				flowName = value;
				DictionaryUtil.Add(QueryParameters, "FlowName", value);
			}
		}

		public string StartedTimeEnd
		{
			get
			{
				return startedTimeEnd;
			}
			set	
			{
				startedTimeEnd = value;
				DictionaryUtil.Add(QueryParameters, "StartedTimeEnd", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListExecutionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListExecutionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
