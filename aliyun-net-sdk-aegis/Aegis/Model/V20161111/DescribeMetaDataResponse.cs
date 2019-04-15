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
	public class DescribeMetaDataResponse : AcsResponse
	{

		private string requestId;

		private DescribeMetaData_MetaData metaData;

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

		public DescribeMetaData_MetaData MetaData
		{
			get
			{
				return metaData;
			}
			set	
			{
				metaData = value;
			}
		}

		public class DescribeMetaData_MetaData
		{

			private string logStoreName;

			private string projectName;

			private int? status;

			private List<DescribeMetaData_DatasourceField> datasourceFieldList;

			public string LogStoreName
			{
				get
				{
					return logStoreName;
				}
				set	
				{
					logStoreName = value;
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

			public int? Status
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

			public List<DescribeMetaData_DatasourceField> DatasourceFieldList
			{
				get
				{
					return datasourceFieldList;
				}
				set	
				{
					datasourceFieldList = value;
				}
			}

			public class DescribeMetaData_DatasourceField
			{

				private string fieldName;

				private string valueType;

				private string fieldDescription;

				private string fieldAliasName;

				private string fieldType;

				private string fieldValue;

				private int? isIdentification;

				public string FieldName
				{
					get
					{
						return fieldName;
					}
					set	
					{
						fieldName = value;
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

				public string FieldDescription
				{
					get
					{
						return fieldDescription;
					}
					set	
					{
						fieldDescription = value;
					}
				}

				public string FieldAliasName
				{
					get
					{
						return fieldAliasName;
					}
					set	
					{
						fieldAliasName = value;
					}
				}

				public string FieldType
				{
					get
					{
						return fieldType;
					}
					set	
					{
						fieldType = value;
					}
				}

				public string FieldValue
				{
					get
					{
						return fieldValue;
					}
					set	
					{
						fieldValue = value;
					}
				}

				public int? IsIdentification
				{
					get
					{
						return isIdentification;
					}
					set	
					{
						isIdentification = value;
					}
				}
			}
		}
	}
}
