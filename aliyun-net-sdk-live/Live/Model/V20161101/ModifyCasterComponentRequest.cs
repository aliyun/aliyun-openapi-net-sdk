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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class ModifyCasterComponentRequest : RpcAcsRequest<ModifyCasterComponentResponse>
    {
        public ModifyCasterComponentRequest()
            : base("live", "2016-11-01", "ModifyCasterComponent")
        {
        }

		private string componentId;

		private string imageLayerContent;

		private string casterId;

		private string componentLayer;

		private string componentName;

		private long? ownerId;

		private string version;

		private string accessKeyId;

		private string componentType;

		private string securityToken;

		private string effect;

		private string action;

		private string textLayerContent;

		public string ComponentId
		{
			get
			{
				return componentId;
			}
			set	
			{
				componentId = value;
				DictionaryUtil.Add(QueryParameters, "ComponentId", value);
			}
		}

		public string ImageLayerContent
		{
			get
			{
				return imageLayerContent;
			}
			set	
			{
				imageLayerContent = value;
				DictionaryUtil.Add(QueryParameters, "ImageLayerContent", value);
			}
		}

		public string CasterId
		{
			get
			{
				return casterId;
			}
			set	
			{
				casterId = value;
				DictionaryUtil.Add(QueryParameters, "CasterId", value);
			}
		}

		public string ComponentLayer
		{
			get
			{
				return componentLayer;
			}
			set	
			{
				componentLayer = value;
				DictionaryUtil.Add(QueryParameters, "ComponentLayer", value);
			}
		}

		public string ComponentName
		{
			get
			{
				return componentName;
			}
			set	
			{
				componentName = value;
				DictionaryUtil.Add(QueryParameters, "ComponentName", value);
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

		public string Version
		{
			get
			{
				return version;
			}
			set	
			{
				version = value;
				DictionaryUtil.Add(QueryParameters, "Version", value);
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

		public string ComponentType
		{
			get
			{
				return componentType;
			}
			set	
			{
				componentType = value;
				DictionaryUtil.Add(QueryParameters, "ComponentType", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string Effect
		{
			get
			{
				return effect;
			}
			set	
			{
				effect = value;
				DictionaryUtil.Add(QueryParameters, "Effect", value);
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

		public string TextLayerContent
		{
			get
			{
				return textLayerContent;
			}
			set	
			{
				textLayerContent = value;
				DictionaryUtil.Add(QueryParameters, "TextLayerContent", value);
			}
		}

        public override ModifyCasterComponentResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyCasterComponentResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}