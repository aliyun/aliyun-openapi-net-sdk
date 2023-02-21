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

namespace Aliyun.Acs.dt_oc_info.Model.V20220829
{
	public class GetOcOperationPurchaseLandResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcOperationPurchaseLand_DataItem> data;

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

		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

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

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
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

		public List<GetOcOperationPurchaseLand_DataItem> Data
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

		public class GetOcOperationPurchaseLand_DataItem
		{

			private string entName;

			private string regionName;

			private string electronicNo;

			private string projectName;

			private string location;

			private string area;

			private string releaseDate;

			private string landSource;

			private string landUse;

			private string landLevel;

			private string signingMode;

			private string useYear;

			private string industry;

			private string promiseDeliveryDate;

			private string promiseStartDate;

			private string promiseEndDate;

			private string department;

			private string price;

			private string volumeFractionUpperBound;

			private string volumeFractionLowerBound;

			public string EntName
			{
				get
				{
					return entName;
				}
				set	
				{
					entName = value;
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

			public string ElectronicNo
			{
				get
				{
					return electronicNo;
				}
				set	
				{
					electronicNo = value;
				}
			}

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string Area
			{
				get
				{
					return area;
				}
				set	
				{
					area = value;
				}
			}

			public string ReleaseDate
			{
				get
				{
					return releaseDate;
				}
				set	
				{
					releaseDate = value;
				}
			}

			public string LandSource
			{
				get
				{
					return landSource;
				}
				set	
				{
					landSource = value;
				}
			}

			public string LandUse
			{
				get
				{
					return landUse;
				}
				set	
				{
					landUse = value;
				}
			}

			public string LandLevel
			{
				get
				{
					return landLevel;
				}
				set	
				{
					landLevel = value;
				}
			}

			public string SigningMode
			{
				get
				{
					return signingMode;
				}
				set	
				{
					signingMode = value;
				}
			}

			public string UseYear
			{
				get
				{
					return useYear;
				}
				set	
				{
					useYear = value;
				}
			}

			public string Industry
			{
				get
				{
					return industry;
				}
				set	
				{
					industry = value;
				}
			}

			public string PromiseDeliveryDate
			{
				get
				{
					return promiseDeliveryDate;
				}
				set	
				{
					promiseDeliveryDate = value;
				}
			}

			public string PromiseStartDate
			{
				get
				{
					return promiseStartDate;
				}
				set	
				{
					promiseStartDate = value;
				}
			}

			public string PromiseEndDate
			{
				get
				{
					return promiseEndDate;
				}
				set	
				{
					promiseEndDate = value;
				}
			}

			public string Department
			{
				get
				{
					return department;
				}
				set	
				{
					department = value;
				}
			}

			public string Price
			{
				get
				{
					return price;
				}
				set	
				{
					price = value;
				}
			}

			public string VolumeFractionUpperBound
			{
				get
				{
					return volumeFractionUpperBound;
				}
				set	
				{
					volumeFractionUpperBound = value;
				}
			}

			public string VolumeFractionLowerBound
			{
				get
				{
					return volumeFractionLowerBound;
				}
				set	
				{
					volumeFractionLowerBound = value;
				}
			}
		}
	}
}
