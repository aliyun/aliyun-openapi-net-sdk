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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeEventTypesDetailResponse : AcsResponse
	{

		private string requestId;

		private DescribeEventTypesDetail_UserStatus userStatus;

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

		public DescribeEventTypesDetail_UserStatus UserStatus
		{
			get
			{
				return userStatus;
			}
			set	
			{
				userStatus = value;
			}
		}

		public class DescribeEventTypesDetail_UserStatus
		{

			private string name;

			private string code;

			private string description;

			private long? parentTypeId;

			private string parentTypeName;

			private int? riskLevel;

			private string riskName;

			private int? status;

			private int? eventHitCount;

			private int? accessCount;

			private string descEvent;

			private string descModel;

			private string dealSuggestion;

			private string riskEvent;

			private string adaptedProduct;

			private string configCode;

			private int? configContentType;

			private string configDescription;

			private string configValue;

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

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
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

			public long? ParentTypeId
			{
				get
				{
					return parentTypeId;
				}
				set	
				{
					parentTypeId = value;
				}
			}

			public string ParentTypeName
			{
				get
				{
					return parentTypeName;
				}
				set	
				{
					parentTypeName = value;
				}
			}

			public int? RiskLevel
			{
				get
				{
					return riskLevel;
				}
				set	
				{
					riskLevel = value;
				}
			}

			public string RiskName
			{
				get
				{
					return riskName;
				}
				set	
				{
					riskName = value;
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

			public int? EventHitCount
			{
				get
				{
					return eventHitCount;
				}
				set	
				{
					eventHitCount = value;
				}
			}

			public int? AccessCount
			{
				get
				{
					return accessCount;
				}
				set	
				{
					accessCount = value;
				}
			}

			public string DescEvent
			{
				get
				{
					return descEvent;
				}
				set	
				{
					descEvent = value;
				}
			}

			public string DescModel
			{
				get
				{
					return descModel;
				}
				set	
				{
					descModel = value;
				}
			}

			public string DealSuggestion
			{
				get
				{
					return dealSuggestion;
				}
				set	
				{
					dealSuggestion = value;
				}
			}

			public string RiskEvent
			{
				get
				{
					return riskEvent;
				}
				set	
				{
					riskEvent = value;
				}
			}

			public string AdaptedProduct
			{
				get
				{
					return adaptedProduct;
				}
				set	
				{
					adaptedProduct = value;
				}
			}

			public string ConfigCode
			{
				get
				{
					return configCode;
				}
				set	
				{
					configCode = value;
				}
			}

			public int? ConfigContentType
			{
				get
				{
					return configContentType;
				}
				set	
				{
					configContentType = value;
				}
			}

			public string ConfigDescription
			{
				get
				{
					return configDescription;
				}
				set	
				{
					configDescription = value;
				}
			}

			public string ConfigValue
			{
				get
				{
					return configValue;
				}
				set	
				{
					configValue = value;
				}
			}
		}
	}
}
