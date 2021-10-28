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
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20201112;

namespace Aliyun.Acs.Cloudauth.Model.V20201112
{
    public class LivenessDetectRequest : RpcAcsRequest<LivenessDetectResponse>
    {
        public LivenessDetectRequest()
            : base("Cloudauth", "2020-11-12", "LivenessDetect", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string mediaCategory;

		private string mediaUrl;

		private string bizType;

		private string bizId;

		private string mediaFile;

		public string MediaCategory
		{
			get
			{
				return mediaCategory;
			}
			set	
			{
				mediaCategory = value;
				DictionaryUtil.Add(BodyParameters, "MediaCategory", value);
			}
		}

		public string MediaUrl
		{
			get
			{
				return mediaUrl;
			}
			set	
			{
				mediaUrl = value;
				DictionaryUtil.Add(BodyParameters, "MediaUrl", value);
			}
		}

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(BodyParameters, "BizType", value);
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(BodyParameters, "BizId", value);
			}
		}

		public string MediaFile
		{
			get
			{
				return mediaFile;
			}
			set	
			{
				mediaFile = value;
				DictionaryUtil.Add(BodyParameters, "MediaFile", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override LivenessDetectResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return LivenessDetectResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
