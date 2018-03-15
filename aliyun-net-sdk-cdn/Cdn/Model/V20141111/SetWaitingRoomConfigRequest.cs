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
    public class SetWaitingRoomConfigRequest : RpcAcsRequest<SetWaitingRoomConfigResponse>
    {
        public SetWaitingRoomConfigRequest()
            : base("Cdn", "2014-11-11", "SetWaitingRoomConfig")
        {
        }

		private string accessKeyId;

		private string waitUrl;

		private string securityToken;

		private string action;

		private string waitUri;

		private long? maxQps;

		private int? maxTimeWait;

		private string domainName;

		private int? allowPct;

		private int? gapTime;

		private long? ownerId;

		private string version;

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

		public string WaitUrl
		{
			get
			{
				return waitUrl;
			}
			set	
			{
				waitUrl = value;
				DictionaryUtil.Add(QueryParameters, "WaitUrl", value);
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

		public string WaitUri
		{
			get
			{
				return waitUri;
			}
			set	
			{
				waitUri = value;
				DictionaryUtil.Add(QueryParameters, "WaitUri", value);
			}
		}

		public long? MaxQps
		{
			get
			{
				return maxQps;
			}
			set	
			{
				maxQps = value;
				DictionaryUtil.Add(QueryParameters, "MaxQps", value.ToString());
			}
		}

		public int? MaxTimeWait
		{
			get
			{
				return maxTimeWait;
			}
			set	
			{
				maxTimeWait = value;
				DictionaryUtil.Add(QueryParameters, "MaxTimeWait", value.ToString());
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

		public int? AllowPct
		{
			get
			{
				return allowPct;
			}
			set	
			{
				allowPct = value;
				DictionaryUtil.Add(QueryParameters, "AllowPct", value.ToString());
			}
		}

		public int? GapTime
		{
			get
			{
				return gapTime;
			}
			set	
			{
				gapTime = value;
				DictionaryUtil.Add(QueryParameters, "GapTime", value.ToString());
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

		public string Version
		{
			get
			{
				return version;
			}
			set	
			{
				version = value;
				DictionaryUtil.Add(QueryParameters, "Version", value);
			}
		}

        public override SetWaitingRoomConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetWaitingRoomConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}