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
	public class ListFaceGroupsResponse : AcsResponse
	{

		private string requestId;

		private string nextMarker;

		private List<ListFaceGroups_FaceGroupsItem> faceGroups;

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

		public List<ListFaceGroups_FaceGroupsItem> FaceGroups
		{
			get
			{
				return faceGroups;
			}
			set	
			{
				faceGroups = value;
			}
		}

		public class ListFaceGroups_FaceGroupsItem
		{

			private string groupName;

			private string modifyTime;

			private string externalId;

			private string createTime;

			private float? maxAge;

			private string gender;

			private float? averageAge;

			private string remarksA;

			private string remarksB;

			private string groupId;

			private string remarksArrayB;

			private int? imageCount;

			private float? minAge;

			private string remarksC;

			private string remarksD;

			private string remarksArrayA;

			private int? faceCount;

			private ListFaceGroups_GroupCoverFace groupCoverFace;

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
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

			public float? MaxAge
			{
				get
				{
					return maxAge;
				}
				set	
				{
					maxAge = value;
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

			public float? AverageAge
			{
				get
				{
					return averageAge;
				}
				set	
				{
					averageAge = value;
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

			public int? ImageCount
			{
				get
				{
					return imageCount;
				}
				set	
				{
					imageCount = value;
				}
			}

			public float? MinAge
			{
				get
				{
					return minAge;
				}
				set	
				{
					minAge = value;
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

			public int? FaceCount
			{
				get
				{
					return faceCount;
				}
				set	
				{
					faceCount = value;
				}
			}

			public ListFaceGroups_GroupCoverFace GroupCoverFace
			{
				get
				{
					return groupCoverFace;
				}
				set	
				{
					groupCoverFace = value;
				}
			}

			public class ListFaceGroups_GroupCoverFace
			{

				private string faceId;

				private long? imageHeight;

				private long? imageWidth;

				private string externalId;

				private string imageUri;

				private ListFaceGroups_FaceBoundary faceBoundary;

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

				public long? ImageHeight
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

				public long? ImageWidth
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

				public ListFaceGroups_FaceBoundary FaceBoundary
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

				public class ListFaceGroups_FaceBoundary
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
		}
	}
}
