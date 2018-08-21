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
	public class IndexFaceResponse : AcsResponse
	{

		private string requestId;

		private string setId;

		private List<IndexFace_SuccessDetailsItem> successDetails;

		private List<IndexFace_FailDetailsItem> failDetails;

		private List<string> srcUris;

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

		public string SetId
		{
			get
			{
				return setId;
			}
			set	
			{
				setId = value;
			}
		}

		public List<IndexFace_SuccessDetailsItem> SuccessDetails
		{
			get
			{
				return successDetails;
			}
			set	
			{
				successDetails = value;
			}
		}

		public List<IndexFace_FailDetailsItem> FailDetails
		{
			get
			{
				return failDetails;
			}
			set	
			{
				failDetails = value;
			}
		}

		public List<string> SrcUris
		{
			get
			{
				return srcUris;
			}
			set	
			{
				srcUris = value;
			}
		}

		public class IndexFace_SuccessDetailsItem
		{

			private string srcUri;

			private string photoId;

			private List<IndexFace_FacesItem> faces;

			public string SrcUri
			{
				get
				{
					return srcUri;
				}
				set	
				{
					srcUri = value;
				}
			}

			public string PhotoId
			{
				get
				{
					return photoId;
				}
				set	
				{
					photoId = value;
				}
			}

			public List<IndexFace_FacesItem> Faces
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

			public class IndexFace_FacesItem
			{

				private string faceId;

				private IndexFace_FaceRectangle faceRectangle;

				private IndexFace_FaceAttribute faceAttribute;

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

				public IndexFace_FaceRectangle FaceRectangle
				{
					get
					{
						return faceRectangle;
					}
					set	
					{
						faceRectangle = value;
					}
				}

				public IndexFace_FaceAttribute FaceAttribute
				{
					get
					{
						return faceAttribute;
					}
					set	
					{
						faceAttribute = value;
					}
				}

				public class IndexFace_FaceRectangle
				{

					private string top;

					private string left;

					private string width;

					private string height;

					public string Top
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

					public string Left
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

					public string Width
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

					public string Height
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

				public class IndexFace_FaceAttribute
				{

					private IndexFace_Gender gender;

					private IndexFace_Age age;

					private IndexFace_HeadPose headPose;

					private IndexFace_EyeStatus eyeStatus;

					private IndexFace_Blur blur;

					private IndexFace_FaceQuality faceQuality;

					public IndexFace_Gender Gender
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

					public IndexFace_Age Age
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

					public IndexFace_HeadPose HeadPose
					{
						get
						{
							return headPose;
						}
						set	
						{
							headPose = value;
						}
					}

					public IndexFace_EyeStatus EyeStatus
					{
						get
						{
							return eyeStatus;
						}
						set	
						{
							eyeStatus = value;
						}
					}

					public IndexFace_Blur Blur
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

					public IndexFace_FaceQuality FaceQuality
					{
						get
						{
							return faceQuality;
						}
						set	
						{
							faceQuality = value;
						}
					}

					public class IndexFace_Gender
					{

						private string _value;

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

					public class IndexFace_Age
					{

						private int? _value;

						public int? _Value
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

					public class IndexFace_HeadPose
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

					public class IndexFace_EyeStatus
					{

						private IndexFace_LeftEyeStatus leftEyeStatus;

						private IndexFace_RightEyeStatus rightEyeStatus;

						public IndexFace_LeftEyeStatus LeftEyeStatus
						{
							get
							{
								return leftEyeStatus;
							}
							set	
							{
								leftEyeStatus = value;
							}
						}

						public IndexFace_RightEyeStatus RightEyeStatus
						{
							get
							{
								return rightEyeStatus;
							}
							set	
							{
								rightEyeStatus = value;
							}
						}

						public class IndexFace_LeftEyeStatus
						{

							private float? normalGlassEyeOpen;

							private float? noGlassEyeClose;

							private float? occlusion;

							private float? noGlassEyeOpen;

							private float? normalGlassEyeClose;

							private float? darkGlasses;

							public float? NormalGlassEyeOpen
							{
								get
								{
									return normalGlassEyeOpen;
								}
								set	
								{
									normalGlassEyeOpen = value;
								}
							}

							public float? NoGlassEyeClose
							{
								get
								{
									return noGlassEyeClose;
								}
								set	
								{
									noGlassEyeClose = value;
								}
							}

							public float? Occlusion
							{
								get
								{
									return occlusion;
								}
								set	
								{
									occlusion = value;
								}
							}

							public float? NoGlassEyeOpen
							{
								get
								{
									return noGlassEyeOpen;
								}
								set	
								{
									noGlassEyeOpen = value;
								}
							}

							public float? NormalGlassEyeClose
							{
								get
								{
									return normalGlassEyeClose;
								}
								set	
								{
									normalGlassEyeClose = value;
								}
							}

							public float? DarkGlasses
							{
								get
								{
									return darkGlasses;
								}
								set	
								{
									darkGlasses = value;
								}
							}
						}

						public class IndexFace_RightEyeStatus
						{

							private float? normalGlassEyeOpen;

							private float? noGlassEyeClose;

							private float? occlusion;

							private float? noGlassEyeOpen;

							private float? normalGlassEyeClose;

							private float? darkGlasses;

							public float? NormalGlassEyeOpen
							{
								get
								{
									return normalGlassEyeOpen;
								}
								set	
								{
									normalGlassEyeOpen = value;
								}
							}

							public float? NoGlassEyeClose
							{
								get
								{
									return noGlassEyeClose;
								}
								set	
								{
									noGlassEyeClose = value;
								}
							}

							public float? Occlusion
							{
								get
								{
									return occlusion;
								}
								set	
								{
									occlusion = value;
								}
							}

							public float? NoGlassEyeOpen
							{
								get
								{
									return noGlassEyeOpen;
								}
								set	
								{
									noGlassEyeOpen = value;
								}
							}

							public float? NormalGlassEyeClose
							{
								get
								{
									return normalGlassEyeClose;
								}
								set	
								{
									normalGlassEyeClose = value;
								}
							}

							public float? DarkGlasses
							{
								get
								{
									return darkGlasses;
								}
								set	
								{
									darkGlasses = value;
								}
							}
						}
					}

					public class IndexFace_Blur
					{

						private IndexFace_Blurness blurness;

						public IndexFace_Blurness Blurness
						{
							get
							{
								return blurness;
							}
							set	
							{
								blurness = value;
							}
						}

						public class IndexFace_Blurness
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
					}

					public class IndexFace_FaceQuality
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
				}
			}
		}

		public class IndexFace_FailDetailsItem
		{

			private string srcUri;

			private string reason;

			public string SrcUri
			{
				get
				{
					return srcUri;
				}
				set	
				{
					srcUri = value;
				}
			}

			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}
		}
	}
}