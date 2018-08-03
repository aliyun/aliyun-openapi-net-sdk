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
	public class GetFaceSetDetailResponse : AcsResponse
	{

		private string requestId;

		private string setId;

		private string nextMarker;

		private List<GetFaceSetDetail_FaceDetailsItem> faceDetails;

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

		public string NextMarker
		{
			get
			{
				return nextMarker;
			}
			set	
			{
				nextMarker = value;
			}
		}

		public List<GetFaceSetDetail_FaceDetailsItem> FaceDetails
		{
			get
			{
				return faceDetails;
			}
			set	
			{
				faceDetails = value;
			}
		}

		public class GetFaceSetDetail_FaceDetailsItem
		{

			private string faceId;

			private string srcUri;

			private string photoId;

			private string groupId;

			private string unGroupReason;

			private GetFaceSetDetail_FaceRectangle faceRectangle;

			private GetFaceSetDetail_FaceAttribute faceAttribute;

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

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string UnGroupReason
			{
				get
				{
					return unGroupReason;
				}
				set	
				{
					unGroupReason = value;
				}
			}

			public GetFaceSetDetail_FaceRectangle FaceRectangle
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

			public GetFaceSetDetail_FaceAttribute FaceAttribute
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

			public class GetFaceSetDetail_FaceRectangle
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

			public class GetFaceSetDetail_FaceAttribute
			{

				private GetFaceSetDetail_Gender gender;

				private GetFaceSetDetail_Age age;

				private GetFaceSetDetail_HeadPose headPose;

				private GetFaceSetDetail_EyeStatus eyeStatus;

				private GetFaceSetDetail_Blur blur;

				private GetFaceSetDetail_FaceQuality faceQuality;

				public GetFaceSetDetail_Gender Gender
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

				public GetFaceSetDetail_Age Age
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

				public GetFaceSetDetail_HeadPose HeadPose
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

				public GetFaceSetDetail_EyeStatus EyeStatus
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

				public GetFaceSetDetail_Blur Blur
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

				public GetFaceSetDetail_FaceQuality FaceQuality
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

				public class GetFaceSetDetail_Gender
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

				public class GetFaceSetDetail_Age
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

				public class GetFaceSetDetail_HeadPose
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

				public class GetFaceSetDetail_EyeStatus
				{

					private GetFaceSetDetail_LeftEyeStatus leftEyeStatus;

					private GetFaceSetDetail_RightEyeStatus rightEyeStatus;

					public GetFaceSetDetail_LeftEyeStatus LeftEyeStatus
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

					public GetFaceSetDetail_RightEyeStatus RightEyeStatus
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

					public class GetFaceSetDetail_LeftEyeStatus
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

					public class GetFaceSetDetail_RightEyeStatus
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

				public class GetFaceSetDetail_Blur
				{

					private GetFaceSetDetail_Blurness blurness;

					public GetFaceSetDetail_Blurness Blurness
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

					public class GetFaceSetDetail_Blurness
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

				public class GetFaceSetDetail_FaceQuality
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
}