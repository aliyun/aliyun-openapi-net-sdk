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
    public class CreateCostUnitRequest : RpcAcsRequest<CreateCostUnitResponse>
    {
        public CreateCostUnitRequest()
            : base("BssOpenApi", "2017-12-14", "CreateCostUnit")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<UnitEntityList> unitEntityLists = new List<UnitEntityList>(){ };

		public List<UnitEntityList> UnitEntityLists
		{
			get
			{
				return unitEntityLists;
			}

			set
			{
				unitEntityLists = value;
				for (int i = 0; i < unitEntityLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UnitEntityList." + (i + 1) + ".UnitName", unitEntityLists[i].UnitName);
					DictionaryUtil.Add(QueryParameters,"UnitEntityList." + (i + 1) + ".ParentUnitId", unitEntityLists[i].ParentUnitId);
					DictionaryUtil.Add(QueryParameters,"UnitEntityList." + (i + 1) + ".OwnerUid", unitEntityLists[i].OwnerUid);
				}
			}
		}

		public class UnitEntityList
		{

			private string unitName;

			private long? parentUnitId;

			private long? ownerUid;

			public string UnitName
			{
				get
				{
					return unitName;
				}
				set	
				{
					unitName = value;
				}
			}

			public long? ParentUnitId
			{
				get
				{
					return parentUnitId;
				}
				set	
				{
					parentUnitId = value;
				}
			}

			public long? OwnerUid
			{
				get
				{
					return ownerUid;
				}
				set	
				{
					ownerUid = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateCostUnitResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateCostUnitResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
