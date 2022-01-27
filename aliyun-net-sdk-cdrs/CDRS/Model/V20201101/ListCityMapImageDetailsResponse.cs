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
	public class ListCityMapImageDetailsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private long? pageNumber;

		private long? pageSize;

		private long? totalCount;

		private List<ListCityMapImageDetails_Datas> data;

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

		public List<ListCityMapImageDetails_Datas> Data
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

		public class ListCityMapImageDetails_Datas
		{

			private string personTargetImageStoragePath;

			private string ageLowerLimit;

			private string ageUpLimit;

			private string vehicleColor;

			private string trousersColor;

			private string dataSourceId;

			private string gender;

			private string ageLowerLimitReliability;

			private string genderCodeReliability;

			private string vehicleClassReliability;

			private string recordId;

			private string ageCodeReliability;

			private string sourceImageStoragePath;

			private string vehicleClass;

			private string motorTargetImageStoragePath;

			private string coatColor;

			private string faceTargetImageStoragePath;

			private string shotTime;

			private string vehicleColorReliability;

			private string trousersColorReliability;

			private string coatColorReliability;

			private string leftTopX;

			private string leftTopY;

			private string rightBottomX;

			private string rightBottomY;

			public string PersonTargetImageStoragePath
			{
				get
				{
					return personTargetImageStoragePath;
				}
				set	
				{
					personTargetImageStoragePath = value;
				}
			}

			public string AgeLowerLimit
			{
				get
				{
					return ageLowerLimit;
				}
				set	
				{
					ageLowerLimit = value;
				}
			}

			public string AgeUpLimit
			{
				get
				{
					return ageUpLimit;
				}
				set	
				{
					ageUpLimit = value;
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

			public string TrousersColor
			{
				get
				{
					return trousersColor;
				}
				set	
				{
					trousersColor = value;
				}
			}

			public string DataSourceId
			{
				get
				{
					return dataSourceId;
				}
				set	
				{
					dataSourceId = value;
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

			public string AgeLowerLimitReliability
			{
				get
				{
					return ageLowerLimitReliability;
				}
				set	
				{
					ageLowerLimitReliability = value;
				}
			}

			public string GenderCodeReliability
			{
				get
				{
					return genderCodeReliability;
				}
				set	
				{
					genderCodeReliability = value;
				}
			}

			public string VehicleClassReliability
			{
				get
				{
					return vehicleClassReliability;
				}
				set	
				{
					vehicleClassReliability = value;
				}
			}

			public string RecordId
			{
				get
				{
					return recordId;
				}
				set	
				{
					recordId = value;
				}
			}

			public string AgeCodeReliability
			{
				get
				{
					return ageCodeReliability;
				}
				set	
				{
					ageCodeReliability = value;
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

			public string MotorTargetImageStoragePath
			{
				get
				{
					return motorTargetImageStoragePath;
				}
				set	
				{
					motorTargetImageStoragePath = value;
				}
			}

			public string CoatColor
			{
				get
				{
					return coatColor;
				}
				set	
				{
					coatColor = value;
				}
			}

			public string FaceTargetImageStoragePath
			{
				get
				{
					return faceTargetImageStoragePath;
				}
				set	
				{
					faceTargetImageStoragePath = value;
				}
			}

			public string ShotTime
			{
				get
				{
					return shotTime;
				}
				set	
				{
					shotTime = value;
				}
			}

			public string VehicleColorReliability
			{
				get
				{
					return vehicleColorReliability;
				}
				set	
				{
					vehicleColorReliability = value;
				}
			}

			public string TrousersColorReliability
			{
				get
				{
					return trousersColorReliability;
				}
				set	
				{
					trousersColorReliability = value;
				}
			}

			public string CoatColorReliability
			{
				get
				{
					return coatColorReliability;
				}
				set	
				{
					coatColorReliability = value;
				}
			}

			public string LeftTopX
			{
				get
				{
					return leftTopX;
				}
				set	
				{
					leftTopX = value;
				}
			}

			public string LeftTopY
			{
				get
				{
					return leftTopY;
				}
				set	
				{
					leftTopY = value;
				}
			}

			public string RightBottomX
			{
				get
				{
					return rightBottomX;
				}
				set	
				{
					rightBottomX = value;
				}
			}

			public string RightBottomY
			{
				get
				{
					return rightBottomY;
				}
				set	
				{
					rightBottomY = value;
				}
			}
		}
	}
}
