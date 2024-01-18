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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeEncryptionKeyResponse : AcsResponse
	{

		private string deleteDate;

		private string requestId;

		private string description;

		private string origin;

		private string materialExpireTime;

		private string encryptionKeyStatus;

		private string keyUsage;

		private string encryptionKey;

		private string creator;

		private string encryptionName;

		private string roleArn;

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

		public string EncryptionKeyStatus
		{
			get
			{
				return encryptionKeyStatus;
			}
			set	
			{
				encryptionKeyStatus = value;
			}
		}

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

		public string EncryptionKey
		{
			get
			{
				return encryptionKey;
			}
			set	
			{
				encryptionKey = value;
			}
		}

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

		public string EncryptionName
		{
			get
			{
				return encryptionName;
			}
			set	
			{
				encryptionName = value;
			}
		}

		public string RoleArn
		{
			get
			{
				return roleArn;
			}
			set	
			{
				roleArn = value;
			}
		}
	}
}
