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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
	public class ListProjectFeatureViewsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private List<ListProjectFeatureViews_FeatureViewsItem> featureViews;

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

		public List<ListProjectFeatureViews_FeatureViewsItem> FeatureViews
		{
			get
			{
				return featureViews;
			}
			set	
			{
				featureViews = value;
			}
		}

		public class ListProjectFeatureViews_FeatureViewsItem
		{

			private string name;

			private string featureViewId;

			private string type;

			private string joinId;

			private string parentJoinId;

			private List<ListProjectFeatureViews_FeaturesItem> features;

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

			public string FeatureViewId
			{
				get
				{
					return featureViewId;
				}
				set	
				{
					featureViewId = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string JoinId
			{
				get
				{
					return joinId;
				}
				set	
				{
					joinId = value;
				}
			}

			public string ParentJoinId
			{
				get
				{
					return parentJoinId;
				}
				set	
				{
					parentJoinId = value;
				}
			}

			public List<ListProjectFeatureViews_FeaturesItem> Features
			{
				get
				{
					return features;
				}
				set	
				{
					features = value;
				}
			}

			public class ListProjectFeatureViews_FeaturesItem
			{

				private string name;

				private string type;

				private List<string> attributes;

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

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public List<string> Attributes
				{
					get
					{
						return attributes;
					}
					set	
					{
						attributes = value;
					}
				}
			}
		}
	}
}
