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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class ListVideoFramesResponse : AcsResponse
	{

		private string setId;

		private string videoUri;

		private string nextMarker;

		private string requestId;

		private List<ListVideoFrames_FramesItem> frames;

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

		public string VideoUri
		{
			get
			{
				return videoUri;
			}
			set	
			{
				videoUri = value;
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

		public List<ListVideoFrames_FramesItem> Frames
		{
			get
			{
				return frames;
			}
			set	
			{
				frames = value;
			}
		}

		public class ListVideoFrames_FramesItem
		{

			private string facesModifyTime;

			private string oCRModifyTime;

			private string oCRStatus;

			private string sourcePosition;

			private string exif;

			private string imageUri;

			private int? imageWidth;

			private string imageFormat;

			private string sourceType;

			private string modifyTime;

			private int? fileSize;

			private string sourceUri;

			private string createTime;

			private string facesStatus;

			private string remarksA;

			private int? imageHeight;

			private string remarksB;

			private string imageTime;

			private string orientation;

			private string location;

			private string oCRFailReason;

			private string facesFailReason;

			private string tagsFailReason;

			private string tagsModifyTime;

			private string tagsStatus;

			private string remarksC;

			private string remarksD;

			private string externalId;

			private List<ListVideoFrames_FacesItem> faces;

			private List<ListVideoFrames_TagsItem> tags;

			private List<ListVideoFrames_OCRItem> oCR;

			public string FacesModifyTime
			{
				get
				{
					return facesModifyTime;
				}
				set	
				{
					facesModifyTime = value;
				}
			}

			public string OCRModifyTime
			{
				get
				{
					return oCRModifyTime;
				}
				set	
				{
					oCRModifyTime = value;
				}
			}

			public string OCRStatus
			{
				get
				{
					return oCRStatus;
				}
				set	
				{
					oCRStatus = value;
				}
			}

			public string SourcePosition
			{
				get
				{
					return sourcePosition;
				}
				set	
				{
					sourcePosition = value;
				}
			}

			public string Exif
			{
				get
				{
					return exif;
				}
				set	
				{
					exif = value;
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

			public int? ImageWidth
			{
				get
				{
					return imageWidth;
				}
				set	
				{
					imageWidth = value;
				}
			}

			public string ImageFormat
			{
				get
				{
					return imageFormat;
				}
				set	
				{
					imageFormat = value;
				}
			}

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public int? FileSize
			{
				get
				{
					return fileSize;
				}
				set	
				{
					fileSize = value;
				}
			}

			public string SourceUri
			{
				get
				{
					return sourceUri;
				}
				set	
				{
					sourceUri = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string FacesStatus
			{
				get
				{
					return facesStatus;
				}
				set	
				{
					facesStatus = value;
				}
			}

			public string RemarksA
			{
				get
				{
					return remarksA;
				}
				set	
				{
					remarksA = value;
				}
			}

			public int? ImageHeight
			{
				get
				{
					return imageHeight;
				}
				set	
				{
					imageHeight = value;
				}
			}

			public string RemarksB
			{
				get
				{
					return remarksB;
				}
				set	
				{
					remarksB = value;
				}
			}

			public string ImageTime
			{
				get
				{
					return imageTime;
				}
				set	
				{
					imageTime = value;
				}
			}

			public string Orientation
			{
				get
				{
					return orientation;
				}
				set	
				{
					orientation = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string OCRFailReason
			{
				get
				{
					return oCRFailReason;
				}
				set	
				{
					oCRFailReason = value;
				}
			}

			public string FacesFailReason
			{
				get
				{
					return facesFailReason;
				}
				set	
				{
					facesFailReason = value;
				}
			}

			public string TagsFailReason
			{
				get
				{
					return tagsFailReason;
				}
				set	
				{
					tagsFailReason = value;
				}
			}

			public string TagsModifyTime
			{
				get
				{
					return tagsModifyTime;
				}
				set	
				{
					tagsModifyTime = value;
				}
			}

			public string TagsStatus
			{
				get
				{
					return tagsStatus;
				}
				set	
				{
					tagsStatus = value;
				}
			}

			public string RemarksC
			{
				get
				{
					return remarksC;
				}
				set	
				{
					remarksC = value;
				}
			}

			public string RemarksD
			{
				get
				{
					return remarksD;
				}
				set	
				{
					remarksD = value;
				}
			}

			public string ExternalId
			{
				get
				{
					return externalId;
				}
				set	
				{
					externalId = value;
				}
			}

			public List<ListVideoFrames_FacesItem> Faces
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

			public List<ListVideoFrames_TagsItem> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<ListVideoFrames_OCRItem> OCR
			{
				get
				{
					return oCR;
				}
				set	
				{
					oCR = value;
				}
			}

			public class ListVideoFrames_FacesItem
			{

				private int? age;

				private float? genderConfidence;

				private float? attractive;

				private string gender;

				private float? faceConfidence;

				private string emotion;

				private string faceId;

				private float? emotionConfidence;

				private string groupId;

				private float? faceQuality;

				private ListVideoFrames_EmotionDetails emotionDetails;

				private ListVideoFrames_FaceAttributes faceAttributes;

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

				public float? FaceQuality
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

				public ListVideoFrames_EmotionDetails EmotionDetails
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

				public ListVideoFrames_FaceAttributes FaceAttributes
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

				public class ListVideoFrames_EmotionDetails
				{

					private float? sAD;

					private float? cALM;

					private float? aNGRY;

					private float? hAPPY;

					private float? sCARED;

					private float? dISGUSTED;

					private float? sURPRISED;

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
				}

				public class ListVideoFrames_FaceAttributes
				{

					private float? glassesConfidence;

					private string glasses;

					private string beard;

					private float? maskConfidence;

					private float? beardConfidence;

					private string mask;

					private ListVideoFrames_FaceBoundary faceBoundary;

					private ListVideoFrames_HeadPose headPose;

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

					public ListVideoFrames_FaceBoundary FaceBoundary
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

					public ListVideoFrames_HeadPose HeadPose
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

					public class ListVideoFrames_FaceBoundary
					{

						private int? top;

						private int? height;

						private int? width;

						private int? left;

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
					}

					public class ListVideoFrames_HeadPose
					{

						private float? pitch;

						private float? roll;

						private float? yaw;

						public float? Pitch
						{
							get
							{
								return pitch;
							}
							set	
							{
								pitch = value;
							}
						}

						public float? Roll
						{
							get
							{
								return roll;
							}
							set	
							{
								roll = value;
							}
						}

						public float? Yaw
						{
							get
							{
								return yaw;
							}
							set	
							{
								yaw = value;
							}
						}
					}
				}
			}

			public class ListVideoFrames_TagsItem
			{

				private float? tagConfidence;

				private int? tagLevel;

				private string tagName;

				private string parentTagName;

				public float? TagConfidence
				{
					get
					{
						return tagConfidence;
					}
					set	
					{
						tagConfidence = value;
					}
				}

				public int? TagLevel
				{
					get
					{
						return tagLevel;
					}
					set	
					{
						tagLevel = value;
					}
				}

				public string TagName
				{
					get
					{
						return tagName;
					}
					set	
					{
						tagName = value;
					}
				}

				public string ParentTagName
				{
					get
					{
						return parentTagName;
					}
					set	
					{
						parentTagName = value;
					}
				}
			}

			public class ListVideoFrames_OCRItem
			{

				private string oCRContents;

				private float? oCRConfidence;

				private ListVideoFrames_OCRBoundary oCRBoundary;

				public string OCRContents
				{
					get
					{
						return oCRContents;
					}
					set	
					{
						oCRContents = value;
					}
				}

				public float? OCRConfidence
				{
					get
					{
						return oCRConfidence;
					}
					set	
					{
						oCRConfidence = value;
					}
				}

				public ListVideoFrames_OCRBoundary OCRBoundary
				{
					get
					{
						return oCRBoundary;
					}
					set	
					{
						oCRBoundary = value;
					}
				}

				public class ListVideoFrames_OCRBoundary
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
		}
	}
}
