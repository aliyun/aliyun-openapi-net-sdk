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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20171117;
using System.Collections.Generic;

namespace Aliyun.Acs.Cloudauth.Model.V20171117
{
    public class SubmitMaterialsRequest : RpcAcsRequest<SubmitMaterialsResponse>
    {
        public SubmitMaterialsRequest()
            : base("Cloudauth", "2017-11-17", "SubmitMaterials", "cloudauth", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private long? resourceOwnerId;

		private List<Material> materials;

		private string verifyToken;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public List<Material> Materials
		{
			get
			{
				return materials;
			}

			set
			{
				materials = value;
				for (int i = 0; i < materials.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Material." + (i + 1) + ".MaterialType", materials[i].MaterialType);
					DictionaryUtil.Add(QueryParameters,"Material." + (i + 1) + ".Value", materials[i].Value);
				}
			}
		}

		public string VerifyToken
		{
			get
			{
				return verifyToken;
			}
			set	
			{
				verifyToken = value;
				DictionaryUtil.Add(QueryParameters, "VerifyToken", value);
			}
		}

		public class Material
		{

			private string materialType;

			private string value_;

			public string MaterialType
			{
				get
				{
					return materialType;
				}
				set	
				{
					materialType = value;
				}
			}

			public string Value
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

        public override SubmitMaterialsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SubmitMaterialsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}