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
	public class QueryTradeMarkApplicationsResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNum;

		private int? currentPageNum;

		private int? pageSize;

		private int? totalPageNum;

		private List<QueryTradeMarkApplications_TmProduces> data;

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

		public List<QueryTradeMarkApplications_TmProduces> Data
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

		public class QueryTradeMarkApplications_TmProduces
		{

			private string bizId;

			private string orderId;

			private string materialName;

			private string tmIcon;

			private string tmName;

			private string tmNumber;

			private long? createTime;

			private int? type;

			private int? status;

			private string userId;

			private float? orderPrice;

			private long? materialId;

			private string loaUrl;

			private string note;

			private long? updateTime;

			private int? supplementStatus;

			private long? supplementId;

			private float? totalPrice;

			private float? servicePrice;

			private List<QueryTradeMarkApplications_ThirdClassifications> thirdClassification;

			private List<string> flags;

			private QueryTradeMarkApplications_FirstClassification firstClassification;

			private QueryTradeMarkApplications_RenewResponse renewResponse;

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

			public string MaterialName
			{
				get
				{
					return materialName;
				}
				set	
				{
					materialName = value;
				}
			}

			public string TmIcon
			{
				get
				{
					return tmIcon;
				}
				set	
				{
					tmIcon = value;
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

			public string TmNumber
			{
				get
				{
					return tmNumber;
				}
				set	
				{
					tmNumber = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public int? Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
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

			public long? MaterialId
			{
				get
				{
					return materialId;
				}
				set	
				{
					materialId = value;
				}
			}

			public string LoaUrl
			{
				get
				{
					return loaUrl;
				}
				set	
				{
					loaUrl = value;
				}
			}

			public string Note
			{
				get
				{
					return note;
				}
				set	
				{
					note = value;
				}
			}

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public int? SupplementStatus
			{
				get
				{
					return supplementStatus;
				}
				set	
				{
					supplementStatus = value;
				}
			}

			public long? SupplementId
			{
				get
				{
					return supplementId;
				}
				set	
				{
					supplementId = value;
				}
			}

			public float? TotalPrice
			{
				get
				{
					return totalPrice;
				}
				set	
				{
					totalPrice = value;
				}
			}

			public float? ServicePrice
			{
				get
				{
					return servicePrice;
				}
				set	
				{
					servicePrice = value;
				}
			}

			public List<QueryTradeMarkApplications_ThirdClassifications> ThirdClassification
			{
				get
				{
					return thirdClassification;
				}
				set	
				{
					thirdClassification = value;
				}
			}

			public List<string> Flags
			{
				get
				{
					return flags;
				}
				set	
				{
					flags = value;
				}
			}

			public QueryTradeMarkApplications_FirstClassification FirstClassification
			{
				get
				{
					return firstClassification;
				}
				set	
				{
					firstClassification = value;
				}
			}

			public QueryTradeMarkApplications_RenewResponse RenewResponse
			{
				get
				{
					return renewResponse;
				}
				set	
				{
					renewResponse = value;
				}
			}

			public class QueryTradeMarkApplications_ThirdClassifications
			{

				private string classificationCode;

				private string classificationName;

				public string ClassificationCode
				{
					get
					{
						return classificationCode;
					}
					set	
					{
						classificationCode = value;
					}
				}

				public string ClassificationName
				{
					get
					{
						return classificationName;
					}
					set	
					{
						classificationName = value;
					}
				}
			}

			public class QueryTradeMarkApplications_FirstClassification
			{

				private string classificationCode;

				private string classificationName;

				public string ClassificationCode
				{
					get
					{
						return classificationCode;
					}
					set	
					{
						classificationCode = value;
					}
				}

				public string ClassificationName
				{
					get
					{
						return classificationName;
					}
					set	
					{
						classificationName = value;
					}
				}
			}

			public class QueryTradeMarkApplications_RenewResponse
			{

				private string name;

				private string engName;

				private string address;

				private string engAddress;

				private long? registerTime;

				private long? submitSbjtime;

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

				public string EngName
				{
					get
					{
						return engName;
					}
					set	
					{
						engName = value;
					}
				}

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

				public string EngAddress
				{
					get
					{
						return engAddress;
					}
					set	
					{
						engAddress = value;
					}
				}

				public long? RegisterTime
				{
					get
					{
						return registerTime;
					}
					set	
					{
						registerTime = value;
					}
				}

				public long? SubmitSbjtime
				{
					get
					{
						return submitSbjtime;
					}
					set	
					{
						submitSbjtime = value;
					}
				}
			}
		}
	}
}
