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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20141111;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class AddLiveAppSnapshotConfigRequest : RpcAcsRequest<AddLiveAppSnapshotConfigResponse>
    {
        public AddLiveAppSnapshotConfigRequest()
            : base("Cdn", "2014-11-11", "AddLiveAppSnapshotConfig")
        {
        }

		private int? timeInterval;

		private string ossBucket;

		private string appName;

		private string securityToken;

		private string domainName;

		private string ossEndpoint;

		private string action;

		private string sequenceOssObject;

		private string overwriteOssObject;

		private long? ownerId;

		private string accessKeyId;

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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override AddLiveAppSnapshotConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AddLiveAppSnapshotConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}