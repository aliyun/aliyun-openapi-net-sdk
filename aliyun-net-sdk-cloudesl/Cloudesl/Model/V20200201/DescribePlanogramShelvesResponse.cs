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
	public class DescribePlanogramShelvesResponse : AcsResponse
	{

		private string code;

		private string dynamicCode;

		private string dynamicMessage;

		private string errorCode;

		private string errorMessage;

		private string message;

		private string requestId;

		private string storeId;

		private bool? success;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribePlanogramShelves_ShelfInfo> shelfInfos;

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

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
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

		public List<DescribePlanogramShelves_ShelfInfo> ShelfInfos
		{
			get
			{
				return shelfInfos;
			}
			set	
			{
				shelfInfos = value;
			}
		}

		public class DescribePlanogramShelves_ShelfInfo
		{

			private string shelf;

			private bool? beMatch;

			private string zone;

			private string category;

			private string shelfType;

			private List<DescribePlanogramShelves_LayerInfo> layerInfos;

			public string Shelf
			{
				get
				{
					return shelf;
				}
				set	
				{
					shelf = value;
				}
			}

			public bool? BeMatch
			{
				get
				{
					return beMatch;
				}
				set	
				{
					beMatch = value;
				}
			}

			public string Zone
			{
				get
				{
					return zone;
				}
				set	
				{
					zone = value;
				}
			}

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public string ShelfType
			{
				get
				{
					return shelfType;
				}
				set	
				{
					shelfType = value;
				}
			}

			public List<DescribePlanogramShelves_LayerInfo> LayerInfos
			{
				get
				{
					return layerInfos;
				}
				set	
				{
					layerInfos = value;
				}
			}

			public class DescribePlanogramShelves_LayerInfo
			{

				private int? layer;

				public int? Layer
				{
					get
					{
						return layer;
					}
					set	
					{
						layer = value;
					}
				}
			}
		}
	}
}
