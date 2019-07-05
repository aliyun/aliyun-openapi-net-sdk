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
	public class DescribeImageLibResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeImageLib_ImageLib> imageLibList;

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

		public List<DescribeImageLib_ImageLib> ImageLibList
		{
			get
			{
				return imageLibList;
			}
			set	
			{
				imageLibList = value;
			}
		}

		public class DescribeImageLib_ImageLib
		{

			private int? imageCount;

			private string modifiedTime;

			private string code;

			private string name;

			private int? id;

			private string source;

			private string category;

			private string serviceModule;

			private string scene;

			private string enable;

			private List<string> bizTypes;

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

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
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

			public int? Id
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

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public string ServiceModule
			{
				get
				{
					return serviceModule;
				}
				set	
				{
					serviceModule = value;
				}
			}

			public string Scene
			{
				get
				{
					return scene;
				}
				set	
				{
					scene = value;
				}
			}

			public string Enable
			{
				get
				{
					return enable;
				}
				set	
				{
					enable = value;
				}
			}

			public List<string> BizTypes
			{
				get
				{
					return bizTypes;
				}
				set	
				{
					bizTypes = value;
				}
			}
		}
	}
}
