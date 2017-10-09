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
    public class SetPasswordPolicyRequest : RpcAcsRequest<SetPasswordPolicyResponse>
    {
        public SetPasswordPolicyRequest()
            : base("Ram", "2015-05-01", "SetPasswordPolicy")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private bool? requireNumbers;

		private int? passwordReusePrevention;

		private bool? requireUppercaseCharacters;

		private int? maxPasswordAge;

		private string action;

		private int? maxLoginAttemps;

		private bool? hardExpiry;

		private int? minimumPasswordLength;

		private bool? requireLowercaseCharacters;

		private bool? requireSymbols;

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

		public bool? HardExpiry
		{
			get
			{
				return hardExpiry;
			}
			set	
			{
				hardExpiry = value;
				DictionaryUtil.Add(QueryParameters, "HardExpiry", value.ToString());
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

        public override SetPasswordPolicyResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetPasswordPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}