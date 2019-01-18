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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeTaskInfoResponse : AcsResponse
	{

		private string requestId;

		private string taskId;

		private string beginTime;

		private string finishTime;

		private string createTime;

		private string taskAction;

		private string dBName;

		private string taskErrorCode;

		private string progress;

		private string expectedFinishTime;

		private string taskErrorMessage;

		private string progressInfo;

		private string status;

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

		public string TaskId
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

		public string BeginTime
		{
			get
			{
				return beginTime;
			}
			set	
			{
				beginTime = value;
			}
		}

		public string FinishTime
		{
			get
			{
				return finishTime;
			}
			set	
			{
				finishTime = value;
			}
		}

		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public string TaskAction
		{
			get
			{
				return taskAction;
			}
			set	
			{
				taskAction = value;
			}
		}

		public string DBName
		{
			get
			{
				return dBName;
			}
			set	
			{
				dBName = value;
			}
		}

		public string TaskErrorCode
		{
			get
			{
				return taskErrorCode;
			}
			set	
			{
				taskErrorCode = value;
			}
		}

		public string Progress
		{
			get
			{
				return progress;
			}
			set	
			{
				progress = value;
			}
		}

		public string ExpectedFinishTime
		{
			get
			{
				return expectedFinishTime;
			}
			set	
			{
				expectedFinishTime = value;
			}
		}

		public string TaskErrorMessage
		{
			get
			{
				return taskErrorMessage;
			}
			set	
			{
				taskErrorMessage = value;
			}
		}

		public string ProgressInfo
		{
			get
			{
				return progressInfo;
			}
			set	
			{
				progressInfo = value;
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
	}
}