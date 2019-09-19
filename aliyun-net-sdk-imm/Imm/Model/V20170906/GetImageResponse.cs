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

		private string requestId;

		private string setId;

		private string imageUri;

		private string remarksA;

		private string remarksB;

		private string createTime;

		private string modifyTime;

		private int? imageWidth;

		private int? imageHeight;

		private string imageFormat;

		private string exif;

		private int? fileSize;

		private string imageTime;

		private string orientation;

		private string sourceType;

		private string sourceUri;

		private string sourcePosition;

		private string facesStatus;

		private string facesModifyTime;

		private string location;

		private string oCRStatus;

		private string oCRModifyTime;

		private string oCRFailReason;

		private string facesFailReason;

		private string tagsFailReason;

		private string tagsModifyTime;

		private string celebrityStatus;

		private string celebrityModifyTime;

		private string celebrityFailReason;

		private string tagsStatus;

		private string remarksC;

		private string remarksD;

		private string externalId;

		private string addressModifyTime;

		private string addressStatus;

		private string addressFailReason;

		private List<GetImage_FacesItem> faces;

		private List<GetImage_OCRItem> oCR;

		private List<GetImage_TagsItem> tags;

		private List<GetImage_CelebrityItem> celebrity;

		private GetImage_Address address;

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

		public string CelebrityStatus
		{
			get
			{
				return celebrityStatus;
			}
			set	
			{
				celebrityStatus = value;
			}
		}

		public string CelebrityModifyTime
		{
			get
			{
				return celebrityModifyTime;
			}
			set	
			{
				celebrityModifyTime = value;
			}
		}

		public string CelebrityFailReason
		{
			get
			{
				return celebrityFailReason;
			}
			set	
			{
				celebrityFailReason = value;
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

		public List<GetImage_CelebrityItem> Celebrity
		{
			get
			{
				return celebrity;
			}
			set	
			{
				celebrity = value;
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

		public class GetImage_FacesItem
		{

			private string faceId;

			private float? faceConfidence;

			private string age;

			private string gender;

			private string emotion;

			private float? attractive;

			private float? genderConfidence;

			private string groupId;

			private float? faceQuality;

			private GetImage_FaceAttributes faceAttributes;

			private GetImage_EmotionDetails emotionDetails;

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

			public class GetImage_FaceAttributes
			{

				private string glasses;

				private string beard;

				private string race;

				private string mask;

				private float? glassesConfidence;

				private float? beardConfidence;

				private float? raceConfidence;

				private float? maskConfidence;

				private GetImage_FaceBoundary faceBoundary;

				private GetImage_HeadPose headPose;

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

			public class GetImage_EmotionDetails
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

		public class GetImage_OCRItem
		{

			private string oCRContents;

			private float? oCRConfidence;

			private GetImage_OCRBoundary oCRBoundary;

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

		public class GetImage_TagsItem
		{

			private string tagName;

			private float? tagConfidence;

			private int? tagLevel;

			private string parentTagName;

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

		public class GetImage_CelebrityItem
		{

			private string celebrityName;

			private string celebrityGender;

			private float? celebrityConfidence;

			private string celebrityLibraryName;

			private GetImage_CelebrityBoundary celebrityBoundary;

			public string CelebrityName
			{
				get
				{
					return celebrityName;
				}
				set	
				{
					celebrityName = value;
				}
			}

			public string CelebrityGender
			{
				get
				{
					return celebrityGender;
				}
				set	
				{
					celebrityGender = value;
				}
			}

			public float? CelebrityConfidence
			{
				get
				{
					return celebrityConfidence;
				}
				set	
				{
					celebrityConfidence = value;
				}
			}

			public string CelebrityLibraryName
			{
				get
				{
					return celebrityLibraryName;
				}
				set	
				{
					celebrityLibraryName = value;
				}
			}

			public GetImage_CelebrityBoundary CelebrityBoundary
			{
				get
				{
					return celebrityBoundary;
				}
				set	
				{
					celebrityBoundary = value;
				}
			}

			public class GetImage_CelebrityBoundary
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

		public class GetImage_Address
		{

			private string addressLine;

			private string country;

			private string province;

			private string city;

			private string district;

			private string township;

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
		}
	}
}
