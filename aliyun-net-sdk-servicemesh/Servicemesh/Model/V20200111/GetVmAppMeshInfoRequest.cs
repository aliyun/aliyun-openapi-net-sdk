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
using Aliyun.Acs.servicemesh.Transform;
using Aliyun.Acs.servicemesh.Transform.V20200111;

namespace Aliyun.Acs.servicemesh.Model.V20200111
{
    public class GetVmAppMeshInfoRequest : RpcAcsRequest<GetVmAppMeshInfoResponse>
    {
        public GetVmAppMeshInfoRequest()
            : base("servicemesh", "2020-01-11", "GetVmAppMeshInfo", "servicemesh", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.servicemesh.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.servicemesh.Endpoint.endpointRegionalType, null);
            }
        }

		private string serviceMeshId;

		public string ServiceMeshId
		{
			get
			{
				return serviceMeshId;
			}
			set	
			{
				serviceMeshId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceMeshId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetVmAppMeshInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetVmAppMeshInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
