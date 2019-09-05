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
	public class GetLocationsResponse : AcsResponse
	{

		private long? storeId;

		private List<GetLocations_LocationItem> locationItems;

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

		public List<GetLocations_LocationItem> LocationItems
		{
			get
			{
				return locationItems;
			}
			set	
			{
				locationItems = value;
			}
		}

		public class GetLocations_LocationItem
		{

			private int? status;

			private long? storeId;

			private string name;

			private bool? link;

			private string locationType;

			private long? locationId;

			private long? parentLocationId;

			private string layerType;

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

			public bool? Link
			{
				get
				{
					return link;
				}
				set	
				{
					link = value;
				}
			}

			public string LocationType
			{
				get
				{
					return locationType;
				}
				set	
				{
					locationType = value;
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

			public long? ParentLocationId
			{
				get
				{
					return parentLocationId;
				}
				set	
				{
					parentLocationId = value;
				}
			}

			public string LayerType
			{
				get
				{
					return layerType;
				}
				set	
				{
					layerType = value;
				}
			}
		}
	}
}
