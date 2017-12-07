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
    public class CreateUploadImageRequest : RpcAcsRequest<CreateUploadImageResponse>
    {
        public CreateUploadImageRequest()
            : base("vod", "2017-03-21", "CreateUploadImage")
        {
        }

		private long? resourceOwnerId;

		private string imageType;

		private string originalFileName;

		private string resourceOwnerAccount;

		private string imageExt;

		private string action;

		private long? ownerId;

		private string title;

		private string accessKeyId;

		private string tags;

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

		public string ImageType
		{
			get
			{
				return imageType;
			}
			set	
			{
				imageType = value;
				DictionaryUtil.Add(QueryParameters, "ImageType", value);
			}
		}

		public string OriginalFileName
		{
			get
			{
				return originalFileName;
			}
			set	
			{
				originalFileName = value;
				DictionaryUtil.Add(QueryParameters, "OriginalFileName", value);
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

		public string ImageExt
		{
			get
			{
				return imageExt;
			}
			set	
			{
				imageExt = value;
				DictionaryUtil.Add(QueryParameters, "ImageExt", value);
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

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
			}
		}

        public override CreateUploadImageResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateUploadImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}