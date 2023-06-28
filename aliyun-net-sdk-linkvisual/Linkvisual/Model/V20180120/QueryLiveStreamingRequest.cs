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
using Aliyun.Acs.Linkvisual.Transform;
using Aliyun.Acs.Linkvisual.Transform.V20180120;

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
    public class QueryLiveStreamingRequest : RpcAcsRequest<QueryLiveStreamingResponse>
    {
        public QueryLiveStreamingRequest()
            : base("Linkvisual", "2018-01-20", "QueryLiveStreaming", "Linkvisual", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string scheme;

		private bool? playUnLimited;

		private int? encryptType;

		private int? cacheDuration;

		private string iotId;

		private bool? forceIFrame;

		private string iotInstanceId;

		private bool? shouldEncrypt;

		private bool? enableStun;

		private int? streamType;

		private string productKey;

		private string deviceName;

		private int? urlValidDuration;

		public string Scheme
		{
			get
			{
				return scheme;
			}
			set	
			{
				scheme = value;
				DictionaryUtil.Add(QueryParameters, "Scheme", value);
			}
		}

		public bool? PlayUnLimited
		{
			get
			{
				return playUnLimited;
			}
			set	
			{
				playUnLimited = value;
				DictionaryUtil.Add(QueryParameters, "PlayUnLimited", value.ToString());
			}
		}

		public int? EncryptType
		{
			get
			{
				return encryptType;
			}
			set	
			{
				encryptType = value;
				DictionaryUtil.Add(QueryParameters, "EncryptType", value.ToString());
			}
		}

		public int? CacheDuration
		{
			get
			{
				return cacheDuration;
			}
			set	
			{
				cacheDuration = value;
				DictionaryUtil.Add(QueryParameters, "CacheDuration", value.ToString());
			}
		}

		public string IotId
		{
			get
			{
				return iotId;
			}
			set	
			{
				iotId = value;
				DictionaryUtil.Add(QueryParameters, "IotId", value);
			}
		}

		public bool? ForceIFrame
		{
			get
			{
				return forceIFrame;
			}
			set	
			{
				forceIFrame = value;
				DictionaryUtil.Add(QueryParameters, "ForceIFrame", value.ToString());
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public bool? ShouldEncrypt
		{
			get
			{
				return shouldEncrypt;
			}
			set	
			{
				shouldEncrypt = value;
				DictionaryUtil.Add(QueryParameters, "ShouldEncrypt", value.ToString());
			}
		}

		public bool? EnableStun
		{
			get
			{
				return enableStun;
			}
			set	
			{
				enableStun = value;
				DictionaryUtil.Add(QueryParameters, "EnableStun", value.ToString());
			}
		}

		public int? StreamType
		{
			get
			{
				return streamType;
			}
			set	
			{
				streamType = value;
				DictionaryUtil.Add(QueryParameters, "StreamType", value.ToString());
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public string DeviceName
		{
			get
			{
				return deviceName;
			}
			set	
			{
				deviceName = value;
				DictionaryUtil.Add(QueryParameters, "DeviceName", value);
			}
		}

		public int? UrlValidDuration
		{
			get
			{
				return urlValidDuration;
			}
			set	
			{
				urlValidDuration = value;
				DictionaryUtil.Add(QueryParameters, "UrlValidDuration", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryLiveStreamingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryLiveStreamingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
