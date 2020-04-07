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

namespace Aliyun.Acs.ARMS.Model.V20190808
{
	public class SearchAlertRulesResponse : AcsResponse
	{

		private string requestId;

		private SearchAlertRules_PageBean pageBean;

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

		public SearchAlertRules_PageBean PageBean
		{
			get
			{
				return pageBean;
			}
			set	
			{
				pageBean = value;
			}
		}

		public class SearchAlertRules_PageBean
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<SearchAlertRules_AlertRuleEntity> alertRules;

			public int? TotalCount
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

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
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

			public List<SearchAlertRules_AlertRuleEntity> AlertRules
			{
				get
				{
					return alertRules;
				}
				set	
				{
					alertRules = value;
				}
			}

			public class SearchAlertRules_AlertRuleEntity
			{

				private string alertTitle;

				private string alertLevel;

				private int? alertType;

				private int? alertVersion;

				private string config;

				private string contactGroupIdList;

				private long? createTime;

				private long? id;

				private string regionId;

				private string status;

				private long? taskId;

				private string taskStatus;

				private long? updateTime;

				private string userId;

				private List<string> alertWays;

				private SearchAlertRules_AlarmContext alarmContext;

				private SearchAlertRules_AlertRule alertRule;

				private SearchAlertRules_MetricParam metricParam;

				private SearchAlertRules_Notice notice;

				public string AlertTitle
				{
					get
					{
						return alertTitle;
					}
					set	
					{
						alertTitle = value;
					}
				}

				public string AlertLevel
				{
					get
					{
						return alertLevel;
					}
					set	
					{
						alertLevel = value;
					}
				}

				public int? AlertType
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

				public int? AlertVersion
				{
					get
					{
						return alertVersion;
					}
					set	
					{
						alertVersion = value;
					}
				}

				public string Config
				{
					get
					{
						return config;
					}
					set	
					{
						config = value;
					}
				}

				public string ContactGroupIdList
				{
					get
					{
						return contactGroupIdList;
					}
					set	
					{
						contactGroupIdList = value;
					}
				}

				public long? CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
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

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				public string Status
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

				public long? TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
					}
				}

				public string TaskStatus
				{
					get
					{
						return taskStatus;
					}
					set	
					{
						taskStatus = value;
					}
				}

				public long? UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public List<string> AlertWays
				{
					get
					{
						return alertWays;
					}
					set	
					{
						alertWays = value;
					}
				}

				public SearchAlertRules_AlarmContext AlarmContext
				{
					get
					{
						return alarmContext;
					}
					set	
					{
						alarmContext = value;
					}
				}

				public SearchAlertRules_AlertRule AlertRule
				{
					get
					{
						return alertRule;
					}
					set	
					{
						alertRule = value;
					}
				}

				public SearchAlertRules_MetricParam MetricParam
				{
					get
					{
						return metricParam;
					}
					set	
					{
						metricParam = value;
					}
				}

				public SearchAlertRules_Notice Notice
				{
					get
					{
						return notice;
					}
					set	
					{
						notice = value;
					}
				}

				public class SearchAlertRules_AlarmContext
				{

					private string alarmContentTemplate;

					private string alarmContentSubTitle;

					public string AlarmContentTemplate
					{
						get
						{
							return alarmContentTemplate;
						}
						set	
						{
							alarmContentTemplate = value;
						}
					}

					public string AlarmContentSubTitle
					{
						get
						{
							return alarmContentSubTitle;
						}
						set	
						{
							alarmContentSubTitle = value;
						}
					}
				}

				public class SearchAlertRules_AlertRule
				{

					private string _operator;

					private List<SearchAlertRules_Rule> rules;

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

					public List<SearchAlertRules_Rule> Rules
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

					public class SearchAlertRules_Rule
					{

						private string aggregates;

						private string alias;

						private string measure;

						private int? nValue;

						private string _operator;

						private float? _value;

						public string Aggregates
						{
							get
							{
								return aggregates;
							}
							set	
							{
								aggregates = value;
							}
						}

						public string Alias
						{
							get
							{
								return alias;
							}
							set	
							{
								alias = value;
							}
						}

						public string Measure
						{
							get
							{
								return measure;
							}
							set	
							{
								measure = value;
							}
						}

						public int? NValue
						{
							get
							{
								return nValue;
							}
							set	
							{
								nValue = value;
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

						public float? _Value
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
					}
				}

				public class SearchAlertRules_MetricParam
				{

					private string appGroupId;

					private string appId;

					private string pid;

					private string type;

					private List<SearchAlertRules_Dimension> dimensions;

					public string AppGroupId
					{
						get
						{
							return appGroupId;
						}
						set	
						{
							appGroupId = value;
						}
					}

					public string AppId
					{
						get
						{
							return appId;
						}
						set	
						{
							appId = value;
						}
					}

					public string Pid
					{
						get
						{
							return pid;
						}
						set	
						{
							pid = value;
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

					public List<SearchAlertRules_Dimension> Dimensions
					{
						get
						{
							return dimensions;
						}
						set	
						{
							dimensions = value;
						}
					}

					public class SearchAlertRules_Dimension
					{

						private string key;

						private string type;

						private string _value;

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
					}
				}

				public class SearchAlertRules_Notice
				{

					private long? endTime;

					private long? noticeEndTime;

					private long? noticeStartTime;

					private long? startTime;

					public long? EndTime
					{
						get
						{
							return endTime;
						}
						set	
						{
							endTime = value;
						}
					}

					public long? NoticeEndTime
					{
						get
						{
							return noticeEndTime;
						}
						set	
						{
							noticeEndTime = value;
						}
					}

					public long? NoticeStartTime
					{
						get
						{
							return noticeStartTime;
						}
						set	
						{
							noticeStartTime = value;
						}
					}

					public long? StartTime
					{
						get
						{
							return startTime;
						}
						set	
						{
							startTime = value;
						}
					}
				}
			}
		}
	}
}
