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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeTaskAttributeResponse : AcsResponse
	{

		private string requestId;

		private string taskId;

		private string regionId;

		private string taskAction;

		private string taskStatus;

		private string taskProcess;

		private string supportCancel;

		private int? totalCount;

		private int? successCount;

		private int? failedCount;

		private string creationTime;

		private string finishedTime;

		private List<DescribeTaskAttribute_OperationProgress> operationProgressSet;

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

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
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

		public string TaskStatus
		{
			get
			{
				return taskStatus;
			}
			set	
			{
				taskStatus = value;
			}
		}

		public string TaskProcess
		{
			get
			{
				return taskProcess;
			}
			set	
			{
				taskProcess = value;
			}
		}

		public string SupportCancel
		{
			get
			{
				return supportCancel;
			}
			set	
			{
				supportCancel = value;
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

		public string CreationTime
		{
			get
			{
				return creationTime;
			}
			set	
			{
				creationTime = value;
			}
		}

		public string FinishedTime
		{
			get
			{
				return finishedTime;
			}
			set	
			{
				finishedTime = value;
			}
		}

		public List<DescribeTaskAttribute_OperationProgress> OperationProgressSet
		{
			get
			{
				return operationProgressSet;
			}
			set	
			{
				operationProgressSet = value;
			}
		}

		public class DescribeTaskAttribute_OperationProgress
		{

			private string operationStatus;

			private string errorCode;

			private string errorMsg;

			private List<DescribeTaskAttribute_RelatedItem> relatedItemSet;

			public string OperationStatus
			{
				get
				{
					return operationStatus;
				}
				set	
				{
					operationStatus = value;
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

			public string ErrorMsg
			{
				get
				{
					return errorMsg;
				}
				set	
				{
					errorMsg = value;
				}
			}

			public List<DescribeTaskAttribute_RelatedItem> RelatedItemSet
			{
				get
				{
					return relatedItemSet;
				}
				set	
				{
					relatedItemSet = value;
				}
			}

			public class DescribeTaskAttribute_RelatedItem
			{

				private string name;

				private string _value;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
