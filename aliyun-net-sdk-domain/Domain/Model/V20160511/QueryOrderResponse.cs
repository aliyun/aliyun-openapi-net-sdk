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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Model.V20160511
{
	public class QueryOrderResponse : AcsResponse
	{

		private string orderID;

		private string userID;

		private string money;

		private string orderDate;

		private bool? checkFlag;

		private string checkDate;

		private bool? validFlag;

		private bool? checkType;

		private List<SubOrderResult> orderProducts;

		public string OrderID
		{
			get
			{
				return orderID;
			}
			set	
			{
				orderID = value;
			}
		}

		public string UserID
		{
			get
			{
				return userID;
			}
			set	
			{
				userID = value;
			}
		}

		public string Money
		{
			get
			{
				return money;
			}
			set	
			{
				money = value;
			}
		}

		public string OrderDate
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

		public bool? CheckFlag
		{
			get
			{
				return checkFlag;
			}
			set	
			{
				checkFlag = value;
			}
		}

		public string CheckDate
		{
			get
			{
				return checkDate;
			}
			set	
			{
				checkDate = value;
			}
		}

		public bool? ValidFlag
		{
			get
			{
				return validFlag;
			}
			set	
			{
				validFlag = value;
			}
		}

		public bool? CheckType
		{
			get
			{
				return checkType;
			}
			set	
			{
				checkType = value;
			}
		}

		public List<SubOrderResult> OrderProducts
		{
			get
			{
				return orderProducts;
			}
			set	
			{
				orderProducts = value;
			}
		}

		public class SubOrderResult{

			private string trackID;

			private string orderID;

			private string saleID;

			private string userID;

			private string classID;

			private string productName;

			private string relatedName;

			private string actionType;

			private int? periodUnit;

			private int? periodNum;

			private int? amount;

			private string orderDate;

			private bool? checkFlag;

			private string checkDate;

			private int? bizStatus;

			private string updateDate;

			private string deadDate;

			private bool? validFlag;

			private string money;

			private string parentSaleID;

			public string TrackID
			{
				get
				{
					return trackID;
				}
				set	
				{
					trackID = value;
				}
			}

			public string OrderID
			{
				get
				{
					return orderID;
				}
				set	
				{
					orderID = value;
				}
			}

			public string SaleID
			{
				get
				{
					return saleID;
				}
				set	
				{
					saleID = value;
				}
			}

			public string UserID
			{
				get
				{
					return userID;
				}
				set	
				{
					userID = value;
				}
			}

			public string ClassID
			{
				get
				{
					return classID;
				}
				set	
				{
					classID = value;
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

			public string RelatedName
			{
				get
				{
					return relatedName;
				}
				set	
				{
					relatedName = value;
				}
			}

			public string ActionType
			{
				get
				{
					return actionType;
				}
				set	
				{
					actionType = value;
				}
			}

			public int? PeriodUnit
			{
				get
				{
					return periodUnit;
				}
				set	
				{
					periodUnit = value;
				}
			}

			public int? PeriodNum
			{
				get
				{
					return periodNum;
				}
				set	
				{
					periodNum = value;
				}
			}

			public int? Amount
			{
				get
				{
					return amount;
				}
				set	
				{
					amount = value;
				}
			}

			public string OrderDate
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

			public bool? CheckFlag
			{
				get
				{
					return checkFlag;
				}
				set	
				{
					checkFlag = value;
				}
			}

			public string CheckDate
			{
				get
				{
					return checkDate;
				}
				set	
				{
					checkDate = value;
				}
			}

			public int? BizStatus
			{
				get
				{
					return bizStatus;
				}
				set	
				{
					bizStatus = value;
				}
			}

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

			public string DeadDate
			{
				get
				{
					return deadDate;
				}
				set	
				{
					deadDate = value;
				}
			}

			public bool? ValidFlag
			{
				get
				{
					return validFlag;
				}
				set	
				{
					validFlag = value;
				}
			}

			public string Money
			{
				get
				{
					return money;
				}
				set	
				{
					money = value;
				}
			}

			public string ParentSaleID
			{
				get
				{
					return parentSaleID;
				}
				set	
				{
					parentSaleID = value;
				}
			}
		}
	}
}