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
	public class ListProduceOrderCasesResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListProduceOrderCases_ProduceOrderCaseModel> produceOrderCases;

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

		public List<ListProduceOrderCases_ProduceOrderCaseModel> ProduceOrderCases
		{
			get
			{
				return produceOrderCases;
			}
			set	
			{
				produceOrderCases = value;
			}
		}

		public class ListProduceOrderCases_ProduceOrderCaseModel
		{

			private int? bindingQuantity;

			private string caseCode;

			private string orderId;

			private int? boxQuantity;

			private string caseId;

			private string encasementMode;

			private bool? beConfirmInboundCase;

			private bool? beConfirmOutboundCase;

			private string applyStatus;

			public int? BindingQuantity
			{
				get
				{
					return bindingQuantity;
				}
				set	
				{
					bindingQuantity = value;
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

			public int? BoxQuantity
			{
				get
				{
					return boxQuantity;
				}
				set	
				{
					boxQuantity = value;
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

			public string EncasementMode
			{
				get
				{
					return encasementMode;
				}
				set	
				{
					encasementMode = value;
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
		}
	}
}
