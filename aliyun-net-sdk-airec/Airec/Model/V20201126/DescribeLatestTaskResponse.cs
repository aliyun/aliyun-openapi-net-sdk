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

namespace Aliyun.Acs.Airec.Model.V20201126
{
	public class DescribeLatestTaskResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLatestTask_IndexVersion> result;

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

		public List<DescribeLatestTask_IndexVersion> Result
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

		public class DescribeLatestTask_IndexVersion
		{

			private string versionId;

			private string status;

			private string builtTime;

			private string switchedTime;

			private bool? rollbackEnabled;

			private int? costSeconds;

			private long? size;

			private int? progress;

			private string flowType;

			private string code;

			private string message;

			public string VersionId
			{
				get
				{
					return versionId;
				}
				set	
				{
					versionId = value;
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

			public string BuiltTime
			{
				get
				{
					return builtTime;
				}
				set	
				{
					builtTime = value;
				}
			}

			public string SwitchedTime
			{
				get
				{
					return switchedTime;
				}
				set	
				{
					switchedTime = value;
				}
			}

			public bool? RollbackEnabled
			{
				get
				{
					return rollbackEnabled;
				}
				set	
				{
					rollbackEnabled = value;
				}
			}

			public int? CostSeconds
			{
				get
				{
					return costSeconds;
				}
				set	
				{
					costSeconds = value;
				}
			}

			public long? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public int? Progress
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

			public string FlowType
			{
				get
				{
					return flowType;
				}
				set	
				{
					flowType = value;
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
		}
	}
}
