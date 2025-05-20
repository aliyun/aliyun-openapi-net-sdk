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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.mseap;
using Aliyun.Acs.mseap.Transform;
using Aliyun.Acs.mseap.Transform.V20210118;

namespace Aliyun.Acs.mseap.Model.V20210118
{
    public class SetRedisValueRequest : RpcAcsRequest<SetRedisValueResponse>
    {
        public SetRedisValueRequest()
            : base("mseap", "2021-01-18", "SetRedisValue")
        {
			Method = MethodType.POST;
        }

		private long? userCallerParentId;

		private string apiType;

		private long? timeout;

		private bool? userMfaPresent;

		private string userKp;

		private string lang;

		private string _value;

		private string key;

		private string userCallerType;

		private string userSecurityToken;

		private string userAccessKeyId;

		private string aliyunKp;

		private string userBid;

		private string originalRequest;

		private string requestId;

		private string userClientIp;

		private string bid;

		[JsonProperty(PropertyName = "UserCallerParentId")]
		public long? UserCallerParentId
		{
			get
			{
				return userCallerParentId;
			}
			set	
			{
				userCallerParentId = value;
				DictionaryUtil.Add(QueryParameters, "UserCallerParentId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ApiType")]
		public string ApiType
		{
			get
			{
				return apiType;
			}
			set	
			{
				apiType = value;
				DictionaryUtil.Add(QueryParameters, "ApiType", value);
			}
		}

		[JsonProperty(PropertyName = "Timeout")]
		public long? Timeout
		{
			get
			{
				return timeout;
			}
			set	
			{
				timeout = value;
				DictionaryUtil.Add(QueryParameters, "Timeout", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "UserMfaPresent")]
		public bool? UserMfaPresent
		{
			get
			{
				return userMfaPresent;
			}
			set	
			{
				userMfaPresent = value;
				DictionaryUtil.Add(QueryParameters, "UserMfaPresent", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "UserKp")]
		public string UserKp
		{
			get
			{
				return userKp;
			}
			set	
			{
				userKp = value;
				DictionaryUtil.Add(QueryParameters, "UserKp", value);
			}
		}

		[JsonProperty(PropertyName = "Lang")]
		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		[JsonProperty(PropertyName = "Value")]
		public string _Value
		{
			get
			{
				return _value;
			}
			set	
			{
				_value = value;
				DictionaryUtil.Add(QueryParameters, "Value", value);
			}
		}

		[JsonProperty(PropertyName = "Key")]
		public string Key
		{
			get
			{
				return key;
			}
			set	
			{
				key = value;
				DictionaryUtil.Add(QueryParameters, "Key", value);
			}
		}

		[JsonProperty(PropertyName = "UserCallerType")]
		public string UserCallerType
		{
			get
			{
				return userCallerType;
			}
			set	
			{
				userCallerType = value;
				DictionaryUtil.Add(QueryParameters, "UserCallerType", value);
			}
		}

		[JsonProperty(PropertyName = "UserSecurityToken")]
		public string UserSecurityToken
		{
			get
			{
				return userSecurityToken;
			}
			set	
			{
				userSecurityToken = value;
				DictionaryUtil.Add(QueryParameters, "UserSecurityToken", value);
			}
		}

		[JsonProperty(PropertyName = "UserAccessKeyId")]
		public string UserAccessKeyId
		{
			get
			{
				return userAccessKeyId;
			}
			set	
			{
				userAccessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "UserAccessKeyId", value);
			}
		}

		[JsonProperty(PropertyName = "AliyunKp")]
		public string AliyunKp
		{
			get
			{
				return aliyunKp;
			}
			set	
			{
				aliyunKp = value;
				DictionaryUtil.Add(QueryParameters, "AliyunKp", value);
			}
		}

		[JsonProperty(PropertyName = "UserBid")]
		public string UserBid
		{
			get
			{
				return userBid;
			}
			set	
			{
				userBid = value;
				DictionaryUtil.Add(QueryParameters, "UserBid", value);
			}
		}

		[JsonProperty(PropertyName = "OriginalRequest")]
		public string OriginalRequest
		{
			get
			{
				return originalRequest;
			}
			set	
			{
				originalRequest = value;
				DictionaryUtil.Add(QueryParameters, "OriginalRequest", value);
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
				DictionaryUtil.Add(QueryParameters, "RequestId", value);
			}
		}

		[JsonProperty(PropertyName = "UserClientIp")]
		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		[JsonProperty(PropertyName = "Bid")]
		public string Bid
		{
			get
			{
				return bid;
			}
			set	
			{
				bid = value;
				DictionaryUtil.Add(QueryParameters, "Bid", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetRedisValueResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetRedisValueResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
