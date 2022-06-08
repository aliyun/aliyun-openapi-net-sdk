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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
	public class ListBusinessSpacesResponse : AcsResponse
	{

		private int? currentPage;

		private int? pageSize;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private List<ListBusinessSpaces_DataItem> data;

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
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

		public List<ListBusinessSpaces_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListBusinessSpaces_DataItem
		{

			private long? id;

			private long? aliUid;

			private long? subAliUid;

			private string roleName;

			private int? loginUserType;

			private string businessSpaceCode;

			private string businessSpaceName;

			private string orderInstanceId;

			private string xspaceProductCode;

			private string xspaceCommodityCode;

			private string productType;

			private string language;

			private string startTime;

			private string endTime;

			private int? currentStatus;

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

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public long? SubAliUid
			{
				get
				{
					return subAliUid;
				}
				set	
				{
					subAliUid = value;
				}
			}

			public string RoleName
			{
				get
				{
					return roleName;
				}
				set	
				{
					roleName = value;
				}
			}

			public int? LoginUserType
			{
				get
				{
					return loginUserType;
				}
				set	
				{
					loginUserType = value;
				}
			}

			public string BusinessSpaceCode
			{
				get
				{
					return businessSpaceCode;
				}
				set	
				{
					businessSpaceCode = value;
				}
			}

			public string BusinessSpaceName
			{
				get
				{
					return businessSpaceName;
				}
				set	
				{
					businessSpaceName = value;
				}
			}

			public string OrderInstanceId
			{
				get
				{
					return orderInstanceId;
				}
				set	
				{
					orderInstanceId = value;
				}
			}

			public string XspaceProductCode
			{
				get
				{
					return xspaceProductCode;
				}
				set	
				{
					xspaceProductCode = value;
				}
			}

			public string XspaceCommodityCode
			{
				get
				{
					return xspaceCommodityCode;
				}
				set	
				{
					xspaceCommodityCode = value;
				}
			}

			public string ProductType
			{
				get
				{
					return productType;
				}
				set	
				{
					productType = value;
				}
			}

			public string Language
			{
				get
				{
					return language;
				}
				set	
				{
					language = value;
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

			public int? CurrentStatus
			{
				get
				{
					return currentStatus;
				}
				set	
				{
					currentStatus = value;
				}
			}
		}
	}
}
