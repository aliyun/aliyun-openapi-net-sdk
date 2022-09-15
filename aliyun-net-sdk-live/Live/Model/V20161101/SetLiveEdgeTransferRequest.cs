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
    public class SetLiveEdgeTransferRequest : RpcAcsRequest<SetLiveEdgeTransferResponse>
    {
        public SetLiveEdgeTransferRequest()
            : base("live", "2016-11-01", "SetLiveEdgeTransfer", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string transferArgs;

		private string appName;

		private string streamName;

		private string targetDomainList;

		private string domainName;

		private long? ownerId;

		private string httpDns;

		[JsonProperty(PropertyName = "TransferArgs")]
		public string TransferArgs
		{
			get
			{
				return transferArgs;
			}
			set	
			{
				transferArgs = value;
				DictionaryUtil.Add(QueryParameters, "TransferArgs", value);
			}
		}

		[JsonProperty(PropertyName = "AppName")]
		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
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

		[JsonProperty(PropertyName = "TargetDomainList")]
		public string TargetDomainList
		{
			get
			{
				return targetDomainList;
			}
			set	
			{
				targetDomainList = value;
				DictionaryUtil.Add(QueryParameters, "TargetDomainList", value);
			}
		}

		[JsonProperty(PropertyName = "DomainName")]
		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
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

		[JsonProperty(PropertyName = "HttpDns")]
		public string HttpDns
		{
			get
			{
				return httpDns;
			}
			set	
			{
				httpDns = value;
				DictionaryUtil.Add(QueryParameters, "HttpDns", value);
			}
		}

        public override SetLiveEdgeTransferResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetLiveEdgeTransferResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
