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
	public class GetSecretValueResponse : AcsResponse
	{

		private string secretDataType;

		private string createTime;

		private string versionId;

		private string nextRotationDate;

		private string secretData;

		private string rotationInterval;

		private string extendedConfig;

		private string lastRotationDate;

		private string requestId;

		private string secretName;

		private string automaticRotation;

		private string secretType;

		private List<string> versionStages;

		[JsonProperty(PropertyName = "SecretDataType")]
		public string SecretDataType
		{
			get
			{
				return secretDataType;
			}
			set	
			{
				secretDataType = value;
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

		[JsonProperty(PropertyName = "VersionId")]
		public string VersionId
		{
			get
			{
				return versionId;
			}
			set	
			{
				versionId = value;
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

		[JsonProperty(PropertyName = "SecretData")]
		public string SecretData
		{
			get
			{
				return secretData;
			}
			set	
			{
				secretData = value;
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

		[JsonProperty(PropertyName = "VersionStages")]
		public List<string> VersionStages
		{
			get
			{
				return versionStages;
			}
			set	
			{
				versionStages = value;
			}
		}
	}
}
