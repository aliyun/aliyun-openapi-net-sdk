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

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
	public class GetPipelineLogResponse : AcsResponse
	{

		private bool? success;

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private List<GetPipelineLog_Job> _object;

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

		public List<GetPipelineLog_Job> _Object
		{
			get
			{
				return _object;
			}
			set	
			{
				_object = value;
			}
		}

		public class GetPipelineLog_Job
		{

			private long? jobId;

			private string actionName;

			private string startTime;

			private List<GetPipelineLog_BuildProcessNode> buildProcessNodes;

			public long? JobId
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

			public string ActionName
			{
				get
				{
					return actionName;
				}
				set	
				{
					actionName = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public List<GetPipelineLog_BuildProcessNode> BuildProcessNodes
			{
				get
				{
					return buildProcessNodes;
				}
				set	
				{
					buildProcessNodes = value;
				}
			}

			public class GetPipelineLog_BuildProcessNode
			{

				private string nodeName;

				private int? nodeIndex;

				private string status;

				public string NodeName
				{
					get
					{
						return nodeName;
					}
					set	
					{
						nodeName = value;
					}
				}

				public int? NodeIndex
				{
					get
					{
						return nodeIndex;
					}
					set	
					{
						nodeIndex = value;
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
	}
}
