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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeSecurityEventOperationsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSecurityEventOperations_SecurityEventOperation> securityEventOperationsResponse;

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

		public List<DescribeSecurityEventOperations_SecurityEventOperation> SecurityEventOperationsResponse
		{
			get
			{
				return securityEventOperationsResponse;
			}
			set	
			{
				securityEventOperationsResponse = value;
			}
		}

		public class DescribeSecurityEventOperations_SecurityEventOperation
		{

			private string operationCode;

			private string operationParams;

			private bool? userCanOperate;

			private List<DescribeSecurityEventOperations_MarkFieldItem> markField;

			private List<DescribeSecurityEventOperations_SecurityEventOperation1> markFieldsSource;

			public string OperationCode
			{
				get
				{
					return operationCode;
				}
				set	
				{
					operationCode = value;
				}
			}

			public string OperationParams
			{
				get
				{
					return operationParams;
				}
				set	
				{
					operationParams = value;
				}
			}

			public bool? UserCanOperate
			{
				get
				{
					return userCanOperate;
				}
				set	
				{
					userCanOperate = value;
				}
			}

			public List<DescribeSecurityEventOperations_MarkFieldItem> MarkField
			{
				get
				{
					return markField;
				}
				set	
				{
					markField = value;
				}
			}

			public List<DescribeSecurityEventOperations_SecurityEventOperation1> MarkFieldsSource
			{
				get
				{
					return markFieldsSource;
				}
				set	
				{
					markFieldsSource = value;
				}
			}

			public class DescribeSecurityEventOperations_MarkFieldItem
			{

				private string filedName;

				private string filedAliasName;

				private string markMisType;

				private string markMisValue;

				private List<string> supportedMisType;

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

				public string FiledAliasName
				{
					get
					{
						return filedAliasName;
					}
					set	
					{
						filedAliasName = value;
					}
				}

				public string MarkMisType
				{
					get
					{
						return markMisType;
					}
					set	
					{
						markMisType = value;
					}
				}

				public string MarkMisValue
				{
					get
					{
						return markMisValue;
					}
					set	
					{
						markMisValue = value;
					}
				}

				public List<string> SupportedMisType
				{
					get
					{
						return supportedMisType;
					}
					set	
					{
						supportedMisType = value;
					}
				}
			}

			public class DescribeSecurityEventOperations_SecurityEventOperation1
			{

				private string filedName;

				private string filedAliasName;

				private string markMisValue;

				private List<string> supportedMisType2;

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

				public string FiledAliasName
				{
					get
					{
						return filedAliasName;
					}
					set	
					{
						filedAliasName = value;
					}
				}

				public string MarkMisValue
				{
					get
					{
						return markMisValue;
					}
					set	
					{
						markMisValue = value;
					}
				}

				public List<string> SupportedMisType2
				{
					get
					{
						return supportedMisType2;
					}
					set	
					{
						supportedMisType2 = value;
					}
				}
			}
		}
	}
}
