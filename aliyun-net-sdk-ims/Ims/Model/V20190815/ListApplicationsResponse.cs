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
	public class ListApplicationsResponse : AcsResponse
	{

		private string requestId;

		private List<ListApplications_Application> applications;

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

		public List<ListApplications_Application> Applications
		{
			get
			{
				return applications;
			}
			set	
			{
				applications = value;
			}
		}

		public class ListApplications_Application
		{

			private string displayName;

			private int? accessTokenValidity;

			private bool? secretRequired;

			private string accountId;

			private string createDate;

			private string appName;

			private string updateDate;

			private string appId;

			private int? refreshTokenValidity;

			private string appPrincipalName;

			private bool? isMultiTenant;

			private string appType;

			private string tenantId;

			private List<string> redirectUris;

			private ListApplications_DelegatedScope delegatedScope;

			public string DisplayName
			{
				get
				{
					return displayName;
				}
				set	
				{
					displayName = value;
				}
			}

			public int? AccessTokenValidity
			{
				get
				{
					return accessTokenValidity;
				}
				set	
				{
					accessTokenValidity = value;
				}
			}

			public bool? SecretRequired
			{
				get
				{
					return secretRequired;
				}
				set	
				{
					secretRequired = value;
				}
			}

			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public int? RefreshTokenValidity
			{
				get
				{
					return refreshTokenValidity;
				}
				set	
				{
					refreshTokenValidity = value;
				}
			}

			public string AppPrincipalName
			{
				get
				{
					return appPrincipalName;
				}
				set	
				{
					appPrincipalName = value;
				}
			}

			public bool? IsMultiTenant
			{
				get
				{
					return isMultiTenant;
				}
				set	
				{
					isMultiTenant = value;
				}
			}

			public string AppType
			{
				get
				{
					return appType;
				}
				set	
				{
					appType = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public List<string> RedirectUris
			{
				get
				{
					return redirectUris;
				}
				set	
				{
					redirectUris = value;
				}
			}

			public ListApplications_DelegatedScope DelegatedScope
			{
				get
				{
					return delegatedScope;
				}
				set	
				{
					delegatedScope = value;
				}
			}

			public class ListApplications_DelegatedScope
			{

				private List<ListApplications_PredefinedScope> predefinedScopes;

				public List<ListApplications_PredefinedScope> PredefinedScopes
				{
					get
					{
						return predefinedScopes;
					}
					set	
					{
						predefinedScopes = value;
					}
				}

				public class ListApplications_PredefinedScope
				{

					private string description;

					private string name;

					private bool? required;

					public string Description
					{
						get
						{
							return description;
						}
						set	
						{
							description = value;
						}
					}

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public bool? Required
					{
						get
						{
							return required;
						}
						set	
						{
							required = value;
						}
					}
				}
			}
		}
	}
}
