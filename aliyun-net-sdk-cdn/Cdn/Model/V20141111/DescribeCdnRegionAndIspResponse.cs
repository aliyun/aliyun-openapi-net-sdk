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

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeCdnRegionAndIspResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeCdnRegionAndIsp_Region> regions;

		private List<DescribeCdnRegionAndIsp_Isp> isps;

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

		public List<DescribeCdnRegionAndIsp_Region> Regions
		{
			get
			{
				return regions;
			}
			set	
			{
				regions = value;
			}
		}

		public List<DescribeCdnRegionAndIsp_Isp> Isps
		{
			get
			{
				return isps;
			}
			set	
			{
				isps = value;
			}
		}

		public class DescribeCdnRegionAndIsp_Region
		{

			private string nameZh;

			private string nameEn;

			public string NameZh
			{
				get
				{
					return nameZh;
				}
				set	
				{
					nameZh = value;
				}
			}

			public string NameEn
			{
				get
				{
					return nameEn;
				}
				set	
				{
					nameEn = value;
				}
			}
		}

		public class DescribeCdnRegionAndIsp_Isp
		{

			private string nameZh;

			private string nameEn;

			public string NameZh
			{
				get
				{
					return nameZh;
				}
				set	
				{
					nameZh = value;
				}
			}

			public string NameEn
			{
				get
				{
					return nameEn;
				}
				set	
				{
					nameEn = value;
				}
			}
		}
	}
}