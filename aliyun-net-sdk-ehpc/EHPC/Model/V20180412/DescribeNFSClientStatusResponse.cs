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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class DescribeNFSClientStatusResponse : AcsResponse
	{

		private string status;

		private string requestId;

		private DescribeNFSClientStatus_Result result;

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

		public DescribeNFSClientStatus_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeNFSClientStatus_Result
		{

			private string invokeRecordStatus;

			private int? exitCode;

			private string output;

			public string InvokeRecordStatus
			{
				get
				{
					return invokeRecordStatus;
				}
				set	
				{
					invokeRecordStatus = value;
				}
			}

			public int? ExitCode
			{
				get
				{
					return exitCode;
				}
				set	
				{
					exitCode = value;
				}
			}

			public string Output
			{
				get
				{
					return output;
				}
				set	
				{
					output = value;
				}
			}
		}
	}
}
