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
using Aliyun.Acs.Ims.Transform;
using Aliyun.Acs.Ims.Transform.V20190815;

namespace Aliyun.Acs.Ims.Model.V20190815
{
    public class SetSecurityPreferenceRequest : RpcAcsRequest<SetSecurityPreferenceResponse>
    {
        public SetSecurityPreferenceRequest()
            : base("Ims", "2019-08-15", "SetSecurityPreference", "ims", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? enableSaveMFATicket;

		private string loginNetworkMasks;

		private bool? allowUserToChangePassword;

		private int? loginSessionDuration;

		private List<string> verificationTypes = new List<string>(){ };

		private bool? allowUserToManageAccessKeys;

		private bool? allowUserToManageMFADevices;

		private string operationForRiskLogin;

		private string mFAOperationForLogin;

		private bool? allowUserToManagePersonalDingTalk;

		[JsonProperty(PropertyName = "EnableSaveMFATicket")]
		public bool? EnableSaveMFATicket
		{
			get
			{
				return enableSaveMFATicket;
			}
			set	
			{
				enableSaveMFATicket = value;
				DictionaryUtil.Add(QueryParameters, "EnableSaveMFATicket", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "LoginNetworkMasks")]
		public string LoginNetworkMasks
		{
			get
			{
				return loginNetworkMasks;
			}
			set	
			{
				loginNetworkMasks = value;
				DictionaryUtil.Add(QueryParameters, "LoginNetworkMasks", value);
			}
		}

		[JsonProperty(PropertyName = "AllowUserToChangePassword")]
		public bool? AllowUserToChangePassword
		{
			get
			{
				return allowUserToChangePassword;
			}
			set	
			{
				allowUserToChangePassword = value;
				DictionaryUtil.Add(QueryParameters, "AllowUserToChangePassword", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "LoginSessionDuration")]
		public int? LoginSessionDuration
		{
			get
			{
				return loginSessionDuration;
			}
			set	
			{
				loginSessionDuration = value;
				DictionaryUtil.Add(QueryParameters, "LoginSessionDuration", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "VerificationTypes")]
		public List<string> VerificationTypes
		{
			get
			{
				return verificationTypes;
			}

			set
			{
				verificationTypes = value;
				if(verificationTypes != null)
				{
					for (int depth1 = 0; depth1 < verificationTypes.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"VerificationTypes." + (depth1 + 1), verificationTypes[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "AllowUserToManageAccessKeys")]
		public bool? AllowUserToManageAccessKeys
		{
			get
			{
				return allowUserToManageAccessKeys;
			}
			set	
			{
				allowUserToManageAccessKeys = value;
				DictionaryUtil.Add(QueryParameters, "AllowUserToManageAccessKeys", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AllowUserToManageMFADevices")]
		public bool? AllowUserToManageMFADevices
		{
			get
			{
				return allowUserToManageMFADevices;
			}
			set	
			{
				allowUserToManageMFADevices = value;
				DictionaryUtil.Add(QueryParameters, "AllowUserToManageMFADevices", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OperationForRiskLogin")]
		public string OperationForRiskLogin
		{
			get
			{
				return operationForRiskLogin;
			}
			set	
			{
				operationForRiskLogin = value;
				DictionaryUtil.Add(QueryParameters, "OperationForRiskLogin", value);
			}
		}

		[JsonProperty(PropertyName = "MFAOperationForLogin")]
		public string MFAOperationForLogin
		{
			get
			{
				return mFAOperationForLogin;
			}
			set	
			{
				mFAOperationForLogin = value;
				DictionaryUtil.Add(QueryParameters, "MFAOperationForLogin", value);
			}
		}

		[JsonProperty(PropertyName = "AllowUserToManagePersonalDingTalk")]
		public bool? AllowUserToManagePersonalDingTalk
		{
			get
			{
				return allowUserToManagePersonalDingTalk;
			}
			set	
			{
				allowUserToManagePersonalDingTalk = value;
				DictionaryUtil.Add(QueryParameters, "AllowUserToManagePersonalDingTalk", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetSecurityPreferenceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetSecurityPreferenceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
