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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeOssBucketInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private bool? isArchive;

		private bool? isBackToResource;

		private int? pollingInterval;

		private bool? isSupportServerSideEncryption;

		private bool? isFresh;

		private long? storageSize;

		private bool? isVersioning;

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
	}
}
