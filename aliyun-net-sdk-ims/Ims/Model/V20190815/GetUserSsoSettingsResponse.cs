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
	public class GetUserSsoSettingsResponse : AcsResponse
	{

		private string requestId;

		private GetUserSsoSettings_UserSsoSettings userSsoSettings;

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

		public GetUserSsoSettings_UserSsoSettings UserSsoSettings
		{
			get
			{
				return userSsoSettings;
			}
			set	
			{
				userSsoSettings = value;
			}
		}

		public class GetUserSsoSettings_UserSsoSettings
		{

			private string auxiliaryDomain;

			private string metadataDocument;

			private bool? ssoEnabled;

			private bool? useTenantSpecificSp;

			private string name;

			public string AuxiliaryDomain
			{
				get
				{
					return auxiliaryDomain;
				}
				set	
				{
					auxiliaryDomain = value;
				}
			}

			public string MetadataDocument
			{
				get
				{
					return metadataDocument;
				}
				set	
				{
					metadataDocument = value;
				}
			}

			public bool? SsoEnabled
			{
				get
				{
					return ssoEnabled;
				}
				set	
				{
					ssoEnabled = value;
				}
			}

			public bool? UseTenantSpecificSp
			{
				get
				{
					return useTenantSpecificSp;
				}
				set	
				{
					useTenantSpecificSp = value;
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
		}
	}
}
