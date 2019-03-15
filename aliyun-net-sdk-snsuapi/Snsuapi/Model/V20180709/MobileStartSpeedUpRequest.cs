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
    public class MobileStartSpeedUpRequest : RpcAcsRequest<MobileStartSpeedUpResponse>
    {
        public MobileStartSpeedUpRequest()
            : base("Snsuapi", "2018-07-09", "MobileStartSpeedUp", "snsuapi", "openAPI")
        {
        }

		private string duration;

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string ip;

		private string destinationIpAddress;

		private string action;

		private string publicIp;

		private string publicPort;

		private long? ownerId;

		private string accessKeyId;

		private string token;

		public string Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
				DictionaryUtil.Add(QueryParameters, "Duration", value);
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

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
				DictionaryUtil.Add(QueryParameters, "Ip", value);
			}
		}

		public string DestinationIpAddress
		{
			get
			{
				return destinationIpAddress;
			}
			set	
			{
				destinationIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "DestinationIpAddress", value);
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

		public string PublicIp
		{
			get
			{
				return publicIp;
			}
			set	
			{
				publicIp = value;
				DictionaryUtil.Add(QueryParameters, "PublicIp", value);
			}
		}

		public string PublicPort
		{
			get
			{
				return publicPort;
			}
			set	
			{
				publicPort = value;
				DictionaryUtil.Add(QueryParameters, "PublicPort", value);
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

		public string Token
		{
			get
			{
				return token;
			}
			set	
			{
				token = value;
				DictionaryUtil.Add(QueryParameters, "Token", value);
			}
		}

        public override MobileStartSpeedUpResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MobileStartSpeedUpResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
