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
using Aliyun.Acs.BssOpenApi;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class AllocateCostUnitResourceRequest : RpcAcsRequest<AllocateCostUnitResourceResponse>
    {
        public AllocateCostUnitResourceRequest()
            : base("BssOpenApi", "2017-12-14", "AllocateCostUnitResource")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<ResourceInstanceList> resourceInstanceLists = new List<ResourceInstanceList>(){ };

		private long? fromUnitId;

		private long? toUnitId;

		private long? fromUnitUserId;

		private long? toUnitUserId;

		public List<ResourceInstanceList> ResourceInstanceLists
		{
			get
			{
				return resourceInstanceLists;
			}

			set
			{
				resourceInstanceLists = value;
				for (int i = 0; i < resourceInstanceLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ResourceInstanceList." + (i + 1) + ".ResourceId", resourceInstanceLists[i].ResourceId);
					DictionaryUtil.Add(QueryParameters,"ResourceInstanceList." + (i + 1) + ".CommodityCode", resourceInstanceLists[i].CommodityCode);
					DictionaryUtil.Add(QueryParameters,"ResourceInstanceList." + (i + 1) + ".ApportionCode", resourceInstanceLists[i].ApportionCode);
					DictionaryUtil.Add(QueryParameters,"ResourceInstanceList." + (i + 1) + ".ResourceUserId", resourceInstanceLists[i].ResourceUserId);
				}
			}
		}

		public long? FromUnitId
		{
			get
			{
				return fromUnitId;
			}
			set	
			{
				fromUnitId = value;
				DictionaryUtil.Add(QueryParameters, "FromUnitId", value.ToString());
			}
		}

		public long? ToUnitId
		{
			get
			{
				return toUnitId;
			}
			set	
			{
				toUnitId = value;
				DictionaryUtil.Add(QueryParameters, "ToUnitId", value.ToString());
			}
		}

		public long? FromUnitUserId
		{
			get
			{
				return fromUnitUserId;
			}
			set	
			{
				fromUnitUserId = value;
				DictionaryUtil.Add(QueryParameters, "FromUnitUserId", value.ToString());
			}
		}

		public long? ToUnitUserId
		{
			get
			{
				return toUnitUserId;
			}
			set	
			{
				toUnitUserId = value;
				DictionaryUtil.Add(QueryParameters, "ToUnitUserId", value.ToString());
			}
		}

		public class ResourceInstanceList
		{

			private string resourceId;

			private string commodityCode;

			private string apportionCode;

			private long? resourceUserId;

			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
				}
			}

			public string CommodityCode
			{
				get
				{
					return commodityCode;
				}
				set	
				{
					commodityCode = value;
				}
			}

			public string ApportionCode
			{
				get
				{
					return apportionCode;
				}
				set	
				{
					apportionCode = value;
				}
			}

			public long? ResourceUserId
			{
				get
				{
					return resourceUserId;
				}
				set	
				{
					resourceUserId = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AllocateCostUnitResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AllocateCostUnitResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
