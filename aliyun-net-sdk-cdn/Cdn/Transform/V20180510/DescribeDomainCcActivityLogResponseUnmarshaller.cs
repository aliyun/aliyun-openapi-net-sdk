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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeDomainCcActivityLogResponseUnmarshaller
    {
        public static DescribeDomainCcActivityLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainCcActivityLogResponse describeDomainCcActivityLogResponse = new DescribeDomainCcActivityLogResponse();

			describeDomainCcActivityLogResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainCcActivityLogResponse.PageIndex = _ctx.LongValue("DescribeDomainCcActivityLog.PageIndex");
			describeDomainCcActivityLogResponse.RequestId = _ctx.StringValue("DescribeDomainCcActivityLog.RequestId");
			describeDomainCcActivityLogResponse.PageSize = _ctx.LongValue("DescribeDomainCcActivityLog.PageSize");
			describeDomainCcActivityLogResponse.Total = _ctx.LongValue("DescribeDomainCcActivityLog.Total");

			List<DescribeDomainCcActivityLogResponse.DescribeDomainCcActivityLog_LogInfo> describeDomainCcActivityLogResponse_activityLog = new List<DescribeDomainCcActivityLogResponse.DescribeDomainCcActivityLog_LogInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDomainCcActivityLog.ActivityLog.Length"); i++) {
				DescribeDomainCcActivityLogResponse.DescribeDomainCcActivityLog_LogInfo logInfo = new DescribeDomainCcActivityLogResponse.DescribeDomainCcActivityLog_LogInfo();
				logInfo._Value = _ctx.StringValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].Value");
				logInfo.Ttl = _ctx.LongValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].Ttl");
				logInfo.Action = _ctx.StringValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].Action");
				logInfo.TriggerObject = _ctx.StringValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].TriggerObject");
				logInfo.TimeStamp = _ctx.StringValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].TimeStamp");
				logInfo.DomainName = _ctx.StringValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].DomainName");
				logInfo.RuleName = _ctx.StringValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].RuleName");

				describeDomainCcActivityLogResponse_activityLog.Add(logInfo);
			}
			describeDomainCcActivityLogResponse.ActivityLog = describeDomainCcActivityLogResponse_activityLog;
        
			return describeDomainCcActivityLogResponse;
        }
    }
}
