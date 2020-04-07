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
    public class SetPasswordPolicyRequest : RpcAcsRequest<SetPasswordPolicyResponse>
    {
        public SetPasswordPolicyRequest()
            : base("Ram", "2015-05-01", "SetPasswordPolicy")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
        }

		private int? passwordReusePrevention;

		private bool? requireUppercaseCharacters;

		private int? minimumPasswordLength;

		private bool? requireNumbers;

		private bool? requireLowercaseCharacters;

		private int? maxPasswordAge;

		private int? maxLoginAttemps;

		private bool? hardExpiry;

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
