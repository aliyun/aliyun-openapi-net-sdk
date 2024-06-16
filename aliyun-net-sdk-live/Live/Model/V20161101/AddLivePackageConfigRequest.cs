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
    public class AddLivePackageConfigRequest : RpcAcsRequest<AddLivePackageConfigResponse>
    {
        public AddLivePackageConfigRequest()
            : base("live", "2016-11-01", "AddLivePackageConfig", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? segmentNum;

		private string protocol;

		private string appName;

		private int? partDuration;

		private string streamName;

		private bool? ignoreTranscode;

		private string domainName;

		private long? ownerId;

		private int? segmentDuration;

		[JsonProperty(PropertyName = "SegmentNum")]
		public int? SegmentNum
		{
			get
			{
				return segmentNum;
			}
			set	
			{
				segmentNum = value;
				DictionaryUtil.Add(QueryParameters, "SegmentNum", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Protocol")]
		public string Protocol
		{
			get
			{
				return protocol;
			}
			set	
			{
				protocol = value;
				DictionaryUtil.Add(QueryParameters, "Protocol", value);
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

		[JsonProperty(PropertyName = "PartDuration")]
		public int? PartDuration
		{
			get
			{
				return partDuration;
			}
			set	
			{
				partDuration = value;
				DictionaryUtil.Add(QueryParameters, "PartDuration", value.ToString());
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

		[JsonProperty(PropertyName = "IgnoreTranscode")]
		public bool? IgnoreTranscode
		{
			get
			{
				return ignoreTranscode;
			}
			set	
			{
				ignoreTranscode = value;
				DictionaryUtil.Add(QueryParameters, "IgnoreTranscode", value.ToString());
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

		[JsonProperty(PropertyName = "SegmentDuration")]
		public int? SegmentDuration
		{
			get
			{
				return segmentDuration;
			}
			set	
			{
				segmentDuration = value;
				DictionaryUtil.Add(QueryParameters, "SegmentDuration", value.ToString());
			}
		}

        public override AddLivePackageConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddLivePackageConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
