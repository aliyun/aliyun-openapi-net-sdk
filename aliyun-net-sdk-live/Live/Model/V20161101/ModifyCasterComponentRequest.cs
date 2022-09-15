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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class ModifyCasterComponentRequest : RpcAcsRequest<ModifyCasterComponentResponse>
    {
        public ModifyCasterComponentRequest()
            : base("live", "2016-11-01", "ModifyCasterComponent", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string imageLayerContent;

		private string componentName;

		private string componentId;

		private string casterId;

		private string componentLayer;

		private long? ownerId;

		private string componentType;

		private string effect;

		private string captionLayerContent;

		private string textLayerContent;

		[JsonProperty(PropertyName = "ImageLayerContent")]
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

		[JsonProperty(PropertyName = "ComponentName")]
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

		[JsonProperty(PropertyName = "ComponentId")]
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

		[JsonProperty(PropertyName = "CasterId")]
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

		[JsonProperty(PropertyName = "ComponentLayer")]
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

		[JsonProperty(PropertyName = "OwnerId")]
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

		[JsonProperty(PropertyName = "ComponentType")]
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

		[JsonProperty(PropertyName = "Effect")]
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

		[JsonProperty(PropertyName = "CaptionLayerContent")]
		public string CaptionLayerContent
		{
			get
			{
				return captionLayerContent;
			}
			set	
			{
				captionLayerContent = value;
				DictionaryUtil.Add(QueryParameters, "CaptionLayerContent", value);
			}
		}

		[JsonProperty(PropertyName = "TextLayerContent")]
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

        public override ModifyCasterComponentResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyCasterComponentResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
