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

namespace Aliyun.Acs.waf_openapi.Model.V20180117
{
	public class DescribeAclRulesResponse : AcsResponse
	{

		private string requestId;

		private DescribeAclRules_Result result;

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

		public DescribeAclRules_Result Result
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

		public class DescribeAclRules_Result
		{

			private int? total;

			private List<DescribeAclRules_AclRule> aclRules;

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public List<DescribeAclRules_AclRule> AclRules
			{
				get
				{
					return aclRules;
				}
				set	
				{
					aclRules = value;
				}
			}

			public class DescribeAclRules_AclRule
			{

				private int? continueWaf;

				private int? continueBlockGeo;

				private int? continueSA;

				private int? continueSdk;

				private int? continueDataRiskControl;

				private int? continueCc;

				private int? isDefault;

				private string name;

				private int? action;

				private long? id;

				private int? order;

				private List<DescribeAclRules_Condition> conditions;

				public int? ContinueWaf
				{
					get
					{
						return continueWaf;
					}
					set	
					{
						continueWaf = value;
					}
				}

				public int? ContinueBlockGeo
				{
					get
					{
						return continueBlockGeo;
					}
					set	
					{
						continueBlockGeo = value;
					}
				}

				public int? ContinueSA
				{
					get
					{
						return continueSA;
					}
					set	
					{
						continueSA = value;
					}
				}

				public int? ContinueSdk
				{
					get
					{
						return continueSdk;
					}
					set	
					{
						continueSdk = value;
					}
				}

				public int? ContinueDataRiskControl
				{
					get
					{
						return continueDataRiskControl;
					}
					set	
					{
						continueDataRiskControl = value;
					}
				}

				public int? ContinueCc
				{
					get
					{
						return continueCc;
					}
					set	
					{
						continueCc = value;
					}
				}

				public int? IsDefault
				{
					get
					{
						return isDefault;
					}
					set	
					{
						isDefault = value;
					}
				}

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

				public int? Action
				{
					get
					{
						return action;
					}
					set	
					{
						action = value;
					}
				}

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public int? Order
				{
					get
					{
						return order;
					}
					set	
					{
						order = value;
					}
				}

				public List<DescribeAclRules_Condition> Conditions
				{
					get
					{
						return conditions;
					}
					set	
					{
						conditions = value;
					}
				}

				public class DescribeAclRules_Condition
				{

					private string contain;

					private string _value;

					private string key;

					public string Contain
					{
						get
						{
							return contain;
						}
						set	
						{
							contain = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
						}
					}
				}
			}
		}
	}
}
