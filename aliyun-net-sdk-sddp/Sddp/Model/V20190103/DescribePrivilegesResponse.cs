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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribePrivilegesResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribePrivileges_Privilege> items;

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

		public List<DescribePrivileges_Privilege> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribePrivileges_Privilege
		{

			private long? id;

			private long? accountId;

			private int? accountType;

			private long? useAccountId;

			private int? useAccountType;

			private string productName;

			private string productCode;

			private string dataType;

			private string dataTypeId;

			private string dataTypeName;

			private string dataInstance;

			private string dataTable;

			private string dataColumn;

			private string dataPackage;

			private string resourceName;

			private string resourcePath;

			private string operation;

			private string policyCondition;

			private string sensitive;

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

			public long? AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

			public int? AccountType
			{
				get
				{
					return accountType;
				}
				set	
				{
					accountType = value;
				}
			}

			public long? UseAccountId
			{
				get
				{
					return useAccountId;
				}
				set	
				{
					useAccountId = value;
				}
			}

			public int? UseAccountType
			{
				get
				{
					return useAccountType;
				}
				set	
				{
					useAccountType = value;
				}
			}

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public string DataType
			{
				get
				{
					return dataType;
				}
				set	
				{
					dataType = value;
				}
			}

			public string DataTypeId
			{
				get
				{
					return dataTypeId;
				}
				set	
				{
					dataTypeId = value;
				}
			}

			public string DataTypeName
			{
				get
				{
					return dataTypeName;
				}
				set	
				{
					dataTypeName = value;
				}
			}

			public string DataInstance
			{
				get
				{
					return dataInstance;
				}
				set	
				{
					dataInstance = value;
				}
			}

			public string DataTable
			{
				get
				{
					return dataTable;
				}
				set	
				{
					dataTable = value;
				}
			}

			public string DataColumn
			{
				get
				{
					return dataColumn;
				}
				set	
				{
					dataColumn = value;
				}
			}

			public string DataPackage
			{
				get
				{
					return dataPackage;
				}
				set	
				{
					dataPackage = value;
				}
			}

			public string ResourceName
			{
				get
				{
					return resourceName;
				}
				set	
				{
					resourceName = value;
				}
			}

			public string ResourcePath
			{
				get
				{
					return resourcePath;
				}
				set	
				{
					resourcePath = value;
				}
			}

			public string Operation
			{
				get
				{
					return operation;
				}
				set	
				{
					operation = value;
				}
			}

			public string PolicyCondition
			{
				get
				{
					return policyCondition;
				}
				set	
				{
					policyCondition = value;
				}
			}

			public string Sensitive
			{
				get
				{
					return sensitive;
				}
				set	
				{
					sensitive = value;
				}
			}
		}
	}
}
