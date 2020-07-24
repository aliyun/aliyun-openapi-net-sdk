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

			private string groupId;

			private string groupName;

			private int? faceCount;

			private string createTime;

			private string modifyTime;

			private string remarksA;

			private string remarksB;

			private string remarksC;

			private string remarksD;

			private string remarksArrayA;

			private string remarksArrayB;

			private string externalId;

			private int? imageCount;

			private ListFaceGroups_GroupCoverFace groupCoverFace;

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
