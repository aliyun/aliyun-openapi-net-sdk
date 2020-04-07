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
    public class SearchAlertHistoriesResponseUnmarshaller
    {
        public static SearchAlertHistoriesResponse Unmarshall(UnmarshallerContext context)
        {
			SearchAlertHistoriesResponse searchAlertHistoriesResponse = new SearchAlertHistoriesResponse();

			searchAlertHistoriesResponse.HttpResponse = context.HttpResponse;
			searchAlertHistoriesResponse.RequestId = context.StringValue("SearchAlertHistories.RequestId");

			SearchAlertHistoriesResponse.SearchAlertHistories_PageBean pageBean = new SearchAlertHistoriesResponse.SearchAlertHistories_PageBean();
			pageBean.TotalCount = context.IntegerValue("SearchAlertHistories.PageBean.TotalCount");
			pageBean.PageNumber = context.IntegerValue("SearchAlertHistories.PageBean.PageNumber");
			pageBean.PageSize = context.IntegerValue("SearchAlertHistories.PageBean.PageSize");

			List<SearchAlertHistoriesResponse.SearchAlertHistories_PageBean.SearchAlertHistories_AlarmHistory> pageBean_alarmHistories = new List<SearchAlertHistoriesResponse.SearchAlertHistories_PageBean.SearchAlertHistories_AlarmHistory>();
			for (int i = 0; i < context.Length("SearchAlertHistories.PageBean.AlarmHistories.Length"); i++) {
				SearchAlertHistoriesResponse.SearchAlertHistories_PageBean.SearchAlertHistories_AlarmHistory alarmHistory = new SearchAlertHistoriesResponse.SearchAlertHistories_PageBean.SearchAlertHistories_AlarmHistory();
				alarmHistory.Id = context.LongValue("SearchAlertHistories.PageBean.AlarmHistories["+ i +"].Id");
				alarmHistory.StrategyId = context.StringValue("SearchAlertHistories.PageBean.AlarmHistories["+ i +"].StrategyId");
				alarmHistory.UserId = context.StringValue("SearchAlertHistories.PageBean.AlarmHistories["+ i +"].UserId");
				alarmHistory.Target = context.StringValue("SearchAlertHistories.PageBean.AlarmHistories["+ i +"].Target");
				alarmHistory.Phones = context.StringValue("SearchAlertHistories.PageBean.AlarmHistories["+ i +"].Phones");
				alarmHistory.Emails = context.StringValue("SearchAlertHistories.PageBean.AlarmHistories["+ i +"].Emails");
				alarmHistory.AlarmTime = context.LongValue("SearchAlertHistories.PageBean.AlarmHistories["+ i +"].AlarmTime");
				alarmHistory.AlarmType = context.IntegerValue("SearchAlertHistories.PageBean.AlarmHistories["+ i +"].AlarmType");
				alarmHistory.AlarmResponseCode = context.IntegerValue("SearchAlertHistories.PageBean.AlarmHistories["+ i +"].AlarmResponseCode");
				alarmHistory.AlarmContent = context.StringValue("SearchAlertHistories.PageBean.AlarmHistories["+ i +"].AlarmContent");
				alarmHistory.AlarmSources = context.StringValue("SearchAlertHistories.PageBean.AlarmHistories["+ i +"].AlarmSources");

				pageBean_alarmHistories.Add(alarmHistory);
			}
			pageBean.AlarmHistories = pageBean_alarmHistories;
			searchAlertHistoriesResponse.PageBean = pageBean;
        
			return searchAlertHistoriesResponse;
        }
    }
}
