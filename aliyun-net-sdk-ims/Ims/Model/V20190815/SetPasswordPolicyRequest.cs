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
    public class SetPasswordPolicyRequest : RpcAcsRequest<SetPasswordPolicyResponse>
    {
        public SetPasswordPolicyRequest()
            : base("Ims", "2019-08-15", "SetPasswordPolicy", "ims", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? passwordReusePrevention;

		private bool? requireUppercaseCharacters;

		private int? minimumPasswordDifferentCharacter;

		private int? minimumPasswordLength;

		private bool? requireNumbers;

		private bool? passwordNotContainUserName;

		private bool? requireLowercaseCharacters;

		private int? maxPasswordAge;

		private bool? hardExpire;

		private int? maxLoginAttemps;

		private bool? requireSymbols;

		public int? PasswordReusePrevention
		{
			get
			{
				return passwordReusePrevention;
			}
			set	
			{
				passwordReusePrevention = value;
				DictionaryUtil.Add(QueryParameters, "PasswordReusePrevention", value.ToString());
			}
		}

		public bool? RequireUppercaseCharacters
		{
			get
			{
				return requireUppercaseCharacters;
			}
			set	
			{
				requireUppercaseCharacters = value;
				DictionaryUtil.Add(QueryParameters, "RequireUppercaseCharacters", value.ToString());
			}
		}

		public int? MinimumPasswordDifferentCharacter
		{
			get
			{
				return minimumPasswordDifferentCharacter;
			}
			set	
			{
				minimumPasswordDifferentCharacter = value;
				DictionaryUtil.Add(QueryParameters, "MinimumPasswordDifferentCharacter", value.ToString());
			}
		}

		public int? MinimumPasswordLength
		{
			get
			{
				return minimumPasswordLength;
			}
			set	
			{
				minimumPasswordLength = value;
				DictionaryUtil.Add(QueryParameters, "MinimumPasswordLength", value.ToString());
			}
		}

		public bool? RequireNumbers
		{
			get
			{
				return requireNumbers;
			}
			set	
			{
				requireNumbers = value;
				DictionaryUtil.Add(QueryParameters, "RequireNumbers", value.ToString());
			}
		}

		public bool? PasswordNotContainUserName
		{
			get
			{
				return passwordNotContainUserName;
			}
			set	
			{
				passwordNotContainUserName = value;
				DictionaryUtil.Add(QueryParameters, "PasswordNotContainUserName", value.ToString());
			}
		}

		public bool? RequireLowercaseCharacters
		{
			get
			{
				return requireLowercaseCharacters;
			}
			set	
			{
				requireLowercaseCharacters = value;
				DictionaryUtil.Add(QueryParameters, "RequireLowercaseCharacters", value.ToString());
			}
		}

		public int? MaxPasswordAge
		{
			get
			{
				return maxPasswordAge;
			}
			set	
			{
				maxPasswordAge = value;
				DictionaryUtil.Add(QueryParameters, "MaxPasswordAge", value.ToString());
			}
		}

		public bool? HardExpire
		{
			get
			{
				return hardExpire;
			}
			set	
			{
				hardExpire = value;
				DictionaryUtil.Add(QueryParameters, "HardExpire", value.ToString());
			}
		}

		public int? MaxLoginAttemps
		{
			get
			{
				return maxLoginAttemps;
			}
			set	
			{
				maxLoginAttemps = value;
				DictionaryUtil.Add(QueryParameters, "MaxLoginAttemps", value.ToString());
			}
		}

		public bool? RequireSymbols
		{
			get
			{
				return requireSymbols;
			}
			set	
			{
				requireSymbols = value;
				DictionaryUtil.Add(QueryParameters, "RequireSymbols", value.ToString());
			}
		}

        public override SetPasswordPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetPasswordPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
