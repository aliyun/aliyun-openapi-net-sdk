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
    public class ForbidLiveCustomStreamRequest : RpcAcsRequest<ForbidLiveCustomStreamResponse>
    {
        public ForbidLiveCustomStreamRequest()
            : base("live", "2016-11-01", "ForbidLiveCustomStream", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string styp;

		private string appName;

		private string streamName;

		private string needwm;

		private string resumeTime;

		private string liveStreamType;

		private string domainName;

		private long? ownerId;

		private string sphd;

		private string oneshot;

		private string appid;

		private string ratio;

		public string Styp
		{
			get
			{
				return styp;
			}
			set	
			{
				styp = value;
				DictionaryUtil.Add(QueryParameters, "Styp", value);
			}
		}

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

		public string Needwm
		{
			get
			{
				return needwm;
			}
			set	
			{
				needwm = value;
				DictionaryUtil.Add(QueryParameters, "Needwm", value);
			}
		}

		public string ResumeTime
		{
			get
			{
				return resumeTime;
			}
			set	
			{
				resumeTime = value;
				DictionaryUtil.Add(QueryParameters, "ResumeTime", value);
			}
		}

		public string LiveStreamType
		{
			get
			{
				return liveStreamType;
			}
			set	
			{
				liveStreamType = value;
				DictionaryUtil.Add(QueryParameters, "LiveStreamType", value);
			}
		}

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

		public string Sphd
		{
			get
			{
				return sphd;
			}
			set	
			{
				sphd = value;
				DictionaryUtil.Add(QueryParameters, "Sphd", value);
			}
		}

		public string Oneshot
		{
			get
			{
				return oneshot;
			}
			set	
			{
				oneshot = value;
				DictionaryUtil.Add(QueryParameters, "Oneshot", value);
			}
		}

		public string Appid
		{
			get
			{
				return appid;
			}
			set	
			{
				appid = value;
				DictionaryUtil.Add(QueryParameters, "Appid", value);
			}
		}

		public string Ratio
		{
			get
			{
				return ratio;
			}
			set	
			{
				ratio = value;
				DictionaryUtil.Add(QueryParameters, "Ratio", value);
			}
		}

        public override ForbidLiveCustomStreamResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ForbidLiveCustomStreamResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
