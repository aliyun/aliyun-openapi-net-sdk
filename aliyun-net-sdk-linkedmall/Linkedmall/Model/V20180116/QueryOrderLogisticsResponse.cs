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
	public class QueryOrderLogisticsResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private QueryOrderLogistics_OrderLogistics orderLogistics;

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

		public QueryOrderLogistics_OrderLogistics OrderLogistics
		{
			get
			{
				return orderLogistics;
			}
			set	
			{
				orderLogistics = value;
			}
		}

		public class QueryOrderLogistics_OrderLogistics
		{

			private string dataProvider;

			private string dataProviderTitle;

			private string logisticsCompanyCode;

			private string logisticsCompanyName;

			private List<QueryOrderLogistics_LogisticsDetailListItem> logisticsDetailList;

			private QueryOrderLogistics_Receiver receiver;

			private QueryOrderLogistics_Fetcher fetcher;

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

			public string LogisticsCompanyCode
			{
				get
				{
					return logisticsCompanyCode;
				}
				set	
				{
					logisticsCompanyCode = value;
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

			public List<QueryOrderLogistics_LogisticsDetailListItem> LogisticsDetailList
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

			public QueryOrderLogistics_Receiver Receiver
			{
				get
				{
					return receiver;
				}
				set	
				{
					receiver = value;
				}
			}

			public QueryOrderLogistics_Fetcher Fetcher
			{
				get
				{
					return fetcher;
				}
				set	
				{
					fetcher = value;
				}
			}

			public class QueryOrderLogistics_LogisticsDetailListItem
			{

				private string ocurrTimeStr;

				private string standerdDesc;

				private string statusIcon;

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

				public string StatusIcon
				{
					get
					{
						return statusIcon;
					}
					set	
					{
						statusIcon = value;
					}
				}
			}

			public class QueryOrderLogistics_Receiver
			{

				private string address;

				private string name;

				private string phoneNumber;

				private string zipCode;

				public string Address
				{
					get
					{
						return address;
					}
					set	
					{
						address = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string PhoneNumber
				{
					get
					{
						return phoneNumber;
					}
					set	
					{
						phoneNumber = value;
					}
				}

				public string ZipCode
				{
					get
					{
						return zipCode;
					}
					set	
					{
						zipCode = value;
					}
				}
			}

			public class QueryOrderLogistics_Fetcher
			{

				private string address;

				private string name;

				private string phoneNumber;

				private string zipCode;

				public string Address
				{
					get
					{
						return address;
					}
					set	
					{
						address = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string PhoneNumber
				{
					get
					{
						return phoneNumber;
					}
					set	
					{
						phoneNumber = value;
					}
				}

				public string ZipCode
				{
					get
					{
						return zipCode;
					}
					set	
					{
						zipCode = value;
					}
				}
			}
		}
	}
}
