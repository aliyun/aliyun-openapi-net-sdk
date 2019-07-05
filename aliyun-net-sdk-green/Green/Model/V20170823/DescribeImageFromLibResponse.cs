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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeImageFromLibResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeImageFromLib_ImageFromLib> imageFromLibList;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

		public int? TotalCount
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

		public List<DescribeImageFromLib_ImageFromLib> ImageFromLibList
		{
			get
			{
				return imageFromLibList;
			}
			set	
			{
				imageFromLibList = value;
			}
		}

		public class DescribeImageFromLib_ImageFromLib
		{

			private string image;

			private string thumbnail;

			private long? id;

			private long? imageHitCount;

			private long? videoHitCount;

			private string createTime;

			public string Image
			{
				get
				{
					return image;
				}
				set	
				{
					image = value;
				}
			}

			public string Thumbnail
			{
				get
				{
					return thumbnail;
				}
				set	
				{
					thumbnail = value;
				}
			}

			public long? Id
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

			public long? ImageHitCount
			{
				get
				{
					return imageHitCount;
				}
				set	
				{
					imageHitCount = value;
				}
			}

			public long? VideoHitCount
			{
				get
				{
					return videoHitCount;
				}
				set	
				{
					videoHitCount = value;
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
		}
	}
}
