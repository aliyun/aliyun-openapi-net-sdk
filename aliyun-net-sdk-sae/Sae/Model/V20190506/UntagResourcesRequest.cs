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
    public class UntagResourcesRequest : RoaAcsRequest<UntagResourcesResponse>
    {
        public UntagResourcesRequest()
            : base("sae", "2019-05-06", "UntagResources", "serverless", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/tags";
			Method = MethodType.DELETE;
        }

		private string tagKeys;

		private bool? deleteAll;

		private string resourceType;

		private string resourceIds;

		public string TagKeys
		{
			get
			{
				return tagKeys;
			}
			set	
			{
				tagKeys = value;
				DictionaryUtil.Add(QueryParameters, "TagKeys", value);
			}
		}

		public bool? DeleteAll
		{
			get
			{
				return deleteAll;
			}
			set	
			{
				deleteAll = value;
				DictionaryUtil.Add(QueryParameters, "DeleteAll", value.ToString());
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public string ResourceIds
		{
			get
			{
				return resourceIds;
			}
			set	
			{
				resourceIds = value;
				DictionaryUtil.Add(QueryParameters, "ResourceIds", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UntagResourcesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UntagResourcesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
