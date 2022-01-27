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
	public class GetImageResponse : AcsResponse
	{

		private string modifyTime;

		private string sourceUri;

		private string sourceType;

		private string facesFailReason;

		private string croppingSuggestionStatus;

		private string croppingSuggestionFailReason;

		private string remarksA;

		private string addressFailReason;

		private string remarksB;

		private string addressModifyTime;

		private string imageFormat;

		private string remarksArrayB;

		private string tagsFailReason;

		private string exif;

		private string facesModifyTime;

		private string remarksC;

		private string remarksD;

		private int? imageWidth;

		private string sourcePosition;

		private string remarksArrayA;

		private string addressStatus;

		private string facesStatus;

		private string imageQualityModifyTime;

		private string requestId;

		private string tagsModifyTime;

		private string externalId;

		private string createTime;

		private string imageQualityFailReason;

		private string imageUri;

		private string orientation;

		private string oCRStatus;

		private string oCRModifyTime;

		private string croppingSuggestionModifyTime;

		private string imageTime;

		private string tagsStatus;

		private string imageQualityStatus;

		private int? imageHeight;

		private string oCRFailReason;

		private string setId;

		private string location;

		private int? fileSize;

		private List<GetImage_CroppingSuggestionItem> croppingSuggestion;

		private List<GetImage_FacesItem> faces;

		private List<GetImage_TagsItem> tags;

		private List<GetImage_OCRItem> oCR;

		private GetImage_ImageQuality imageQuality;

		private GetImage_Address address;

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

		public string CroppingSuggestionStatus
		{
			get
			{
				return croppingSuggestionStatus;
			}
			set	
			{
				croppingSuggestionStatus = value;
			}
		}

		public string CroppingSuggestionFailReason
		{
			get
			{
				return croppingSuggestionFailReason;
			}
			set	
			{
				croppingSuggestionFailReason = value;
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

		public string AddressFailReason
		{
			get
			{
				return addressFailReason;
			}
			set	
			{
				addressFailReason = value;
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

		public string AddressModifyTime
		{
			get
			{
				return addressModifyTime;
			}
			set	
			{
				addressModifyTime = value;
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

		public string RemarksArrayB
		{
			get
			{
				return remarksArrayB;
			}
			set	
			{
				remarksArrayB = value;
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

		public string RemarksArrayA
		{
			get
			{
				return remarksArrayA;
			}
			set	
			{
				remarksArrayA = value;
			}
		}

		public string AddressStatus
		{
			get
			{
				return addressStatus;
			}
			set	
			{
				addressStatus = value;
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

		public string ImageQualityModifyTime
		{
			get
			{
				return imageQualityModifyTime;
			}
			set	
			{
				imageQualityModifyTime = value;
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

		public string ImageQualityFailReason
		{
			get
			{
				return imageQualityFailReason;
			}
			set	
			{
				imageQualityFailReason = value;
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

		public string CroppingSuggestionModifyTime
		{
			get
			{
				return croppingSuggestionModifyTime;
			}
			set	
			{
				croppingSuggestionModifyTime = value;
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

		public string ImageQualityStatus
		{
			get
			{
				return imageQualityStatus;
			}
			set	
			{
				imageQualityStatus = value;
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

		public List<GetImage_CroppingSuggestionItem> CroppingSuggestion
		{
			get
			{
				return croppingSuggestion;
			}
			set	
			{
				croppingSuggestion = value;
			}
		}

		public List<GetImage_FacesItem> Faces
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

		public List<GetImage_TagsItem> Tags
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

		public List<GetImage_OCRItem> OCR
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

		public GetImage_ImageQuality ImageQuality
		{
			get
			{
				return imageQuality;
			}
			set	
			{
				imageQuality = value;
			}
		}

		public GetImage_Address Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
			}
		}

		public class GetImage_CroppingSuggestionItem
		{

			private string aspectRatio;

			private float? score;

			private GetImage_CroppingBoundary croppingBoundary;

			public string AspectRatio
			{
				get
				{
					return aspectRatio;
				}
				set	
				{
					aspectRatio = value;
				}
			}

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

			public GetImage_CroppingBoundary CroppingBoundary
			{
				get
				{
					return croppingBoundary;
				}
				set	
				{
					croppingBoundary = value;
				}
			}

			public class GetImage_CroppingBoundary
			{

				private int? left;

				private int? top;

				private int? height;

				private int? width;

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
			}
		}

		public class GetImage_FacesItem
		{

			private float? faceConfidence;

			private string faceId;

			private float? attractive;

			private float? faceQuality;

			private float? genderConfidence;

			private float? emotionConfidence;

			private string emotion;

			private string gender;

			private string age;

			private string groupId;

			private GetImage_EmotionDetails emotionDetails;

			private GetImage_FaceAttributes faceAttributes;

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

			public GetImage_EmotionDetails EmotionDetails
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

			public GetImage_FaceAttributes FaceAttributes
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

			public class GetImage_EmotionDetails
			{

				private float? cALM;

				private float? sCARED;

				private float? hAPPY;

				private float? sAD;

				private float? sURPRISED;

				private float? aNGRY;

				private float? dISGUSTED;

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
			}

			public class GetImage_FaceAttributes
			{

				private string beard;

				private float? beardConfidence;

				private float? maskConfidence;

				private string mask;

				private string glasses;

				private float? glassesConfidence;

				private GetImage_FaceBoundary faceBoundary;

				private GetImage_HeadPose headPose;

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

				public GetImage_FaceBoundary FaceBoundary
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

				public GetImage_HeadPose HeadPose
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

				public class GetImage_FaceBoundary
				{

					private int? left;

					private int? top;

					private int? height;

					private int? width;

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
				}

				public class GetImage_HeadPose
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

		public class GetImage_TagsItem
		{

			private float? tagConfidence;

			private string tagName;

			private int? tagLevel;

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

		public class GetImage_OCRItem
		{

			private float? oCRConfidence;

			private string oCRContents;

			private GetImage_OCRBoundary oCRBoundary;

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

			public GetImage_OCRBoundary OCRBoundary
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

			public class GetImage_OCRBoundary
			{

				private int? left;

				private int? top;

				private int? height;

				private int? width;

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
			}
		}

		public class GetImage_ImageQuality
		{

			private float? clarityScore;

			private float? compositionScore;

			private float? contrastScore;

			private float? color;

			private float? exposure;

			private float? overallScore;

			private float? clarity;

			private float? contrast;

			private float? exposureScore;

			private float? colorScore;

			public float? ClarityScore
			{
				get
				{
					return clarityScore;
				}
				set	
				{
					clarityScore = value;
				}
			}

			public float? CompositionScore
			{
				get
				{
					return compositionScore;
				}
				set	
				{
					compositionScore = value;
				}
			}

			public float? ContrastScore
			{
				get
				{
					return contrastScore;
				}
				set	
				{
					contrastScore = value;
				}
			}

			public float? Color
			{
				get
				{
					return color;
				}
				set	
				{
					color = value;
				}
			}

			public float? Exposure
			{
				get
				{
					return exposure;
				}
				set	
				{
					exposure = value;
				}
			}

			public float? OverallScore
			{
				get
				{
					return overallScore;
				}
				set	
				{
					overallScore = value;
				}
			}

			public float? Clarity
			{
				get
				{
					return clarity;
				}
				set	
				{
					clarity = value;
				}
			}

			public float? Contrast
			{
				get
				{
					return contrast;
				}
				set	
				{
					contrast = value;
				}
			}

			public float? ExposureScore
			{
				get
				{
					return exposureScore;
				}
				set	
				{
					exposureScore = value;
				}
			}

			public float? ColorScore
			{
				get
				{
					return colorScore;
				}
				set	
				{
					colorScore = value;
				}
			}
		}

		public class GetImage_Address
		{

			private string township;

			private string addressLine;

			private string country;

			private string city;

			private string district;

			private string province;

			public string Township
			{
				get
				{
					return township;
				}
				set	
				{
					township = value;
				}
			}

			public string AddressLine
			{
				get
				{
					return addressLine;
				}
				set	
				{
					addressLine = value;
				}
			}

			public string Country
			{
				get
				{
					return country;
				}
				set	
				{
					country = value;
				}
			}

			public string City
			{
				get
				{
					return city;
				}
				set	
				{
					city = value;
				}
			}

			public string District
			{
				get
				{
					return district;
				}
				set	
				{
					district = value;
				}
			}

			public string Province
			{
				get
				{
					return province;
				}
				set	
				{
					province = value;
				}
			}
		}
	}
}
