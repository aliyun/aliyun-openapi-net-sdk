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

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
	public class ConfigDataSetResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private ConfigDataSet_Data data;

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

		public ConfigDataSet_Data Data
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

		public class ConfigDataSet_Data
		{

			private int? roleConfigStatus;

			private int? channelType;

			private int? judgeType;

			private long? setId;

			private ConfigDataSet_RuleInfo ruleInfo;

			public int? RoleConfigStatus
			{
				get
				{
					return roleConfigStatus;
				}
				set	
				{
					roleConfigStatus = value;
				}
			}

			public int? ChannelType
			{
				get
				{
					return channelType;
				}
				set	
				{
					channelType = value;
				}
			}

			public int? JudgeType
			{
				get
				{
					return judgeType;
				}
				set	
				{
					judgeType = value;
				}
			}

			public long? SetId
			{
				get
				{
					return setId;
				}
				set	
				{
					setId = value;
				}
			}

			public ConfigDataSet_RuleInfo RuleInfo
			{
				get
				{
					return ruleInfo;
				}
				set	
				{
					ruleInfo = value;
				}
			}

			public class ConfigDataSet_RuleInfo
			{

				private List<ConfigDataSet_ConditionBasicInfo> conditions;

				private List<ConfigDataSet_RuleBasicInfo> rules;

				public List<ConfigDataSet_ConditionBasicInfo> Conditions
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

				public List<ConfigDataSet_RuleBasicInfo> Rules
				{
					get
					{
						return rules;
					}
					set	
					{
						rules = value;
					}
				}

				public class ConfigDataSet_ConditionBasicInfo
				{

					private string lambda;

					private string cid;

					private List<ConfigDataSet_OperatorBasicInfo> operators;

					private ConfigDataSet_CheckRange checkRange;

					public string Lambda
					{
						get
						{
							return lambda;
						}
						set	
						{
							lambda = value;
						}
					}

					public string Cid
					{
						get
						{
							return cid;
						}
						set	
						{
							cid = value;
						}
					}

					public List<ConfigDataSet_OperatorBasicInfo> Operators
					{
						get
						{
							return operators;
						}
						set	
						{
							operators = value;
						}
					}

					public ConfigDataSet_CheckRange CheckRange
					{
						get
						{
							return checkRange;
						}
						set	
						{
							checkRange = value;
						}
					}

					public class ConfigDataSet_OperatorBasicInfo
					{

						private string type;

						private string oid;

						private ConfigDataSet_Param param;

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

						public string Oid
						{
							get
							{
								return oid;
							}
							set	
							{
								oid = value;
							}
						}

						public ConfigDataSet_Param Param
						{
							get
							{
								return param;
							}
							set	
							{
								param = value;
							}
						}

						public class ConfigDataSet_Param
						{

							private bool? inSentence;

							private List<string> keywords;

							public bool? InSentence
							{
								get
								{
									return inSentence;
								}
								set	
								{
									inSentence = value;
								}
							}

							public List<string> Keywords
							{
								get
								{
									return keywords;
								}
								set	
								{
									keywords = value;
								}
							}
						}
					}

					public class ConfigDataSet_CheckRange
					{

						private string role;

						private int? roleId;

						private ConfigDataSet_Anchor anchor;

						private ConfigDataSet_Range range;

						public string Role
						{
							get
							{
								return role;
							}
							set	
							{
								role = value;
							}
						}

						public int? RoleId
						{
							get
							{
								return roleId;
							}
							set	
							{
								roleId = value;
							}
						}

						public ConfigDataSet_Anchor Anchor
						{
							get
							{
								return anchor;
							}
							set	
							{
								anchor = value;
							}
						}

						public ConfigDataSet_Range Range
						{
							get
							{
								return range;
							}
							set	
							{
								range = value;
							}
						}

						public class ConfigDataSet_Anchor
						{

							private int? hitTime;

							private string cid;

							private string location;

							public int? HitTime
							{
								get
								{
									return hitTime;
								}
								set	
								{
									hitTime = value;
								}
							}

							public string Cid
							{
								get
								{
									return cid;
								}
								set	
								{
									cid = value;
								}
							}

							public string Location
							{
								get
								{
									return location;
								}
								set	
								{
									location = value;
								}
							}
						}

						public class ConfigDataSet_Range
						{

							private int? to;

							private int? from;

							public int? To
							{
								get
								{
									return to;
								}
								set	
								{
									to = value;
								}
							}

							public int? From
							{
								get
								{
									return from;
								}
								set	
								{
									from = value;
								}
							}
						}
					}
				}

				public class ConfigDataSet_RuleBasicInfo
				{

					private string lambda;

					private int? externalProperty;

					private string rid;

					public string Lambda
					{
						get
						{
							return lambda;
						}
						set	
						{
							lambda = value;
						}
					}

					public int? ExternalProperty
					{
						get
						{
							return externalProperty;
						}
						set	
						{
							externalProperty = value;
						}
					}

					public string Rid
					{
						get
						{
							return rid;
						}
						set	
						{
							rid = value;
						}
					}
				}
			}
		}
	}
}
