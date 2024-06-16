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

namespace Aliyun.Acs.ComputeNest.Model.V20210601
{
	public class GetServiceTemplateParameterConstraintsResponse : AcsResponse
	{

		private string requestId;

		private List<GetServiceTemplateParameterConstraints_ParameterConstraintsItem> parameterConstraints;

		private List<string> familyConstraints;

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

		public List<GetServiceTemplateParameterConstraints_ParameterConstraintsItem> ParameterConstraints
		{
			get
			{
				return parameterConstraints;
			}
			set	
			{
				parameterConstraints = value;
			}
		}

		public List<string> FamilyConstraints
		{
			get
			{
				return familyConstraints;
			}
			set	
			{
				familyConstraints = value;
			}
		}

		public class GetServiceTemplateParameterConstraints_ParameterConstraintsItem
		{

			private string type;

			private string parameterKey;

			private string behavior;

			private string behaviorReason;

			private List<GetServiceTemplateParameterConstraints_OriginalConstraintsItem> originalConstraints;

			private List<GetServiceTemplateParameterConstraints_QueryErrorsItem> queryErrors;

			private List<string> allowedValues;

			private List<string> associationParameterNames;

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

			public string ParameterKey
			{
				get
				{
					return parameterKey;
				}
				set	
				{
					parameterKey = value;
				}
			}

			public string Behavior
			{
				get
				{
					return behavior;
				}
				set	
				{
					behavior = value;
				}
			}

			public string BehaviorReason
			{
				get
				{
					return behaviorReason;
				}
				set	
				{
					behaviorReason = value;
				}
			}

			public List<GetServiceTemplateParameterConstraints_OriginalConstraintsItem> OriginalConstraints
			{
				get
				{
					return originalConstraints;
				}
				set	
				{
					originalConstraints = value;
				}
			}

			public List<GetServiceTemplateParameterConstraints_QueryErrorsItem> QueryErrors
			{
				get
				{
					return queryErrors;
				}
				set	
				{
					queryErrors = value;
				}
			}

			public List<string> AllowedValues
			{
				get
				{
					return allowedValues;
				}
				set	
				{
					allowedValues = value;
				}
			}

			public List<string> AssociationParameterNames
			{
				get
				{
					return associationParameterNames;
				}
				set	
				{
					associationParameterNames = value;
				}
			}

			public class GetServiceTemplateParameterConstraints_OriginalConstraintsItem
			{

				private string propertyName;

				private string resourceName;

				private string resourceType;

				private List<string> allowedValues1;

				public string PropertyName
				{
					get
					{
						return propertyName;
					}
					set	
					{
						propertyName = value;
					}
				}

				public string ResourceName
				{
					get
					{
						return resourceName;
					}
					set	
					{
						resourceName = value;
					}
				}

				public string ResourceType
				{
					get
					{
						return resourceType;
					}
					set	
					{
						resourceType = value;
					}
				}

				public List<string> AllowedValues1
				{
					get
					{
						return allowedValues1;
					}
					set	
					{
						allowedValues1 = value;
					}
				}
			}

			public class GetServiceTemplateParameterConstraints_QueryErrorsItem
			{

				private string errorMessage;

				private string resourceName;

				private string resourceType;

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

				public string ResourceName
				{
					get
					{
						return resourceName;
					}
					set	
					{
						resourceName = value;
					}
				}

				public string ResourceType
				{
					get
					{
						return resourceType;
					}
					set	
					{
						resourceType = value;
					}
				}
			}
		}
	}
}
