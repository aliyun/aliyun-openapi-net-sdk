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

namespace Aliyun.Acs.Trademark.Model.V20180724
{
	public class QueryMaterialListResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNum;

		private int? currentPageNum;

		private int? pageSize;

		private int? totalPageNum;

		private List<QueryMaterialList_Trademark> data;

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

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public int? CurrentPageNum
		{
			get
			{
				return currentPageNum;
			}
			set	
			{
				currentPageNum = value;
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

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
			}
		}

		public List<QueryMaterialList_Trademark> Data
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

		public class QueryMaterialList_Trademark
		{

			private long? id;

			private string name;

			private int? type;

			private int? region;

			private string contactName;

			private int? status;

			private string loaKey;

			private int? loaStatus;

			private string cardNumber;

			private long? validDate;

			private int? principalName;

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

			public int? Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public int? Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string ContactName
			{
				get
				{
					return contactName;
				}
				set	
				{
					contactName = value;
				}
			}

			public int? Status
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

			public string LoaKey
			{
				get
				{
					return loaKey;
				}
				set	
				{
					loaKey = value;
				}
			}

			public int? LoaStatus
			{
				get
				{
					return loaStatus;
				}
				set	
				{
					loaStatus = value;
				}
			}

			public string CardNumber
			{
				get
				{
					return cardNumber;
				}
				set	
				{
					cardNumber = value;
				}
			}

			public long? ValidDate
			{
				get
				{
					return validDate;
				}
				set	
				{
					validDate = value;
				}
			}

			public int? PrincipalName
			{
				get
				{
					return principalName;
				}
				set	
				{
					principalName = value;
				}
			}
		}
	}
}
