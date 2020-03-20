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

namespace Aliyun.Acs.ROS.Model.V20190910
{
	public class ListStackGroupOperationsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<ListStackGroupOperations_StackGroupOperation> stackGroupOperations;

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

		public List<ListStackGroupOperations_StackGroupOperation> StackGroupOperations
		{
			get
			{
				return stackGroupOperations;
			}
			set	
			{
				stackGroupOperations = value;
			}
		}

		public class ListStackGroupOperations_StackGroupOperation
		{

			private string stackGroupName;

			private string stackGroupId;

			private string operationId;

			private string operationDescription;

			private string createTime;

			private string endTime;

			private string action;

			private string status;

			public string StackGroupName
			{
				get
				{
					return stackGroupName;
				}
				set	
				{
					stackGroupName = value;
				}
			}

			public string StackGroupId
			{
				get
				{
					return stackGroupId;
				}
				set	
				{
					stackGroupId = value;
				}
			}

			public string OperationId
			{
				get
				{
					return operationId;
				}
				set	
				{
					operationId = value;
				}
			}

			public string OperationDescription
			{
				get
				{
					return operationDescription;
				}
				set	
				{
					operationDescription = value;
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

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string Action
			{
				get
				{
					return action;
				}
				set	
				{
					action = value;
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
