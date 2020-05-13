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
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20180916;

namespace Aliyun.Acs.Cloudauth.Model.V20180916
{
    public class SubmitVerificationRequest : RpcAcsRequest<SubmitVerificationResponse>
    {
        public SubmitVerificationRequest()
            : base("Cloudauth", "2018-09-16", "SubmitVerification", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string biz;

		private string sourceIp;

		private List<Material> materials = new List<Material>(){ };

		private string ticketId;

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

		public string Biz
		{
			get
			{
				return biz;
			}
			set	
			{
				biz = value;
				DictionaryUtil.Add(BodyParameters, "Biz", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
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
					DictionaryUtil.Add(BodyParameters,"Material." + (i + 1) + ".MaterialType", materials[i].MaterialType);
					DictionaryUtil.Add(BodyParameters,"Material." + (i + 1) + ".Value", materials[i].Value);
				}
			}
		}

		public string TicketId
		{
			get
			{
				return ticketId;
			}
			set	
			{
				ticketId = value;
				DictionaryUtil.Add(BodyParameters, "TicketId", value);
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

        public override SubmitVerificationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitVerificationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
