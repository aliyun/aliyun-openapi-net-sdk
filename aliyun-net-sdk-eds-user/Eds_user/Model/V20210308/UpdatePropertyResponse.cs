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
	public class UpdatePropertyResponse : AcsResponse
	{

		private string requestId;

		private UpdateProperty_UpdateResult updateResult;

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

		[JsonProperty(PropertyName = "UpdateResult")]
		public UpdateProperty_UpdateResult UpdateResult
		{
			get
			{
				return updateResult;
			}
			set	
			{
				updateResult = value;
			}
		}

		public class UpdateProperty_UpdateResult
		{

			private long? propertyId;

			private string propertyKey;

			private UpdateProperty_SavePropertyValueModel savePropertyValueModel;

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

			[JsonProperty(PropertyName = "SavePropertyValueModel")]
			public UpdateProperty_SavePropertyValueModel SavePropertyValueModel
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

			public class UpdateProperty_SavePropertyValueModel
			{

				private List<UpdateProperty_SavePropertyValuesItem> savePropertyValues;

				private List<UpdateProperty_FailedPropertyValuesItem> failedPropertyValues;

				[JsonProperty(PropertyName = "SavePropertyValues")]
				public List<UpdateProperty_SavePropertyValuesItem> SavePropertyValues
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

				[JsonProperty(PropertyName = "FailedPropertyValues")]
				public List<UpdateProperty_FailedPropertyValuesItem> FailedPropertyValues
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

				public class UpdateProperty_SavePropertyValuesItem
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

				public class UpdateProperty_FailedPropertyValuesItem
				{

					private long? propertyId;

					private string propertyValue;

					private string errorCode;

					private string errorMessage;

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

					[JsonProperty(PropertyName = "ErrorCode")]
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

					[JsonProperty(PropertyName = "ErrorMessage")]
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
