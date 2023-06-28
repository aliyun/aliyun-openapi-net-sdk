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
    public class ModifyCasterVideoResourceRequest : RpcAcsRequest<ModifyCasterVideoResourceResponse>
    {
        public ModifyCasterVideoResourceRequest()
            : base("live", "2016-11-01", "ModifyCasterVideoResource", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string imageId;

		private int? endOffset;

		private string materialId;

		private string resourceId;

		private string vodUrl;

		private string casterId;

		private long? ownerId;

		private int? beginOffset;

		private string liveStreamUrl;

		private string imageUrl;

		private int? ptsCallbackInterval;

		private string resourceName;

		private int? repeatNum;

		[JsonProperty(PropertyName = "ImageId")]
		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		[JsonProperty(PropertyName = "EndOffset")]
		public int? EndOffset
		{
			get
			{
				return endOffset;
			}
			set	
			{
				endOffset = value;
				DictionaryUtil.Add(QueryParameters, "EndOffset", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "MaterialId")]
		public string MaterialId
		{
			get
			{
				return materialId;
			}
			set	
			{
				materialId = value;
				DictionaryUtil.Add(QueryParameters, "MaterialId", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceId")]
		public string ResourceId
		{
			get
			{
				return resourceId;
			}
			set	
			{
				resourceId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId", value);
			}
		}

		[JsonProperty(PropertyName = "VodUrl")]
		public string VodUrl
		{
			get
			{
				return vodUrl;
			}
			set	
			{
				vodUrl = value;
				DictionaryUtil.Add(QueryParameters, "VodUrl", value);
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

		[JsonProperty(PropertyName = "BeginOffset")]
		public int? BeginOffset
		{
			get
			{
				return beginOffset;
			}
			set	
			{
				beginOffset = value;
				DictionaryUtil.Add(QueryParameters, "BeginOffset", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "LiveStreamUrl")]
		public string LiveStreamUrl
		{
			get
			{
				return liveStreamUrl;
			}
			set	
			{
				liveStreamUrl = value;
				DictionaryUtil.Add(QueryParameters, "LiveStreamUrl", value);
			}
		}

		[JsonProperty(PropertyName = "ImageUrl")]
		public string ImageUrl
		{
			get
			{
				return imageUrl;
			}
			set	
			{
				imageUrl = value;
				DictionaryUtil.Add(QueryParameters, "ImageUrl", value);
			}
		}

		[JsonProperty(PropertyName = "PtsCallbackInterval")]
		public int? PtsCallbackInterval
		{
			get
			{
				return ptsCallbackInterval;
			}
			set	
			{
				ptsCallbackInterval = value;
				DictionaryUtil.Add(QueryParameters, "PtsCallbackInterval", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ResourceName")]
		public string ResourceName
		{
			get
			{
				return resourceName;
			}
			set	
			{
				resourceName = value;
				DictionaryUtil.Add(QueryParameters, "ResourceName", value);
			}
		}

		[JsonProperty(PropertyName = "RepeatNum")]
		public int? RepeatNum
		{
			get
			{
				return repeatNum;
			}
			set	
			{
				repeatNum = value;
				DictionaryUtil.Add(QueryParameters, "RepeatNum", value.ToString());
			}
		}

        public override ModifyCasterVideoResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyCasterVideoResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
