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
using Aliyun.Acs.Snsuapi.Transform;
using Aliyun.Acs.Snsuapi.Transform.V20180709;

namespace Aliyun.Acs.Snsuapi.Model.V20180709
{
    public class BandStartSpeedUpRequest : RpcAcsRequest<BandStartSpeedUpResponse>
    {
        public BandStartSpeedUpRequest()
            : base("Snsuapi", "2018-07-09", "BandStartSpeedUp", "snsuapi", "openAPI")
        {
        }

		private string ipAddress;

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private int? port;

		private long? bandId;

		private string action;

		private long? ownerId;

		private long? targetBandwidth;

		private string bandScene;

		private string accessKeyId;

		private string direction;

		public string IpAddress
		{
			get
			{
				return ipAddress;
			}
			set	
			{
				ipAddress = value;
				DictionaryUtil.Add(QueryParameters, "IpAddress", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public int? Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(QueryParameters, "Port", value.ToString());
			}
		}

		public long? BandId
		{
			get
			{
				return bandId;
			}
			set	
			{
				bandId = value;
				DictionaryUtil.Add(QueryParameters, "BandId", value.ToString());
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

		public long? TargetBandwidth
		{
			get
			{
				return targetBandwidth;
			}
			set	
			{
				targetBandwidth = value;
				DictionaryUtil.Add(QueryParameters, "TargetBandwidth", value.ToString());
			}
		}

		public string BandScene
		{
			get
			{
				return bandScene;
			}
			set	
			{
				bandScene = value;
				DictionaryUtil.Add(QueryParameters, "BandScene", value);
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

		public string Direction
		{
			get
			{
				return direction;
			}
			set	
			{
				direction = value;
				DictionaryUtil.Add(QueryParameters, "Direction", value);
			}
		}

        public override BandStartSpeedUpResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BandStartSpeedUpResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
