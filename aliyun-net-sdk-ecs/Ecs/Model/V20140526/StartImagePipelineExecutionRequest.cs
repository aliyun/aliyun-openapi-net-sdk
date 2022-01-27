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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class StartImagePipelineExecutionRequest : RpcAcsRequest<StartImagePipelineExecutionResponse>
    {
        public StartImagePipelineExecutionRequest()
            : base("Ecs", "2014-05-26", "StartImagePipelineExecution", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string imagePipelineId;

		private long? resourceOwnerId;

		private string clientToken;

		private List<string> templateTags = new List<string>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		[JsonProperty(PropertyName = "ImagePipelineId")]
		public string ImagePipelineId
		{
			get
			{
				return imagePipelineId;
			}
			set	
			{
				imagePipelineId = value;
				DictionaryUtil.Add(QueryParameters, "ImagePipelineId", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerId")]
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

		[JsonProperty(PropertyName = "ClientToken")]
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

		[JsonProperty(PropertyName = "TemplateTag")]
		public List<string> TemplateTags
		{
			get
			{
				return templateTags;
			}

			set
			{
				templateTags = value;
				if(templateTags != null)
				{
					for (int depth1 = 0; depth1 < templateTags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"TemplateTag." + (depth1 + 1), templateTags[depth1]);
						DictionaryUtil.Add(QueryParameters,"TemplateTag." + (depth1 + 1), templateTags[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerAccount")]
		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public class TemplateTag
		{

			private string key;

			private string value_;

			[JsonProperty(PropertyName = "Key")]
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

			[JsonProperty(PropertyName = "Value")]
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

        public override StartImagePipelineExecutionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartImagePipelineExecutionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
