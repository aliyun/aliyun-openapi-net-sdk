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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class AddWorkspaceUsersResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private AddWorkspaceUsers_Result result;

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

		public AddWorkspaceUsers_Result Result
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

		public class AddWorkspaceUsers_Result
		{

			private int? failure;

			private string failureDetail;

			private int? success;

			private int? total;

			public int? Failure
			{
				get
				{
					return failure;
				}
				set	
				{
					failure = value;
				}
			}

			public string FailureDetail
			{
				get
				{
					return failureDetail;
				}
				set	
				{
					failureDetail = value;
				}
			}

			public int? Success
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

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}
		}
	}
}
