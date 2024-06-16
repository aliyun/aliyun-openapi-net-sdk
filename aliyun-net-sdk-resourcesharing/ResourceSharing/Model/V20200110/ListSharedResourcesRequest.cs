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
using Aliyun.Acs.ResourceSharing.Transform;
using Aliyun.Acs.ResourceSharing.Transform.V20200110;

namespace Aliyun.Acs.ResourceSharing.Model.V20200110
{
    public class ListSharedResourcesRequest : RpcAcsRequest<ListSharedResourcesResponse>
    {
        public ListSharedResourcesRequest()
            : base("ResourceSharing", "2020-01-10", "ListSharedResources", "ressharing", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ResourceSharing.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ResourceSharing.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string nextToken;

		private List<string> resourceShareIdss = new List<string>(){ };

		private string resourceOwner;

		private string resourceType;

		private string target;

		private int? maxResults;

		private List<string> resourceIdss = new List<string>(){ };

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		public List<string> ResourceShareIdss
		{
			get
			{
				return resourceShareIdss;
			}

			set
			{
				resourceShareIdss = value;
			}
		}

		public string ResourceOwner
		{
			get
			{
				return resourceOwner;
			}
			set	
			{
				resourceOwner = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwner", value);
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

		public string Target
		{
			get
			{
				return target;
			}
			set	
			{
				target = value;
				DictionaryUtil.Add(QueryParameters, "Target", value);
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		public List<string> ResourceIdss
		{
			get
			{
				return resourceIdss;
			}

			set
			{
				resourceIdss = value;
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListSharedResourcesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListSharedResourcesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
