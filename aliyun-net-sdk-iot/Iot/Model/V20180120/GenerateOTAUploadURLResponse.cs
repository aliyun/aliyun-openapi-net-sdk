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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class GenerateOTAUploadURLResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private GenerateOTAUploadURL_Data data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public GenerateOTAUploadURL_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GenerateOTAUploadURL_Data
		{

			private string key;

			private string host;

			private string policy;

			private string oSSAccessKeyId;

			private string signature;

			private string firmwareUrl;

			private string utcCreate;

			private string objectStorage;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Host
			{
				get
				{
					return host;
				}
				set	
				{
					host = value;
				}
			}

			public string Policy
			{
				get
				{
					return policy;
				}
				set	
				{
					policy = value;
				}
			}

			public string OSSAccessKeyId
			{
				get
				{
					return oSSAccessKeyId;
				}
				set	
				{
					oSSAccessKeyId = value;
				}
			}

			public string Signature
			{
				get
				{
					return signature;
				}
				set	
				{
					signature = value;
				}
			}

			public string FirmwareUrl
			{
				get
				{
					return firmwareUrl;
				}
				set	
				{
					firmwareUrl = value;
				}
			}

			public string UtcCreate
			{
				get
				{
					return utcCreate;
				}
				set	
				{
					utcCreate = value;
				}
			}

			public string ObjectStorage
			{
				get
				{
					return objectStorage;
				}
				set	
				{
					objectStorage = value;
				}
			}
		}
	}
}
