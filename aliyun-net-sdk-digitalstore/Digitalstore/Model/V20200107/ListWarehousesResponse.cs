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

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
	public class ListWarehousesResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListWarehouses_WarehouseModel> warehouses;

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

		public List<ListWarehouses_WarehouseModel> Warehouses
		{
			get
			{
				return warehouses;
			}
			set	
			{
				warehouses = value;
			}
		}

		public class ListWarehouses_WarehouseModel
		{

			private string tel;

			private string description;

			private string name;

			private string warehouseCategoryCode;

			private string createDate;

			private string code;

			private string address;

			private string updateDate;

			private string contact;

			private int? disable;

			private string warehouseId;

			public string Tel
			{
				get
				{
					return tel;
				}
				set	
				{
					tel = value;
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

			public string WarehouseCategoryCode
			{
				get
				{
					return warehouseCategoryCode;
				}
				set	
				{
					warehouseCategoryCode = value;
				}
			}

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
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

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

			public string Contact
			{
				get
				{
					return contact;
				}
				set	
				{
					contact = value;
				}
			}

			public int? Disable
			{
				get
				{
					return disable;
				}
				set	
				{
					disable = value;
				}
			}

			public string WarehouseId
			{
				get
				{
					return warehouseId;
				}
				set	
				{
					warehouseId = value;
				}
			}
		}
	}
}
