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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeBatchResultResponse : AcsResponse
	{

		private string traceId;

		private long? status;

		private long? batchCount;

		private long? successNumber;

		private List<FailResult> failResults;

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
			}
		}

		public long? Status
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

		public long? BatchCount
		{
			get
			{
				return batchCount;
			}
			set	
			{
				batchCount = value;
			}
		}

		public long? SuccessNumber
		{
			get
			{
				return successNumber;
			}
			set	
			{
				successNumber = value;
			}
		}

		public List<FailResult> FailResults
		{
			get
			{
				return failResults;
			}
			set	
			{
				failResults = value;
			}
		}

		public class FailResult{

			private string batchIndex;

			private string errorCode;

			public string BatchIndex
			{
				get
				{
					return batchIndex;
				}
				set	
				{
					batchIndex = value;
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