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
using Aliyun.Acs.Mts.Transform;
using Aliyun.Acs.Mts.Transform.V20140618;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class PlayInfoRequest : RpcAcsRequest<PlayInfoResponse>
    {
        public PlayInfoRequest()
            : base("Mts", "2014-06-18", "PlayInfo", "mts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string resourceOwnerId;

		private string formats;

		private string rand;

		private long? authTimeout;

		private string playDomain;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string hlsUriToken;

		private string terminal;

		private string ownerId;

		private string mediaId;

		private string authInfo;

		public string ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value);
			}
		}

		public string Formats
		{
			get
			{
				return formats;
			}
			set	
			{
				formats = value;
				DictionaryUtil.Add(QueryParameters, "Formats", value);
			}
		}

		public string Rand
		{
			get
			{
				return rand;
			}
			set	
			{
				rand = value;
				DictionaryUtil.Add(QueryParameters, "Rand", value);
			}
		}

		public long? AuthTimeout
		{
			get
			{
				return authTimeout;
			}
			set	
			{
				authTimeout = value;
				DictionaryUtil.Add(QueryParameters, "AuthTimeout", value.ToString());
			}
		}

		public string PlayDomain
		{
			get
			{
				return playDomain;
			}
			set	
			{
				playDomain = value;
				DictionaryUtil.Add(QueryParameters, "PlayDomain", value);
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

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string HlsUriToken
		{
			get
			{
				return hlsUriToken;
			}
			set	
			{
				hlsUriToken = value;
				DictionaryUtil.Add(QueryParameters, "HlsUriToken", value);
			}
		}

		public string Terminal
		{
			get
			{
				return terminal;
			}
			set	
			{
				terminal = value;
				DictionaryUtil.Add(QueryParameters, "Terminal", value);
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public string MediaId
		{
			get
			{
				return mediaId;
			}
			set	
			{
				mediaId = value;
				DictionaryUtil.Add(QueryParameters, "MediaId", value);
			}
		}

		public string AuthInfo
		{
			get
			{
				return authInfo;
			}
			set	
			{
				authInfo = value;
				DictionaryUtil.Add(QueryParameters, "AuthInfo", value);
			}
		}

        public override PlayInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PlayInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
