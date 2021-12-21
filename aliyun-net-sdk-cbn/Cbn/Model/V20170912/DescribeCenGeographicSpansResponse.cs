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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class DescribeCenGeographicSpansResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeCenGeographicSpans_GeographicSpanModel> geographicSpanModels;

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

		public int? TotalCount
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

		public List<DescribeCenGeographicSpans_GeographicSpanModel> GeographicSpanModels
		{
			get
			{
				return geographicSpanModels;
			}
			set	
			{
				geographicSpanModels = value;
			}
		}

		public class DescribeCenGeographicSpans_GeographicSpanModel
		{

			private string localGeoRegionId;

			private string geographicSpanId;

			private string oppositeGeoRegionId;

			public string LocalGeoRegionId
			{
				get
				{
					return localGeoRegionId;
				}
				set	
				{
					localGeoRegionId = value;
				}
			}

			public string GeographicSpanId
			{
				get
				{
					return geographicSpanId;
				}
				set	
				{
					geographicSpanId = value;
				}
			}

			public string OppositeGeoRegionId
			{
				get
				{
					return oppositeGeoRegionId;
				}
				set	
				{
					oppositeGeoRegionId = value;
				}
			}
		}
	}
}
