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
	public class CreateFilteringAlgorithmResponse : AcsResponse
	{

		private string requestId;

		private CreateFilteringAlgorithm_Result result;

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

		public CreateFilteringAlgorithm_Result Result
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

		public class CreateFilteringAlgorithm_Result
		{

			private string algorithmId;

			private string status;

			private string gmtCreate;

			private string gmtModified;

			private CreateFilteringAlgorithm_Meta meta;

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

			public CreateFilteringAlgorithm_Meta Meta
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

			public class CreateFilteringAlgorithm_Meta
			{

				private string algorithmName;

				private string type;

				private string projectName;

				private string tableName;

				private string category;

				private string extInfo;

				private string cron;

				private bool? cronEnabled;

				private string gmtModified;

				private string gmtCreate;

				private string status;

				private string description;

				private CreateFilteringAlgorithm_Threshold threshold;

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

				public string ExtInfo
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

				public CreateFilteringAlgorithm_Threshold Threshold
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

				public class CreateFilteringAlgorithm_Threshold
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
