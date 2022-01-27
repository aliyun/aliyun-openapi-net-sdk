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

namespace Aliyun.Acs.DBFS.Model.V20200418
{
	public class OpreateConstantsResponse : AcsResponse
	{

		private long? totalCount;

		private string masterData;

		private long? pageSize;

		private string zoneData;

		private string requestId;

		private long? pageNumber;

		private string accessData;

		private string productCodeData;

		private string osversionData;

		private string data;

		private string regionData;

		private string endpointData;

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

		public string MasterData
		{
			get
			{
				return masterData;
			}
			set	
			{
				masterData = value;
			}
		}

		public long? PageSize
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

		public string ZoneData
		{
			get
			{
				return zoneData;
			}
			set	
			{
				zoneData = value;
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

		public long? PageNumber
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

		public string AccessData
		{
			get
			{
				return accessData;
			}
			set	
			{
				accessData = value;
			}
		}

		public string ProductCodeData
		{
			get
			{
				return productCodeData;
			}
			set	
			{
				productCodeData = value;
			}
		}

		public string OsversionData
		{
			get
			{
				return osversionData;
			}
			set	
			{
				osversionData = value;
			}
		}

		public string Data
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

		public string RegionData
		{
			get
			{
				return regionData;
			}
			set	
			{
				regionData = value;
			}
		}

		public string EndpointData
		{
			get
			{
				return endpointData;
			}
			set	
			{
				endpointData = value;
			}
		}
	}
}
