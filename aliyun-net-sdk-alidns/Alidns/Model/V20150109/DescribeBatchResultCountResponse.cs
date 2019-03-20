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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeBatchResultCountResponse : AcsResponse
	{

		private string requestId;

		private int? status;

		private int? totalCount;

		private int? successCount;

		private int? failedCount;

		private string reason;

		private string batchType;

		private long? taskId;

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

		public int? Status
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

		public int? SuccessCount
		{
			get
			{
				return successCount;
			}
			set	
			{
				successCount = value;
			}
		}

		public int? FailedCount
		{
			get
			{
				return failedCount;
			}
			set	
			{
				failedCount = value;
			}
		}

		public string Reason
		{
			get
			{
				return reason;
			}
			set	
			{
				reason = value;
			}
		}

		public string BatchType
		{
			get
			{
				return batchType;
			}
			set	
			{
				batchType = value;
			}
		}

		public long? TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
			}
		}
	}
}
