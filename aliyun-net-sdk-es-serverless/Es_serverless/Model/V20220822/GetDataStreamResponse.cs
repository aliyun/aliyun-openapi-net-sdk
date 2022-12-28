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

namespace Aliyun.Acs.es_serverless.Model.V20220822
{
	public class GetDataStreamResponse : AcsResponse
	{

		private string requestId;

		private GetDataStream_Result result;

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

		public GetDataStream_Result Result
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

		public class GetDataStream_Result
		{

			private string appName;

			private string regionId;

			private string deletePhase;

			private string dataStreamId;

			private string dataStreamName;

			private string type;

			private string createTime;

			private string timeStampKey;

			private GetDataStream_Template template;

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string DeletePhase
			{
				get
				{
					return deletePhase;
				}
				set	
				{
					deletePhase = value;
				}
			}

			public string DataStreamId
			{
				get
				{
					return dataStreamId;
				}
				set	
				{
					dataStreamId = value;
				}
			}

			public string DataStreamName
			{
				get
				{
					return dataStreamName;
				}
				set	
				{
					dataStreamName = value;
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

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string TimeStampKey
			{
				get
				{
					return timeStampKey;
				}
				set	
				{
					timeStampKey = value;
				}
			}

			public GetDataStream_Template Template
			{
				get
				{
					return template;
				}
				set	
				{
					template = value;
				}
			}

			public class GetDataStream_Template
			{

				private List<GetDataStream_MappingsItem> mappings;

				public List<GetDataStream_MappingsItem> Mappings
				{
					get
					{
						return mappings;
					}
					set	
					{
						mappings = value;
					}
				}

				public class GetDataStream_MappingsItem
				{

					private string type;

					private bool? caseSensitive;

					private bool? docValues;

					private bool? index;

					private string key;

					private List<string> tokenizeOnChars;

					private List<string> properties;

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

					public bool? CaseSensitive
					{
						get
						{
							return caseSensitive;
						}
						set	
						{
							caseSensitive = value;
						}
					}

					public bool? DocValues
					{
						get
						{
							return docValues;
						}
						set	
						{
							docValues = value;
						}
					}

					public bool? Index
					{
						get
						{
							return index;
						}
						set	
						{
							index = value;
						}
					}

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

					public List<string> TokenizeOnChars
					{
						get
						{
							return tokenizeOnChars;
						}
						set	
						{
							tokenizeOnChars = value;
						}
					}

					public List<string> Properties
					{
						get
						{
							return properties;
						}
						set	
						{
							properties = value;
						}
					}
				}
			}
		}
	}
}
