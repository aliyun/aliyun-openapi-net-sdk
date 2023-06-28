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
    public class GenerateSuperResolutionImageRequest : RpcAcsRequest<GenerateSuperResolutionImageResponse>
    {
        public GenerateSuperResolutionImageRequest()
            : base("imageenhan", "2019-09-30", "GenerateSuperResolutionImage", "imageenhan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imageenhan.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imageenhan.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? scale;

		private string userData;

		private string outputFormat;

		private string imageUrl;

		private int? outputQuality;

		public int? Scale
		{
			get
			{
				return scale;
			}
			set	
			{
				scale = value;
				DictionaryUtil.Add(BodyParameters, "Scale", value.ToString());
			}
		}

		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
				DictionaryUtil.Add(BodyParameters, "UserData", value);
			}
		}

		public string OutputFormat
		{
			get
			{
				return outputFormat;
			}
			set	
			{
				outputFormat = value;
				DictionaryUtil.Add(BodyParameters, "OutputFormat", value);
			}
		}

		public string ImageUrl
		{
			get
			{
				return imageUrl;
			}
			set	
			{
				imageUrl = value;
				DictionaryUtil.Add(BodyParameters, "ImageUrl", value);
			}
		}

		public int? OutputQuality
		{
			get
			{
				return outputQuality;
			}
			set	
			{
				outputQuality = value;
				DictionaryUtil.Add(BodyParameters, "OutputQuality", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GenerateSuperResolutionImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GenerateSuperResolutionImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
