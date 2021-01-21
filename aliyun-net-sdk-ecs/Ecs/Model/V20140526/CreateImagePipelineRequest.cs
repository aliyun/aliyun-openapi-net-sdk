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
    public class CreateImagePipelineRequest : RpcAcsRequest<CreateImagePipelineResponse>
    {
        public CreateImagePipelineRequest()
            : base("Ecs", "2014-05-26", "CreateImagePipeline", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string baseImageType;

		private long? resourceOwnerId;

		private string clientToken;

		private List<string> toRegionIds = new List<string>(){ };

		private int? internetMaxBandwidthOut;

		private string description;

		private string resourceGroupId;

		private string imageName;

		private int? systemDiskSize;

		private string instanceType;

		private List<Tag> tags = new List<Tag>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string baseImage;

		private string vSwitchId;

		private List<long?> addAccounts = new List<long?>(){ };

		private bool? deleteInstanceOnFailure;

		private string name;

		private string buildContent;

		public string BaseImageType
		{
			get
			{
				return baseImageType;
			}
			set	
			{
				baseImageType = value;
				DictionaryUtil.Add(QueryParameters, "BaseImageType", value);
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

		public List<string> ToRegionIds
		{
			get
			{
				return toRegionIds;
			}

			set
			{
				toRegionIds = value;
				for (int i = 0; i < toRegionIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ToRegionId." + (i + 1) , toRegionIds[i]);
				}
			}
		}

		public int? InternetMaxBandwidthOut
		{
			get
			{
				return internetMaxBandwidthOut;
			}
			set	
			{
				internetMaxBandwidthOut = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthOut", value.ToString());
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

		public string ImageName
		{
			get
			{
				return imageName;
			}
			set	
			{
				imageName = value;
				DictionaryUtil.Add(QueryParameters, "ImageName", value);
			}
		}

		public int? SystemDiskSize
		{
			get
			{
				return systemDiskSize;
			}
			set	
			{
				systemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskSize", value.ToString());
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
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

		public string BaseImage
		{
			get
			{
				return baseImage;
			}
			set	
			{
				baseImage = value;
				DictionaryUtil.Add(QueryParameters, "BaseImage", value);
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

		public List<long?> AddAccounts
		{
			get
			{
				return addAccounts;
			}

			set
			{
				addAccounts = value;
				for (int i = 0; i < addAccounts.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AddAccount." + (i + 1) , addAccounts[i]);
				}
			}
		}

		public bool? DeleteInstanceOnFailure
		{
			get
			{
				return deleteInstanceOnFailure;
			}
			set	
			{
				deleteInstanceOnFailure = value;
				DictionaryUtil.Add(QueryParameters, "DeleteInstanceOnFailure", value.ToString());
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

		public string BuildContent
		{
			get
			{
				return buildContent;
			}
			set	
			{
				buildContent = value;
				DictionaryUtil.Add(QueryParameters, "BuildContent", value);
			}
		}

		public class Tag
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

        public override CreateImagePipelineResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateImagePipelineResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
