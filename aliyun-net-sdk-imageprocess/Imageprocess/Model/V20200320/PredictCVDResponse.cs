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
	public class PredictCVDResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private PredictCVD_Data data;

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

		public PredictCVD_Data Data
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

		public class PredictCVD_Data
		{

			private PredictCVD_Lesion lesion;

			public PredictCVD_Lesion Lesion
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

			public class PredictCVD_Lesion
			{

				private float? cVDProbability;

				private List<string> resultURL;

				private PredictCVD_FeatureScore featureScore;

				public float? CVDProbability
				{
					get
					{
						return cVDProbability;
					}
					set	
					{
						cVDProbability = value;
					}
				}

				public List<string> ResultURL
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

				public PredictCVD_FeatureScore FeatureScore
				{
					get
					{
						return featureScore;
					}
					set	
					{
						featureScore = value;
					}
				}

				public class PredictCVD_FeatureScore
				{

					private List<string> myoEpiRatio;

					private List<string> ascAoMaxDiam;

					private List<string> coronaryCalciumVol;

					private List<string> eatVolume;

					private List<string> aortaCalciumScore;

					private List<string> cardioThoracicRatio;

					private List<string> eatHUMean;

					private List<string> eatHUSTD;

					private List<string> rightLungLowattRatio;

					private List<string> ascendAortaLength;

					private List<string> leftLungLowattRatio;

					private List<string> deepFeature;

					private List<string> aortaCalciumVolume;

					private List<string> coronaryCalciumScore;

					public List<string> MyoEpiRatio
					{
						get
						{
							return myoEpiRatio;
						}
						set	
						{
							myoEpiRatio = value;
						}
					}

					public List<string> AscAoMaxDiam
					{
						get
						{
							return ascAoMaxDiam;
						}
						set	
						{
							ascAoMaxDiam = value;
						}
					}

					public List<string> CoronaryCalciumVol
					{
						get
						{
							return coronaryCalciumVol;
						}
						set	
						{
							coronaryCalciumVol = value;
						}
					}

					public List<string> EatVolume
					{
						get
						{
							return eatVolume;
						}
						set	
						{
							eatVolume = value;
						}
					}

					public List<string> AortaCalciumScore
					{
						get
						{
							return aortaCalciumScore;
						}
						set	
						{
							aortaCalciumScore = value;
						}
					}

					public List<string> CardioThoracicRatio
					{
						get
						{
							return cardioThoracicRatio;
						}
						set	
						{
							cardioThoracicRatio = value;
						}
					}

					public List<string> EatHUMean
					{
						get
						{
							return eatHUMean;
						}
						set	
						{
							eatHUMean = value;
						}
					}

					public List<string> EatHUSTD
					{
						get
						{
							return eatHUSTD;
						}
						set	
						{
							eatHUSTD = value;
						}
					}

					public List<string> RightLungLowattRatio
					{
						get
						{
							return rightLungLowattRatio;
						}
						set	
						{
							rightLungLowattRatio = value;
						}
					}

					public List<string> AscendAortaLength
					{
						get
						{
							return ascendAortaLength;
						}
						set	
						{
							ascendAortaLength = value;
						}
					}

					public List<string> LeftLungLowattRatio
					{
						get
						{
							return leftLungLowattRatio;
						}
						set	
						{
							leftLungLowattRatio = value;
						}
					}

					public List<string> DeepFeature
					{
						get
						{
							return deepFeature;
						}
						set	
						{
							deepFeature = value;
						}
					}

					public List<string> AortaCalciumVolume
					{
						get
						{
							return aortaCalciumVolume;
						}
						set	
						{
							aortaCalciumVolume = value;
						}
					}

					public List<string> CoronaryCalciumScore
					{
						get
						{
							return coronaryCalciumScore;
						}
						set	
						{
							coronaryCalciumScore = value;
						}
					}
				}
			}
		}
	}
}
