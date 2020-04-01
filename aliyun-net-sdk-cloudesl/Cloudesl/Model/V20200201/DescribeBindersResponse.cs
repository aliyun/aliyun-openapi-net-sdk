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

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
	public class DescribeBindersResponse : AcsResponse
	{

		private string errorMessage;

		private string errorCode;

		private int? totalCount;

		private string message;

		private int? pageSize;

		private string dynamicCode;

		private string code;

		private string dynamicMessage;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<DescribeBinders_EslItemBindInfo> eslItemBindInfos;

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
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

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
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

		public List<DescribeBinders_EslItemBindInfo> EslItemBindInfos
		{
			get
			{
				return eslItemBindInfos;
			}
			set	
			{
				eslItemBindInfos = value;
			}
		}

		public class DescribeBinders_EslItemBindInfo
		{

			private string promotionText;

			private string bindId;

			private string storeId;

			private string templateId;

			private string eslPic;

			private string eslStatus;

			private string itemTitle;

			private string originalPrice;

			private string templateSceneId;

			private string gmtModified;

			private string actionPrice;

			private string priceUnit;

			private string eslConnectAp;

			private string skuId;

			private string eslBarCode;

			private string itemShortTitle;

			private bool? bePromotion;

			private string eslModel;

			private string itemBarCode;

			private string itemId;

			private string promotionStart;

			private string promotionEnd;

			public string PromotionText
			{
				get
				{
					return promotionText;
				}
				set	
				{
					promotionText = value;
				}
			}

			public string BindId
			{
				get
				{
					return bindId;
				}
				set	
				{
					bindId = value;
				}
			}

			public string StoreId
			{
				get
				{
					return storeId;
				}
				set	
				{
					storeId = value;
				}
			}

			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}

			public string EslPic
			{
				get
				{
					return eslPic;
				}
				set	
				{
					eslPic = value;
				}
			}

			public string EslStatus
			{
				get
				{
					return eslStatus;
				}
				set	
				{
					eslStatus = value;
				}
			}

			public string ItemTitle
			{
				get
				{
					return itemTitle;
				}
				set	
				{
					itemTitle = value;
				}
			}

			public string OriginalPrice
			{
				get
				{
					return originalPrice;
				}
				set	
				{
					originalPrice = value;
				}
			}

			public string TemplateSceneId
			{
				get
				{
					return templateSceneId;
				}
				set	
				{
					templateSceneId = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string ActionPrice
			{
				get
				{
					return actionPrice;
				}
				set	
				{
					actionPrice = value;
				}
			}

			public string PriceUnit
			{
				get
				{
					return priceUnit;
				}
				set	
				{
					priceUnit = value;
				}
			}

			public string EslConnectAp
			{
				get
				{
					return eslConnectAp;
				}
				set	
				{
					eslConnectAp = value;
				}
			}

			public string SkuId
			{
				get
				{
					return skuId;
				}
				set	
				{
					skuId = value;
				}
			}

			public string EslBarCode
			{
				get
				{
					return eslBarCode;
				}
				set	
				{
					eslBarCode = value;
				}
			}

			public string ItemShortTitle
			{
				get
				{
					return itemShortTitle;
				}
				set	
				{
					itemShortTitle = value;
				}
			}

			public bool? BePromotion
			{
				get
				{
					return bePromotion;
				}
				set	
				{
					bePromotion = value;
				}
			}

			public string EslModel
			{
				get
				{
					return eslModel;
				}
				set	
				{
					eslModel = value;
				}
			}

			public string ItemBarCode
			{
				get
				{
					return itemBarCode;
				}
				set	
				{
					itemBarCode = value;
				}
			}

			public string ItemId
			{
				get
				{
					return itemId;
				}
				set	
				{
					itemId = value;
				}
			}

			public string PromotionStart
			{
				get
				{
					return promotionStart;
				}
				set	
				{
					promotionStart = value;
				}
			}

			public string PromotionEnd
			{
				get
				{
					return promotionEnd;
				}
				set	
				{
					promotionEnd = value;
				}
			}
		}
	}
}
