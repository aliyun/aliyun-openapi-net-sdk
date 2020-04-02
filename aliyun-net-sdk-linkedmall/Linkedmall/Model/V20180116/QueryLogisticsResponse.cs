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

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
	public class QueryLogisticsResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private List<QueryLogistics_DataItem> data;

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

		public List<QueryLogistics_DataItem> Data
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

		public class QueryLogistics_DataItem
		{

			private string mailNo;

			private string dataProvider;

			private string dataProviderTitle;

			private string logisticsCompanyName;

			private List<QueryLogistics_LogisticsDetailListItem> logisticsDetailList;

			private List<QueryLogistics_GoodsItem> goods;

			public string MailNo
			{
				get
				{
					return mailNo;
				}
				set	
				{
					mailNo = value;
				}
			}

			public string DataProvider
			{
				get
				{
					return dataProvider;
				}
				set	
				{
					dataProvider = value;
				}
			}

			public string DataProviderTitle
			{
				get
				{
					return dataProviderTitle;
				}
				set	
				{
					dataProviderTitle = value;
				}
			}

			public string LogisticsCompanyName
			{
				get
				{
					return logisticsCompanyName;
				}
				set	
				{
					logisticsCompanyName = value;
				}
			}

			public List<QueryLogistics_LogisticsDetailListItem> LogisticsDetailList
			{
				get
				{
					return logisticsDetailList;
				}
				set	
				{
					logisticsDetailList = value;
				}
			}

			public List<QueryLogistics_GoodsItem> Goods
			{
				get
				{
					return goods;
				}
				set	
				{
					goods = value;
				}
			}

			public class QueryLogistics_LogisticsDetailListItem
			{

				private string standerdDesc;

				private string ocurrTimeStr;

				public string StanderdDesc
				{
					get
					{
						return standerdDesc;
					}
					set	
					{
						standerdDesc = value;
					}
				}

				public string OcurrTimeStr
				{
					get
					{
						return ocurrTimeStr;
					}
					set	
					{
						ocurrTimeStr = value;
					}
				}
			}

			public class QueryLogistics_GoodsItem
			{

				private string goodName;

				private int? quantity;

				private long? itemId;

				public string GoodName
				{
					get
					{
						return goodName;
					}
					set	
					{
						goodName = value;
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

				public long? ItemId
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
			}
		}
	}
}
