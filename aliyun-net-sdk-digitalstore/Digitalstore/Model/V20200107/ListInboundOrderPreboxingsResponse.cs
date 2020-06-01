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
	public class ListInboundOrderPreboxingsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<ListInboundOrderPreboxings_InboundOrderPreboxingBiz> inboundOrderPreboxings;

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

		public List<ListInboundOrderPreboxings_InboundOrderPreboxingBiz> InboundOrderPreboxings
		{
			get
			{
				return inboundOrderPreboxings;
			}
			set	
			{
				inboundOrderPreboxings = value;
			}
		}

		public class ListInboundOrderPreboxings_InboundOrderPreboxingBiz
		{

			private string orderId;

			private string orderType;

			private string orderCode;

			private string caseId;

			private string barcode;

			private string tagValue;

			private int? quantity;

			private int? operateQuantity;

			private string styleId;

			private string styleCode;

			private string styleName;

			private string colorId;

			private string colorCode;

			private string colorName;

			private string sizeId;

			private string sizeCode;

			private string sizeName;

			private string sKUName;

			private string sKUId;

			private string caseCode;

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

			public string OrderType
			{
				get
				{
					return orderType;
				}
				set	
				{
					orderType = value;
				}
			}

			public string OrderCode
			{
				get
				{
					return orderCode;
				}
				set	
				{
					orderCode = value;
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

			public string TagValue
			{
				get
				{
					return tagValue;
				}
				set	
				{
					tagValue = value;
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

			public string StyleId
			{
				get
				{
					return styleId;
				}
				set	
				{
					styleId = value;
				}
			}

			public string StyleCode
			{
				get
				{
					return styleCode;
				}
				set	
				{
					styleCode = value;
				}
			}

			public string StyleName
			{
				get
				{
					return styleName;
				}
				set	
				{
					styleName = value;
				}
			}

			public string ColorId
			{
				get
				{
					return colorId;
				}
				set	
				{
					colorId = value;
				}
			}

			public string ColorCode
			{
				get
				{
					return colorCode;
				}
				set	
				{
					colorCode = value;
				}
			}

			public string ColorName
			{
				get
				{
					return colorName;
				}
				set	
				{
					colorName = value;
				}
			}

			public string SizeId
			{
				get
				{
					return sizeId;
				}
				set	
				{
					sizeId = value;
				}
			}

			public string SizeCode
			{
				get
				{
					return sizeCode;
				}
				set	
				{
					sizeCode = value;
				}
			}

			public string SizeName
			{
				get
				{
					return sizeName;
				}
				set	
				{
					sizeName = value;
				}
			}

			public string SKUName
			{
				get
				{
					return sKUName;
				}
				set	
				{
					sKUName = value;
				}
			}

			public string SKUId
			{
				get
				{
					return sKUId;
				}
				set	
				{
					sKUId = value;
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
		}
	}
}
