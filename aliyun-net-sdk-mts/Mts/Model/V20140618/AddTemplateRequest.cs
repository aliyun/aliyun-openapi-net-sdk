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
using Aliyun.Acs.Mts.Transform;
using Aliyun.Acs.Mts.Transform.V20140618;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class AddTemplateRequest : RpcAcsRequest<AddTemplateResponse>
    {
        public AddTemplateRequest()
            : base("Mts", "2014-06-18", "AddTemplate", "mts", "openAPI")
        {
        }

		private string container;

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string name;

		private string action;

		private string transConfig;

		private string muxConfig;

		private string video;

		private string audio;

		private long? ownerId;

		private string accessKeyId;

		public string Container
		{
			get
			{
				return container;
			}
			set	
			{
				container = value;
				DictionaryUtil.Add(QueryParameters, "Container", value);
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

		public string TransConfig
		{
			get
			{
				return transConfig;
			}
			set	
			{
				transConfig = value;
				DictionaryUtil.Add(QueryParameters, "TransConfig", value);
			}
		}

		public string MuxConfig
		{
			get
			{
				return muxConfig;
			}
			set	
			{
				muxConfig = value;
				DictionaryUtil.Add(QueryParameters, "MuxConfig", value);
			}
		}

		public string Video
		{
			get
			{
				return video;
			}
			set	
			{
				video = value;
				DictionaryUtil.Add(QueryParameters, "Video", value);
			}
		}

		public string Audio
		{
			get
			{
				return audio;
			}
			set	
			{
				audio = value;
				DictionaryUtil.Add(QueryParameters, "Audio", value);
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

        public override AddTemplateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AddTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}