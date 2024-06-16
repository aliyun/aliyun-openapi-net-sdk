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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class DescribeWhiteRuleListResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private DescribeWhiteRuleList_Data data;

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

		public int? Code
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public DescribeWhiteRuleList_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeWhiteRuleList_Data
		{

			private List<DescribeWhiteRuleList_ResponseDataItem> responseData;

			private DescribeWhiteRuleList_PageInfo pageInfo;

			public List<DescribeWhiteRuleList_ResponseDataItem> ResponseData
			{
				get
				{
					return responseData;
				}
				set	
				{
					responseData = value;
				}
			}

			public DescribeWhiteRuleList_PageInfo PageInfo
			{
				get
				{
					return pageInfo;
				}
				set	
				{
					pageInfo = value;
				}
			}

			public class DescribeWhiteRuleList_ResponseDataItem
			{

				private long? id;

				private string gmtCreate;

				private string gmtModified;

				private long? aliuid;

				private long? subAliuid;

				private string alertType;

				private string alertTypeId;

				private string alertName;

				private string alertNameId;

				private int? status;

				private string incidentUuid;

				private string alertUuid;

				private DescribeWhiteRuleList_Expression expression;

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

				public string GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public long? Aliuid
				{
					get
					{
						return aliuid;
					}
					set	
					{
						aliuid = value;
					}
				}

				public long? SubAliuid
				{
					get
					{
						return subAliuid;
					}
					set	
					{
						subAliuid = value;
					}
				}

				public string AlertType
				{
					get
					{
						return alertType;
					}
					set	
					{
						alertType = value;
					}
				}

				public string AlertTypeId
				{
					get
					{
						return alertTypeId;
					}
					set	
					{
						alertTypeId = value;
					}
				}

				public string AlertName
				{
					get
					{
						return alertName;
					}
					set	
					{
						alertName = value;
					}
				}

				public string AlertNameId
				{
					get
					{
						return alertNameId;
					}
					set	
					{
						alertNameId = value;
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

				public string IncidentUuid
				{
					get
					{
						return incidentUuid;
					}
					set	
					{
						incidentUuid = value;
					}
				}

				public string AlertUuid
				{
					get
					{
						return alertUuid;
					}
					set	
					{
						alertUuid = value;
					}
				}

				public DescribeWhiteRuleList_Expression Expression
				{
					get
					{
						return expression;
					}
					set	
					{
						expression = value;
					}
				}

				public class DescribeWhiteRuleList_Expression
				{

					private string logic;

					private List<DescribeWhiteRuleList_Condition> conditions;

					public string Logic
					{
						get
						{
							return logic;
						}
						set	
						{
							logic = value;
						}
					}

					public List<DescribeWhiteRuleList_Condition> Conditions
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

					public class DescribeWhiteRuleList_Condition
					{

						private int? itemId;

						private string _operator;

						private bool? isNot;

						private DescribeWhiteRuleList_Left left;

						private DescribeWhiteRuleList_Right right;

						public int? ItemId
						{
							get
							{
								return itemId;
							}
							set	
							{
								itemId = value;
							}
						}

						public string _Operator
						{
							get
							{
								return _operator;
							}
							set	
							{
								_operator = value;
							}
						}

						public bool? IsNot
						{
							get
							{
								return isNot;
							}
							set	
							{
								isNot = value;
							}
						}

						public DescribeWhiteRuleList_Left Left
						{
							get
							{
								return left;
							}
							set	
							{
								left = value;
							}
						}

						public DescribeWhiteRuleList_Right Right
						{
							get
							{
								return right;
							}
							set	
							{
								right = value;
							}
						}

						public class DescribeWhiteRuleList_Left
						{

							private string _value;

							private bool? isVar;

							private string type;

							private string modifier;

							private string modifierParam;

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

							public bool? IsVar
							{
								get
								{
									return isVar;
								}
								set	
								{
									isVar = value;
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

							public string Modifier
							{
								get
								{
									return modifier;
								}
								set	
								{
									modifier = value;
								}
							}

							public string ModifierParam
							{
								get
								{
									return modifierParam;
								}
								set	
								{
									modifierParam = value;
								}
							}
						}

						public class DescribeWhiteRuleList_Right
						{

							private string _value;

							private bool? isVar;

							private string type;

							private string modifier;

							private string modifierParam;

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

							public bool? IsVar
							{
								get
								{
									return isVar;
								}
								set	
								{
									isVar = value;
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

							public string Modifier
							{
								get
								{
									return modifier;
								}
								set	
								{
									modifier = value;
								}
							}

							public string ModifierParam
							{
								get
								{
									return modifierParam;
								}
								set	
								{
									modifierParam = value;
								}
							}
						}
					}
				}
			}

			public class DescribeWhiteRuleList_PageInfo
			{

				private int? currentPage;

				private int? pageSize;

				private long? totalCount;

				public int? CurrentPage
				{
					get
					{
						return currentPage;
					}
					set	
					{
						currentPage = value;
					}
				}

				public int? PageSize
				{
					get
					{
						return pageSize;
					}
					set	
					{
						pageSize = value;
					}
				}

				public long? TotalCount
				{
					get
					{
						return totalCount;
					}
					set	
					{
						totalCount = value;
					}
				}
			}
		}
	}
}
