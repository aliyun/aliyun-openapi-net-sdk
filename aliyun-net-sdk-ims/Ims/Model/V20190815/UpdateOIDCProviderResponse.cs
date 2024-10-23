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
	public class UpdateOIDCProviderResponse : AcsResponse
	{

		private string requestId;

		private UpdateOIDCProvider_OIDCProvider oIDCProvider;

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

		[JsonProperty(PropertyName = "OIDCProvider")]
		public UpdateOIDCProvider_OIDCProvider OIDCProvider
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

		public class UpdateOIDCProvider_OIDCProvider
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

			[JsonProperty(PropertyName = "OIDCProviderName")]
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

			[JsonProperty(PropertyName = "Arn")]
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

			[JsonProperty(PropertyName = "IssuerUrl")]
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

			[JsonProperty(PropertyName = "Fingerprints")]
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

			[JsonProperty(PropertyName = "ClientIds")]
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

			[JsonProperty(PropertyName = "GmtCreate")]
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

			[JsonProperty(PropertyName = "GmtModified")]
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

			[JsonProperty(PropertyName = "IssuanceLimitTime")]
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
