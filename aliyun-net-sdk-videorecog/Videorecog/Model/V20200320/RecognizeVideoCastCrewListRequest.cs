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
using Aliyun.Acs.videorecog.Transform;
using Aliyun.Acs.videorecog.Transform.V20200320;

namespace Aliyun.Acs.videorecog.Model.V20200320
{
    public class RecognizeVideoCastCrewListRequest : RpcAcsRequest<RecognizeVideoCastCrewListResponse>
    {
        public RecognizeVideoCastCrewListRequest()
            : base("videorecog", "2020-03-20", "RecognizeVideoCastCrewList", "videorecog", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.videorecog.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.videorecog.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<Params> _params = new List<Params>(){ };

		private string registerUrl;

		private string videoUrl;

		[JsonProperty(PropertyName = "Params")]
		public List<Params> _Params
		{
			get
			{
				return _params;
			}

			set
			{
				_params = value;
				if(_params != null)
				{
					for (int depth1 = 0; depth1 < _params.Count; depth1++)
					{
						if(_params[depth1] != null)
						{

							DictionaryUtil.Add(BodyParameters,"Params." + (depth1 + 1) +".Type", _params[depth1].Type);
						}
					}
				}
			}
		}

		[JsonProperty(PropertyName = "RegisterUrl")]
		public string RegisterUrl
		{
			get
			{
				return registerUrl;
			}
			set	
			{
				registerUrl = value;
				DictionaryUtil.Add(BodyParameters, "RegisterUrl", value);
			}
		}

		[JsonProperty(PropertyName = "VideoUrl")]
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

		public class Params
		{

			private string type;

			[JsonProperty(PropertyName = "Type")]
			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RecognizeVideoCastCrewListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RecognizeVideoCastCrewListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
