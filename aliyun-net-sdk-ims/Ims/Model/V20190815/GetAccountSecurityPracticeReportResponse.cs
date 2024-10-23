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

namespace Aliyun.Acs.Ims.Model.V20190815
{
	public class GetAccountSecurityPracticeReportResponse : AcsResponse
	{

		private string requestId;

		private GetAccountSecurityPracticeReport_AccountSecurityPracticeInfo accountSecurityPracticeInfo;

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

		public GetAccountSecurityPracticeReport_AccountSecurityPracticeInfo AccountSecurityPracticeInfo
		{
			get
			{
				return accountSecurityPracticeInfo;
			}
			set	
			{
				accountSecurityPracticeInfo = value;
			}
		}

		public class GetAccountSecurityPracticeReport_AccountSecurityPracticeInfo
		{

			private int? score;

			private GetAccountSecurityPracticeReport_AccountSecurityPracticeUserInfo accountSecurityPracticeUserInfo;

			public int? Score
			{
				get
				{
					return score;
				}
				set	
				{
					score = value;
				}
			}

			public GetAccountSecurityPracticeReport_AccountSecurityPracticeUserInfo AccountSecurityPracticeUserInfo
			{
				get
				{
					return accountSecurityPracticeUserInfo;
				}
				set	
				{
					accountSecurityPracticeUserInfo = value;
				}
			}

			public class GetAccountSecurityPracticeReport_AccountSecurityPracticeUserInfo
			{

				private int? unusedAkNum;

				private int? subUserWithUnusedAccessKey;

				private int? rootWithAccessKey;

				private int? subUser;

				private bool? bindMfa;

				private int? oldAkNum;

				private string subUserPwdLevel;

				private int? subUserWithOldAccessKey;

				private int? subUserBindMfa;

				public int? UnusedAkNum
				{
					get
					{
						return unusedAkNum;
					}
					set	
					{
						unusedAkNum = value;
					}
				}

				public int? SubUserWithUnusedAccessKey
				{
					get
					{
						return subUserWithUnusedAccessKey;
					}
					set	
					{
						subUserWithUnusedAccessKey = value;
					}
				}

				public int? RootWithAccessKey
				{
					get
					{
						return rootWithAccessKey;
					}
					set	
					{
						rootWithAccessKey = value;
					}
				}

				public int? SubUser
				{
					get
					{
						return subUser;
					}
					set	
					{
						subUser = value;
					}
				}

				public bool? BindMfa
				{
					get
					{
						return bindMfa;
					}
					set	
					{
						bindMfa = value;
					}
				}

				public int? OldAkNum
				{
					get
					{
						return oldAkNum;
					}
					set	
					{
						oldAkNum = value;
					}
				}

				public string SubUserPwdLevel
				{
					get
					{
						return subUserPwdLevel;
					}
					set	
					{
						subUserPwdLevel = value;
					}
				}

				public int? SubUserWithOldAccessKey
				{
					get
					{
						return subUserWithOldAccessKey;
					}
					set	
					{
						subUserWithOldAccessKey = value;
					}
				}

				public int? SubUserBindMfa
				{
					get
					{
						return subUserBindMfa;
					}
					set	
					{
						subUserBindMfa = value;
					}
				}
			}
		}
	}
}
