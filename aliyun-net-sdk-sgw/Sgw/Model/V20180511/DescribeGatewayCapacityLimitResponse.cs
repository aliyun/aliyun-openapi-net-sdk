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
	public class DescribeGatewayCapacityLimitResponse : AcsResponse
	{

		private long? fileSystemSizeInTB;

		private string requestId;

		private string message;

		private bool? isMetadataSeparate;

		private long? fileNumber;

		private string code;

		private bool? success;

		public long? FileSystemSizeInTB
		{
			get
			{
				return fileSystemSizeInTB;
			}
			set	
			{
				fileSystemSizeInTB = value;
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

		public bool? IsMetadataSeparate
		{
			get
			{
				return isMetadataSeparate;
			}
			set	
			{
				isMetadataSeparate = value;
			}
		}

		public long? FileNumber
		{
			get
			{
				return fileNumber;
			}
			set	
			{
				fileNumber = value;
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
