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
using Aliyun.Acs.Ims.Transform;
using Aliyun.Acs.Ims.Transform.V20190815;

namespace Aliyun.Acs.Ims.Model.V20190815
{
    public class CreateLoginProfileRequest : RpcAcsRequest<CreateLoginProfileResponse>
    {
        public CreateLoginProfileRequest()
            : base("Ims", "2019-08-15", "CreateLoginProfile", "ims", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string password;

		private bool? mFABindRequired;

		private bool? passwordResetRequired;

		private string userPrincipalName;

		private string status;

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public bool? MFABindRequired
		{
			get
			{
				return mFABindRequired;
			}
			set	
			{
				mFABindRequired = value;
				DictionaryUtil.Add(QueryParameters, "MFABindRequired", value.ToString());
			}
		}

		public bool? PasswordResetRequired
		{
			get
			{
				return passwordResetRequired;
			}
			set	
			{
				passwordResetRequired = value;
				DictionaryUtil.Add(QueryParameters, "PasswordResetRequired", value.ToString());
			}
		}

		public string UserPrincipalName
		{
			get
			{
				return userPrincipalName;
			}
			set	
			{
				userPrincipalName = value;
				DictionaryUtil.Add(QueryParameters, "UserPrincipalName", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

        public override CreateLoginProfileResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLoginProfileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
