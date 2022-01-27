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
	public class ListVehicleResultsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private long? pageNumber;

		private long? pageSize;

		private long? totalCount;

		private List<ListVehicleResults_Datas> data;

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

		public List<ListVehicleResults_Datas> Data
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

		public class ListVehicleResults_Datas
		{

			private string vehicleId;

			private string gender;

			private string vehicleClass;

			private string profession;

			private string liveAddress;

			private string plateId;

			private string vehicleApplication;

			private string personId;

			private string updateTime;

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

			public string Profession
			{
				get
				{
					return profession;
				}
				set	
				{
					profession = value;
				}
			}

			public string LiveAddress
			{
				get
				{
					return liveAddress;
				}
				set	
				{
					liveAddress = value;
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

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}
		}
	}
}
