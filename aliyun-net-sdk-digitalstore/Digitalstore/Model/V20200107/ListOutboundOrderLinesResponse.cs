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
	public class ListOutboundOrderLinesResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListOutboundOrderLines_OutboundOrderLineBiz> outboundOrderLines;

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

		public List<ListOutboundOrderLines_OutboundOrderLineBiz> OutboundOrderLines
		{
			get
			{
				return outboundOrderLines;
			}
			set	
			{
				outboundOrderLines = value;
			}
		}

		public class ListOutboundOrderLines_OutboundOrderLineBiz
		{

			private string barcode;

			private int? operateQuantity;

			private int? quantity;

			private int? confirmQuantity;

			public string Barcode
			{
				get
				{
					return barcode;
				}
				set	
				{
					barcode = value;
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

			public int? Quantity
			{
				get
				{
					return quantity;
				}
				set	
				{
					quantity = value;
				}
			}

			public int? ConfirmQuantity
			{
				get
				{
					return confirmQuantity;
				}
				set	
				{
					confirmQuantity = value;
				}
			}
		}
	}
}
