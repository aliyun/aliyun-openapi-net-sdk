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
	public class CreateOIDCProviderResponse : AcsResponse
	{

		private string requestId;

		private CreateOIDCProvider_OIDCProvider oIDCProvider;

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

		public CreateOIDCProvider_OIDCProvider OIDCProvider
		{
			get
			{
				return oIDCProvider;
			}
			set	
			{
				oIDCProvider = value;
			}
		}

		public class CreateOIDCProvider_OIDCProvider
		{

			private string updateDate;

			private string description;

			private string oIDCProviderName;

			private string createDate;

			private string arn;

			private string issuerUrl;

			private string fingerprints;

			private string clientIds;

			private string gmtCreate;

			private string gmtModified;

			private long? issuanceLimitTime;

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

			public string OIDCProviderName
			{
				get
				{
					return oIDCProviderName;
				}
				set	
				{
					oIDCProviderName = value;
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

			public string Arn
			{
				get
				{
					return arn;
				}
				set	
				{
					arn = value;
				}
			}

			public string IssuerUrl
			{
				get
				{
					return issuerUrl;
				}
				set	
				{
					issuerUrl = value;
				}
			}

			public string Fingerprints
			{
				get
				{
					return fingerprints;
				}
				set	
				{
					fingerprints = value;
				}
			}

			public string ClientIds
			{
				get
				{
					return clientIds;
				}
				set	
				{
					clientIds = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public long? IssuanceLimitTime
			{
				get
				{
					return issuanceLimitTime;
				}
				set	
				{
					issuanceLimitTime = value;
				}
			}
		}
	}
}
