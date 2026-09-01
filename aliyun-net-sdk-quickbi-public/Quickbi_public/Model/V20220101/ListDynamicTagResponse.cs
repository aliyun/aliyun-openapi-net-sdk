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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class ListDynamicTagResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<ListDynamicTag_Data> result;

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

		public List<ListDynamicTag_Data> Result
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

		public class ListDynamicTag_Data
		{

			private string tableName;

			private string columnName;

			private int? relatedAttribute;

			private string configName;

			private string dsId;

			private string organizationId;

			private string configId;

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

			public string ColumnName
			{
				get
				{
					return columnName;
				}
				set	
				{
					columnName = value;
				}
			}

			public int? RelatedAttribute
			{
				get
				{
					return relatedAttribute;
				}
				set	
				{
					relatedAttribute = value;
				}
			}

			public string ConfigName
			{
				get
				{
					return configName;
				}
				set	
				{
					configName = value;
				}
			}

			public string DsId
			{
				get
				{
					return dsId;
				}
				set	
				{
					dsId = value;
				}
			}

			public string OrganizationId
			{
				get
				{
					return organizationId;
				}
				set	
				{
					organizationId = value;
				}
			}

			public string ConfigId
			{
				get
				{
					return configId;
				}
				set	
				{
					configId = value;
				}
			}
		}
	}
}
