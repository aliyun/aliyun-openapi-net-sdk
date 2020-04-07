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

namespace Aliyun.Acs.cusanalytic_sc_online.Model.V20190524
{
	public class GetBaseAgeDataResponse : AcsResponse
	{

		private string day;

		private long? storeId;

		private string errorMsg;

		private string hour;

		private long? locationId;

		private string summaryType;

		private bool? success;

		private List<GetBaseAgeData_AgeItem> ageItems;

		private List<GetBaseAgeData_AgeItem> femaleAgeItems;

		private List<GetBaseAgeData_AgeItem> maleAgeItems;

		public string Day
		{
			get
			{
				return day;
			}
			set	
			{
				day = value;
			}
		}

		public long? StoreId
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

		public string Hour
		{
			get
			{
				return hour;
			}
			set	
			{
				hour = value;
			}
		}

		public long? LocationId
		{
			get
			{
				return locationId;
			}
			set	
			{
				locationId = value;
			}
		}

		public string SummaryType
		{
			get
			{
				return summaryType;
			}
			set	
			{
				summaryType = value;
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

		public List<GetBaseAgeData_AgeItem> AgeItems
		{
			get
			{
				return ageItems;
			}
			set	
			{
				ageItems = value;
			}
		}

		public List<GetBaseAgeData_AgeItem> FemaleAgeItems
		{
			get
			{
				return femaleAgeItems;
			}
			set	
			{
				femaleAgeItems = value;
			}
		}

		public List<GetBaseAgeData_AgeItem> MaleAgeItems
		{
			get
			{
				return maleAgeItems;
			}
			set	
			{
				maleAgeItems = value;
			}
		}

		public class GetBaseAgeData_AgeItem
		{

			private string name;

			private int? count;

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

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}
	}
}
