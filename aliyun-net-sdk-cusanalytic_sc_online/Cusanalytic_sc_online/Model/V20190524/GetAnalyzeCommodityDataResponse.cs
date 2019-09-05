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
	public class GetAnalyzeCommodityDataResponse : AcsResponse
	{

		private int? pageIndex;

		private int? total;

		private int? pageSize;

		private List<GetAnalyzeCommodityData_AnalyzeCommodityItem> analyzeCommodityItems;

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
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

		public List<GetAnalyzeCommodityData_AnalyzeCommodityItem> AnalyzeCommodityItems
		{
			get
			{
				return analyzeCommodityItems;
			}
			set	
			{
				analyzeCommodityItems = value;
			}
		}

		public class GetAnalyzeCommodityData_AnalyzeCommodityItem
		{

			private string locationNames;

			private long? supportCount;

			private string locationIds;

			private long? itemCount;

			public string LocationNames
			{
				get
				{
					return locationNames;
				}
				set	
				{
					locationNames = value;
				}
			}

			public long? SupportCount
			{
				get
				{
					return supportCount;
				}
				set	
				{
					supportCount = value;
				}
			}

			public string LocationIds
			{
				get
				{
					return locationIds;
				}
				set	
				{
					locationIds = value;
				}
			}

			public long? ItemCount
			{
				get
				{
					return itemCount;
				}
				set	
				{
					itemCount = value;
				}
			}
		}
	}
}
