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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class DetectImageFacesResponse : AcsResponse
	{

		private string requestId;

		private string imageUri;

		private List<DetectImageFaces_FacesItem> faces;

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

		public string ImageUri
		{
			get
			{
				return imageUri;
			}
			set	
			{
				imageUri = value;
			}
		}

		public List<DetectImageFaces_FacesItem> Faces
		{
			get
			{
				return faces;
			}
			set	
			{
				faces = value;
			}
		}

		public class DetectImageFaces_FacesItem
		{

			private string faceId;

			private float? faceConfidence;

			private string age;

			private string gender;

			private string emotion;

			private float? attractive;

			private float? genderConfidence;

			private float? ageConfidence;

			private float? attractiveConfidence;

			private float? emotionConfidence;

			private DetectImageFaces_FaceAttributes faceAttributes;

			private DetectImageFaces_EmotionDetails emotionDetails;

			public string FaceId
			{
				get
				{
					return faceId;
				}
				set	
				{
					faceId = value;
				}
			}

			public float? FaceConfidence
			{
				get
				{
					return faceConfidence;
				}
				set	
				{
					faceConfidence = value;
				}
			}

			public string Age
			{
				get
				{
					return age;
				}
				set	
				{
					age = value;
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

			public string Emotion
			{
				get
				{
					return emotion;
				}
				set	
				{
					emotion = value;
				}
			}

			public float? Attractive
			{
				get
				{
					return attractive;
				}
				set	
				{
					attractive = value;
				}
			}

			public float? GenderConfidence
			{
				get
				{
					return genderConfidence;
				}
				set	
				{
					genderConfidence = value;
				}
			}

			public float? AgeConfidence
			{
				get
				{
					return ageConfidence;
				}
				set	
				{
					ageConfidence = value;
				}
			}

			public float? AttractiveConfidence
			{
				get
				{
					return attractiveConfidence;
				}
				set	
				{
					attractiveConfidence = value;
				}
			}

			public float? EmotionConfidence
			{
				get
				{
					return emotionConfidence;
				}
				set	
				{
					emotionConfidence = value;
				}
			}

			public DetectImageFaces_FaceAttributes FaceAttributes
			{
				get
				{
					return faceAttributes;
				}
				set	
				{
					faceAttributes = value;
				}
			}

			public DetectImageFaces_EmotionDetails EmotionDetails
			{
				get
				{
					return emotionDetails;
				}
				set	
				{
					emotionDetails = value;
				}
			}

			public class DetectImageFaces_FaceAttributes
			{

				private string glasses;

				private string beard;

				private string race;

				private string mask;

				private float? glassesConfidence;

				private float? beardConfidence;

				private float? raceConfidence;

				private float? maskConfidence;

				private DetectImageFaces_FaceBoundary faceBoundary;

				public string Glasses
				{
					get
					{
						return glasses;
					}
					set	
					{
						glasses = value;
					}
				}

				public string Beard
				{
					get
					{
						return beard;
					}
					set	
					{
						beard = value;
					}
				}

				public string Race
				{
					get
					{
						return race;
					}
					set	
					{
						race = value;
					}
				}

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

				public float? GlassesConfidence
				{
					get
					{
						return glassesConfidence;
					}
					set	
					{
						glassesConfidence = value;
					}
				}

				public float? BeardConfidence
				{
					get
					{
						return beardConfidence;
					}
					set	
					{
						beardConfidence = value;
					}
				}

				public float? RaceConfidence
				{
					get
					{
						return raceConfidence;
					}
					set	
					{
						raceConfidence = value;
					}
				}

				public float? MaskConfidence
				{
					get
					{
						return maskConfidence;
					}
					set	
					{
						maskConfidence = value;
					}
				}

				public DetectImageFaces_FaceBoundary FaceBoundary
				{
					get
					{
						return faceBoundary;
					}
					set	
					{
						faceBoundary = value;
					}
				}

				public class DetectImageFaces_FaceBoundary
				{

					private int? left;

					private int? top;

					private int? width;

					private int? height;

					public int? Left
					{
						get
						{
							return left;
						}
						set	
						{
							left = value;
						}
					}

					public int? Top
					{
						get
						{
							return top;
						}
						set	
						{
							top = value;
						}
					}

					public int? Width
					{
						get
						{
							return width;
						}
						set	
						{
							width = value;
						}
					}

					public int? Height
					{
						get
						{
							return height;
						}
						set	
						{
							height = value;
						}
					}
				}
			}

			public class DetectImageFaces_EmotionDetails
			{

				private float? hAPPY;

				private float? sAD;

				private float? aNGRY;

				private float? sURPRISED;

				private float? sCARED;

				private float? dISGUSTED;

				private float? cALM;

				public float? HAPPY
				{
					get
					{
						return hAPPY;
					}
					set	
					{
						hAPPY = value;
					}
				}

				public float? SAD
				{
					get
					{
						return sAD;
					}
					set	
					{
						sAD = value;
					}
				}

				public float? ANGRY
				{
					get
					{
						return aNGRY;
					}
					set	
					{
						aNGRY = value;
					}
				}

				public float? SURPRISED
				{
					get
					{
						return sURPRISED;
					}
					set	
					{
						sURPRISED = value;
					}
				}

				public float? SCARED
				{
					get
					{
						return sCARED;
					}
					set	
					{
						sCARED = value;
					}
				}

				public float? DISGUSTED
				{
					get
					{
						return dISGUSTED;
					}
					set	
					{
						dISGUSTED = value;
					}
				}

				public float? CALM
				{
					get
					{
						return cALM;
					}
					set	
					{
						cALM = value;
					}
				}
			}
		}
	}
}