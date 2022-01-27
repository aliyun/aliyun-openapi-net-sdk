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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class ListFlowInstanceRequest : RpcAcsRequest<ListFlowInstanceResponse>
    {
        public ListFlowInstanceRequest()
            : base("Emr", "2016-04-08", "ListFlowInstance", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> statusLists = new List<string>(){ };

		private string nodeInstanceId;

		private int? pageNumber;

		private int? pageSize;

		private string id;

		private string projectId;

		private string owner;

		private string timeRange;

		private string orderBy;

		private string instanceId;

		private string flowName;

		private string flowId;

		private string orderType;

		public List<string> StatusLists
		{
			get
			{
				return statusLists;
			}

			set
			{
				statusLists = value;
				for (int i = 0; i < statusLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"StatusList." + (i + 1) , statusLists[i]);
				}
			}
		}

		public string NodeInstanceId
		{
			get
			{
				return nodeInstanceId;
			}
			set	
			{
				nodeInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "NodeInstanceId", value);
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

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value);
			}
		}

		public string Owner
		{
			get
			{
				return owner;
			}
			set	
			{
				owner = value;
				DictionaryUtil.Add(QueryParameters, "Owner", value);
			}
		}

		public string TimeRange
		{
			get
			{
				return timeRange;
			}
			set	
			{
				timeRange = value;
				DictionaryUtil.Add(QueryParameters, "TimeRange", value);
			}
		}

		public string OrderBy
		{
			get
			{
				return orderBy;
			}
			set	
			{
				orderBy = value;
				DictionaryUtil.Add(QueryParameters, "OrderBy", value);
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

		public string FlowId
		{
			get
			{
				return flowId;
			}
			set	
			{
				flowId = value;
				DictionaryUtil.Add(QueryParameters, "FlowId", value);
			}
		}

		public string OrderType
		{
			get
			{
				return orderType;
			}
			set	
			{
				orderType = value;
				DictionaryUtil.Add(QueryParameters, "OrderType", value);
			}
		}

        public override ListFlowInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListFlowInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
