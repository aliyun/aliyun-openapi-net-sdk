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
using System.Collections.Generic;

namespace Aliyun.Acs.Ram.Model.V20150501
{
	public class GetPasswordPolicyResponse : AcsResponse
	{

		private string requestId;

		private GetPasswordPolicy_PasswordPolicy passwordPolicy;

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

		public GetPasswordPolicy_PasswordPolicy PasswordPolicy
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

		public class GetPasswordPolicy_PasswordPolicy
		{

			private int? minimumPasswordLength;

			private bool? requireLowercaseCharacters;

			private bool? requireUppercaseCharacters;

			private bool? requireNumbers;

			private bool? requireSymbols;

			private bool? hardExpiry;

			private int? maxPasswordAge;

			private int? passwordReusePrevention;

			private int? maxLoginAttemps;

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