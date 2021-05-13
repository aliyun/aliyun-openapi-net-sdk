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
using Aliyun.Acs.quotas.Model.V20200510;

namespace Aliyun.Acs.quotas.Transform.V20200510
{
    public class ListQuotaAlarmsResponseUnmarshaller
    {
        public static ListQuotaAlarmsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQuotaAlarmsResponse listQuotaAlarmsResponse = new ListQuotaAlarmsResponse();

			listQuotaAlarmsResponse.HttpResponse = _ctx.HttpResponse;
			listQuotaAlarmsResponse.TotalCount = _ctx.IntegerValue("ListQuotaAlarms.TotalCount");
			listQuotaAlarmsResponse.RequestId = _ctx.StringValue("ListQuotaAlarms.RequestId");
			listQuotaAlarmsResponse.NextToken = _ctx.StringValue("ListQuotaAlarms.NextToken");
			listQuotaAlarmsResponse.MaxResults = _ctx.IntegerValue("ListQuotaAlarms.MaxResults");

			List<ListQuotaAlarmsResponse.ListQuotaAlarms_QuotaAlarm> listQuotaAlarmsResponse_quotaAlarms = new List<ListQuotaAlarmsResponse.ListQuotaAlarms_QuotaAlarm>();
			for (int i = 0; i < _ctx.Length("ListQuotaAlarms.QuotaAlarms.Length"); i++) {
				ListQuotaAlarmsResponse.ListQuotaAlarms_QuotaAlarm quotaAlarm = new ListQuotaAlarmsResponse.ListQuotaAlarms_QuotaAlarm();
				quotaAlarm.AlarmId = _ctx.StringValue("ListQuotaAlarms.QuotaAlarms["+ i +"].AlarmId");
				quotaAlarm.QuotaDimensions = _ctx.StringValue("ListQuotaAlarms.QuotaAlarms["+ i +"].QuotaDimensions");
				quotaAlarm.ThresholdPercent = _ctx.FloatValue("ListQuotaAlarms.QuotaAlarms["+ i +"].ThresholdPercent");
				quotaAlarm.ProductCode = _ctx.StringValue("ListQuotaAlarms.QuotaAlarms["+ i +"].ProductCode");
				quotaAlarm.CreateTime = _ctx.StringValue("ListQuotaAlarms.QuotaAlarms["+ i +"].CreateTime");
				quotaAlarm.WebHook = _ctx.StringValue("ListQuotaAlarms.QuotaAlarms["+ i +"].WebHook");
				quotaAlarm.QuotaUsage = _ctx.FloatValue("ListQuotaAlarms.QuotaAlarms["+ i +"].QuotaUsage");
				quotaAlarm.ExceedThreshold = _ctx.BooleanValue("ListQuotaAlarms.QuotaAlarms["+ i +"].ExceedThreshold");
				quotaAlarm.QuotaActionCode = _ctx.StringValue("ListQuotaAlarms.QuotaAlarms["+ i +"].QuotaActionCode");
				quotaAlarm.QuotaValue = _ctx.FloatValue("ListQuotaAlarms.QuotaAlarms["+ i +"].QuotaValue");
				quotaAlarm.AlarmName = _ctx.StringValue("ListQuotaAlarms.QuotaAlarms["+ i +"].AlarmName");
				quotaAlarm.NotifyTarget = _ctx.StringValue("ListQuotaAlarms.QuotaAlarms["+ i +"].NotifyTarget");
				quotaAlarm.Threshold = _ctx.FloatValue("ListQuotaAlarms.QuotaAlarms["+ i +"].Threshold");
				quotaAlarm.ThresholdType = _ctx.StringValue("ListQuotaAlarms.QuotaAlarms["+ i +"].ThresholdType");

				List<string> quotaAlarm_notifyChannels = new List<string>();
				for (int j = 0; j < _ctx.Length("ListQuotaAlarms.QuotaAlarms["+ i +"].NotifyChannels.Length"); j++) {
					quotaAlarm_notifyChannels.Add(_ctx.StringValue("ListQuotaAlarms.QuotaAlarms["+ i +"].NotifyChannels["+ j +"]"));
				}
				quotaAlarm.NotifyChannels = quotaAlarm_notifyChannels;

				listQuotaAlarmsResponse_quotaAlarms.Add(quotaAlarm);
			}
			listQuotaAlarmsResponse.QuotaAlarms = listQuotaAlarmsResponse_quotaAlarms;
        
			return listQuotaAlarmsResponse;
        }
    }
}
