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
    public class AddLiveRecordVodConfigRequest : RpcAcsRequest<AddLiveRecordVodConfigResponse>
    {
        public AddLiveRecordVodConfigRequest()
            : base("live", "2016-11-01", "AddLiveRecordVodConfig", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string autoCompose;

		private string composeVodTranscodeGroupId;

		private string storageLocation;

		private string appName;

		private string streamName;

		private string vodTranscodeGroupId;

		private string domainName;

		private int? cycleDuration;

		private long? ownerId;

		public string AutoCompose
		{
			get
			{
				return autoCompose;
			}
			set	
			{
				autoCompose = value;
				DictionaryUtil.Add(QueryParameters, "AutoCompose", value);
			}
		}

		public string ComposeVodTranscodeGroupId
		{
			get
			{
				return composeVodTranscodeGroupId;
			}
			set	
			{
				composeVodTranscodeGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ComposeVodTranscodeGroupId", value);
			}
		}

		public string StorageLocation
		{
			get
			{
				return storageLocation;
			}
			set	
			{
				storageLocation = value;
				DictionaryUtil.Add(QueryParameters, "StorageLocation", value);
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

		public string VodTranscodeGroupId
		{
			get
			{
				return vodTranscodeGroupId;
			}
			set	
			{
				vodTranscodeGroupId = value;
				DictionaryUtil.Add(QueryParameters, "VodTranscodeGroupId", value);
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

		public int? CycleDuration
		{
			get
			{
				return cycleDuration;
			}
			set	
			{
				cycleDuration = value;
				DictionaryUtil.Add(QueryParameters, "CycleDuration", value.ToString());
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

        public override AddLiveRecordVodConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddLiveRecordVodConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
