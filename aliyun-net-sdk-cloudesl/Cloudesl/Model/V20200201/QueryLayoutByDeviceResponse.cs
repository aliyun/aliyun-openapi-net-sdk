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
	public class QueryLayoutByDeviceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string message;

		private string errorCode;

		private string errorMessage;

		private string code;

		private string dynamicCode;

		private string dynamicMessage;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<QueryLayoutByDevice_Layout> layoutList;

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

		public List<QueryLayoutByDevice_Layout> LayoutList
		{
			get
			{
				return layoutList;
			}
			set	
			{
				layoutList = value;
			}
		}

		public class QueryLayoutByDevice_Layout
		{

			private string layoutId;

			private string layoutName;

			private string description;

			private string layoutTemplateId;

			private bool? isBind;

			private string brand;

			private string basePic;

			public string LayoutId
			{
				get
				{
					return layoutId;
				}
				set	
				{
					layoutId = value;
				}
			}

			public string LayoutName
			{
				get
				{
					return layoutName;
				}
				set	
				{
					layoutName = value;
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

			public string LayoutTemplateId
			{
				get
				{
					return layoutTemplateId;
				}
				set	
				{
					layoutTemplateId = value;
				}
			}

			public bool? IsBind
			{
				get
				{
					return isBind;
				}
				set	
				{
					isBind = value;
				}
			}

			public string Brand
			{
				get
				{
					return brand;
				}
				set	
				{
					brand = value;
				}
			}

			public string BasePic
			{
				get
				{
					return basePic;
				}
				set	
				{
					basePic = value;
				}
			}
		}
	}
}
