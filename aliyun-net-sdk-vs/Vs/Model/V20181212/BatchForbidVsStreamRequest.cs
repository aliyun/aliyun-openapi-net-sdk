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
using Aliyun.Acs.vs;
using Aliyun.Acs.vs.Transform;
using Aliyun.Acs.vs.Transform.V20181212;

namespace Aliyun.Acs.vs.Model.V20181212
{
    public class BatchForbidVsStreamRequest : RpcAcsRequest<BatchForbidVsStreamResponse>
    {
        public BatchForbidVsStreamRequest()
            : base("vs", "2018-12-12", "BatchForbidVsStream")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string channel;

		private string controlStreamAction;

		private string resumeTime;

		private string liveStreamType;

		private string domainName;

		private long? ownerId;

		private string oneshot;

		public string Channel
		{
			get
			{
				return channel;
			}
			set	
			{
				channel = value;
				DictionaryUtil.Add(QueryParameters, "Channel", value);
			}
		}

		public string ControlStreamAction
		{
			get
			{
				return controlStreamAction;
			}
			set	
			{
				controlStreamAction = value;
				DictionaryUtil.Add(QueryParameters, "ControlStreamAction", value);
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

        public override BatchForbidVsStreamResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchForbidVsStreamResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
