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
	public class ListFeatureViewFieldRelationshipsResponse : AcsResponse
	{

		private string requestId;

		private List<ListFeatureViewFieldRelationships_RelationshipsItem> relationships;

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

		public List<ListFeatureViewFieldRelationships_RelationshipsItem> Relationships
		{
			get
			{
				return relationships;
			}
			set	
			{
				relationships = value;
			}
		}

		public class ListFeatureViewFieldRelationships_RelationshipsItem
		{

			private string featureName;

			private string onlineTableName;

			private string offlineTableName;

			private List<ListFeatureViewFieldRelationships_ModelsItem> models;

			public string FeatureName
			{
				get
				{
					return featureName;
				}
				set	
				{
					featureName = value;
				}
			}

			public string OnlineTableName
			{
				get
				{
					return onlineTableName;
				}
				set	
				{
					onlineTableName = value;
				}
			}

			public string OfflineTableName
			{
				get
				{
					return offlineTableName;
				}
				set	
				{
					offlineTableName = value;
				}
			}

			public List<ListFeatureViewFieldRelationships_ModelsItem> Models
			{
				get
				{
					return models;
				}
				set	
				{
					models = value;
				}
			}

			public class ListFeatureViewFieldRelationships_ModelsItem
			{

				private string modelId;

				private string modelName;

				private string featureAliasName;

				public string ModelId
				{
					get
					{
						return modelId;
					}
					set	
					{
						modelId = value;
					}
				}

				public string ModelName
				{
					get
					{
						return modelName;
					}
					set	
					{
						modelName = value;
					}
				}

				public string FeatureAliasName
				{
					get
					{
						return featureAliasName;
					}
					set	
					{
						featureAliasName = value;
					}
				}
			}
		}
	}
}
