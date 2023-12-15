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
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class UploadStreamByURLRequest : RpcAcsRequest<UploadStreamByURLResponse>
    {
        public UploadStreamByURLRequest()
            : base("vod", "2017-03-21", "UploadStreamByURL", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string fileExtension;

		private string userData;

		private string hDRType;

		private string definition;

		private string streamURL;

		private string mediaId;

		[JsonProperty(PropertyName = "FileExtension")]
		public string FileExtension
		{
			get
			{
				return fileExtension;
			}
			set	
			{
				fileExtension = value;
				DictionaryUtil.Add(QueryParameters, "FileExtension", value);
			}
		}

		[JsonProperty(PropertyName = "UserData")]
		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
				DictionaryUtil.Add(QueryParameters, "UserData", value);
			}
		}

		[JsonProperty(PropertyName = "HDRType")]
		public string HDRType
		{
			get
			{
				return hDRType;
			}
			set	
			{
				hDRType = value;
				DictionaryUtil.Add(QueryParameters, "HDRType", value);
			}
		}

		[JsonProperty(PropertyName = "Definition")]
		public string Definition
		{
			get
			{
				return definition;
			}
			set	
			{
				definition = value;
				DictionaryUtil.Add(QueryParameters, "Definition", value);
			}
		}

		[JsonProperty(PropertyName = "StreamURL")]
		public string StreamURL
		{
			get
			{
				return streamURL;
			}
			set	
			{
				streamURL = value;
				DictionaryUtil.Add(QueryParameters, "StreamURL", value);
			}
		}

		[JsonProperty(PropertyName = "MediaId")]
		public string MediaId
		{
			get
			{
				return mediaId;
			}
			set	
			{
				mediaId = value;
				DictionaryUtil.Add(QueryParameters, "MediaId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UploadStreamByURLResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UploadStreamByURLResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
