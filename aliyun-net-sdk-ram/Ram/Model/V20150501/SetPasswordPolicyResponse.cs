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

namespace Aliyun.Acs.Ram.Model.V20150501
{
	public class SetPasswordPolicyResponse : AcsResponse
	{

		private string requestId;

		private SetPasswordPolicy_PasswordPolicy passwordPolicy;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public SetPasswordPolicy_PasswordPolicy PasswordPolicy
		{
			get
			{
				return passwordPolicy;
			}
			set	
			{
				passwordPolicy = value;
			}
		}

		public class SetPasswordPolicy_PasswordPolicy
		{

			private bool? requireNumbers;

			private bool? requireLowercaseCharacters;

			private bool? hardExpiry;

			private int? passwordReusePrevention;

			private bool? requireSymbols;

			private int? maxPasswordAge;

			private int? minimumPasswordLength;

			private bool? requireUppercaseCharacters;

			private int? maxLoginAttemps;

			public bool? RequireNumbers
			{
				get
				{
					return requireNumbers;
				}
				set	
				{
					requireNumbers = value;
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
				}
			}
		}
	}
}
