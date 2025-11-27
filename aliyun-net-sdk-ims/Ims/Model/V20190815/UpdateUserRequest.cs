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
    public class UpdateUserRequest : RpcAcsRequest<UpdateUserResponse>
    {
        public UpdateUserRequest()
            : base("Ims", "2019-08-15", "UpdateUser", "ims", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string newMobilePhone;

		private string userId;

		private string newEmail;

		private string newDisplayName;

		private string userPrincipalName;

		private string newComments;

		private string newUserPrincipalName;

		[JsonProperty(PropertyName = "NewMobilePhone")]
		public string NewMobilePhone
		{
			get
			{
				return newMobilePhone;
			}
			set	
			{
				newMobilePhone = value;
				DictionaryUtil.Add(QueryParameters, "NewMobilePhone", value);
			}
		}

		[JsonProperty(PropertyName = "UserId")]
		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "NewEmail")]
		public string NewEmail
		{
			get
			{
				return newEmail;
			}
			set	
			{
				newEmail = value;
				DictionaryUtil.Add(QueryParameters, "NewEmail", value);
			}
		}

		[JsonProperty(PropertyName = "NewDisplayName")]
		public string NewDisplayName
		{
			get
			{
				return newDisplayName;
			}
			set	
			{
				newDisplayName = value;
				DictionaryUtil.Add(QueryParameters, "NewDisplayName", value);
			}
		}

		[JsonProperty(PropertyName = "UserPrincipalName")]
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

		[JsonProperty(PropertyName = "NewComments")]
		public string NewComments
		{
			get
			{
				return newComments;
			}
			set	
			{
				newComments = value;
				DictionaryUtil.Add(QueryParameters, "NewComments", value);
			}
		}

		[JsonProperty(PropertyName = "NewUserPrincipalName")]
		public string NewUserPrincipalName
		{
			get
			{
				return newUserPrincipalName;
			}
			set	
			{
				newUserPrincipalName = value;
				DictionaryUtil.Add(QueryParameters, "NewUserPrincipalName", value);
			}
		}

        public override UpdateUserResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
