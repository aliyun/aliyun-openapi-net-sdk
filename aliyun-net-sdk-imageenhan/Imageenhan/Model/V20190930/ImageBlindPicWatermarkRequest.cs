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
    public class ImageBlindPicWatermarkRequest : RpcAcsRequest<ImageBlindPicWatermarkResponse>
    {
        public ImageBlindPicWatermarkRequest()
            : base("imageenhan", "2019-09-30", "ImageBlindPicWatermark", "imageenhan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imageenhan.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imageenhan.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string watermarkImageURL;

		private int? qualityFactor;

		private string functionType;

		private string logoURL;

		private string outputFileType;

		private string originImageURL;

		public string WatermarkImageURL
		{
			get
			{
				return watermarkImageURL;
			}
			set	
			{
				watermarkImageURL = value;
				DictionaryUtil.Add(BodyParameters, "WatermarkImageURL", value);
			}
		}

		public int? QualityFactor
		{
			get
			{
				return qualityFactor;
			}
			set	
			{
				qualityFactor = value;
				DictionaryUtil.Add(BodyParameters, "QualityFactor", value.ToString());
			}
		}

		public string FunctionType
		{
			get
			{
				return functionType;
			}
			set	
			{
				functionType = value;
				DictionaryUtil.Add(BodyParameters, "FunctionType", value);
			}
		}

		public string LogoURL
		{
			get
			{
				return logoURL;
			}
			set	
			{
				logoURL = value;
				DictionaryUtil.Add(BodyParameters, "LogoURL", value);
			}
		}

		public string OutputFileType
		{
			get
			{
				return outputFileType;
			}
			set	
			{
				outputFileType = value;
				DictionaryUtil.Add(BodyParameters, "OutputFileType", value);
			}
		}

		public string OriginImageURL
		{
			get
			{
				return originImageURL;
			}
			set	
			{
				originImageURL = value;
				DictionaryUtil.Add(BodyParameters, "OriginImageURL", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ImageBlindPicWatermarkResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImageBlindPicWatermarkResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
