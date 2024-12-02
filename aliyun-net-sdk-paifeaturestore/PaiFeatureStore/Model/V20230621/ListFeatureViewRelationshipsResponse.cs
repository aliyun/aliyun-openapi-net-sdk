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
	public class ListFeatureViewRelationshipsResponse : AcsResponse
	{

		private string requestId;

		private List<ListFeatureViewRelationships_RelationshipsItem> relationships;

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

		public List<ListFeatureViewRelationships_RelationshipsItem> Relationships
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

		public class ListFeatureViewRelationships_RelationshipsItem
		{

			private string featureViewName;

			private string projectName;

			private List<ListFeatureViewRelationships_ModelsItem> models;

			public string FeatureViewName
			{
				get
				{
					return featureViewName;
				}
				set	
				{
					featureViewName = value;
				}
			}

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
				}
			}

			public List<ListFeatureViewRelationships_ModelsItem> Models
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

			public class ListFeatureViewRelationships_ModelsItem
			{

				private string modelId;

				private string modelName;

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
			}
		}
	}
}
