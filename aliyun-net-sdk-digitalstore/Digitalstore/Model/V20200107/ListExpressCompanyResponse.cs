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
	public class ListExpressCompanyResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private bool? success;

		private string requestId;

		private List<ListExpressCompany_ExpressCompanyBiz> expressCompanies;

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

		public List<ListExpressCompany_ExpressCompanyBiz> ExpressCompanies
		{
			get
			{
				return expressCompanies;
			}
			set	
			{
				expressCompanies = value;
			}
		}

		public class ListExpressCompany_ExpressCompanyBiz
		{

			private int? disable;

			private string updateDate;

			private string createDate;

			private string expressCompanyId;

			private string expressCompanyName;

			private string expressCompanyCode;

			private string description;

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

			public string ExpressCompanyId
			{
				get
				{
					return expressCompanyId;
				}
				set	
				{
					expressCompanyId = value;
				}
			}

			public string ExpressCompanyName
			{
				get
				{
					return expressCompanyName;
				}
				set	
				{
					expressCompanyName = value;
				}
			}

			public string ExpressCompanyCode
			{
				get
				{
					return expressCompanyCode;
				}
				set	
				{
					expressCompanyCode = value;
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
		}
	}
}
