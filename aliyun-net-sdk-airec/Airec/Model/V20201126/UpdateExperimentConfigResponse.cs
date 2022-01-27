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
	public class UpdateExperimentConfigResponse : AcsResponse
	{

		private string requestId;

		private UpdateExperimentConfig_Result result;

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

		public UpdateExperimentConfig_Result Result
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

		public class UpdateExperimentConfig_Result
		{

			private string experimentId;

			private string name;

			private string description;

			private string status;

			private bool? _base;

			private string onlineTime;

			private string offlineTime;

			private List<UpdateExperimentConfig_Algorithm> algorithms;

			private List<string> buckets;

			public string ExperimentId
			{
				get
				{
					return experimentId;
				}
				set	
				{
					experimentId = value;
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

			public bool? _Base
			{
				get
				{
					return _base;
				}
				set	
				{
					_base = value;
				}
			}

			public string OnlineTime
			{
				get
				{
					return onlineTime;
				}
				set	
				{
					onlineTime = value;
				}
			}

			public string OfflineTime
			{
				get
				{
					return offlineTime;
				}
				set	
				{
					offlineTime = value;
				}
			}

			public List<UpdateExperimentConfig_Algorithm> Algorithms
			{
				get
				{
					return algorithms;
				}
				set	
				{
					algorithms = value;
				}
			}

			public List<string> Buckets
			{
				get
				{
					return buckets;
				}
				set	
				{
					buckets = value;
				}
			}

			public class UpdateExperimentConfig_Algorithm
			{

				private string key;

				private string name;

				private string category;

				private string type;

				private string defaultValue;

				private string experimentValue;

				private bool? hasConfig;

				private List<UpdateExperimentConfig_ConfigItem> config;

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

				public string DefaultValue
				{
					get
					{
						return defaultValue;
					}
					set	
					{
						defaultValue = value;
					}
				}

				public string ExperimentValue
				{
					get
					{
						return experimentValue;
					}
					set	
					{
						experimentValue = value;
					}
				}

				public bool? HasConfig
				{
					get
					{
						return hasConfig;
					}
					set	
					{
						hasConfig = value;
					}
				}

				public List<UpdateExperimentConfig_ConfigItem> Config
				{
					get
					{
						return config;
					}
					set	
					{
						config = value;
					}
				}

				public class UpdateExperimentConfig_ConfigItem
				{

					private string key;

					private string name;

					private string defaultValue;

					private string experimentValue;

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

					public string DefaultValue
					{
						get
						{
							return defaultValue;
						}
						set	
						{
							defaultValue = value;
						}
					}

					public string ExperimentValue
					{
						get
						{
							return experimentValue;
						}
						set	
						{
							experimentValue = value;
						}
					}
				}
			}
		}
	}
}
