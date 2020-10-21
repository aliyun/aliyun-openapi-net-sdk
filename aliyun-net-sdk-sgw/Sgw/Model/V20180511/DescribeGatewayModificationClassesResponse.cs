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
	public class DescribeGatewayModificationClassesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private List<DescribeGatewayModificationClasses_TargetGatewayClass> targetGatewayClasses;

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

		public List<DescribeGatewayModificationClasses_TargetGatewayClass> TargetGatewayClasses
		{
			get
			{
				return targetGatewayClasses;
			}
			set	
			{
				targetGatewayClasses = value;
			}
		}

		public class DescribeGatewayModificationClasses_TargetGatewayClass
		{

			private string gatewayClass;

			private bool? isAvailable;

			public string GatewayClass
			{
				get
				{
					return gatewayClass;
				}
				set	
				{
					gatewayClass = value;
				}
			}

			public bool? IsAvailable
			{
				get
				{
					return isAvailable;
				}
				set	
				{
					isAvailable = value;
				}
			}
		}
	}
}
