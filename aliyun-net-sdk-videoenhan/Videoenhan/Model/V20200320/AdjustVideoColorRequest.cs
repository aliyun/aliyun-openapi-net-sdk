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
    public class AdjustVideoColorRequest : RpcAcsRequest<AdjustVideoColorResponse>
    {
        public AdjustVideoColorRequest()
            : base("videoenhan", "2020-03-20", "AdjustVideoColor", "videoenhan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.videoenhan.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.videoenhan.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string mode;

		private string videoUrl;

		private long? videoBitrate;

		private string videoCodec;

		private string videoFormat;

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(BodyParameters, "Mode", value);
			}
		}

		public string VideoUrl
		{
			get
			{
				return videoUrl;
			}
			set	
			{
				videoUrl = value;
				DictionaryUtil.Add(BodyParameters, "VideoUrl", value);
			}
		}

		public long? VideoBitrate
		{
			get
			{
				return videoBitrate;
			}
			set	
			{
				videoBitrate = value;
				DictionaryUtil.Add(BodyParameters, "VideoBitrate", value.ToString());
			}
		}

		public string VideoCodec
		{
			get
			{
				return videoCodec;
			}
			set	
			{
				videoCodec = value;
				DictionaryUtil.Add(BodyParameters, "VideoCodec", value);
			}
		}

		public string VideoFormat
		{
			get
			{
				return videoFormat;
			}
			set	
			{
				videoFormat = value;
				DictionaryUtil.Add(BodyParameters, "VideoFormat", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AdjustVideoColorResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AdjustVideoColorResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
