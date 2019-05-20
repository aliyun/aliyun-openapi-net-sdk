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
	public class ListNotaryOrdersResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNum;

		private int? currentPageNum;

		private int? pageSize;

		private int? totalPageNum;

		private bool? prePage;

		private bool? nextPage;

		private bool? success;

		private string errorMsg;

		private string errorCode;

		private List<ListNotaryOrders_NotaryOrder> data;

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

		public bool? PrePage
		{
			get
			{
				return prePage;
			}
			set	
			{
				prePage = value;
			}
		}

		public bool? NextPage
		{
			get
			{
				return nextPage;
			}
			set	
			{
				nextPage = value;
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

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
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

		public List<ListNotaryOrders_NotaryOrder> Data
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

		public class ListNotaryOrders_NotaryOrder
		{

			private long? notaryOrderId;

			private string aliyunOrderId;

			private string tmRegisterNo;

			private string tmName;

			private string tmImage;

			private string tmClassification;

			private float? orderPrice;

			private int? notaryStatus;

			private long? orderDate;

			private long? gmtModified;

			private string notaryCertificate;

			private string bizId;

			private int? notaryType;

			private string notaryPlatformName;

			private string applyPostStatus;

			public long? NotaryOrderId
			{
				get
				{
					return notaryOrderId;
				}
				set	
				{
					notaryOrderId = value;
				}
			}

			public string AliyunOrderId
			{
				get
				{
					return aliyunOrderId;
				}
				set	
				{
					aliyunOrderId = value;
				}
			}

			public string TmRegisterNo
			{
				get
				{
					return tmRegisterNo;
				}
				set	
				{
					tmRegisterNo = value;
				}
			}

			public string TmName
			{
				get
				{
					return tmName;
				}
				set	
				{
					tmName = value;
				}
			}

			public string TmImage
			{
				get
				{
					return tmImage;
				}
				set	
				{
					tmImage = value;
				}
			}

			public string TmClassification
			{
				get
				{
					return tmClassification;
				}
				set	
				{
					tmClassification = value;
				}
			}

			public float? OrderPrice
			{
				get
				{
					return orderPrice;
				}
				set	
				{
					orderPrice = value;
				}
			}

			public int? NotaryStatus
			{
				get
				{
					return notaryStatus;
				}
				set	
				{
					notaryStatus = value;
				}
			}

			public long? OrderDate
			{
				get
				{
					return orderDate;
				}
				set	
				{
					orderDate = value;
				}
			}

			public long? GmtModified
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

			public string NotaryCertificate
			{
				get
				{
					return notaryCertificate;
				}
				set	
				{
					notaryCertificate = value;
				}
			}

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public int? NotaryType
			{
				get
				{
					return notaryType;
				}
				set	
				{
					notaryType = value;
				}
			}

			public string NotaryPlatformName
			{
				get
				{
					return notaryPlatformName;
				}
				set	
				{
					notaryPlatformName = value;
				}
			}

			public string ApplyPostStatus
			{
				get
				{
					return applyPostStatus;
				}
				set	
				{
					applyPostStatus = value;
				}
			}
		}
	}
}
