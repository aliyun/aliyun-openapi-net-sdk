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
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class GetPlayInfoRequest : RpcAcsRequest<GetPlayInfoResponse>
    {
        public GetPlayInfoRequest()
            : base("vod", "2017-03-21", "GetPlayInfo", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string formats;

		private string reAuthInfo;

		private string playConfig;

		private string outputType;

		private string definition;

		private long? authTimeout;

		private string streamType;

		private string videoId;

		private string resultType;

		private string additionType;

		public string Formats
		{
			get
			{
				return formats;
			}
			set	
			{
				formats = value;
				DictionaryUtil.Add(QueryParameters, "Formats", value);
			}
		}

		public string ReAuthInfo
		{
			get
			{
				return reAuthInfo;
			}
			set	
			{
				reAuthInfo = value;
				DictionaryUtil.Add(QueryParameters, "ReAuthInfo", value);
			}
		}

		public string PlayConfig
		{
			get
			{
				return playConfig;
			}
			set	
			{
				playConfig = value;
				DictionaryUtil.Add(QueryParameters, "PlayConfig", value);
			}
		}

		public string OutputType
		{
			get
			{
				return outputType;
			}
			set	
			{
				outputType = value;
				DictionaryUtil.Add(QueryParameters, "OutputType", value);
			}
		}

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

		public long? AuthTimeout
		{
			get
			{
				return authTimeout;
			}
			set	
			{
				authTimeout = value;
				DictionaryUtil.Add(QueryParameters, "AuthTimeout", value.ToString());
			}
		}

		public string StreamType
		{
			get
			{
				return streamType;
			}
			set	
			{
				streamType = value;
				DictionaryUtil.Add(QueryParameters, "StreamType", value);
			}
		}

		public string VideoId
		{
			get
			{
				return videoId;
			}
			set	
			{
				videoId = value;
				DictionaryUtil.Add(QueryParameters, "VideoId", value);
			}
		}

		public string ResultType
		{
			get
			{
				return resultType;
			}
			set	
			{
				resultType = value;
				DictionaryUtil.Add(QueryParameters, "ResultType", value);
			}
		}

		public string AdditionType
		{
			get
			{
				return additionType;
			}
			set	
			{
				additionType = value;
				DictionaryUtil.Add(QueryParameters, "AdditionType", value);
			}
		}

        public override GetPlayInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetPlayInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
