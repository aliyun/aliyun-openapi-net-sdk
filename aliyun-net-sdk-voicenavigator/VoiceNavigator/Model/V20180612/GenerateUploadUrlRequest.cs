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
using Aliyun.Acs.VoiceNavigator.Transform;
using Aliyun.Acs.VoiceNavigator.Transform.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
    public class GenerateUploadUrlRequest : RpcAcsRequest<GenerateUploadUrlResponse>
    {
        public GenerateUploadUrlRequest()
            : base("VoiceNavigator", "2018-06-12", "GenerateUploadUrl", "voicebot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.VoiceNavigator.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.VoiceNavigator.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? callerParentId;

		private bool? securityTransport;

		private bool? proxyOriginalSecurityTransport;

		private long? userId;

		private string callerType;

		private string callerIp;

		private string securityToken;

		private long? instanceOwnerId;

		private string clientIp;

		private long? tenantId;

		private string proxyOriginalSourceIp;

		private string key;

		private long? callerUid;

		private string callerBid;

		private long? xspaceTenantBuId;

		private bool? mfaPresent;

		private int? environment;

		private string fileName;

		private string instanceId;

		private string requestId;

		private long? xspaceServicerId;

		private string tenantName;

		private bool? proxyTrustTransportInfo;

		private string userName;

		public long? CallerParentId
		{
			get
			{
				return callerParentId;
			}
			set	
			{
				callerParentId = value;
				DictionaryUtil.Add(BodyParameters, "CallerParentId", value.ToString());
			}
		}

		public bool? SecurityTransport
		{
			get
			{
				return securityTransport;
			}
			set	
			{
				securityTransport = value;
				DictionaryUtil.Add(BodyParameters, "SecurityTransport", value.ToString());
			}
		}

		public bool? ProxyOriginalSecurityTransport
		{
			get
			{
				return proxyOriginalSecurityTransport;
			}
			set	
			{
				proxyOriginalSecurityTransport = value;
				DictionaryUtil.Add(BodyParameters, "ProxyOriginalSecurityTransport", value.ToString());
			}
		}

		public long? UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(BodyParameters, "UserId", value.ToString());
			}
		}

		public string CallerType
		{
			get
			{
				return callerType;
			}
			set	
			{
				callerType = value;
				DictionaryUtil.Add(BodyParameters, "CallerType", value);
			}
		}

		public string CallerIp
		{
			get
			{
				return callerIp;
			}
			set	
			{
				callerIp = value;
				DictionaryUtil.Add(BodyParameters, "CallerIp", value);
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
				DictionaryUtil.Add(BodyParameters, "SecurityToken", value);
			}
		}

		public long? InstanceOwnerId
		{
			get
			{
				return instanceOwnerId;
			}
			set	
			{
				instanceOwnerId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceOwnerId", value.ToString());
			}
		}

		public string ClientIp
		{
			get
			{
				return clientIp;
			}
			set	
			{
				clientIp = value;
				DictionaryUtil.Add(BodyParameters, "ClientIp", value);
			}
		}

		public long? TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
				DictionaryUtil.Add(BodyParameters, "TenantId", value.ToString());
			}
		}

		public string ProxyOriginalSourceIp
		{
			get
			{
				return proxyOriginalSourceIp;
			}
			set	
			{
				proxyOriginalSourceIp = value;
				DictionaryUtil.Add(BodyParameters, "ProxyOriginalSourceIp", value);
			}
		}

		public string Key
		{
			get
			{
				return key;
			}
			set	
			{
				key = value;
				DictionaryUtil.Add(BodyParameters, "Key", value);
			}
		}

		public long? CallerUid
		{
			get
			{
				return callerUid;
			}
			set	
			{
				callerUid = value;
				DictionaryUtil.Add(BodyParameters, "CallerUid", value.ToString());
			}
		}

		public string CallerBid
		{
			get
			{
				return callerBid;
			}
			set	
			{
				callerBid = value;
				DictionaryUtil.Add(BodyParameters, "CallerBid", value);
			}
		}

		public long? XspaceTenantBuId
		{
			get
			{
				return xspaceTenantBuId;
			}
			set	
			{
				xspaceTenantBuId = value;
				DictionaryUtil.Add(BodyParameters, "XspaceTenantBuId", value.ToString());
			}
		}

		public bool? MfaPresent
		{
			get
			{
				return mfaPresent;
			}
			set	
			{
				mfaPresent = value;
				DictionaryUtil.Add(BodyParameters, "MfaPresent", value.ToString());
			}
		}

		public int? Environment
		{
			get
			{
				return environment;
			}
			set	
			{
				environment = value;
				DictionaryUtil.Add(BodyParameters, "Environment", value.ToString());
			}
		}

		public string FileName
		{
			get
			{
				return fileName;
			}
			set	
			{
				fileName = value;
				DictionaryUtil.Add(BodyParameters, "FileName", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
				DictionaryUtil.Add(BodyParameters, "RequestId", value);
			}
		}

		public long? XspaceServicerId
		{
			get
			{
				return xspaceServicerId;
			}
			set	
			{
				xspaceServicerId = value;
				DictionaryUtil.Add(BodyParameters, "XspaceServicerId", value.ToString());
			}
		}

		public string TenantName
		{
			get
			{
				return tenantName;
			}
			set	
			{
				tenantName = value;
				DictionaryUtil.Add(BodyParameters, "TenantName", value);
			}
		}

		public bool? ProxyTrustTransportInfo
		{
			get
			{
				return proxyTrustTransportInfo;
			}
			set	
			{
				proxyTrustTransportInfo = value;
				DictionaryUtil.Add(BodyParameters, "ProxyTrustTransportInfo", value.ToString());
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(BodyParameters, "UserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GenerateUploadUrlResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GenerateUploadUrlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
