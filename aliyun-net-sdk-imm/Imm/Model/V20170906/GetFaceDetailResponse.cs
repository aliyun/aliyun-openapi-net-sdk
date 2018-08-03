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
	public class GetFaceDetailResponse : AcsResponse
	{

		private string setId;

		private string faceId;

		private string photoId;

		private string photoUrl;

		private string groupId;

		private string requestId;

		private GetFaceDetail_FaceRectangle faceRectangle;

		private GetFaceDetail_FaceAttribute faceAttribute;

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

		public string PhotoUrl
		{
			get
			{
				return photoUrl;
			}
			set	
			{
				photoUrl = value;
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

		public GetFaceDetail_FaceRectangle FaceRectangle
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

		public GetFaceDetail_FaceAttribute FaceAttribute
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

		public class GetFaceDetail_FaceRectangle
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

		public class GetFaceDetail_FaceAttribute
		{

			private GetFaceDetail_Gender gender;

			private GetFaceDetail_Age age;

			private GetFaceDetail_HeadPose headPose;

			private GetFaceDetail_EyeStatus eyeStatus;

			private GetFaceDetail_Blur blur;

			private GetFaceDetail_FaceQuality faceQuality;

			public GetFaceDetail_Gender Gender
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

			public GetFaceDetail_Age Age
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

			public GetFaceDetail_HeadPose HeadPose
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

			public GetFaceDetail_EyeStatus EyeStatus
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

			public GetFaceDetail_Blur Blur
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

			public GetFaceDetail_FaceQuality FaceQuality
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

			public class GetFaceDetail_Gender
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

			public class GetFaceDetail_Age
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

			public class GetFaceDetail_HeadPose
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

			public class GetFaceDetail_EyeStatus
			{

				private GetFaceDetail_LeftEyeStatus leftEyeStatus;

				private GetFaceDetail_RightEyeStatus rightEyeStatus;

				public GetFaceDetail_LeftEyeStatus LeftEyeStatus
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

				public GetFaceDetail_RightEyeStatus RightEyeStatus
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

				public class GetFaceDetail_LeftEyeStatus
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

				public class GetFaceDetail_RightEyeStatus
				{

					private float? normalGlassEyeOpen;

					private float? noGlassEyeClose;

					private float? normalGlassEyeClose;

					private float? occlusion;

					private float? noGlassEyeOpen;

					private float? normalGlassEyeClose1;

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

					public float? NormalGlassEyeClose1
					{
						get
						{
							return normalGlassEyeClose1;
						}
						set	
						{
							normalGlassEyeClose1 = value;
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

			public class GetFaceDetail_Blur
			{

				private GetFaceDetail_Blurness blurness;

				public GetFaceDetail_Blurness Blurness
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

				public class GetFaceDetail_Blurness
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

			public class GetFaceDetail_FaceQuality
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