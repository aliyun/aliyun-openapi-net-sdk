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
using Aliyun.Acs.EHPC;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class ListInvocationResultsRequest : RpcAcsRequest<ListInvocationResultsResponse>
    {
        public ListInvocationResultsRequest()
            : base("EHPC", "2018-04-12", "ListInvocationResults")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointRegionalType, null);
            }
        }

		private List<Instance> instances = new List<Instance>(){ };

		private string clusterId;

		private string commandId;

		private int? pageNumber;

		private string invokeRecordStatus;

		private int? pageSize;

		public List<Instance> Instances
		{
			get
			{
				return instances;
			}

			set
			{
				instances = value;
				for (int i = 0; i < instances.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Instance." + (i + 1) + ".Id", instances[i].Id);
				}
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string CommandId
		{
			get
			{
				return commandId;
			}
			set	
			{
				commandId = value;
				DictionaryUtil.Add(QueryParameters, "CommandId", value);
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

		public string InvokeRecordStatus
		{
			get
			{
				return invokeRecordStatus;
			}
			set	
			{
				invokeRecordStatus = value;
				DictionaryUtil.Add(QueryParameters, "InvokeRecordStatus", value);
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

		public class Instance
		{

			private string id;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}
		}

        public override ListInvocationResultsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListInvocationResultsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
