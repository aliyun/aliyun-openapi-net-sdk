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

namespace Aliyun.Acs.Airec.Model.V20201126
{
	public class DeleteFilteringAlgorithmResponse : AcsResponse
	{

		private string requestId;

		private DeleteFilteringAlgorithm_Result result;

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

		public DeleteFilteringAlgorithm_Result Result
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

		public class DeleteFilteringAlgorithm_Result
		{

			private string status;

			private string gmtCreate;

			private string gmtModified;

			private string algorithmId;

			private DeleteFilteringAlgorithm_Meta meta;

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

			public string AlgorithmId
			{
				get
				{
					return algorithmId;
				}
				set	
				{
					algorithmId = value;
				}
			}

			public DeleteFilteringAlgorithm_Meta Meta
			{
				get
				{
					return meta;
				}
				set	
				{
					meta = value;
				}
			}

			public class DeleteFilteringAlgorithm_Meta
			{

				private string metaType;

				private string algorithmName;

				private string cron;

				private bool? cronEnabled;

				private string taskId;

				private string projectName;

				private string tableName;

				private string type;

				private string category;

				private string clusterId;

				private string description;

				private DeleteFilteringAlgorithm_ExtInfo extInfo;

				private DeleteFilteringAlgorithm_Threshold threshold;

				public string MetaType
				{
					get
					{
						return metaType;
					}
					set	
					{
						metaType = value;
					}
				}

				public string AlgorithmName
				{
					get
					{
						return algorithmName;
					}
					set	
					{
						algorithmName = value;
					}
				}

				public string Cron
				{
					get
					{
						return cron;
					}
					set	
					{
						cron = value;
					}
				}

				public bool? CronEnabled
				{
					get
					{
						return cronEnabled;
					}
					set	
					{
						cronEnabled = value;
					}
				}

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
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

				public string TableName
				{
					get
					{
						return tableName;
					}
					set	
					{
						tableName = value;
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

				public string ClusterId
				{
					get
					{
						return clusterId;
					}
					set	
					{
						clusterId = value;
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

				public DeleteFilteringAlgorithm_ExtInfo ExtInfo
				{
					get
					{
						return extInfo;
					}
					set	
					{
						extInfo = value;
					}
				}

				public DeleteFilteringAlgorithm_Threshold Threshold
				{
					get
					{
						return threshold;
					}
					set	
					{
						threshold = value;
					}
				}

				public class DeleteFilteringAlgorithm_ExtInfo
				{

					private string itemSeparator;

					private string kvSeparator;

					public string ItemSeparator
					{
						get
						{
							return itemSeparator;
						}
						set	
						{
							itemSeparator = value;
						}
					}

					public string KvSeparator
					{
						get
						{
							return kvSeparator;
						}
						set	
						{
							kvSeparator = value;
						}
					}
				}

				public class DeleteFilteringAlgorithm_Threshold
				{

					private int? indexLossThreshold;

					private int? indexSizeThreshold;

					private int? sourceDataSizeThreshold;

					private int? sourceDataRecordThreshold;

					public int? IndexLossThreshold
					{
						get
						{
							return indexLossThreshold;
						}
						set	
						{
							indexLossThreshold = value;
						}
					}

					public int? IndexSizeThreshold
					{
						get
						{
							return indexSizeThreshold;
						}
						set	
						{
							indexSizeThreshold = value;
						}
					}

					public int? SourceDataSizeThreshold
					{
						get
						{
							return sourceDataSizeThreshold;
						}
						set	
						{
							sourceDataSizeThreshold = value;
						}
					}

					public int? SourceDataRecordThreshold
					{
						get
						{
							return sourceDataRecordThreshold;
						}
						set	
						{
							sourceDataRecordThreshold = value;
						}
					}
				}
			}
		}
	}
}
