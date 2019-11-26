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
	public class DescribeLDAPConfigResponse : AcsResponse
	{

		private string requestId;

		private DescribeLDAPConfig_Ldap ldap;

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

		public DescribeLDAPConfig_Ldap Ldap
		{
			get
			{
				return ldap;
			}
			set	
			{
				ldap = value;
			}
		}

		public class DescribeLDAPConfig_Ldap
		{

			private string bindDN;

			private string uRI;

			private string searchBase;

			public string BindDN
			{
				get
				{
					return bindDN;
				}
				set	
				{
					bindDN = value;
				}
			}

			public string URI
			{
				get
				{
					return uRI;
				}
				set	
				{
					uRI = value;
				}
			}

			public string SearchBase
			{
				get
				{
					return searchBase;
				}
				set	
				{
					searchBase = value;
				}
			}
		}
	}
}
