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

namespace Aliyun.Acs.eds_user.Model.V20210308
{
	public class ListPropertyResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<ListProperty_Data> properties;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "NextToken")]
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

		[JsonProperty(PropertyName = "Properties")]
		public List<ListProperty_Data> Properties
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

		public class ListProperty_Data
		{

			private long? propertyId;

			private string propertyKey;

			private List<ListProperty_PropertyValuesItem> propertyValues;

			[JsonProperty(PropertyName = "PropertyId")]
			public long? PropertyId
			{
				get
				{
					return propertyId;
				}
				set	
				{
					propertyId = value;
				}
			}

			[JsonProperty(PropertyName = "PropertyKey")]
			public string PropertyKey
			{
				get
				{
					return propertyKey;
				}
				set	
				{
					propertyKey = value;
				}
			}

			[JsonProperty(PropertyName = "PropertyValues")]
			public List<ListProperty_PropertyValuesItem> PropertyValues
			{
				get
				{
					return propertyValues;
				}
				set	
				{
					propertyValues = value;
				}
			}

			public class ListProperty_PropertyValuesItem
			{

				private long? propertyValueId;

				private string propertyValue;

				[JsonProperty(PropertyName = "PropertyValueId")]
				public long? PropertyValueId
				{
					get
					{
						return propertyValueId;
					}
					set	
					{
						propertyValueId = value;
					}
				}

				[JsonProperty(PropertyName = "PropertyValue")]
				public string PropertyValue
				{
					get
					{
						return propertyValue;
					}
					set	
					{
						propertyValue = value;
					}
				}
			}
		}
	}
}
