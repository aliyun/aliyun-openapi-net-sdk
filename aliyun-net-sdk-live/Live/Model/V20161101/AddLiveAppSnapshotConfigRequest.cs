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
    public class AddLiveAppSnapshotConfigRequest : RpcAcsRequest<AddLiveAppSnapshotConfigResponse>
    {
        public AddLiveAppSnapshotConfigRequest()
            : base("live", "2016-11-01", "AddLiveAppSnapshotConfig", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? timeInterval;

		private string ossEndpoint;

		private string appName;

		private string securityToken;

		private string overwriteOssObject;

		private string ossBucket;

		private string domainName;

		private string sequenceOssObject;

		private long? ownerId;

		private string callback;

		public int? TimeInterval
		{
			get
			{
				return timeInterval;
			}
			set	
			{
				timeInterval = value;
				DictionaryUtil.Add(QueryParameters, "TimeInterval", value.ToString());
			}
		}

		public string OssEndpoint
		{
			get
			{
				return ossEndpoint;
			}
			set	
			{
				ossEndpoint = value;
				DictionaryUtil.Add(QueryParameters, "OssEndpoint", value);
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

		public string OverwriteOssObject
		{
			get
			{
				return overwriteOssObject;
			}
			set	
			{
				overwriteOssObject = value;
				DictionaryUtil.Add(QueryParameters, "OverwriteOssObject", value);
			}
		}

		public string OssBucket
		{
			get
			{
				return ossBucket;
			}
			set	
			{
				ossBucket = value;
				DictionaryUtil.Add(QueryParameters, "OssBucket", value);
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

		public string SequenceOssObject
		{
			get
			{
				return sequenceOssObject;
			}
			set	
			{
				sequenceOssObject = value;
				DictionaryUtil.Add(QueryParameters, "SequenceOssObject", value);
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

		public string Callback
		{
			get
			{
				return callback;
			}
			set	
			{
				callback = value;
				DictionaryUtil.Add(QueryParameters, "Callback", value);
			}
		}

        public override AddLiveAppSnapshotConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddLiveAppSnapshotConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
