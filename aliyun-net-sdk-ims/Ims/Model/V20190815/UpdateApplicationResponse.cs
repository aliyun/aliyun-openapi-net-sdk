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
	public class UpdateApplicationResponse : AcsResponse
	{

		private string requestId;

		private UpdateApplication_Application application;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Application")]
		public UpdateApplication_Application Application
		{
			get
			{
				return application;
			}
			set	
			{
				application = value;
			}
		}

		public class UpdateApplication_Application
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

			private UpdateApplication_DelegatedScope delegatedScope;

			[JsonProperty(PropertyName = "DisplayName")]
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

			[JsonProperty(PropertyName = "AccessTokenValidity")]
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

			[JsonProperty(PropertyName = "SecretRequired")]
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

			[JsonProperty(PropertyName = "AccountId")]
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

			[JsonProperty(PropertyName = "CreateDate")]
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

			[JsonProperty(PropertyName = "AppName")]
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

			[JsonProperty(PropertyName = "UpdateDate")]
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

			[JsonProperty(PropertyName = "AppId")]
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

			[JsonProperty(PropertyName = "RefreshTokenValidity")]
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

			[JsonProperty(PropertyName = "AppPrincipalName")]
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

			[JsonProperty(PropertyName = "IsMultiTenant")]
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

			[JsonProperty(PropertyName = "AppType")]
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

			[JsonProperty(PropertyName = "TenantId")]
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

			[JsonProperty(PropertyName = "RedirectUris")]
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

			[JsonProperty(PropertyName = "DelegatedScope")]
			public UpdateApplication_DelegatedScope DelegatedScope
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

			public class UpdateApplication_DelegatedScope
			{

				private List<UpdateApplication_PredefinedScope> predefinedScopes;

				[JsonProperty(PropertyName = "PredefinedScopes")]
				public List<UpdateApplication_PredefinedScope> PredefinedScopes
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

				public class UpdateApplication_PredefinedScope
				{

					private string description;

					private string name;

					private bool? required;

					[JsonProperty(PropertyName = "Description")]
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

					[JsonProperty(PropertyName = "Name")]
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

					[JsonProperty(PropertyName = "Required")]
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
