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

namespace Aliyun.Acs.Cloudauth.Model.V20200618
{
	public class DescribeSmsDetailResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string code;

		private int? totalItem;

		private int? totalPage;

		private int? currentPage;

		private int? pageSize;

		private List<DescribeSmsDetail_ItemsItem> items;

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

		public int? TotalItem
		{
			get
			{
				return totalItem;
			}
			set	
			{
				totalItem = value;
			}
		}

		public int? TotalPage
		{
			get
			{
				return totalPage;
			}
			set	
			{
				totalPage = value;
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
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

		public List<DescribeSmsDetail_ItemsItem> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeSmsDetail_ItemsItem
		{

			private string bizId;

			private string outerOrderNo;

			private string content;

			private string errorCode;

			private string errorMessage;

			private int? smsSize;

			private string mobile;

			private string receiveDate;

			private string sendDate;

			private string signName;

			private string templateCode;

			private string taskDate;

			private string sendStatus;

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

			public string OuterOrderNo
			{
				get
				{
					return outerOrderNo;
				}
				set	
				{
					outerOrderNo = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
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

			public int? SmsSize
			{
				get
				{
					return smsSize;
				}
				set	
				{
					smsSize = value;
				}
			}

			public string Mobile
			{
				get
				{
					return mobile;
				}
				set	
				{
					mobile = value;
				}
			}

			public string ReceiveDate
			{
				get
				{
					return receiveDate;
				}
				set	
				{
					receiveDate = value;
				}
			}

			public string SendDate
			{
				get
				{
					return sendDate;
				}
				set	
				{
					sendDate = value;
				}
			}

			public string SignName
			{
				get
				{
					return signName;
				}
				set	
				{
					signName = value;
				}
			}

			public string TemplateCode
			{
				get
				{
					return templateCode;
				}
				set	
				{
					templateCode = value;
				}
			}

			public string TaskDate
			{
				get
				{
					return taskDate;
				}
				set	
				{
					taskDate = value;
				}
			}

			public string SendStatus
			{
				get
				{
					return sendStatus;
				}
				set	
				{
					sendStatus = value;
				}
			}
		}
	}
}
