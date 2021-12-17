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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeSmbAclResponse : AcsResponse
	{

		private string requestId;

		private DescribeSmbAcl_Acl acl;

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

		public DescribeSmbAcl_Acl Acl
		{
			get
			{
				return acl;
			}
			set	
			{
				acl = value;
			}
		}

		public class DescribeSmbAcl_Acl
		{

			private string authMethod;

			private bool? enableAnonymousAccess;

			private bool? enabled;

			private bool? encryptData;

			private bool? rejectUnencryptedAccess;

			private string superAdminSid;

			private string homeDirPath;

			public string AuthMethod
			{
				get
				{
					return authMethod;
				}
				set	
				{
					authMethod = value;
				}
			}

			public bool? EnableAnonymousAccess
			{
				get
				{
					return enableAnonymousAccess;
				}
				set	
				{
					enableAnonymousAccess = value;
				}
			}

			public bool? Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}

			public bool? EncryptData
			{
				get
				{
					return encryptData;
				}
				set	
				{
					encryptData = value;
				}
			}

			public bool? RejectUnencryptedAccess
			{
				get
				{
					return rejectUnencryptedAccess;
				}
				set	
				{
					rejectUnencryptedAccess = value;
				}
			}

			public string SuperAdminSid
			{
				get
				{
					return superAdminSid;
				}
				set	
				{
					superAdminSid = value;
				}
			}

			public string HomeDirPath
			{
				get
				{
					return homeDirPath;
				}
				set	
				{
					homeDirPath = value;
				}
			}
		}
	}
}
