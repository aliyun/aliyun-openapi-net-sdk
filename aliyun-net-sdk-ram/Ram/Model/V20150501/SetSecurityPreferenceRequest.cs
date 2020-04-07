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
using Aliyun.Acs.Ram;
using Aliyun.Acs.Ram.Transform;
using Aliyun.Acs.Ram.Transform.V20150501;

namespace Aliyun.Acs.Ram.Model.V20150501
{
    public class SetSecurityPreferenceRequest : RpcAcsRequest<SetSecurityPreferenceResponse>
    {
        public SetSecurityPreferenceRequest()
            : base("Ram", "2015-05-01", "SetSecurityPreference")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
        }

		private bool? enableSaveMFATicket;

		private string loginNetworkMasks;

		private bool? allowUserToChangePassword;

		private bool? allowUserToManagePublicKeys;

		private int? loginSessionDuration;

		private bool? allowUserToManageAccessKeys;

		private bool? allowUserToManageMFADevices;

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

		public bool? AllowUserToManagePublicKeys
		{
			get
			{
				return allowUserToManagePublicKeys;
			}
			set	
			{
				allowUserToManagePublicKeys = value;
				DictionaryUtil.Add(QueryParameters, "AllowUserToManagePublicKeys", value.ToString());
			}
		}

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

        public override SetSecurityPreferenceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetSecurityPreferenceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
