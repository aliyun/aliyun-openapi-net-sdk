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
	public class GetAnalyzePlaceDataResponse : AcsResponse
	{

		private long? count;

		private long? storeId;

		private float? percent;

		private string locationName;

		private string parentLocationIds;

		private long? locationId;

		private List<GetAnalyzePlaceData_AnalyzePlaceItem> analyzePlaceItems;

		public long? Count
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

		public float? Percent
		{
			get
			{
				return percent;
			}
			set	
			{
				percent = value;
			}
		}

		public string LocationName
		{
			get
			{
				return locationName;
			}
			set	
			{
				locationName = value;
			}
		}

		public string ParentLocationIds
		{
			get
			{
				return parentLocationIds;
			}
			set	
			{
				parentLocationIds = value;
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

		public List<GetAnalyzePlaceData_AnalyzePlaceItem> AnalyzePlaceItems
		{
			get
			{
				return analyzePlaceItems;
			}
			set	
			{
				analyzePlaceItems = value;
			}
		}

		public class GetAnalyzePlaceData_AnalyzePlaceItem
		{

			private string locationName;

			private long? locationId;

			private string parentLocationIds;

			private long? count;

			private long? storeId;

			private float? percent;

			private int? maleCount;

			private int? femaleCount;

			private List<GetAnalyzePlaceData_AgeItem> ageItems;

			public string LocationName
			{
				get
				{
					return locationName;
				}
				set	
				{
					locationName = value;
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

			public string ParentLocationIds
			{
				get
				{
					return parentLocationIds;
				}
				set	
				{
					parentLocationIds = value;
				}
			}

			public long? Count
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

			public float? Percent
			{
				get
				{
					return percent;
				}
				set	
				{
					percent = value;
				}
			}

			public int? MaleCount
			{
				get
				{
					return maleCount;
				}
				set	
				{
					maleCount = value;
				}
			}

			public int? FemaleCount
			{
				get
				{
					return femaleCount;
				}
				set	
				{
					femaleCount = value;
				}
			}

			public List<GetAnalyzePlaceData_AgeItem> AgeItems
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

			public class GetAnalyzePlaceData_AgeItem
			{

				private int? count;

				private int? age;

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

				public int? Age
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
			}
		}
	}
}
