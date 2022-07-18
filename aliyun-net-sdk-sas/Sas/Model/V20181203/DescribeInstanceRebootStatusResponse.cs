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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeInstanceRebootStatusResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeInstanceRebootStatus_RebootStatus> rebootStatuses;

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

		public List<DescribeInstanceRebootStatus_RebootStatus> RebootStatuses
		{
			get
			{
				return rebootStatuses;
			}
			set	
			{
				rebootStatuses = value;
			}
		}

		public class DescribeInstanceRebootStatus_RebootStatus
		{

			private string uuid;

			private int? rebootStatus;

			private string code;

			private string msg;

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public int? RebootStatus
			{
				get
				{
					return rebootStatus;
				}
				set	
				{
					rebootStatus = value;
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

			public string Msg
			{
				get
				{
					return msg;
				}
				set	
				{
					msg = value;
				}
			}
		}
	}
}
