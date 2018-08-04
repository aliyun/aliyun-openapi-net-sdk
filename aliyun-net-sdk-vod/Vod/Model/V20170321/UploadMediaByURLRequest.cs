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
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class UploadMediaByURLRequest : RpcAcsRequest<UploadMediaByURLResponse>
    {
        public UploadMediaByURLRequest()
            : base("vod", "2017-03-21", "UploadMediaByURL", "vod", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string templateGroupId;

		private string uploadMetadatas;

		private string resourceOwnerAccount;

		private string uploadURLs;

		private string action;

		private string messageCallback;

		private long? ownerId;

		private string priority;

		private string storageLocation;

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

		public string TemplateGroupId
		{
			get
			{
				return templateGroupId;
			}
			set	
			{
				templateGroupId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateGroupId", value);
			}
		}

		public string UploadMetadatas
		{
			get
			{
				return uploadMetadatas;
			}
			set	
			{
				uploadMetadatas = value;
				DictionaryUtil.Add(QueryParameters, "UploadMetadatas", value);
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

		public string UploadURLs
		{
			get
			{
				return uploadURLs;
			}
			set	
			{
				uploadURLs = value;
				DictionaryUtil.Add(QueryParameters, "UploadURLs", value);
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

		public string MessageCallback
		{
			get
			{
				return messageCallback;
			}
			set	
			{
				messageCallback = value;
				DictionaryUtil.Add(QueryParameters, "MessageCallback", value);
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

		public string Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
				DictionaryUtil.Add(QueryParameters, "Priority", value);
			}
		}

		public string StorageLocation
		{
			get
			{
				return storageLocation;
			}
			set	
			{
				storageLocation = value;
				DictionaryUtil.Add(QueryParameters, "StorageLocation", value);
			}
		}

        public override UploadMediaByURLResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UploadMediaByURLResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}