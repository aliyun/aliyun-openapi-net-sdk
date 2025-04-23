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
	public class CreatePropertyResponse : AcsResponse
	{

		private string requestId;

		private CreateProperty_CreateResult createResult;

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

		public CreateProperty_CreateResult CreateResult
		{
			get
			{
				return createResult;
			}
			set	
			{
				createResult = value;
			}
		}

		public class CreateProperty_CreateResult
		{

			private long? propertyId;

			private string propertyKey;

			private CreateProperty_SavePropertyValueModel savePropertyValueModel;

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

			public CreateProperty_SavePropertyValueModel SavePropertyValueModel
			{
				get
				{
					return savePropertyValueModel;
				}
				set	
				{
					savePropertyValueModel = value;
				}
			}

			public class CreateProperty_SavePropertyValueModel
			{

				private List<CreateProperty_SavePropertyValuesItem> savePropertyValues;

				private List<CreateProperty_FailedPropertyValuesItem> failedPropertyValues;

				public List<CreateProperty_SavePropertyValuesItem> SavePropertyValues
				{
					get
					{
						return savePropertyValues;
					}
					set	
					{
						savePropertyValues = value;
					}
				}

				public List<CreateProperty_FailedPropertyValuesItem> FailedPropertyValues
				{
					get
					{
						return failedPropertyValues;
					}
					set	
					{
						failedPropertyValues = value;
					}
				}

				public class CreateProperty_SavePropertyValuesItem
				{

					private long? propertyValueId;

					private string propertyValue;

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

				public class CreateProperty_FailedPropertyValuesItem
				{

					private long? propertyId;

					private string propertyValue;

					private string errorCode;

					private string errorMessage;

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

					public string ErrorCode
					{
						get
						{
							return errorCode;
						}
						set	
						{
							errorCode = value;
						}
					}

					public string ErrorMessage
					{
						get
						{
							return errorMessage;
						}
						set	
						{
							errorMessage = value;
						}
					}
				}
			}
		}
	}
}
