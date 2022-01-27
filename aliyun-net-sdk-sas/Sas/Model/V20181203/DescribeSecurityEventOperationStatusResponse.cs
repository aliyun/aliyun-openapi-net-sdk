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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeSecurityEventOperationStatusResponse : AcsResponse
	{

		private string requestId;

		private DescribeSecurityEventOperationStatus_SecurityEventOperationStatusResponse securityEventOperationStatusResponse;

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

		public DescribeSecurityEventOperationStatus_SecurityEventOperationStatusResponse SecurityEventOperationStatusResponse
		{
			get
			{
				return securityEventOperationStatusResponse;
			}
			set	
			{
				securityEventOperationStatusResponse = value;
			}
		}

		public class DescribeSecurityEventOperationStatus_SecurityEventOperationStatusResponse
		{

			private string taskStatus;

			private List<DescribeSecurityEventOperationStatus_SecurityEventOperationStatus> securityEventOperationStatuses;

			public string TaskStatus
			{
				get
				{
					return taskStatus;
				}
				set	
				{
					taskStatus = value;
				}
			}

			public List<DescribeSecurityEventOperationStatus_SecurityEventOperationStatus> SecurityEventOperationStatuses
			{
				get
				{
					return securityEventOperationStatuses;
				}
				set	
				{
					securityEventOperationStatuses = value;
				}
			}

			public class DescribeSecurityEventOperationStatus_SecurityEventOperationStatus
			{

				private string securityEventId;

				private string status;

				private string errorCode;

				public string SecurityEventId
				{
					get
					{
						return securityEventId;
					}
					set	
					{
						securityEventId = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string ErrorCode
				{
					get
					{
						return errorCode;
					}
					set	
					{
						errorCode = value;
					}
				}
			}
		}
	}
}
