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
	public class GetProduceOrderByTagResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string orderId;

		private string orderCode;

		private string sourceOrderCode;

		private string caseId;

		private string caseCode;

		private string tag;

		private string barcode;

		private string sKUId;

		private string productId;

		private string productCode;

		private string productName;

		private string productColorCode;

		private string productColorId;

		private string productColorName;

		private string productSizeCode;

		private string productSizeId;

		private string productSizeName;

		private string sKUName;

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

		public string SourceOrderCode
		{
			get
			{
				return sourceOrderCode;
			}
			set	
			{
				sourceOrderCode = value;
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

		public string Tag
		{
			get
			{
				return tag;
			}
			set	
			{
				tag = value;
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

		public string ProductId
		{
			get
			{
				return productId;
			}
			set	
			{
				productId = value;
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

		public string ProductColorCode
		{
			get
			{
				return productColorCode;
			}
			set	
			{
				productColorCode = value;
			}
		}

		public string ProductColorId
		{
			get
			{
				return productColorId;
			}
			set	
			{
				productColorId = value;
			}
		}

		public string ProductColorName
		{
			get
			{
				return productColorName;
			}
			set	
			{
				productColorName = value;
			}
		}

		public string ProductSizeCode
		{
			get
			{
				return productSizeCode;
			}
			set	
			{
				productSizeCode = value;
			}
		}

		public string ProductSizeId
		{
			get
			{
				return productSizeId;
			}
			set	
			{
				productSizeId = value;
			}
		}

		public string ProductSizeName
		{
			get
			{
				return productSizeName;
			}
			set	
			{
				productSizeName = value;
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
	}
}
