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
    public class AddLiveStreamWatermarkRequest : RpcAcsRequest<AddLiveStreamWatermarkResponse>
    {
        public AddLiveStreamWatermarkRequest()
            : base("live", "2016-11-01", "AddLiveStreamWatermark", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private float? yOffset;

		private string pictureUrl;

		private string description;

		private int? type;

		private int? height;

		private float? xOffset;

		private long? ownerId;

		private int? refWidth;

		private int? transparency;

		private string domain;

		private string name;

		private string offsetCorner;

		private int? refHeight;

		[JsonProperty(PropertyName = "YOffset")]
		public float? YOffset
		{
			get
			{
				return yOffset;
			}
			set	
			{
				yOffset = value;
				DictionaryUtil.Add(QueryParameters, "YOffset", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "PictureUrl")]
		public string PictureUrl
		{
			get
			{
				return pictureUrl;
			}
			set	
			{
				pictureUrl = value;
				DictionaryUtil.Add(QueryParameters, "PictureUrl", value);
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

		[JsonProperty(PropertyName = "Type")]
		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Height")]
		public int? Height
		{
			get
			{
				return height;
			}
			set	
			{
				height = value;
				DictionaryUtil.Add(QueryParameters, "Height", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "XOffset")]
		public float? XOffset
		{
			get
			{
				return xOffset;
			}
			set	
			{
				xOffset = value;
				DictionaryUtil.Add(QueryParameters, "XOffset", value.ToString());
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

		[JsonProperty(PropertyName = "RefWidth")]
		public int? RefWidth
		{
			get
			{
				return refWidth;
			}
			set	
			{
				refWidth = value;
				DictionaryUtil.Add(QueryParameters, "RefWidth", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Transparency")]
		public int? Transparency
		{
			get
			{
				return transparency;
			}
			set	
			{
				transparency = value;
				DictionaryUtil.Add(QueryParameters, "Transparency", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Domain")]
		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
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

		[JsonProperty(PropertyName = "OffsetCorner")]
		public string OffsetCorner
		{
			get
			{
				return offsetCorner;
			}
			set	
			{
				offsetCorner = value;
				DictionaryUtil.Add(QueryParameters, "OffsetCorner", value);
			}
		}

		[JsonProperty(PropertyName = "RefHeight")]
		public int? RefHeight
		{
			get
			{
				return refHeight;
			}
			set	
			{
				refHeight = value;
				DictionaryUtil.Add(QueryParameters, "RefHeight", value.ToString());
			}
		}

        public override AddLiveStreamWatermarkResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddLiveStreamWatermarkResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
