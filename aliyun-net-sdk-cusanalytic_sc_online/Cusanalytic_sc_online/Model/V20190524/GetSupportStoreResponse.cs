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
	public class GetSupportStoreResponse : AcsResponse
	{

		private List<GetSupportStore_StorePopDTO> storePopDTOs;

		public List<GetSupportStore_StorePopDTO> StorePopDTOs
		{
			get
			{
				return storePopDTOs;
			}
			set	
			{
				storePopDTOs = value;
			}
		}

		public class GetSupportStore_StorePopDTO
		{

			private long? storeId;

			private string name;

			private string regionName;

			private string openingStartTime;

			private string openingEndTime;

			private long? regionId;

			private string storeType;

			private string address;

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

			public string RegionName
			{
				get
				{
					return regionName;
				}
				set	
				{
					regionName = value;
				}
			}

			public string OpeningStartTime
			{
				get
				{
					return openingStartTime;
				}
				set	
				{
					openingStartTime = value;
				}
			}

			public string OpeningEndTime
			{
				get
				{
					return openingEndTime;
				}
				set	
				{
					openingEndTime = value;
				}
			}

			public long? RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string StoreType
			{
				get
				{
					return storeType;
				}
				set	
				{
					storeType = value;
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
		}
	}
}
