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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class ListDeployedAlgorithmModelsResponse : AcsResponse
	{

		private string requestId;

		private List<ListDeployedAlgorithmModels_ResultItem> result;

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

		public List<ListDeployedAlgorithmModels_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListDeployedAlgorithmModels_ResultItem
		{

			private string id;

			private string appGroupName;

			private string scene;

			private string desc;

			private string gmtCreate;

			private string gmtModified;

			private string status;

			private List<ListDeployedAlgorithmModels_ModelsItem> models;

			private List<string> apps;

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

			public string AppGroupName
			{
				get
				{
					return appGroupName;
				}
				set	
				{
					appGroupName = value;
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

			public string Desc
			{
				get
				{
					return desc;
				}
				set	
				{
					desc = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public List<ListDeployedAlgorithmModels_ModelsItem> Models
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

			public List<string> Apps
			{
				get
				{
					return apps;
				}
				set	
				{
					apps = value;
				}
			}

			public class ListDeployedAlgorithmModels_ModelsItem
			{

				private string modelName;

				private int? modelId;

				private int? progress;

				private string status;

				private int? projectId;

				private string algorithmType;

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

				public int? ModelId
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

				public int? Progress
				{
					get
					{
						return progress;
					}
					set	
					{
						progress = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public int? ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
					}
				}

				public string AlgorithmType
				{
					get
					{
						return algorithmType;
					}
					set	
					{
						algorithmType = value;
					}
				}
			}
		}
	}
}
