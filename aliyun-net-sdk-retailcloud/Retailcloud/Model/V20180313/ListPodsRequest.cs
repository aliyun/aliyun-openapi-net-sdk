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
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class ListPodsRequest : RpcAcsRequest<ListPodsResponse>
    {
        public ListPodsRequest()
            : base("retailcloud", "2018-03-13", "ListPods", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<int?> statusLists = new List<int?>(){ };

		private long? deployOrderId;

		private int? pageSize;

		private int? pageNumber;

		private List<int?> resultLists = new List<int?>(){ };

		public List<int?> StatusLists
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
					DictionaryUtil.Add(BodyParameters,"StatusList." + (i + 1) , statusLists[i]);
				}
			}
		}

		public long? DeployOrderId
		{
			get
			{
				return deployOrderId;
			}
			set	
			{
				deployOrderId = value;
				DictionaryUtil.Add(QueryParameters, "DeployOrderId", value.ToString());
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

		public List<int?> ResultLists
		{
			get
			{
				return resultLists;
			}

			set
			{
				resultLists = value;
				for (int i = 0; i < resultLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"ResultList." + (i + 1) , resultLists[i]);
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListPodsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListPodsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
