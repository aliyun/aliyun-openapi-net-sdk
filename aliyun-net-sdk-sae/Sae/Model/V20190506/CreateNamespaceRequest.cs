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
using Aliyun.Acs.sae.Transform;
using Aliyun.Acs.sae.Transform.V20190506;

namespace Aliyun.Acs.sae.Model.V20190506
{
    public class CreateNamespaceRequest : RoaAcsRequest<CreateNamespaceResponse>
    {
        public CreateNamespaceRequest()
            : base("sae", "2019-05-06", "CreateNamespace", "serverless", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v1/paas/namespace";
			Method = MethodType.POST;
        }

		private string namespaceName;

		private string namespaceDescription;

		private bool? enableMicroRegistration;

		private string namespaceId;

		private string nameSpaceShortId;

		public string NamespaceName
		{
			get
			{
				return namespaceName;
			}
			set	
			{
				namespaceName = value;
				DictionaryUtil.Add(QueryParameters, "NamespaceName", value);
			}
		}

		public string NamespaceDescription
		{
			get
			{
				return namespaceDescription;
			}
			set	
			{
				namespaceDescription = value;
				DictionaryUtil.Add(QueryParameters, "NamespaceDescription", value);
			}
		}

		public bool? EnableMicroRegistration
		{
			get
			{
				return enableMicroRegistration;
			}
			set	
			{
				enableMicroRegistration = value;
				DictionaryUtil.Add(QueryParameters, "EnableMicroRegistration", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "NamespaceId", value);
			}
		}

		public string NameSpaceShortId
		{
			get
			{
				return nameSpaceShortId;
			}
			set	
			{
				nameSpaceShortId = value;
				DictionaryUtil.Add(QueryParameters, "NameSpaceShortId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateNamespaceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateNamespaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
