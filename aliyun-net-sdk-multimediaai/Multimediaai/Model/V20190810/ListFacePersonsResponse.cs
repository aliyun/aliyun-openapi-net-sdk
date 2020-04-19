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
	public class ListFacePersonsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private long? totalCount;

		private List<ListFacePersons_FacePerson> facePersons;

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

		public List<ListFacePersons_FacePerson> FacePersons
		{
			get
			{
				return facePersons;
			}
			set	
			{
				facePersons = value;
			}
		}

		public class ListFacePersons_FacePerson
		{

			private long? facePersonId;

			private string facePersonName;

			private string imageUrl;

			private long? imageCount;

			public long? FacePersonId
			{
				get
				{
					return facePersonId;
				}
				set	
				{
					facePersonId = value;
				}
			}

			public string FacePersonName
			{
				get
				{
					return facePersonName;
				}
				set	
				{
					facePersonName = value;
				}
			}

			public string ImageUrl
			{
				get
				{
					return imageUrl;
				}
				set	
				{
					imageUrl = value;
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
		}
	}
}
