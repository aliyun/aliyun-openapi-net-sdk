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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class GetInventorySchemaResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<GetInventorySchema_Schema> schemas;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<GetInventorySchema_Schema> Schemas
		{
			get
			{
				return schemas;
			}
			set	
			{
				schemas = value;
			}
		}

		public class GetInventorySchema_Schema
		{

			private string typeName;

			private string version;

			private List<GetInventorySchema_Attribute> attributes;

			public string TypeName
			{
				get
				{
					return typeName;
				}
				set	
				{
					typeName = value;
				}
			}

			public string Version
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

			public List<GetInventorySchema_Attribute> Attributes
			{
				get
				{
					return attributes;
				}
				set	
				{
					attributes = value;
				}
			}

			public class GetInventorySchema_Attribute
			{

				private string name;

				private string dataType;

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

				public string DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}
			}
		}
	}
}
