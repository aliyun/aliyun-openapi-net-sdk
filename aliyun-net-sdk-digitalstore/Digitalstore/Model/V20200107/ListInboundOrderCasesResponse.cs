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
	public class ListInboundOrderCasesResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListInboundOrderCases_CaseBiz> cases;

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

		public List<ListInboundOrderCases_CaseBiz> Cases
		{
			get
			{
				return cases;
			}
			set	
			{
				cases = value;
			}
		}

		public class ListInboundOrderCases_CaseBiz
		{

			private string id;

			private int? operateQuantity;

			private string caseCode;

			private string caseStatus;

			private bool? beConfirmInboundCase;

			private bool? beConfirmOutboundCase;

			private string applyStatus;

			private int? preboxingQuantity;

			public string Id
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

			public int? OperateQuantity
			{
				get
				{
					return operateQuantity;
				}
				set	
				{
					operateQuantity = value;
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

			public string CaseStatus
			{
				get
				{
					return caseStatus;
				}
				set	
				{
					caseStatus = value;
				}
			}

			public bool? BeConfirmInboundCase
			{
				get
				{
					return beConfirmInboundCase;
				}
				set	
				{
					beConfirmInboundCase = value;
				}
			}

			public bool? BeConfirmOutboundCase
			{
				get
				{
					return beConfirmOutboundCase;
				}
				set	
				{
					beConfirmOutboundCase = value;
				}
			}

			public string ApplyStatus
			{
				get
				{
					return applyStatus;
				}
				set	
				{
					applyStatus = value;
				}
			}

			public int? PreboxingQuantity
			{
				get
				{
					return preboxingQuantity;
				}
				set	
				{
					preboxingQuantity = value;
				}
			}
		}
	}
}
