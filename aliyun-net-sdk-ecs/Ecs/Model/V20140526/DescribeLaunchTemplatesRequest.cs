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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeLaunchTemplatesRequest : RpcAcsRequest<DescribeLaunchTemplatesResponse>
    {
        public DescribeLaunchTemplatesRequest()
            : base("Ecs", "2014-05-26", "DescribeLaunchTemplates", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> launchTemplateNames = new List<string>(){ };

		private long? resourceOwnerId;

		private int? pageNumber;

		private int? pageSize;

		private List<TemplateTag> templateTags = new List<TemplateTag>(){ };

		private List<string> launchTemplateIds = new List<string>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string templateResourceGroupId;

		private long? ownerId;

		public List<string> LaunchTemplateNames
		{
			get
			{
				return launchTemplateNames;
			}

			set
			{
				launchTemplateNames = value;
				for (int i = 0; i < launchTemplateNames.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LaunchTemplateName." + (i + 1) , launchTemplateNames[i]);
				}
			}
		}

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public List<TemplateTag> TemplateTags
		{
			get
			{
				return templateTags;
			}

			set
			{
				templateTags = value;
				for (int i = 0; i < templateTags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TemplateTag." + (i + 1) + ".Key", templateTags[i].Key);
					DictionaryUtil.Add(QueryParameters,"TemplateTag." + (i + 1) + ".Value", templateTags[i].Value);
				}
			}
		}

		public List<string> LaunchTemplateIds
		{
			get
			{
				return launchTemplateIds;
			}

			set
			{
				launchTemplateIds = value;
				for (int i = 0; i < launchTemplateIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LaunchTemplateId." + (i + 1) , launchTemplateIds[i]);
				}
			}
		}

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

		public string TemplateResourceGroupId
		{
			get
			{
				return templateResourceGroupId;
			}
			set	
			{
				templateResourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateResourceGroupId", value);
			}
		}

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

        public override DescribeLaunchTemplatesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeLaunchTemplatesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
