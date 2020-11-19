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
using Aliyun.Acs.Cdn.Transform.V20180510;

namespace Aliyun.Acs.Cdn.Model.V20180510
{
    public class SetWaitingRoomConfigRequest : RpcAcsRequest<SetWaitingRoomConfigResponse>
    {
        public SetWaitingRoomConfigRequest()
            : base("Cdn", "2018-05-10", "SetWaitingRoomConfig")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string waitUrl;

		private string waitUri;

		private int? maxTimeWait;

		private string domainName;

		private int? allowPct;

		private int? gapTime;

		private long? ownerId;

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

        public override SetWaitingRoomConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetWaitingRoomConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
