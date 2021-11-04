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
using Aliyun.Acs.Privatelink.Transform;
using Aliyun.Acs.Privatelink.Transform.V20200415;

namespace Aliyun.Acs.Privatelink.Model.V20200415
{
    public class CreateVpcEndpointServiceRequest : RpcAcsRequest<CreateVpcEndpointServiceResponse>
    {
        public CreateVpcEndpointServiceRequest()
            : base("Privatelink", "2020-04-15", "CreateVpcEndpointService", "privatelink", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Privatelink.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Privatelink.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private bool? autoAcceptEnabled;

		private string clientToken;

		private string payer;

		private bool? zoneAffinityEnabled;

		private bool? dryRun;

		private List<string> resources = new List<string>(){ };

		private string serviceDescription;

		public bool? AutoAcceptEnabled
		{
			get
			{
				return autoAcceptEnabled;
			}
			set	
			{
				autoAcceptEnabled = value;
				DictionaryUtil.Add(QueryParameters, "AutoAcceptEnabled", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string Payer
		{
			get
			{
				return payer;
			}
			set	
			{
				payer = value;
				DictionaryUtil.Add(QueryParameters, "Payer", value);
			}
		}

		public bool? ZoneAffinityEnabled
		{
			get
			{
				return zoneAffinityEnabled;
			}
			set	
			{
				zoneAffinityEnabled = value;
				DictionaryUtil.Add(QueryParameters, "ZoneAffinityEnabled", value.ToString());
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public List<string> Resources
		{
			get
			{
				return resources;
			}

			set
			{
				resources = value;
				if(resources != null)
				{
					for (int depth1 = 0; depth1 < resources.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Resource." + (depth1 + 1), resources[depth1]);
						DictionaryUtil.Add(QueryParameters,"Resource." + (depth1 + 1), resources[depth1]);
					}
				}
			}
		}

		public string ServiceDescription
		{
			get
			{
				return serviceDescription;
			}
			set	
			{
				serviceDescription = value;
				DictionaryUtil.Add(QueryParameters, "ServiceDescription", value);
			}
		}

		public class Resource
		{

			private string resourceType;

			private string resourceId;

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

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
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateVpcEndpointServiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVpcEndpointServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
