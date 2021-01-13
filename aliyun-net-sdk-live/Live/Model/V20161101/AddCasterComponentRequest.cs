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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class AddCasterComponentRequest : RpcAcsRequest<AddCasterComponentResponse>
    {
        public AddCasterComponentRequest()
            : base("live", "2016-11-01", "AddCasterComponent", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string htmlLayerContent;

		private string imageLayerContent;

		private string componentName;

		private string layerOrder;

		private string casterId;

		private string componentLayer;

		private long? ownerId;

		private string componentType;

		private string locationId;

		private string effect;

		private string captionLayerContent;

		private string textLayerContent;

		public string HtmlLayerContent
		{
			get
			{
				return htmlLayerContent;
			}
			set	
			{
				htmlLayerContent = value;
				DictionaryUtil.Add(QueryParameters, "HtmlLayerContent", value);
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

		public string LayerOrder
		{
			get
			{
				return layerOrder;
			}
			set	
			{
				layerOrder = value;
				DictionaryUtil.Add(QueryParameters, "LayerOrder", value);
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

		public string LocationId
		{
			get
			{
				return locationId;
			}
			set	
			{
				locationId = value;
				DictionaryUtil.Add(QueryParameters, "LocationId", value);
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

        public override AddCasterComponentResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddCasterComponentResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
