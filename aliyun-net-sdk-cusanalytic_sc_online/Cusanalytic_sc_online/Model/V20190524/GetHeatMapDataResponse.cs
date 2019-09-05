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
	public class GetHeatMapDataResponse : AcsResponse
	{

		private string eMapName;

		private float? width;

		private string eMapUrl;

		private long? storeId;

		private float? height;

		private List<GetHeatMapData_HeatMapItem> heatMapItems;

		public string EMapName
		{
			get
			{
				return eMapName;
			}
			set	
			{
				eMapName = value;
			}
		}

		public float? Width
		{
			get
			{
				return width;
			}
			set	
			{
				width = value;
			}
		}

		public string EMapUrl
		{
			get
			{
				return eMapUrl;
			}
			set	
			{
				eMapUrl = value;
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

		public float? Height
		{
			get
			{
				return height;
			}
			set	
			{
				height = value;
			}
		}

		public List<GetHeatMapData_HeatMapItem> HeatMapItems
		{
			get
			{
				return heatMapItems;
			}
			set	
			{
				heatMapItems = value;
			}
		}

		public class GetHeatMapData_HeatMapItem
		{

			private float? y;

			private float? weight;

			private float? x;

			public float? Y
			{
				get
				{
					return y;
				}
				set	
				{
					y = value;
				}
			}

			public float? Weight
			{
				get
				{
					return weight;
				}
				set	
				{
					weight = value;
				}
			}

			public float? X
			{
				get
				{
					return x;
				}
				set	
				{
					x = value;
				}
			}
		}
	}
}
