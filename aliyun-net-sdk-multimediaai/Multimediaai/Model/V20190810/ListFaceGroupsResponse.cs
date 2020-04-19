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

namespace Aliyun.Acs.multimediaai.Model.V20190810
{
	public class ListFaceGroupsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private long? totalCount;

		private List<ListFaceGroups_FaceGroup> faceGroups;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<ListFaceGroups_FaceGroup> FaceGroups
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

		public class ListFaceGroups_FaceGroup
		{

			private long? faceGroupId;

			private string faceGroupName;

			private string description;

			private long? personCount;

			private long? imageCount;

			private List<ListFaceGroups_TemplatesItem> templates;

			public long? FaceGroupId
			{
				get
				{
					return faceGroupId;
				}
				set	
				{
					faceGroupId = value;
				}
			}

			public string FaceGroupName
			{
				get
				{
					return faceGroupName;
				}
				set	
				{
					faceGroupName = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public long? PersonCount
			{
				get
				{
					return personCount;
				}
				set	
				{
					personCount = value;
				}
			}

			public long? ImageCount
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

			public List<ListFaceGroups_TemplatesItem> Templates
			{
				get
				{
					return templates;
				}
				set	
				{
					templates = value;
				}
			}

			public class ListFaceGroups_TemplatesItem
			{

				private string id;

				private string name;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}
			}
		}
	}
}
