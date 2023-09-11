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
using Aliyun.Acs.Kms.Transform;
using Aliyun.Acs.Kms.Transform.V20160120;

namespace Aliyun.Acs.Kms.Model.V20160120
{
    public class CreatePolicyRequest : RpcAcsRequest<CreatePolicyResponse>
    {
        public CreatePolicyRequest()
            : base("Kms", "2016-01-20", "CreatePolicy", "kms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Kms.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Kms.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string accessControlRules;

		private string description;

		private string resources;

		private string kmsInstance;

		private string permissions;

		private string name;

		[JsonProperty(PropertyName = "AccessControlRules")]
		public string AccessControlRules
		{
			get
			{
				return accessControlRules;
			}
			set	
			{
				accessControlRules = value;
				DictionaryUtil.Add(QueryParameters, "AccessControlRules", value);
			}
		}

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
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "Resources")]
		public string Resources
		{
			get
			{
				return resources;
			}
			set	
			{
				resources = value;
				DictionaryUtil.Add(QueryParameters, "Resources", value);
			}
		}

		[JsonProperty(PropertyName = "KmsInstance")]
		public string KmsInstance
		{
			get
			{
				return kmsInstance;
			}
			set	
			{
				kmsInstance = value;
				DictionaryUtil.Add(QueryParameters, "KmsInstance", value);
			}
		}

		[JsonProperty(PropertyName = "Permissions")]
		public string Permissions
		{
			get
			{
				return permissions;
			}
			set	
			{
				permissions = value;
				DictionaryUtil.Add(QueryParameters, "Permissions", value);
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
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

        public override CreatePolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreatePolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
