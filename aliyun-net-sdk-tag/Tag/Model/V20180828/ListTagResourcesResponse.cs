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

namespace Aliyun.Acs.Tag.Model.V20180828
{
	public class ListTagResourcesResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<ListTagResources_TagResource> tagResources;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<ListTagResources_TagResource> TagResources
		{
			get
			{
				return tagResources;
			}
			set	
			{
				tagResources = value;
			}
		}

		public class ListTagResources_TagResource
		{

			private string resourceARN;

			private List<ListTagResources_Tag> tags;

			public string ResourceARN
			{
				get
				{
					return resourceARN;
				}
				set	
				{
					resourceARN = value;
				}
			}

			public List<ListTagResources_Tag> Tags
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

			public class ListTagResources_Tag
			{

				private string key;

				private string _value;

				private string category;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
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
			}
		}
	}
}
