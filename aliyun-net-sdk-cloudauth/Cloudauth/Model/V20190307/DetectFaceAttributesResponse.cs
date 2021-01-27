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

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
	public class DetectFaceAttributesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private DetectFaceAttributes_Data data;

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

		public DetectFaceAttributes_Data Data
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

		public class DetectFaceAttributes_Data
		{

			private int? imgWidth;

			private int? imgHeight;

			private List<DetectFaceAttributes_FaceAttributesDetectInfo> faceInfos;

			public int? ImgWidth
			{
				get
				{
					return imgWidth;
				}
				set	
				{
					imgWidth = value;
				}
			}

			public int? ImgHeight
			{
				get
				{
					return imgHeight;
				}
				set	
				{
					imgHeight = value;
				}
			}

			public List<DetectFaceAttributes_FaceAttributesDetectInfo> FaceInfos
			{
				get
				{
					return faceInfos;
				}
				set	
				{
					faceInfos = value;
				}
			}

			public class DetectFaceAttributes_FaceAttributesDetectInfo
			{

				private DetectFaceAttributes_FaceRect faceRect;

				private DetectFaceAttributes_FaceAttributes faceAttributes;

				public DetectFaceAttributes_FaceRect FaceRect
				{
					get
					{
						return faceRect;
					}
					set	
					{
						faceRect = value;
					}
				}

				public DetectFaceAttributes_FaceAttributes FaceAttributes
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

				public class DetectFaceAttributes_FaceRect
				{

					private int? top;

					private int? left;

					private int? width;

					private int? height;

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

				public class DetectFaceAttributes_FaceAttributes
				{

					private int? age;

					private string glasses;

					private string facetype;

					private float? blur;

					private float? facequal;

					private int? integrity;

					private string respirator;

					private float? appearanceScore;

					private DetectFaceAttributes_Gender gender;

					private DetectFaceAttributes_Smiling smiling;

					private DetectFaceAttributes_Headpose headpose;

					public int? Age
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

					public string Facetype
					{
						get
						{
							return facetype;
						}
						set	
						{
							facetype = value;
						}
					}

					public float? Blur
					{
						get
						{
							return blur;
						}
						set	
						{
							blur = value;
						}
					}

					public float? Facequal
					{
						get
						{
							return facequal;
						}
						set	
						{
							facequal = value;
						}
					}

					public int? Integrity
					{
						get
						{
							return integrity;
						}
						set	
						{
							integrity = value;
						}
					}

					public string Respirator
					{
						get
						{
							return respirator;
						}
						set	
						{
							respirator = value;
						}
					}

					public float? AppearanceScore
					{
						get
						{
							return appearanceScore;
						}
						set	
						{
							appearanceScore = value;
						}
					}

					public DetectFaceAttributes_Gender Gender
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

					public DetectFaceAttributes_Smiling Smiling
					{
						get
						{
							return smiling;
						}
						set	
						{
							smiling = value;
						}
					}

					public DetectFaceAttributes_Headpose Headpose
					{
						get
						{
							return headpose;
						}
						set	
						{
							headpose = value;
						}
					}

					public class DetectFaceAttributes_Gender
					{

						private float? score;

						private string _value;

						public float? Score
						{
							get
							{
								return score;
							}
							set	
							{
								score = value;
							}
						}

						public string _Value
						{
							get
							{
								return _value;
							}
							set	
							{
								_value = value;
							}
						}
					}

					public class DetectFaceAttributes_Smiling
					{

						private float? _value;

						private float? threshold;

						public float? _Value
						{
							get
							{
								return _value;
							}
							set	
							{
								_value = value;
							}
						}

						public float? Threshold
						{
							get
							{
								return threshold;
							}
							set	
							{
								threshold = value;
							}
						}
					}

					public class DetectFaceAttributes_Headpose
					{

						private float? pitchAngle;

						private float? rollAngle;

						private float? yawAngle;

						public float? PitchAngle
						{
							get
							{
								return pitchAngle;
							}
							set	
							{
								pitchAngle = value;
							}
						}

						public float? RollAngle
						{
							get
							{
								return rollAngle;
							}
							set	
							{
								rollAngle = value;
							}
						}

						public float? YawAngle
						{
							get
							{
								return yawAngle;
							}
							set	
							{
								yawAngle = value;
							}
						}
					}
				}
			}
		}
	}
}
