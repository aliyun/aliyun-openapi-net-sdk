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

namespace Aliyun.Acs.Copyright.Model.V20190123
{
	public class CheckPatentSellStatusResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<CheckPatentSellStatus_DataItem> data;

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

		public List<CheckPatentSellStatus_DataItem> Data
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

		public class CheckPatentSellStatus_DataItem
		{

			private string age;

			private string applyNumber;

			private string discount;

			private string endDate;

			private string errorMessage;

			private float? fee;

			private string type;

			public string Age
			{
				get
				{
					return age;
				}
				set	
				{
					age = value;
				}
			}

			public string ApplyNumber
			{
				get
				{
					return applyNumber;
				}
				set	
				{
					applyNumber = value;
				}
			}

			public string Discount
			{
				get
				{
					return discount;
				}
				set	
				{
					discount = value;
				}
			}

			public string EndDate
			{
				get
				{
					return endDate;
				}
				set	
				{
					endDate = value;
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

			public float? Fee
			{
				get
				{
					return fee;
				}
				set	
				{
					fee = value;
				}
			}

			public string Type
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
		}
	}
}
