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

namespace Aliyun.Acs.CDRS.Model.V20201101
{
	public class ListVehicleDetailsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private long? pageNumber;

		private long? pageSize;

		private long? totalCount;

		private List<ListVehicleDetails_Datas> data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public List<ListVehicleDetails_Datas> Data
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

		public class ListVehicleDetails_Datas
		{

			private string vehicleId;

			private string vehicleColor;

			private string targetImageStoragePath;

			private string gender;

			private string personType;

			private string prefOutTime;

			private string popularPoi;

			private string popularAddress;

			private string sourceImageStoragePath;

			private string vehicleClass;

			private string vehicleApplication;

			private string personId;

			private string plateId;

			private string sourceUrl;

			private string targetUrl;

			public string VehicleId
			{
				get
				{
					return vehicleId;
				}
				set	
				{
					vehicleId = value;
				}
			}

			public string VehicleColor
			{
				get
				{
					return vehicleColor;
				}
				set	
				{
					vehicleColor = value;
				}
			}

			public string TargetImageStoragePath
			{
				get
				{
					return targetImageStoragePath;
				}
				set	
				{
					targetImageStoragePath = value;
				}
			}

			public string Gender
			{
				get
				{
					return gender;
				}
				set	
				{
					gender = value;
				}
			}

			public string PersonType
			{
				get
				{
					return personType;
				}
				set	
				{
					personType = value;
				}
			}

			public string PrefOutTime
			{
				get
				{
					return prefOutTime;
				}
				set	
				{
					prefOutTime = value;
				}
			}

			public string PopularPoi
			{
				get
				{
					return popularPoi;
				}
				set	
				{
					popularPoi = value;
				}
			}

			public string PopularAddress
			{
				get
				{
					return popularAddress;
				}
				set	
				{
					popularAddress = value;
				}
			}

			public string SourceImageStoragePath
			{
				get
				{
					return sourceImageStoragePath;
				}
				set	
				{
					sourceImageStoragePath = value;
				}
			}

			public string VehicleClass
			{
				get
				{
					return vehicleClass;
				}
				set	
				{
					vehicleClass = value;
				}
			}

			public string VehicleApplication
			{
				get
				{
					return vehicleApplication;
				}
				set	
				{
					vehicleApplication = value;
				}
			}

			public string PersonId
			{
				get
				{
					return personId;
				}
				set	
				{
					personId = value;
				}
			}

			public string PlateId
			{
				get
				{
					return plateId;
				}
				set	
				{
					plateId = value;
				}
			}

			public string SourceUrl
			{
				get
				{
					return sourceUrl;
				}
				set	
				{
					sourceUrl = value;
				}
			}

			public string TargetUrl
			{
				get
				{
					return targetUrl;
				}
				set	
				{
					targetUrl = value;
				}
			}
		}
	}
}
