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
	public class ListApplicationOrderCasesResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListApplicationOrderCases_ApplyOrderCaseModel> applyOrderCases;

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

		public List<ListApplicationOrderCases_ApplyOrderCaseModel> ApplyOrderCases
		{
			get
			{
				return applyOrderCases;
			}
			set	
			{
				applyOrderCases = value;
			}
		}

		public class ListApplicationOrderCases_ApplyOrderCaseModel
		{

			private string createDate;

			private string status;

			private string orderCaseId;

			private int? productTotal;

			private string caseCode;

			private int? receivedQuantity;

			private string updateDate;

			private string orderId;

			private string caseId;

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

			public string OrderCaseId
			{
				get
				{
					return orderCaseId;
				}
				set	
				{
					orderCaseId = value;
				}
			}

			public int? ProductTotal
			{
				get
				{
					return productTotal;
				}
				set	
				{
					productTotal = value;
				}
			}

			public string CaseCode
			{
				get
				{
					return caseCode;
				}
				set	
				{
					caseCode = value;
				}
			}

			public int? ReceivedQuantity
			{
				get
				{
					return receivedQuantity;
				}
				set	
				{
					receivedQuantity = value;
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

			public string OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			public string CaseId
			{
				get
				{
					return caseId;
				}
				set	
				{
					caseId = value;
				}
			}
		}
	}
}
