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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeSecretsResponse : AcsResponse
	{

		private string requestId;

		private long? pageSize;

		private long? pageNumber;

		private List<DescribeSecrets_SecretsItem> secrets;

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

		[JsonProperty(PropertyName = "PageSize")]
		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		[JsonProperty(PropertyName = "Secrets")]
		public List<DescribeSecrets_SecretsItem> Secrets
		{
			get
			{
				return secrets;
			}
			set	
			{
				secrets = value;
			}
		}

		public class DescribeSecrets_SecretsItem
		{

			private string accountId;

			private string secretName;

			private string regionId;

			private string secretArn;

			private string description;

			private string username;

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

			[JsonProperty(PropertyName = "SecretName")]
			public string SecretName
			{
				get
				{
					return secretName;
				}
				set	
				{
					secretName = value;
				}
			}

			[JsonProperty(PropertyName = "RegionId")]
			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			[JsonProperty(PropertyName = "SecretArn")]
			public string SecretArn
			{
				get
				{
					return secretArn;
				}
				set	
				{
					secretArn = value;
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

			[JsonProperty(PropertyName = "Username")]
			public string Username
			{
				get
				{
					return username;
				}
				set	
				{
					username = value;
				}
			}
		}
	}
}
