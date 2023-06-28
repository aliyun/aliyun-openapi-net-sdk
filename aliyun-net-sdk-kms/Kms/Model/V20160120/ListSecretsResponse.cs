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

namespace Aliyun.Acs.Kms.Model.V20160120
{
	public class ListSecretsResponse : AcsResponse
	{

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private int? totalCount;

		private List<ListSecrets_Secret> secretList;

		[JsonProperty(PropertyName = "PageNumber")]
		public int? PageNumber
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

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
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

		[JsonProperty(PropertyName = "SecretList")]
		public List<ListSecrets_Secret> SecretList
		{
			get
			{
				return secretList;
			}
			set	
			{
				secretList = value;
			}
		}

		public class ListSecrets_Secret
		{

			private string secretName;

			private string updateTime;

			private string secretType;

			private string plannedDeleteTime;

			private string createTime;

			private List<ListSecrets_Tag> tags;

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

			[JsonProperty(PropertyName = "UpdateTime")]
			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			[JsonProperty(PropertyName = "SecretType")]
			public string SecretType
			{
				get
				{
					return secretType;
				}
				set	
				{
					secretType = value;
				}
			}

			[JsonProperty(PropertyName = "PlannedDeleteTime")]
			public string PlannedDeleteTime
			{
				get
				{
					return plannedDeleteTime;
				}
				set	
				{
					plannedDeleteTime = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTime")]
			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			[JsonProperty(PropertyName = "Tags")]
			public List<ListSecrets_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class ListSecrets_Tag
			{

				private string tagValue;

				private string tagKey;

				[JsonProperty(PropertyName = "TagValue")]
				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}

				[JsonProperty(PropertyName = "TagKey")]
				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}
			}
		}
	}
}
