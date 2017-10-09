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
using Aliyun.Acs.Ram.Transform;
using Aliyun.Acs.Ram.Transform.V20150501;
using System.Collections.Generic;

namespace Aliyun.Acs.Ram.Model.V20150501
{
    public class SetSecurityPreferenceRequest : RpcAcsRequest<SetSecurityPreferenceResponse>
    {
        public SetSecurityPreferenceRequest()
            : base("Ram", "2015-05-01", "SetSecurityPreference")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private bool? allowUserToManageAccessKeys;

		private bool? allowUserToManageMFADevices;

		private bool? allowUserToManagePublicKeys;

		private bool? enableSaveMFATicket;

		private string action;

		private bool? allowUserToChangePassword;

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

        public override SetSecurityPreferenceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetSecurityPreferenceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}