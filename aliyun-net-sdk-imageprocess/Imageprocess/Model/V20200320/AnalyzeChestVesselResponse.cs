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

namespace Aliyun.Acs.imageprocess.Model.V20200320
{
	public class AnalyzeChestVesselResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private AnalyzeChestVessel_Data data;

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

		public AnalyzeChestVessel_Data Data
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

		public class AnalyzeChestVessel_Data
		{

			private string resultURL;

			private AnalyzeChestVessel_AortaInfo aortaInfo;

			private AnalyzeChestVessel_PulmonaryInfo pulmonaryInfo;

			public string ResultURL
			{
				get
				{
					return resultURL;
				}
				set	
				{
					resultURL = value;
				}
			}

			public AnalyzeChestVessel_AortaInfo AortaInfo
			{
				get
				{
					return aortaInfo;
				}
				set	
				{
					aortaInfo = value;
				}
			}

			public AnalyzeChestVessel_PulmonaryInfo PulmonaryInfo
			{
				get
				{
					return pulmonaryInfo;
				}
				set	
				{
					pulmonaryInfo = value;
				}
			}

			public class AnalyzeChestVessel_AortaInfo
			{

				private long? maxAreaIndex;

				private float? maxArea;

				private float? maxDiameter;

				private long? labelValue;

				private List<string> coordinates;

				private List<string> area;

				public long? MaxAreaIndex
				{
					get
					{
						return maxAreaIndex;
					}
					set	
					{
						maxAreaIndex = value;
					}
				}

				public float? MaxArea
				{
					get
					{
						return maxArea;
					}
					set	
					{
						maxArea = value;
					}
				}

				public float? MaxDiameter
				{
					get
					{
						return maxDiameter;
					}
					set	
					{
						maxDiameter = value;
					}
				}

				public long? LabelValue
				{
					get
					{
						return labelValue;
					}
					set	
					{
						labelValue = value;
					}
				}

				public List<string> Coordinates
				{
					get
					{
						return coordinates;
					}
					set	
					{
						coordinates = value;
					}
				}

				public List<string> Area
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
			}

			public class AnalyzeChestVessel_PulmonaryInfo
			{

				private long? maxAreaIndex;

				private float? maxArea;

				private float? maxDiameter;

				private long? labelValue;

				private float? nearestAortaArea;

				private List<string> coordinates1;

				private List<string> area2;

				public long? MaxAreaIndex
				{
					get
					{
						return maxAreaIndex;
					}
					set	
					{
						maxAreaIndex = value;
					}
				}

				public float? MaxArea
				{
					get
					{
						return maxArea;
					}
					set	
					{
						maxArea = value;
					}
				}

				public float? MaxDiameter
				{
					get
					{
						return maxDiameter;
					}
					set	
					{
						maxDiameter = value;
					}
				}

				public long? LabelValue
				{
					get
					{
						return labelValue;
					}
					set	
					{
						labelValue = value;
					}
				}

				public float? NearestAortaArea
				{
					get
					{
						return nearestAortaArea;
					}
					set	
					{
						nearestAortaArea = value;
					}
				}

				public List<string> Coordinates1
				{
					get
					{
						return coordinates1;
					}
					set	
					{
						coordinates1 = value;
					}
				}

				public List<string> Area2
				{
					get
					{
						return area2;
					}
					set	
					{
						area2 = value;
					}
				}
			}
		}
	}
}
