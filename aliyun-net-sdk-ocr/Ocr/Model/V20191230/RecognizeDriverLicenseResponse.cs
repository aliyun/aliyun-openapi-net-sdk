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

namespace Aliyun.Acs.ocr.Model.V20191230
{
	public class RecognizeDriverLicenseResponse : AcsResponse
	{

		private string requestId;

		private RecognizeDriverLicense_Data data;

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

		public RecognizeDriverLicense_Data Data
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

		public class RecognizeDriverLicense_Data
		{

			private RecognizeDriverLicense_FaceResult faceResult;

			private RecognizeDriverLicense_BackResult backResult;

			public RecognizeDriverLicense_FaceResult FaceResult
			{
				get
				{
					return faceResult;
				}
				set	
				{
					faceResult = value;
				}
			}

			public RecognizeDriverLicense_BackResult BackResult
			{
				get
				{
					return backResult;
				}
				set	
				{
					backResult = value;
				}
			}

			public class RecognizeDriverLicense_FaceResult
			{

				private string name;

				private string licenseNumber;

				private string vehicleType;

				private string startDate;

				private string endDate;

				private string issueDate;

				private string address;

				private string gender;

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

				public string LicenseNumber
				{
					get
					{
						return licenseNumber;
					}
					set	
					{
						licenseNumber = value;
					}
				}

				public string VehicleType
				{
					get
					{
						return vehicleType;
					}
					set	
					{
						vehicleType = value;
					}
				}

				public string StartDate
				{
					get
					{
						return startDate;
					}
					set	
					{
						startDate = value;
					}
				}

				public string EndDate
				{
					get
					{
						return endDate;
					}
					set	
					{
						endDate = value;
					}
				}

				public string IssueDate
				{
					get
					{
						return issueDate;
					}
					set	
					{
						issueDate = value;
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
			}

			public class RecognizeDriverLicense_BackResult
			{

				private string archiveNumber;

				public string ArchiveNumber
				{
					get
					{
						return archiveNumber;
					}
					set	
					{
						archiveNumber = value;
					}
				}
			}
		}
	}
}
