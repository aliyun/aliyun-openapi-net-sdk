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
	public class RecognizeDrivingLicenseResponse : AcsResponse
	{

		private string requestId;

		private RecognizeDrivingLicense_Data data;

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

		public RecognizeDrivingLicense_Data Data
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

		public class RecognizeDrivingLicense_Data
		{

			private RecognizeDrivingLicense_FaceResult faceResult;

			private RecognizeDrivingLicense_BackResult backResult;

			public RecognizeDrivingLicense_FaceResult FaceResult
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

			public RecognizeDrivingLicense_BackResult BackResult
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

			public class RecognizeDrivingLicense_FaceResult
			{

				private string plateNumber;

				private string vehicleType;

				private string owner;

				private string useCharacter;

				private string address;

				private string model;

				private string vin;

				private string engineNumber;

				private string registerDate;

				private string issueDate;

				public string PlateNumber
				{
					get
					{
						return plateNumber;
					}
					set	
					{
						plateNumber = value;
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

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
					}
				}

				public string UseCharacter
				{
					get
					{
						return useCharacter;
					}
					set	
					{
						useCharacter = value;
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

				public string Model
				{
					get
					{
						return model;
					}
					set	
					{
						model = value;
					}
				}

				public string Vin
				{
					get
					{
						return vin;
					}
					set	
					{
						vin = value;
					}
				}

				public string EngineNumber
				{
					get
					{
						return engineNumber;
					}
					set	
					{
						engineNumber = value;
					}
				}

				public string RegisterDate
				{
					get
					{
						return registerDate;
					}
					set	
					{
						registerDate = value;
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
			}

			public class RecognizeDrivingLicense_BackResult
			{

				private string approvedPassengerCapacity;

				private string approvedLoad;

				private string fileNumber;

				private string grossMass;

				private string energyType;

				private string inspectionRecord;

				private string overallDimension;

				private string tractionMass;

				private string unladenMass;

				private string plateNumber;

				public string ApprovedPassengerCapacity
				{
					get
					{
						return approvedPassengerCapacity;
					}
					set	
					{
						approvedPassengerCapacity = value;
					}
				}

				public string ApprovedLoad
				{
					get
					{
						return approvedLoad;
					}
					set	
					{
						approvedLoad = value;
					}
				}

				public string FileNumber
				{
					get
					{
						return fileNumber;
					}
					set	
					{
						fileNumber = value;
					}
				}

				public string GrossMass
				{
					get
					{
						return grossMass;
					}
					set	
					{
						grossMass = value;
					}
				}

				public string EnergyType
				{
					get
					{
						return energyType;
					}
					set	
					{
						energyType = value;
					}
				}

				public string InspectionRecord
				{
					get
					{
						return inspectionRecord;
					}
					set	
					{
						inspectionRecord = value;
					}
				}

				public string OverallDimension
				{
					get
					{
						return overallDimension;
					}
					set	
					{
						overallDimension = value;
					}
				}

				public string TractionMass
				{
					get
					{
						return tractionMass;
					}
					set	
					{
						tractionMass = value;
					}
				}

				public string UnladenMass
				{
					get
					{
						return unladenMass;
					}
					set	
					{
						unladenMass = value;
					}
				}

				public string PlateNumber
				{
					get
					{
						return plateNumber;
					}
					set	
					{
						plateNumber = value;
					}
				}
			}
		}
	}
}
