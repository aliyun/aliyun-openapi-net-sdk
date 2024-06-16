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
    public class RestartTranscodeTaskRequest : RpcAcsRequest<RestartTranscodeTaskResponse>
    {
        public RestartTranscodeTaskRequest()
            : base("live", "2016-11-01", "RestartTranscodeTask", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string transcodingTemplate;

		private string securityToken;

		private string pushDomain;

		private string streamName;

		private string app;

		[JsonProperty(PropertyName = "TranscodingTemplate")]
		public string TranscodingTemplate
		{
			get
			{
				return transcodingTemplate;
			}
			set	
			{
				transcodingTemplate = value;
				DictionaryUtil.Add(QueryParameters, "TranscodingTemplate", value);
			}
		}

		[JsonProperty(PropertyName = "SecurityToken")]
		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		[JsonProperty(PropertyName = "PushDomain")]
		public string PushDomain
		{
			get
			{
				return pushDomain;
			}
			set	
			{
				pushDomain = value;
				DictionaryUtil.Add(QueryParameters, "PushDomain", value);
			}
		}

		[JsonProperty(PropertyName = "StreamName")]
		public string StreamName
		{
			get
			{
				return streamName;
			}
			set	
			{
				streamName = value;
				DictionaryUtil.Add(QueryParameters, "StreamName", value);
			}
		}

		[JsonProperty(PropertyName = "App")]
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RestartTranscodeTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RestartTranscodeTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
