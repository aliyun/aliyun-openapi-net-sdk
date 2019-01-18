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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.lubancloud.Model.V20180509
{
	public class GetStylesResponse : AcsResponse
	{

		private string requestId;

		private List<GetStyles_Style> styles;

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

		public List<GetStyles_Style> Styles
		{
			get
			{
				return styles;
			}
			set	
			{
				styles = value;
			}
		}

		public class GetStyles_Style
		{

			private long? id;

			private string name;

			private long? parentId;

			private string previewUrl;

			private List<GetStyles_SubStyle> subStyles;

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

			public long? ParentId
			{
				get
				{
					return parentId;
				}
				set	
				{
					parentId = value;
				}
			}

			public string PreviewUrl
			{
				get
				{
					return previewUrl;
				}
				set	
				{
					previewUrl = value;
				}
			}

			public List<GetStyles_SubStyle> SubStyles
			{
				get
				{
					return subStyles;
				}
				set	
				{
					subStyles = value;
				}
			}

			public class GetStyles_SubStyle
			{

				private long? id;

				private string name;

				private long? parentId;

				private string previewUrl;

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

				public long? ParentId
				{
					get
					{
						return parentId;
					}
					set	
					{
						parentId = value;
					}
				}

				public string PreviewUrl
				{
					get
					{
						return previewUrl;
					}
					set	
					{
						previewUrl = value;
					}
				}
			}
		}
	}
}