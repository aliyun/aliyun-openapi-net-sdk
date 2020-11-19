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
using Aliyun.Acs.Cdn;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20141111;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class UpdateLiveAppSnapshotConfigRequest : RpcAcsRequest<UpdateLiveAppSnapshotConfigResponse>
    {
        public UpdateLiveAppSnapshotConfigRequest()
            : base("Cdn", "2014-11-11", "UpdateLiveAppSnapshotConfig")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointRegionalType, null);
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

        public override UpdateLiveAppSnapshotConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateLiveAppSnapshotConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
