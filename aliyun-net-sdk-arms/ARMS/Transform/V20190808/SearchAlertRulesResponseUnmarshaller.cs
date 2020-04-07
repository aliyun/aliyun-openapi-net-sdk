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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.ARMS.Model.V20190808;

namespace Aliyun.Acs.ARMS.Transform.V20190808
{
    public class SearchAlertRulesResponseUnmarshaller
    {
        public static SearchAlertRulesResponse Unmarshall(UnmarshallerContext context)
        {
			SearchAlertRulesResponse searchAlertRulesResponse = new SearchAlertRulesResponse();

			searchAlertRulesResponse.HttpResponse = context.HttpResponse;
			searchAlertRulesResponse.RequestId = context.StringValue("SearchAlertRules.RequestId");

			SearchAlertRulesResponse.SearchAlertRules_PageBean pageBean = new SearchAlertRulesResponse.SearchAlertRules_PageBean();
			pageBean.TotalCount = context.IntegerValue("SearchAlertRules.PageBean.TotalCount");
			pageBean.PageNumber = context.IntegerValue("SearchAlertRules.PageBean.PageNumber");
			pageBean.PageSize = context.IntegerValue("SearchAlertRules.PageBean.PageSize");

			List<SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity> pageBean_alertRules = new List<SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity>();
			for (int i = 0; i < context.Length("SearchAlertRules.PageBean.AlertRules.Length"); i++) {
				SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity alertRuleEntity = new SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity();
				alertRuleEntity.AlertTitle = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertTitle");
				alertRuleEntity.AlertLevel = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertLevel");
				alertRuleEntity.AlertType = context.IntegerValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertType");
				alertRuleEntity.AlertVersion = context.IntegerValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertVersion");
				alertRuleEntity.Config = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].Config");
				alertRuleEntity.ContactGroupIdList = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].ContactGroupIdList");
				alertRuleEntity.CreateTime = context.LongValue("SearchAlertRules.PageBean.AlertRules["+ i +"].CreateTime");
				alertRuleEntity.Id = context.LongValue("SearchAlertRules.PageBean.AlertRules["+ i +"].Id");
				alertRuleEntity.RegionId = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].RegionId");
				alertRuleEntity.Status = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].Status");
				alertRuleEntity.TaskId = context.LongValue("SearchAlertRules.PageBean.AlertRules["+ i +"].TaskId");
				alertRuleEntity.TaskStatus = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].TaskStatus");
				alertRuleEntity.UpdateTime = context.LongValue("SearchAlertRules.PageBean.AlertRules["+ i +"].UpdateTime");
				alertRuleEntity.UserId = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].UserId");

				List<string> alertRuleEntity_alertWays = new List<string>();
				for (int j = 0; j < context.Length("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertWays.Length"); j++) {
					alertRuleEntity_alertWays.Add(context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertWays["+ j +"]"));
				}
				alertRuleEntity.AlertWays = alertRuleEntity_alertWays;

				SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_AlarmContext alarmContext = new SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_AlarmContext();
				alarmContext.AlarmContentTemplate = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlarmContext.AlarmContentTemplate");
				alarmContext.AlarmContentSubTitle = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlarmContext.AlarmContentSubTitle");
				alertRuleEntity.AlarmContext = alarmContext;

				SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_AlertRule alertRule = new SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_AlertRule();
				alertRule._Operator = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertRule.Operator");

				List<SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_AlertRule.SearchAlertRules_Rule> alertRule_rules = new List<SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_AlertRule.SearchAlertRules_Rule>();
				for (int j = 0; j < context.Length("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertRule.Rules.Length"); j++) {
					SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_AlertRule.SearchAlertRules_Rule rule = new SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_AlertRule.SearchAlertRules_Rule();
					rule.Aggregates = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertRule.Rules["+ j +"].Aggregates");
					rule.Alias = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertRule.Rules["+ j +"].Alias");
					rule.Measure = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertRule.Rules["+ j +"].Measure");
					rule.NValue = context.IntegerValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertRule.Rules["+ j +"].NValue");
					rule._Operator = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertRule.Rules["+ j +"].Operator");
					rule._Value = context.FloatValue("SearchAlertRules.PageBean.AlertRules["+ i +"].AlertRule.Rules["+ j +"].Value");

					alertRule_rules.Add(rule);
				}
				alertRule.Rules = alertRule_rules;
				alertRuleEntity.AlertRule = alertRule;

				SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_MetricParam metricParam = new SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_MetricParam();
				metricParam.AppGroupId = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].MetricParam.AppGroupId");
				metricParam.AppId = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].MetricParam.AppId");
				metricParam.Pid = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].MetricParam.Pid");
				metricParam.Type = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].MetricParam.Type");

				List<SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_MetricParam.SearchAlertRules_Dimension> metricParam_dimensions = new List<SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_MetricParam.SearchAlertRules_Dimension>();
				for (int j = 0; j < context.Length("SearchAlertRules.PageBean.AlertRules["+ i +"].MetricParam.Dimensions.Length"); j++) {
					SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_MetricParam.SearchAlertRules_Dimension dimension = new SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_MetricParam.SearchAlertRules_Dimension();
					dimension.Key = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].MetricParam.Dimensions["+ j +"].Key");
					dimension.Type = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].MetricParam.Dimensions["+ j +"].Type");
					dimension._Value = context.StringValue("SearchAlertRules.PageBean.AlertRules["+ i +"].MetricParam.Dimensions["+ j +"].Value");

					metricParam_dimensions.Add(dimension);
				}
				metricParam.Dimensions = metricParam_dimensions;
				alertRuleEntity.MetricParam = metricParam;

				SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_Notice notice = new SearchAlertRulesResponse.SearchAlertRules_PageBean.SearchAlertRules_AlertRuleEntity.SearchAlertRules_Notice();
				notice.EndTime = context.LongValue("SearchAlertRules.PageBean.AlertRules["+ i +"].Notice.EndTime");
				notice.NoticeEndTime = context.LongValue("SearchAlertRules.PageBean.AlertRules["+ i +"].Notice.NoticeEndTime");
				notice.NoticeStartTime = context.LongValue("SearchAlertRules.PageBean.AlertRules["+ i +"].Notice.NoticeStartTime");
				notice.StartTime = context.LongValue("SearchAlertRules.PageBean.AlertRules["+ i +"].Notice.StartTime");
				alertRuleEntity.Notice = notice;

				pageBean_alertRules.Add(alertRuleEntity);
			}
			pageBean.AlertRules = pageBean_alertRules;
			searchAlertRulesResponse.PageBean = pageBean;
        
			return searchAlertRulesResponse;
        }
    }
}
