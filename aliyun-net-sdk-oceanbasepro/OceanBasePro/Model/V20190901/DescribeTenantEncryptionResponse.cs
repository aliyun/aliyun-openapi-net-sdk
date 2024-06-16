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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeTenantEncryptionResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeTenantEncryption_TenantEncryptionsItem> tenantEncryptions;

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

		[JsonProperty(PropertyName = "TotalCount")]
		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		[JsonProperty(PropertyName = "TenantEncryptions")]
		public List<DescribeTenantEncryption_TenantEncryptionsItem> TenantEncryptions
		{
			get
			{
				return tenantEncryptions;
			}
			set	
			{
				tenantEncryptions = value;
			}
		}

		public class DescribeTenantEncryption_TenantEncryptionsItem
		{

			private string tenantId;

			private string tenantMode;

			private string tenantName;

			private bool? enableEncryption;

			private string tenantStatus;

			private string status;

			private string encryptionType;

			private string encryptionKeyId;

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

			[JsonProperty(PropertyName = "TenantMode")]
			public string TenantMode
			{
				get
				{
					return tenantMode;
				}
				set	
				{
					tenantMode = value;
				}
			}

			[JsonProperty(PropertyName = "TenantName")]
			public string TenantName
			{
				get
				{
					return tenantName;
				}
				set	
				{
					tenantName = value;
				}
			}

			[JsonProperty(PropertyName = "EnableEncryption")]
			public bool? EnableEncryption
			{
				get
				{
					return enableEncryption;
				}
				set	
				{
					enableEncryption = value;
				}
			}

			[JsonProperty(PropertyName = "TenantStatus")]
			public string TenantStatus
			{
				get
				{
					return tenantStatus;
				}
				set	
				{
					tenantStatus = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			[JsonProperty(PropertyName = "EncryptionType")]
			public string EncryptionType
			{
				get
				{
					return encryptionType;
				}
				set	
				{
					encryptionType = value;
				}
			}

			[JsonProperty(PropertyName = "EncryptionKeyId")]
			public string EncryptionKeyId
			{
				get
				{
					return encryptionKeyId;
				}
				set	
				{
					encryptionKeyId = value;
				}
			}
		}
	}
}
