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
	public class ListVideosResponse : AcsResponse
	{

		private string setId;

		private string nextMarker;

		private string requestId;

		private List<ListVideos_VideosItem> videos;

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

		public List<ListVideos_VideosItem> Videos
		{
			get
			{
				return videos;
			}
			set	
			{
				videos = value;
			}
		}

		public class ListVideos_VideosItem
		{

			private string videoUri;

			private string remarksA;

			private string remarksB;

			private string createTime;

			private string modifyTime;

			private int? videoWidth;

			private int? videoHeight;

			private string videoFormat;

			private float? videoDuration;

			private int? fileSize;

			private int? videoFrames;

			private string sourceType;

			private string sourceUri;

			private string sourcePosition;

			private string processStatus;

			private string processModifyTime;

			private string videoTagsStatus;

			private string videoTagsModifyTime;

			private string celebrityStatus;

			private string celebrityModifyTime;

			private string celebrityFailReason;

			private string videoTagsFailReason;

			private string processFailReason;

			private string remarksC;

			private string remarksD;

			private string externalId;

			private List<ListVideos_VideoTagsItem> videoTags;

			private List<ListVideos_CelebrityItem> celebrity;

			private List<ListVideos_PersonsItem> persons;

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

			public int? VideoWidth
			{
				get
				{
					return videoWidth;
				}
				set	
				{
					videoWidth = value;
				}
			}

			public int? VideoHeight
			{
				get
				{
					return videoHeight;
				}
				set	
				{
					videoHeight = value;
				}
			}

			public string VideoFormat
			{
				get
				{
					return videoFormat;
				}
				set	
				{
					videoFormat = value;
				}
			}

			public float? VideoDuration
			{
				get
				{
					return videoDuration;
				}
				set	
				{
					videoDuration = value;
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

			public int? VideoFrames
			{
				get
				{
					return videoFrames;
				}
				set	
				{
					videoFrames = value;
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

			public string ProcessStatus
			{
				get
				{
					return processStatus;
				}
				set	
				{
					processStatus = value;
				}
			}

			public string ProcessModifyTime
			{
				get
				{
					return processModifyTime;
				}
				set	
				{
					processModifyTime = value;
				}
			}

			public string VideoTagsStatus
			{
				get
				{
					return videoTagsStatus;
				}
				set	
				{
					videoTagsStatus = value;
				}
			}

			public string VideoTagsModifyTime
			{
				get
				{
					return videoTagsModifyTime;
				}
				set	
				{
					videoTagsModifyTime = value;
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

			public string VideoTagsFailReason
			{
				get
				{
					return videoTagsFailReason;
				}
				set	
				{
					videoTagsFailReason = value;
				}
			}

			public string ProcessFailReason
			{
				get
				{
					return processFailReason;
				}
				set	
				{
					processFailReason = value;
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

			public List<ListVideos_VideoTagsItem> VideoTags
			{
				get
				{
					return videoTags;
				}
				set	
				{
					videoTags = value;
				}
			}

			public List<ListVideos_CelebrityItem> Celebrity
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

			public List<ListVideos_PersonsItem> Persons
			{
				get
				{
					return persons;
				}
				set	
				{
					persons = value;
				}
			}

			public class ListVideos_VideoTagsItem
			{

				private string tagName;

				private string parentTagName;

				private float? tagConfidence;

				private int? tagLevel;

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
			}

			public class ListVideos_CelebrityItem
			{

				private string celebrityName;

				private int? celebrityNum;

				private string celebrityLibraryName;

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

				public int? CelebrityNum
				{
					get
					{
						return celebrityNum;
					}
					set	
					{
						celebrityNum = value;
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
			}

			public class ListVideos_PersonsItem
			{

				private string personId;

				private int? age;

				private float? ageConfidence;

				private string gender;

				private float? genderConfidence;

				public string PersonId
				{
					get
					{
						return personId;
					}
					set	
					{
						personId = value;
					}
				}

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
			}
		}
	}
}
