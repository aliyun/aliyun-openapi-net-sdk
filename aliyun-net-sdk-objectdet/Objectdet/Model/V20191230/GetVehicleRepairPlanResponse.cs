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

namespace Aliyun.Acs.objectdet.Model.V20191230
{
	public class GetVehicleRepairPlanResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string errorMessage;

		private bool? success;

		private int? httpCode;

		private GetVehicleRepairPlan_Data data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public int? HttpCode
		{
			get
			{
				return httpCode;
			}
			set	
			{
				httpCode = value;
			}
		}

		public GetVehicleRepairPlan_Data Data
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

		public class GetVehicleRepairPlan_Data
		{

			private string frameNo;

			private List<GetVehicleRepairPlan_RepairItems> repairParts;

			public string FrameNo
			{
				get
				{
					return frameNo;
				}
				set	
				{
					frameNo = value;
				}
			}

			public List<GetVehicleRepairPlan_RepairItems> RepairParts
			{
				get
				{
					return repairParts;
				}
				set	
				{
					repairParts = value;
				}
			}

			public class GetVehicleRepairPlan_RepairItems
			{

				private string garageType;

				private bool? oeMatch;

				private string outStandardPartsId;

				private string outStandardPartsName;

				private bool? partNameMatch;

				private string partsStdCode;

				private string partsStdName;

				private string relationType;

				private string repairFee;

				private string repairType;

				private string repairTypeName;

				public string GarageType
				{
					get
					{
						return garageType;
					}
					set	
					{
						garageType = value;
					}
				}

				public bool? OeMatch
				{
					get
					{
						return oeMatch;
					}
					set	
					{
						oeMatch = value;
					}
				}

				public string OutStandardPartsId
				{
					get
					{
						return outStandardPartsId;
					}
					set	
					{
						outStandardPartsId = value;
					}
				}

				public string OutStandardPartsName
				{
					get
					{
						return outStandardPartsName;
					}
					set	
					{
						outStandardPartsName = value;
					}
				}

				public bool? PartNameMatch
				{
					get
					{
						return partNameMatch;
					}
					set	
					{
						partNameMatch = value;
					}
				}

				public string PartsStdCode
				{
					get
					{
						return partsStdCode;
					}
					set	
					{
						partsStdCode = value;
					}
				}

				public string PartsStdName
				{
					get
					{
						return partsStdName;
					}
					set	
					{
						partsStdName = value;
					}
				}

				public string RelationType
				{
					get
					{
						return relationType;
					}
					set	
					{
						relationType = value;
					}
				}

				public string RepairFee
				{
					get
					{
						return repairFee;
					}
					set	
					{
						repairFee = value;
					}
				}

				public string RepairType
				{
					get
					{
						return repairType;
					}
					set	
					{
						repairType = value;
					}
				}

				public string RepairTypeName
				{
					get
					{
						return repairTypeName;
					}
					set	
					{
						repairTypeName = value;
					}
				}
			}
		}
	}
}
