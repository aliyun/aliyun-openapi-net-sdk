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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeOssBucketInfoResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private bool? isArchive;

		private bool? isFresh;

		private bool? isSupportServerSideEncryption;

		private long? storageSize;

		private bool? isVersioning;

		private bool? isBackToResource;

		private int? pollingInterval;

		private string code;

		private bool? success;

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

		[JsonProperty(PropertyName = "Message")]
		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		[JsonProperty(PropertyName = "IsArchive")]
		public bool? IsArchive
		{
			get
			{
				return isArchive;
			}
			set	
			{
				isArchive = value;
			}
		}

		[JsonProperty(PropertyName = "IsFresh")]
		public bool? IsFresh
		{
			get
			{
				return isFresh;
			}
			set	
			{
				isFresh = value;
			}
		}

		[JsonProperty(PropertyName = "IsSupportServerSideEncryption")]
		public bool? IsSupportServerSideEncryption
		{
			get
			{
				return isSupportServerSideEncryption;
			}
			set	
			{
				isSupportServerSideEncryption = value;
			}
		}

		[JsonProperty(PropertyName = "StorageSize")]
		public long? StorageSize
		{
			get
			{
				return storageSize;
			}
			set	
			{
				storageSize = value;
			}
		}

		[JsonProperty(PropertyName = "IsVersioning")]
		public bool? IsVersioning
		{
			get
			{
				return isVersioning;
			}
			set	
			{
				isVersioning = value;
			}
		}

		[JsonProperty(PropertyName = "IsBackToResource")]
		public bool? IsBackToResource
		{
			get
			{
				return isBackToResource;
			}
			set	
			{
				isBackToResource = value;
			}
		}

		[JsonProperty(PropertyName = "PollingInterval")]
		public int? PollingInterval
		{
			get
			{
				return pollingInterval;
			}
			set	
			{
				pollingInterval = value;
			}
		}

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Success")]
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
	}
}
