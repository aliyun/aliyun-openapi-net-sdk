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

namespace Aliyun.Acs.reid.Model.V20190928
{
	public class ListMaskDetectionResultsResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private int? pageNumber;

		private string message;

		private string code;

		private long? totalCount;

		private string dynamicCode;

		private int? pageSize;

		private string requestId;

		private bool? success;

		private string dynamicMessage;

		private List<ListMaskDetectionResults_DetectionResult> maskDetectionResults;

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

		public long? TotalCount
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

		public List<ListMaskDetectionResults_DetectionResult> MaskDetectionResults
		{
			get
			{
				return maskDetectionResults;
			}
			set	
			{
				maskDetectionResults = value;
			}
		}

		public class ListMaskDetectionResults_DetectionResult
		{

			private string pkId;

			private string score;

			private long? locationId;

			private string imageKey;

			private long? id;

			private string ipcId;

			private string maskResult;

			public string PkId
			{
				get
				{
					return pkId;
				}
				set	
				{
					pkId = value;
				}
			}

			public string Score
			{
				get
				{
					return score;
				}
				set	
				{
					score = value;
				}
			}

			public long? LocationId
			{
				get
				{
					return locationId;
				}
				set	
				{
					locationId = value;
				}
			}

			public string ImageKey
			{
				get
				{
					return imageKey;
				}
				set	
				{
					imageKey = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string IpcId
			{
				get
				{
					return ipcId;
				}
				set	
				{
					ipcId = value;
				}
			}

			public string MaskResult
			{
				get
				{
					return maskResult;
				}
				set	
				{
					maskResult = value;
				}
			}
		}
	}
}
