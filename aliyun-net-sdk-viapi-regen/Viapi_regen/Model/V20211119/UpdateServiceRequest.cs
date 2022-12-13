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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.viapi_regen.Transform;
using Aliyun.Acs.viapi_regen.Transform.V20211119;

namespace Aliyun.Acs.viapi_regen.Model.V20211119
{
    public class UpdateServiceRequest : RpcAcsRequest<UpdateServiceResponse>
    {
        public UpdateServiceRequest()
            : base("viapi-regen", "2021-11-19", "UpdateService", "selflearning", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.viapi_regen.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.viapi_regen.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string description;

		private long? id;

		private string authorizationType;

		private string name;

		private string authorizedAccount;

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "Id")]
		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(BodyParameters, "Id", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AuthorizationType")]
		public string AuthorizationType
		{
			get
			{
				return authorizationType;
			}
			set	
			{
				authorizationType = value;
				DictionaryUtil.Add(BodyParameters, "AuthorizationType", value);
			}
		}

		[JsonProperty(PropertyName = "Name")]
		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "AuthorizedAccount")]
		public string AuthorizedAccount
		{
			get
			{
				return authorizedAccount;
			}
			set	
			{
				authorizedAccount = value;
				DictionaryUtil.Add(BodyParameters, "AuthorizedAccount", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateServiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
