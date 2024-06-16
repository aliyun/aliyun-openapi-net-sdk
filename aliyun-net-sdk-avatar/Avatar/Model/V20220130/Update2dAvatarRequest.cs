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
using Aliyun.Acs.avatar;
using Aliyun.Acs.avatar.Transform;
using Aliyun.Acs.avatar.Transform.V20220130;

namespace Aliyun.Acs.avatar.Model.V20220130
{
    public class Update2dAvatarRequest : RpcAcsRequest<Update2dAvatarResponse>
    {
        public Update2dAvatarRequest()
            : base("avatar", "2022-01-30", "Update2dAvatar")
        {
			Method = MethodType.POST;
        }

		private string image;

		private int? orientation;

		private string code;

		private string description;

		private string video;

		private string portrait;

		private bool? transparent;

		private long? tenantId;

		private string name;

		private bool? callback;

		[JsonProperty(PropertyName = "Image")]
		public string Image
		{
			get
			{
				return image;
			}
			set	
			{
				image = value;
				DictionaryUtil.Add(QueryParameters, "Image", value);
			}
		}

		[JsonProperty(PropertyName = "Orientation")]
		public int? Orientation
		{
			get
			{
				return orientation;
			}
			set	
			{
				orientation = value;
				DictionaryUtil.Add(QueryParameters, "Orientation", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Code")]
		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
				DictionaryUtil.Add(QueryParameters, "Code", value);
			}
		}

		[JsonProperty(PropertyName = "Description")]
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

		[JsonProperty(PropertyName = "Video")]
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

		[JsonProperty(PropertyName = "Portrait")]
		public string Portrait
		{
			get
			{
				return portrait;
			}
			set	
			{
				portrait = value;
				DictionaryUtil.Add(QueryParameters, "Portrait", value);
			}
		}

		[JsonProperty(PropertyName = "Transparent")]
		public bool? Transparent
		{
			get
			{
				return transparent;
			}
			set	
			{
				transparent = value;
				DictionaryUtil.Add(QueryParameters, "Transparent", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "TenantId")]
		public long? TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
				DictionaryUtil.Add(QueryParameters, "TenantId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Name")]
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

		[JsonProperty(PropertyName = "Callback")]
		public bool? Callback
		{
			get
			{
				return callback;
			}
			set	
			{
				callback = value;
				DictionaryUtil.Add(QueryParameters, "Callback", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override Update2dAvatarResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return Update2dAvatarResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
