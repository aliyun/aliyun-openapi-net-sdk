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
using Aliyun.Acs.sgw.Transform;
using Aliyun.Acs.sgw.Transform.V20180511;

namespace Aliyun.Acs.sgw.Model.V20180511
{
    public class CreateGatewayRequest : RpcAcsRequest<CreateGatewayResponse>
    {
        public CreateGatewayRequest()
            : base("sgw", "2018-05-11", "CreateGateway", "hcs_sgw", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string gatewayClass;

		private bool? postPaid;

		private string description;

		private string type;

		private bool? releaseAfterExpiration;

		private string securityToken;

		private string storageBundleId;

		private string vSwitchId;

		private string name;

		private string location;

		private int? publicNetworkBandwidth;

		public string GatewayClass
		{
			get
			{
				return gatewayClass;
			}
			set	
			{
				gatewayClass = value;
				DictionaryUtil.Add(QueryParameters, "GatewayClass", value);
			}
		}

		public bool? PostPaid
		{
			get
			{
				return postPaid;
			}
			set	
			{
				postPaid = value;
				DictionaryUtil.Add(QueryParameters, "PostPaid", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public bool? ReleaseAfterExpiration
		{
			get
			{
				return releaseAfterExpiration;
			}
			set	
			{
				releaseAfterExpiration = value;
				DictionaryUtil.Add(QueryParameters, "ReleaseAfterExpiration", value.ToString());
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string StorageBundleId
		{
			get
			{
				return storageBundleId;
			}
			set	
			{
				storageBundleId = value;
				DictionaryUtil.Add(QueryParameters, "StorageBundleId", value);
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string Location
		{
			get
			{
				return location;
			}
			set	
			{
				location = value;
				DictionaryUtil.Add(QueryParameters, "Location", value);
			}
		}

		public int? PublicNetworkBandwidth
		{
			get
			{
				return publicNetworkBandwidth;
			}
			set	
			{
				publicNetworkBandwidth = value;
				DictionaryUtil.Add(QueryParameters, "PublicNetworkBandwidth", value.ToString());
			}
		}

        public override CreateGatewayResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateGatewayResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
