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

namespace Aliyun.Acs.Baas.Model.V20180731
{
	public class GetBcSchemaResponse : AcsResponse
	{

		private string requestId;

		private GetBcSchema_Result result;

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

		public GetBcSchema_Result Result
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

		public class GetBcSchema_Result
		{

			private List<GetBcSchema_ResponsesItem> responses;

			private GetBcSchema_Schema schema;

			public List<GetBcSchema_ResponsesItem> Responses
			{
				get
				{
					return responses;
				}
				set	
				{
					responses = value;
				}
			}

			public GetBcSchema_Schema Schema
			{
				get
				{
					return schema;
				}
				set	
				{
					schema = value;
				}
			}

			public class GetBcSchema_ResponsesItem
			{

				private string categoryName;

				private string description;

				private string category;

				private GetBcSchema_Properties properties;

				public string CategoryName
				{
					get
					{
						return categoryName;
					}
					set	
					{
						categoryName = value;
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

				public GetBcSchema_Properties Properties
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

				public class GetBcSchema_Properties
				{

					private int? count;

					private List<GetBcSchema_DataSourceItem> dataSource;

					public int? Count
					{
						get
						{
							return count;
						}
						set	
						{
							count = value;
						}
					}

					public List<GetBcSchema_DataSourceItem> DataSource
					{
						get
						{
							return dataSource;
						}
						set	
						{
							dataSource = value;
						}
					}

					public class GetBcSchema_DataSourceItem
					{

						private int? key;

						private string field;

						private string type;

						private int? length;

						private int? allowNull;

						private string reg;

						private int? indexes;

						private string annotation;

						public int? Key
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

						public string Field
						{
							get
							{
								return field;
							}
							set	
							{
								field = value;
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

						public int? Length
						{
							get
							{
								return length;
							}
							set	
							{
								length = value;
							}
						}

						public int? AllowNull
						{
							get
							{
								return allowNull;
							}
							set	
							{
								allowNull = value;
							}
						}

						public string Reg
						{
							get
							{
								return reg;
							}
							set	
							{
								reg = value;
							}
						}

						public int? Indexes
						{
							get
							{
								return indexes;
							}
							set	
							{
								indexes = value;
							}
						}

						public string Annotation
						{
							get
							{
								return annotation;
							}
							set	
							{
								annotation = value;
							}
						}
					}
				}
			}

			public class GetBcSchema_Schema
			{

				private long? id;

				private string name;

				private string description;

				private long? version;

				private long? createTime;

				private long? updateTime;

				private bool? isTemplate;

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

				public long? Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public long? CreateTime
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

				public long? UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				public bool? IsTemplate
				{
					get
					{
						return isTemplate;
					}
					set	
					{
						isTemplate = value;
					}
				}
			}
		}
	}
}