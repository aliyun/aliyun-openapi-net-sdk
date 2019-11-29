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

namespace Aliyun.Acs.cloudesl.Model.V20190801
{
	public class DescribeApDevicesResponse : AcsResponse
	{

		private string errorMessage;

		private string errorCode;

		private int? totalCount;

		private string message;

		private int? pageSize;

		private string dynamicCode;

		private string code;

		private string dynamicMessage;

		private string requestId;

		private bool? success;

		private int? pageNumber;

		private List<DescribeApDevices_ApInfo> apDevices;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
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

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<DescribeApDevices_ApInfo> ApDevices
		{
			get
			{
				return apDevices;
			}
			set	
			{
				apDevices = value;
			}
		}

		public class DescribeApDevices_ApInfo
		{

			private bool? isActivate;

			private string mac;

			private bool? status;

			private string model;

			public bool? IsActivate
			{
				get
				{
					return isActivate;
				}
				set	
				{
					isActivate = value;
				}
			}

			public string Mac
			{
				get
				{
					return mac;
				}
				set	
				{
					mac = value;
				}
			}

			public bool? Status
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

			public string Model
			{
				get
				{
					return model;
				}
				set	
				{
					model = value;
				}
			}
		}
	}
}
