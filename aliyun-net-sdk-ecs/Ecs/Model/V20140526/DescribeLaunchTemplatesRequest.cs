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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeLaunchTemplatesRequest : RpcAcsRequest<DescribeLaunchTemplatesResponse>
    {
        public DescribeLaunchTemplatesRequest()
            : base("Ecs", "2014-05-26", "DescribeLaunchTemplates", "ecs", "openAPI")
        {
        }

		private string templateTag1Value;

		private List<string> launchTemplateNames;

		private long? resourceOwnerId;

		private string templateTag4Key;

		private int? pageNumber;

		private string templateTag3Key;

		private string regionId;

		private string templateTag5Value;

		private int? pageSize;

		private string action;

		private string templateTag3Value;

		private string templateTag2Key;

		private List<string> launchTemplateIds;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string templateResourceGroupId;

		private string templateTag2Value;

		private long? ownerId;

		private string templateTag4Value;

		private string templateTag5Key;

		private string templateTag1Key;

		public string TemplateTag1Value
		{
			get
			{
				return templateTag1Value;
			}
			set	
			{
				templateTag1Value = value;
				DictionaryUtil.Add(QueryParameters, "TemplateTag.1.Value", value);
			}
		}

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

		public string TemplateTag4Key
		{
			get
			{
				return templateTag4Key;
			}
			set	
			{
				templateTag4Key = value;
				DictionaryUtil.Add(QueryParameters, "TemplateTag.4.Key", value);
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

		public string TemplateTag3Key
		{
			get
			{
				return templateTag3Key;
			}
			set	
			{
				templateTag3Key = value;
				DictionaryUtil.Add(QueryParameters, "TemplateTag.3.Key", value);
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public string TemplateTag5Value
		{
			get
			{
				return templateTag5Value;
			}
			set	
			{
				templateTag5Value = value;
				DictionaryUtil.Add(QueryParameters, "TemplateTag.5.Value", value);
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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string TemplateTag3Value
		{
			get
			{
				return templateTag3Value;
			}
			set	
			{
				templateTag3Value = value;
				DictionaryUtil.Add(QueryParameters, "TemplateTag.3.Value", value);
			}
		}

		public string TemplateTag2Key
		{
			get
			{
				return templateTag2Key;
			}
			set	
			{
				templateTag2Key = value;
				DictionaryUtil.Add(QueryParameters, "TemplateTag.2.Key", value);
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

		public string TemplateTag2Value
		{
			get
			{
				return templateTag2Value;
			}
			set	
			{
				templateTag2Value = value;
				DictionaryUtil.Add(QueryParameters, "TemplateTag.2.Value", value);
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

		public string TemplateTag4Value
		{
			get
			{
				return templateTag4Value;
			}
			set	
			{
				templateTag4Value = value;
				DictionaryUtil.Add(QueryParameters, "TemplateTag.4.Value", value);
			}
		}

		public string TemplateTag5Key
		{
			get
			{
				return templateTag5Key;
			}
			set	
			{
				templateTag5Key = value;
				DictionaryUtil.Add(QueryParameters, "TemplateTag.5.Key", value);
			}
		}

		public string TemplateTag1Key
		{
			get
			{
				return templateTag1Key;
			}
			set	
			{
				templateTag1Key = value;
				DictionaryUtil.Add(QueryParameters, "TemplateTag.1.Key", value);
			}
		}

        public override DescribeLaunchTemplatesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeLaunchTemplatesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}