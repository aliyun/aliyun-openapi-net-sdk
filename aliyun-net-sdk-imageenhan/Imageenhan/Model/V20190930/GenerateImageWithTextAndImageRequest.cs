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
using Aliyun.Acs.imageenhan.Transform;
using Aliyun.Acs.imageenhan.Transform.V20190930;

namespace Aliyun.Acs.imageenhan.Model.V20190930
{
    public class GenerateImageWithTextAndImageRequest : RpcAcsRequest<GenerateImageWithTextAndImageResponse>
    {
        public GenerateImageWithTextAndImageRequest()
            : base("imageenhan", "2019-09-30", "GenerateImageWithTextAndImage", "imageenhan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imageenhan.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imageenhan.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resolution;

		private int? number;

		private float? similarity;

		private string aspectRatioMode;

		private string text;

		private string refImageUrl;

		public string Resolution
		{
			get
			{
				return resolution;
			}
			set	
			{
				resolution = value;
				DictionaryUtil.Add(BodyParameters, "Resolution", value);
			}
		}

		public int? Number
		{
			get
			{
				return number;
			}
			set	
			{
				number = value;
				DictionaryUtil.Add(BodyParameters, "Number", value.ToString());
			}
		}

		public float? Similarity
		{
			get
			{
				return similarity;
			}
			set	
			{
				similarity = value;
				DictionaryUtil.Add(BodyParameters, "Similarity", value.ToString());
			}
		}

		public string AspectRatioMode
		{
			get
			{
				return aspectRatioMode;
			}
			set	
			{
				aspectRatioMode = value;
				DictionaryUtil.Add(BodyParameters, "AspectRatioMode", value);
			}
		}

		public string Text
		{
			get
			{
				return text;
			}
			set	
			{
				text = value;
				DictionaryUtil.Add(BodyParameters, "Text", value);
			}
		}

		public string RefImageUrl
		{
			get
			{
				return refImageUrl;
			}
			set	
			{
				refImageUrl = value;
				DictionaryUtil.Add(BodyParameters, "RefImageUrl", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GenerateImageWithTextAndImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GenerateImageWithTextAndImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
