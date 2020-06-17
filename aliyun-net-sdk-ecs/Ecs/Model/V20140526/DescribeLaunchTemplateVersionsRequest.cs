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
    public class DescribeLaunchTemplateVersionsRequest : RpcAcsRequest<DescribeLaunchTemplateVersionsResponse>
    {
        public DescribeLaunchTemplateVersionsRequest()
            : base("Ecs", "2014-05-26", "DescribeLaunchTemplateVersions", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string launchTemplateName;

		private long? maxVersion;

		private long? resourceOwnerId;

		private bool? defaultVersion;

		private long? minVersion;

		private int? pageNumber;

		private int? pageSize;

		private string launchTemplateId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<long?> launchTemplateVersions = new List<long?>(){ };

		private bool? detailFlag;

		public string LaunchTemplateName
		{
			get
			{
				return launchTemplateName;
			}
			set	
			{
				launchTemplateName = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateName", value);
			}
		}

		public long? MaxVersion
		{
			get
			{
				return maxVersion;
			}
			set	
			{
				maxVersion = value;
				DictionaryUtil.Add(QueryParameters, "MaxVersion", value.ToString());
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

		public bool? DefaultVersion
		{
			get
			{
				return defaultVersion;
			}
			set	
			{
				defaultVersion = value;
				DictionaryUtil.Add(QueryParameters, "DefaultVersion", value.ToString());
			}
		}

		public long? MinVersion
		{
			get
			{
				return minVersion;
			}
			set	
			{
				minVersion = value;
				DictionaryUtil.Add(QueryParameters, "MinVersion", value.ToString());
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

		public string LaunchTemplateId
		{
			get
			{
				return launchTemplateId;
			}
			set	
			{
				launchTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateId", value);
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

		public List<long?> LaunchTemplateVersions
		{
			get
			{
				return launchTemplateVersions;
			}

			set
			{
				launchTemplateVersions = value;
				for (int i = 0; i < launchTemplateVersions.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LaunchTemplateVersion." + (i + 1) , launchTemplateVersions[i]);
				}
			}
		}

		public bool? DetailFlag
		{
			get
			{
				return detailFlag;
			}
			set	
			{
				detailFlag = value;
				DictionaryUtil.Add(QueryParameters, "DetailFlag", value.ToString());
			}
		}

        public override DescribeLaunchTemplateVersionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeLaunchTemplateVersionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
