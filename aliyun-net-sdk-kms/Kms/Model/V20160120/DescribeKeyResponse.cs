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
	public class DescribeKeyResponse : AcsResponse
	{

		private string requestId;

		private DescribeKey_KeyMetadata keyMetadata;

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

		[JsonProperty(PropertyName = "KeyMetadata")]
		public DescribeKey_KeyMetadata KeyMetadata
		{
			get
			{
				return keyMetadata;
			}
			set	
			{
				keyMetadata = value;
			}
		}

		public class DescribeKey_KeyMetadata
		{

			private string deletionProtection;

			private string keyId;

			private string nextRotationDate;

			private string keyState;

			private string rotationInterval;

			private string arn;

			private string creator;

			private string lastRotationDate;

			private string deleteDate;

			private string primaryKeyVersion;

			private string description;

			private string keySpec;

			private string origin;

			private string materialExpireTime;

			private string deletionProtectionDescription;

			private string automaticRotation;

			private string protectionLevel;

			private string keyUsage;

			private string creationDate;

			private string dKMSInstanceId;

			[JsonProperty(PropertyName = "DeletionProtection")]
			public string DeletionProtection
			{
				get
				{
					return deletionProtection;
				}
				set	
				{
					deletionProtection = value;
				}
			}

			[JsonProperty(PropertyName = "KeyId")]
			public string KeyId
			{
				get
				{
					return keyId;
				}
				set	
				{
					keyId = value;
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

			[JsonProperty(PropertyName = "KeyState")]
			public string KeyState
			{
				get
				{
					return keyState;
				}
				set	
				{
					keyState = value;
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

			[JsonProperty(PropertyName = "Creator")]
			public string Creator
			{
				get
				{
					return creator;
				}
				set	
				{
					creator = value;
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

			[JsonProperty(PropertyName = "DeleteDate")]
			public string DeleteDate
			{
				get
				{
					return deleteDate;
				}
				set	
				{
					deleteDate = value;
				}
			}

			[JsonProperty(PropertyName = "PrimaryKeyVersion")]
			public string PrimaryKeyVersion
			{
				get
				{
					return primaryKeyVersion;
				}
				set	
				{
					primaryKeyVersion = value;
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

			[JsonProperty(PropertyName = "KeySpec")]
			public string KeySpec
			{
				get
				{
					return keySpec;
				}
				set	
				{
					keySpec = value;
				}
			}

			[JsonProperty(PropertyName = "Origin")]
			public string Origin
			{
				get
				{
					return origin;
				}
				set	
				{
					origin = value;
				}
			}

			[JsonProperty(PropertyName = "MaterialExpireTime")]
			public string MaterialExpireTime
			{
				get
				{
					return materialExpireTime;
				}
				set	
				{
					materialExpireTime = value;
				}
			}

			[JsonProperty(PropertyName = "DeletionProtectionDescription")]
			public string DeletionProtectionDescription
			{
				get
				{
					return deletionProtectionDescription;
				}
				set	
				{
					deletionProtectionDescription = value;
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

			[JsonProperty(PropertyName = "ProtectionLevel")]
			public string ProtectionLevel
			{
				get
				{
					return protectionLevel;
				}
				set	
				{
					protectionLevel = value;
				}
			}

			[JsonProperty(PropertyName = "KeyUsage")]
			public string KeyUsage
			{
				get
				{
					return keyUsage;
				}
				set	
				{
					keyUsage = value;
				}
			}

			[JsonProperty(PropertyName = "CreationDate")]
			public string CreationDate
			{
				get
				{
					return creationDate;
				}
				set	
				{
					creationDate = value;
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
		}
	}
}
