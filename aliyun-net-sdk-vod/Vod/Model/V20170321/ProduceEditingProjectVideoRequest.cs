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
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class ProduceEditingProjectVideoRequest : RpcAcsRequest<ProduceEditingProjectVideoResponse>
    {
        public ProduceEditingProjectVideoRequest()
            : base("vod", "2017-03-21", "ProduceEditingProjectVideo", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string description;

		private string title;

		private string coverURL;

		private string userData;

		private string produceConfig;

		private string projectId;

		private string mediaMetadata;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string timeline;

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

		public string Title
		{
			get
			{
				return title;
			}
			set	
			{
				title = value;
				DictionaryUtil.Add(QueryParameters, "Title", value);
			}
		}

		public string CoverURL
		{
			get
			{
				return coverURL;
			}
			set	
			{
				coverURL = value;
				DictionaryUtil.Add(QueryParameters, "CoverURL", value);
			}
		}

		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
				DictionaryUtil.Add(QueryParameters, "UserData", value);
			}
		}

		public string ProduceConfig
		{
			get
			{
				return produceConfig;
			}
			set	
			{
				produceConfig = value;
				DictionaryUtil.Add(QueryParameters, "ProduceConfig", value);
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value);
			}
		}

		public string MediaMetadata
		{
			get
			{
				return mediaMetadata;
			}
			set	
			{
				mediaMetadata = value;
				DictionaryUtil.Add(QueryParameters, "MediaMetadata", value);
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

		public string Timeline
		{
			get
			{
				return timeline;
			}
			set	
			{
				timeline = value;
				DictionaryUtil.Add(QueryParameters, "Timeline", value);
			}
		}

        public override ProduceEditingProjectVideoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ProduceEditingProjectVideoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
