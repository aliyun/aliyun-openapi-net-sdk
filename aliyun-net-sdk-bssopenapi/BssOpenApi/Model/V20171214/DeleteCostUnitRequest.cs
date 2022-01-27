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
    public class DeleteCostUnitRequest : RpcAcsRequest<DeleteCostUnitResponse>
    {
        public DeleteCostUnitRequest()
            : base("BssOpenApi", "2017-12-14", "DeleteCostUnit")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? unitId;

		private long? ownerUid;

		public long? UnitId
		{
			get
			{
				return unitId;
			}
			set	
			{
				unitId = value;
				DictionaryUtil.Add(QueryParameters, "UnitId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "OwnerUid", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteCostUnitResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteCostUnitResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
