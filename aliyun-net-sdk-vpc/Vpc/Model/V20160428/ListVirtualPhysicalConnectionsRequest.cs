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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class ListVirtualPhysicalConnectionsRequest : RpcAcsRequest<ListVirtualPhysicalConnectionsResponse>
    {
        public ListVirtualPhysicalConnectionsRequest()
            : base("Vpc", "2016-04-28", "ListVirtualPhysicalConnections", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> vlanIdss = new List<string>(){ };

		private string virtualPhysicalConnectionBusinessStatus;

		private string resourceGroupId;

		private List<string> virtualPhysicalConnectionAliUidss = new List<string>(){ };

		private string nextToken;

		private List<string> virtualPhysicalConnectionIdss = new List<string>(){ };

		private bool? isConfirmed;

		private List<string> tagss = new List<string>(){ };

		private List<string> virtualPhysicalConnectionStatusess = new List<string>(){ };

		private string physicalConnectionId;

		private int? maxResults;

		public List<string> VlanIdss
		{
			get
			{
				return vlanIdss;
			}

			set
			{
				vlanIdss = value;
			}
		}

		public string VirtualPhysicalConnectionBusinessStatus
		{
			get
			{
				return virtualPhysicalConnectionBusinessStatus;
			}
			set	
			{
				virtualPhysicalConnectionBusinessStatus = value;
				DictionaryUtil.Add(QueryParameters, "VirtualPhysicalConnectionBusinessStatus", value);
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public List<string> VirtualPhysicalConnectionAliUidss
		{
			get
			{
				return virtualPhysicalConnectionAliUidss;
			}

			set
			{
				virtualPhysicalConnectionAliUidss = value;
			}
		}

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

		public List<string> VirtualPhysicalConnectionIdss
		{
			get
			{
				return virtualPhysicalConnectionIdss;
			}

			set
			{
				virtualPhysicalConnectionIdss = value;
			}
		}

		public bool? IsConfirmed
		{
			get
			{
				return isConfirmed;
			}
			set	
			{
				isConfirmed = value;
				DictionaryUtil.Add(QueryParameters, "IsConfirmed", value.ToString());
			}
		}

		public List<string> Tagss
		{
			get
			{
				return tagss;
			}

			set
			{
				tagss = value;
				if(tagss != null)
				{
					for (int depth1 = 0; depth1 < tagss.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tags." + (depth1 + 1), tagss[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tags." + (depth1 + 1), tagss[depth1]);
					}
				}
			}
		}

		public List<string> VirtualPhysicalConnectionStatusess
		{
			get
			{
				return virtualPhysicalConnectionStatusess;
			}

			set
			{
				virtualPhysicalConnectionStatusess = value;
			}
		}

		public string PhysicalConnectionId
		{
			get
			{
				return physicalConnectionId;
			}
			set	
			{
				physicalConnectionId = value;
				DictionaryUtil.Add(QueryParameters, "PhysicalConnectionId", value);
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

		public class Tags
		{

			private string key;

			private string value_;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListVirtualPhysicalConnectionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListVirtualPhysicalConnectionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
