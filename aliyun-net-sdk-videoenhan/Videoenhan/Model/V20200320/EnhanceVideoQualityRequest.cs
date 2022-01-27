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
using Aliyun.Acs.videoenhan.Transform;
using Aliyun.Acs.videoenhan.Transform.V20200320;

namespace Aliyun.Acs.videoenhan.Model.V20200320
{
    public class EnhanceVideoQualityRequest : RpcAcsRequest<EnhanceVideoQualityResponse>
    {
        public EnhanceVideoQualityRequest()
            : base("videoenhan", "2020-03-20", "EnhanceVideoQuality", "videoenhan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.videoenhan.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.videoenhan.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string hDRFormat;

		private int? frameRate;

		private int? maxIlluminance;

		private int? bitrate;

		private int? outPutWidth;

		private int? outPutHeight;

		private string videoURL;

		public string HDRFormat
		{
			get
			{
				return hDRFormat;
			}
			set	
			{
				hDRFormat = value;
				DictionaryUtil.Add(BodyParameters, "HDRFormat", value);
			}
		}

		public int? FrameRate
		{
			get
			{
				return frameRate;
			}
			set	
			{
				frameRate = value;
				DictionaryUtil.Add(BodyParameters, "FrameRate", value.ToString());
			}
		}

		public int? MaxIlluminance
		{
			get
			{
				return maxIlluminance;
			}
			set	
			{
				maxIlluminance = value;
				DictionaryUtil.Add(BodyParameters, "MaxIlluminance", value.ToString());
			}
		}

		public int? Bitrate
		{
			get
			{
				return bitrate;
			}
			set	
			{
				bitrate = value;
				DictionaryUtil.Add(BodyParameters, "Bitrate", value.ToString());
			}
		}

		public int? OutPutWidth
		{
			get
			{
				return outPutWidth;
			}
			set	
			{
				outPutWidth = value;
				DictionaryUtil.Add(BodyParameters, "OutPutWidth", value.ToString());
			}
		}

		public int? OutPutHeight
		{
			get
			{
				return outPutHeight;
			}
			set	
			{
				outPutHeight = value;
				DictionaryUtil.Add(BodyParameters, "OutPutHeight", value.ToString());
			}
		}

		public string VideoURL
		{
			get
			{
				return videoURL;
			}
			set	
			{
				videoURL = value;
				DictionaryUtil.Add(BodyParameters, "VideoURL", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override EnhanceVideoQualityResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return EnhanceVideoQualityResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
