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
    public class AddLiveStreamMergeRequest : RpcAcsRequest<AddLiveStreamMergeResponse>
    {
        public AddLiveStreamMergeRequest()
            : base("live", "2016-11-01", "AddLiveStreamMerge", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string inAppName2;

		private string inAppName1;

		private string startTime;

		private string protocol;

		private string appName;

		private string inStreamName2;

		private string streamName;

		private string inStreamName1;

		private string domainName;

		private string endTime;

		private long? ownerId;

		public string InAppName2
		{
			get
			{
				return inAppName2;
			}
			set	
			{
				inAppName2 = value;
				DictionaryUtil.Add(QueryParameters, "InAppName2", value);
			}
		}

		public string InAppName1
		{
			get
			{
				return inAppName1;
			}
			set	
			{
				inAppName1 = value;
				DictionaryUtil.Add(QueryParameters, "InAppName1", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

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

		public string InStreamName2
		{
			get
			{
				return inStreamName2;
			}
			set	
			{
				inStreamName2 = value;
				DictionaryUtil.Add(QueryParameters, "InStreamName2", value);
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

		public string InStreamName1
		{
			get
			{
				return inStreamName1;
			}
			set	
			{
				inStreamName1 = value;
				DictionaryUtil.Add(QueryParameters, "InStreamName1", value);
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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
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

        public override AddLiveStreamMergeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddLiveStreamMergeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
