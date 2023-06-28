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
	public class DescribeSecretResponse : AcsResponse
	{

		private string updateTime;

		private string createTime;

		private string nextRotationDate;

		private string encryptionKeyId;

		private string rotationInterval;

		private string arn;

		private string extendedConfig;

		private string lastRotationDate;

		private string requestId;

		private string description;

		private string secretName;

		private string automaticRotation;

		private string secretType;

		private string plannedDeleteTime;

		private string dKMSInstanceId;

		private List<DescribeSecret_Tag> tags;

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

		[JsonProperty(PropertyName = "NextRotationDate")]
		public string NextRotationDate
		{
			get
			{
				return nextRotationDate;
			}
			set	
			{
				nextRotationDate = value;
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

		[JsonProperty(PropertyName = "RotationInterval")]
		public string RotationInterval
		{
			get
			{
				return rotationInterval;
			}
			set	
			{
				rotationInterval = value;
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

		[JsonProperty(PropertyName = "ExtendedConfig")]
		public string ExtendedConfig
		{
			get
			{
				return extendedConfig;
			}
			set	
			{
				extendedConfig = value;
			}
		}

		[JsonProperty(PropertyName = "LastRotationDate")]
		public string LastRotationDate
		{
			get
			{
				return lastRotationDate;
			}
			set	
			{
				lastRotationDate = value;
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

		[JsonProperty(PropertyName = "AutomaticRotation")]
		public string AutomaticRotation
		{
			get
			{
				return automaticRotation;
			}
			set	
			{
				automaticRotation = value;
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

		[JsonProperty(PropertyName = "DKMSInstanceId")]
		public string DKMSInstanceId
		{
			get
			{
				return dKMSInstanceId;
			}
			set	
			{
				dKMSInstanceId = value;
			}
		}

		[JsonProperty(PropertyName = "Tags")]
		public List<DescribeSecret_Tag> Tags
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

		public class DescribeSecret_Tag
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
