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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class UpdateLiveSnapshotDetectPornConfigRequest : RpcAcsRequest<UpdateLiveSnapshotDetectPornConfigResponse>
    {
        public UpdateLiveSnapshotDetectPornConfigRequest()
            : base("live", "2016-11-01", "UpdateLiveSnapshotDetectPornConfig")
        {
        }

		private string ossBucket;

		private string appName;

		private string securityToken;

		private string domainName;

		private string ossEndpoint;

		private string action;

		private int? interval;

		private long? ownerId;

		private string ossObject;

		private string accessKeyId;

		private List<string> scenes;

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

		public int? Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value.ToString());
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

		public string OssObject
		{
			get
			{
				return ossObject;
			}
			set	
			{
				ossObject = value;
				DictionaryUtil.Add(QueryParameters, "OssObject", value);
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

		public List<string> Scenes
		{
			get
			{
				return scenes;
			}

			set
			{
				scenes = value;
				for (int i = 0; i < scenes.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Scene." + (i + 1) , scenes[i]);
				}
			}
		}

        public override UpdateLiveSnapshotDetectPornConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UpdateLiveSnapshotDetectPornConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}