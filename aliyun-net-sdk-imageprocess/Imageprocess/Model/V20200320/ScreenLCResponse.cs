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

namespace Aliyun.Acs.imageprocess.Model.V20200320
{
	public class ScreenLCResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private ScreenLC_Data data;

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

		public ScreenLC_Data Data
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

		public class ScreenLC_Data
		{

			private ScreenLC_Lesion lesion;

			public ScreenLC_Lesion Lesion
			{
				get
				{
					return lesion;
				}
				set	
				{
					lesion = value;
				}
			}

			public class ScreenLC_Lesion
			{

				private string mask;

				private float? liverVolume;

				private List<ScreenLC_LesionListItem> lesionList;

				private ScreenLC_PatientLevelResult patientLevelResult;

				public string Mask
				{
					get
					{
						return mask;
					}
					set	
					{
						mask = value;
					}
				}

				public float? LiverVolume
				{
					get
					{
						return liverVolume;
					}
					set	
					{
						liverVolume = value;
					}
				}

				public List<ScreenLC_LesionListItem> LesionList
				{
					get
					{
						return lesionList;
					}
					set	
					{
						lesionList = value;
					}
				}

				public ScreenLC_PatientLevelResult PatientLevelResult
				{
					get
					{
						return patientLevelResult;
					}
					set	
					{
						patientLevelResult = value;
					}
				}

				public class ScreenLC_LesionListItem
				{

					private string type;

					private float? volume;

					private long? keySlice;

					private float? malignancy;

					private List<string> recistEndpoints;

					private List<string> diameter;

					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
						}
					}

					public float? Volume
					{
						get
						{
							return volume;
						}
						set	
						{
							volume = value;
						}
					}

					public long? KeySlice
					{
						get
						{
							return keySlice;
						}
						set	
						{
							keySlice = value;
						}
					}

					public float? Malignancy
					{
						get
						{
							return malignancy;
						}
						set	
						{
							malignancy = value;
						}
					}

					public List<string> RecistEndpoints
					{
						get
						{
							return recistEndpoints;
						}
						set	
						{
							recistEndpoints = value;
						}
					}

					public List<string> Diameter
					{
						get
						{
							return diameter;
						}
						set	
						{
							diameter = value;
						}
					}
				}

				public class ScreenLC_PatientLevelResult
				{

					private float? tumorNonCystProb;

					private float? hCCProb;

					private float? malignantNonHCCProb;

					private string benignNonCystProb;

					private float? cystProb;

					public float? TumorNonCystProb
					{
						get
						{
							return tumorNonCystProb;
						}
						set	
						{
							tumorNonCystProb = value;
						}
					}

					public float? HCCProb
					{
						get
						{
							return hCCProb;
						}
						set	
						{
							hCCProb = value;
						}
					}

					public float? MalignantNonHCCProb
					{
						get
						{
							return malignantNonHCCProb;
						}
						set	
						{
							malignantNonHCCProb = value;
						}
					}

					public string BenignNonCystProb
					{
						get
						{
							return benignNonCystProb;
						}
						set	
						{
							benignNonCystProb = value;
						}
					}

					public float? CystProb
					{
						get
						{
							return cystProb;
						}
						set	
						{
							cystProb = value;
						}
					}
				}
			}
		}
	}
}
