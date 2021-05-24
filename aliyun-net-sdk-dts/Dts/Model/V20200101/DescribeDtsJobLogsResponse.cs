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

namespace Aliyun.Acs.Dts.Model.V20200101
{
	public class DescribeDtsJobLogsResponse : AcsResponse
	{

		private string dynamicCode;

		private string dynamicMessage;

		private string errCode;

		private string errMessage;

		private int? httpStatusCode;

		private string requestId;

		private bool? success;

		private int? pageNumber;

		private int? pageRecordCount;

		private long? totalRecordCount;

		private List<DescribeDtsJobLogs_JobRunningLog> jobRunningLogs;

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

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public long? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public List<DescribeDtsJobLogs_JobRunningLog> JobRunningLogs
		{
			get
			{
				return jobRunningLogs;
			}
			set	
			{
				jobRunningLogs = value;
			}
		}

		public class DescribeDtsJobLogs_JobRunningLog
		{

			private long? id;

			private string jobId;

			private long? logDatetime;

			private string contentKey;

			private string status;

			private List<string> _params;

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

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public long? LogDatetime
			{
				get
				{
					return logDatetime;
				}
				set	
				{
					logDatetime = value;
				}
			}

			public string ContentKey
			{
				get
				{
					return contentKey;
				}
				set	
				{
					contentKey = value;
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

			public List<string> _Params
			{
				get
				{
					return _params;
				}
				set	
				{
					_params = value;
				}
			}
		}
	}
}
