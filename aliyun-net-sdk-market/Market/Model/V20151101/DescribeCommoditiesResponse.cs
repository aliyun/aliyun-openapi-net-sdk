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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeCommoditiesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private DescribeCommodities_Data data;

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

		public DescribeCommodities_Data Data
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

		public class DescribeCommodities_Data
		{

			private long? totalCount;

			private List<DescribeCommodities_Commodity> commodities;

			private DescribeCommodities_Pageable pageable;

			public long? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public List<DescribeCommodities_Commodity> Commodities
			{
				get
				{
					return commodities;
				}
				set	
				{
					commodities = value;
				}
			}

			public DescribeCommodities_Pageable Pageable
			{
				get
				{
					return pageable;
				}
				set	
				{
					pageable = value;
				}
			}

			public class DescribeCommodities_Commodity
			{

				private string commodityId;

				private string properties;

				private string applicationId;

				public string CommodityId
				{
					get
					{
						return commodityId;
					}
					set	
					{
						commodityId = value;
					}
				}

				public string Properties
				{
					get
					{
						return properties;
					}
					set	
					{
						properties = value;
					}
				}

				public string ApplicationId
				{
					get
					{
						return applicationId;
					}
					set	
					{
						applicationId = value;
					}
				}
			}

			public class DescribeCommodities_Pageable
			{

				private int? pageNumber;

				private int? pageSize;

				public int? PageNumber
				{
					get
					{
						return pageNumber;
					}
					set	
					{
						pageNumber = value;
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
			}
		}
	}
}
