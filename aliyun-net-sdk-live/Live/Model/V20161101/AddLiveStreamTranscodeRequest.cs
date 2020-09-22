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
    public class AddLiveStreamTranscodeRequest : RpcAcsRequest<AddLiveStreamTranscodeResponse>
    {
        public AddLiveStreamTranscodeRequest()
            : base("live", "2016-11-01", "AddLiveStreamTranscode", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string template;

		private string lazy;

		private string mix;

		private string app;

		private string watermark;

		private long? ownerId;

		private string domain;

		private string waterPattern;

		private string onlyAudio;

		public string Template
		{
			get
			{
				return template;
			}
			set	
			{
				template = value;
				DictionaryUtil.Add(QueryParameters, "Template", value);
			}
		}

		public string Lazy
		{
			get
			{
				return lazy;
			}
			set	
			{
				lazy = value;
				DictionaryUtil.Add(QueryParameters, "Lazy", value);
			}
		}

		public string Mix
		{
			get
			{
				return mix;
			}
			set	
			{
				mix = value;
				DictionaryUtil.Add(QueryParameters, "Mix", value);
			}
		}

		public string App
		{
			get
			{
				return app;
			}
			set	
			{
				app = value;
				DictionaryUtil.Add(QueryParameters, "App", value);
			}
		}

		public string Watermark
		{
			get
			{
				return watermark;
			}
			set	
			{
				watermark = value;
				DictionaryUtil.Add(QueryParameters, "Watermark", value);
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

		public string WaterPattern
		{
			get
			{
				return waterPattern;
			}
			set	
			{
				waterPattern = value;
				DictionaryUtil.Add(QueryParameters, "WaterPattern", value);
			}
		}

		public string OnlyAudio
		{
			get
			{
				return onlyAudio;
			}
			set	
			{
				onlyAudio = value;
				DictionaryUtil.Add(QueryParameters, "OnlyAudio", value);
			}
		}

        public override AddLiveStreamTranscodeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddLiveStreamTranscodeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
