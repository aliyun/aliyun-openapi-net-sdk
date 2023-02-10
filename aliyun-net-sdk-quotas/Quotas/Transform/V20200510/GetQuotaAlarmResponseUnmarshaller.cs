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
    public class GetQuotaAlarmResponseUnmarshaller
    {
        public static GetQuotaAlarmResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetQuotaAlarmResponse getQuotaAlarmResponse = new GetQuotaAlarmResponse();

			getQuotaAlarmResponse.HttpResponse = _ctx.HttpResponse;
			getQuotaAlarmResponse.RequestId = _ctx.StringValue("GetQuotaAlarm.RequestId");

			GetQuotaAlarmResponse.GetQuotaAlarm_QuotaAlarm quotaAlarm = new GetQuotaAlarmResponse.GetQuotaAlarm_QuotaAlarm();
			quotaAlarm.ThresholdPercent = _ctx.FloatValue("GetQuotaAlarm.QuotaAlarm.ThresholdPercent");
			quotaAlarm.ThresholdType = _ctx.StringValue("GetQuotaAlarm.QuotaAlarm.ThresholdType");
			quotaAlarm.QuotaDimension = _ctx.StringValue("GetQuotaAlarm.QuotaAlarm.QuotaDimension");
			quotaAlarm.CreateTime = _ctx.StringValue("GetQuotaAlarm.QuotaAlarm.CreateTime");
			quotaAlarm.QuotaActionCode = _ctx.StringValue("GetQuotaAlarm.QuotaAlarm.QuotaActionCode");
			quotaAlarm.AlarmName = _ctx.StringValue("GetQuotaAlarm.QuotaAlarm.AlarmName");
			quotaAlarm.NotifyTarget = _ctx.StringValue("GetQuotaAlarm.QuotaAlarm.NotifyTarget");
			quotaAlarm.QuotaUsage = _ctx.FloatValue("GetQuotaAlarm.QuotaAlarm.QuotaUsage");
			quotaAlarm.QuotaValue = _ctx.FloatValue("GetQuotaAlarm.QuotaAlarm.QuotaValue");
			quotaAlarm.AlarmId = _ctx.StringValue("GetQuotaAlarm.QuotaAlarm.AlarmId");
			quotaAlarm.Threshold = _ctx.FloatValue("GetQuotaAlarm.QuotaAlarm.Threshold");
			quotaAlarm.ProductCode = _ctx.StringValue("GetQuotaAlarm.QuotaAlarm.ProductCode");

			List<string> quotaAlarm_notifyChannels = new List<string>();
			for (int i = 0; i < _ctx.Length("GetQuotaAlarm.QuotaAlarm.NotifyChannels.Length"); i++) {
				quotaAlarm_notifyChannels.Add(_ctx.StringValue("GetQuotaAlarm.QuotaAlarm.NotifyChannels["+ i +"]"));
			}
			quotaAlarm.NotifyChannels = quotaAlarm_notifyChannels;
			getQuotaAlarmResponse.QuotaAlarm = quotaAlarm;
        
			return getQuotaAlarmResponse;
        }
    }
}
