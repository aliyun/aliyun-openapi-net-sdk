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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class DescribePopApiResponse : AcsResponse
	{

		private string requestId;

		private string popCode;

		private string version;

		private string apiName;

		private string apiMeta;

		private List<DescribePopApi_OpenApiMetaListItem> openApiMetaList;

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

		public string PopCode
		{
			get
			{
				return popCode;
			}
			set	
			{
				popCode = value;
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

		public string ApiName
		{
			get
			{
				return apiName;
			}
			set	
			{
				apiName = value;
			}
		}

		public string ApiMeta
		{
			get
			{
				return apiMeta;
			}
			set	
			{
				apiMeta = value;
			}
		}

		public List<DescribePopApi_OpenApiMetaListItem> OpenApiMetaList
		{
			get
			{
				return openApiMetaList;
			}
			set	
			{
				openApiMetaList = value;
			}
		}

		public class DescribePopApi_OpenApiMetaListItem
		{

			private string name;

			private bool? required;

			private string exampleValue;

			private string description;

			private string _in;

			private string visibility;

			private string type;

			private bool? isRequired;

			private string style;

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

			public bool? Required
			{
				get
				{
					return required;
				}
				set	
				{
					required = value;
				}
			}

			public string ExampleValue
			{
				get
				{
					return exampleValue;
				}
				set	
				{
					exampleValue = value;
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

			public string _In
			{
				get
				{
					return _in;
				}
				set	
				{
					_in = value;
				}
			}

			public string Visibility
			{
				get
				{
					return visibility;
				}
				set	
				{
					visibility = value;
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

			public bool? IsRequired
			{
				get
				{
					return isRequired;
				}
				set	
				{
					isRequired = value;
				}
			}

			public string Style
			{
				get
				{
					return style;
				}
				set	
				{
					style = value;
				}
			}
		}
	}
}
