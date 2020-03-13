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
using Aliyun.Acs.acms_open.Transform;
using Aliyun.Acs.acms_open.Transform.V20200206;

namespace Aliyun.Acs.acms_open.Model.V20200206
{
    public class UpdateNamespaceRequest : RoaAcsRequest<UpdateNamespaceResponse>
    {
        public UpdateNamespaceRequest()
            : base("acms-open", "2020-02-06", "UpdateNamespace", "acms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/diamond-ops/pop/namespace";
			Method = MethodType.PUT;
        }

		private string namespaceName;

		private string namespaceId;

		public string NamespaceName
		{
			get
			{
				return namespaceName;
			}
			set	
			{
				namespaceName = value;
				DictionaryUtil.Add(BodyParameters, "NamespaceName", value);
			}
		}

		public string NamespaceId
		{
			get
			{
				return namespaceId;
			}
			set	
			{
				namespaceId = value;
				DictionaryUtil.Add(BodyParameters, "NamespaceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateNamespaceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateNamespaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
