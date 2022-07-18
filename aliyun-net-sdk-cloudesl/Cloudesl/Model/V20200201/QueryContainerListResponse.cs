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

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
	public class QueryContainerListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string message;

		private string errorCode;

		private string errorMessage;

		private string code;

		private string dynamicCode;

		private string dynamicMessage;

		private int? pageSize;

		private int? pageNumber;

		private int? totalCount;

		private List<QueryContainerList_Container> containerList;

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

		public List<QueryContainerList_Container> ContainerList
		{
			get
			{
				return containerList;
			}
			set	
			{
				containerList = value;
			}
		}

		public class QueryContainerList_Container
		{

			private string containerId;

			private string containerName;

			private string description;

			private int? topPx;

			private int? leftPx;

			private int? widthPx;

			private int? heightPx;

			private string groupId;

			private string groupName;

			private string demoTemplateId;

			private string demoTemplateName;

			public string ContainerId
			{
				get
				{
					return containerId;
				}
				set	
				{
					containerId = value;
				}
			}

			public string ContainerName
			{
				get
				{
					return containerName;
				}
				set	
				{
					containerName = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public int? TopPx
			{
				get
				{
					return topPx;
				}
				set	
				{
					topPx = value;
				}
			}

			public int? LeftPx
			{
				get
				{
					return leftPx;
				}
				set	
				{
					leftPx = value;
				}
			}

			public int? WidthPx
			{
				get
				{
					return widthPx;
				}
				set	
				{
					widthPx = value;
				}
			}

			public int? HeightPx
			{
				get
				{
					return heightPx;
				}
				set	
				{
					heightPx = value;
				}
			}

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public string DemoTemplateId
			{
				get
				{
					return demoTemplateId;
				}
				set	
				{
					demoTemplateId = value;
				}
			}

			public string DemoTemplateName
			{
				get
				{
					return demoTemplateName;
				}
				set	
				{
					demoTemplateName = value;
				}
			}
		}
	}
}
