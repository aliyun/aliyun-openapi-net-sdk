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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeDataSourceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? count;

		private List<DescribeDataSource_Data> metaDatas;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

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

		public List<DescribeDataSource_Data> MetaDatas
		{
			get
			{
				return metaDatas;
			}
			set	
			{
				metaDatas = value;
			}
		}

		public class DescribeDataSource_Data
		{

			private int? dataSourceId;

			private string dateSourceName;

			private string description;

			private List<DescribeDataSource_MetaDataField> metaDataFields;

			public int? DataSourceId
			{
				get
				{
					return dataSourceId;
				}
				set	
				{
					dataSourceId = value;
				}
			}

			public string DateSourceName
			{
				get
				{
					return dateSourceName;
				}
				set	
				{
					dateSourceName = value;
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

			public List<DescribeDataSource_MetaDataField> MetaDataFields
			{
				get
				{
					return metaDataFields;
				}
				set	
				{
					metaDataFields = value;
				}
			}

			public class DescribeDataSource_MetaDataField
			{

				private string filedName;

				private string filed;

				private string valueType;

				private string sample;

				private List<DescribeDataSource__Operator> operatorList;

				public string FiledName
				{
					get
					{
						return filedName;
					}
					set	
					{
						filedName = value;
					}
				}

				public string Filed
				{
					get
					{
						return filed;
					}
					set	
					{
						filed = value;
					}
				}

				public string ValueType
				{
					get
					{
						return valueType;
					}
					set	
					{
						valueType = value;
					}
				}

				public string Sample
				{
					get
					{
						return sample;
					}
					set	
					{
						sample = value;
					}
				}

				public List<DescribeDataSource__Operator> OperatorList
				{
					get
					{
						return operatorList;
					}
					set	
					{
						operatorList = value;
					}
				}

				public class DescribeDataSource__Operator
				{

					private string name;

					private string description;

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
				}
			}
		}
	}
}
