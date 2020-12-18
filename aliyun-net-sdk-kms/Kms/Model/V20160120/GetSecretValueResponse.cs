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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Kms.Model.V20160120
{
	public class GetSecretValueResponse : AcsResponse
	{

		private string requestId;

		private string secretName;

		private string versionId;

		private string createTime;

		private string secretData;

		private string secretDataType;

		private string automaticRotation;

		private string rotationInterval;

		private string nextRotationDate;

		private string extendedConfig;

		private string lastRotationDate;

		private string secretType;

		private List<string> versionStages;

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
