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
        public static DescribeDomainCcActivityLogResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainCcActivityLogResponse describeDomainCcActivityLogResponse = new DescribeDomainCcActivityLogResponse();

			describeDomainCcActivityLogResponse.HttpResponse = context.HttpResponse;
			describeDomainCcActivityLogResponse.RequestId = context.StringValue("DescribeDomainCcActivityLog.RequestId");
			describeDomainCcActivityLogResponse.PageIndex = context.LongValue("DescribeDomainCcActivityLog.PageIndex");
			describeDomainCcActivityLogResponse.PageSize = context.LongValue("DescribeDomainCcActivityLog.PageSize");
			describeDomainCcActivityLogResponse.Total = context.LongValue("DescribeDomainCcActivityLog.Total");

			List<DescribeDomainCcActivityLogResponse.DescribeDomainCcActivityLog_LogInfo> describeDomainCcActivityLogResponse_activityLog = new List<DescribeDomainCcActivityLogResponse.DescribeDomainCcActivityLog_LogInfo>();
			for (int i = 0; i < context.Length("DescribeDomainCcActivityLog.ActivityLog.Length"); i++) {
				DescribeDomainCcActivityLogResponse.DescribeDomainCcActivityLog_LogInfo logInfo = new DescribeDomainCcActivityLogResponse.DescribeDomainCcActivityLog_LogInfo();
				logInfo.TimeStamp = context.StringValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].TimeStamp");
				logInfo._Value = context.StringValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].Value");
				logInfo.TriggerObject = context.StringValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].TriggerObject");
				logInfo.DomainName = context.StringValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].DomainName");
				logInfo.Ttl = context.LongValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].Ttl");
				logInfo.Action = context.StringValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].Action");
				logInfo.RuleName = context.StringValue("DescribeDomainCcActivityLog.ActivityLog["+ i +"].RuleName");

				describeDomainCcActivityLogResponse_activityLog.Add(logInfo);
			}
			describeDomainCcActivityLogResponse.ActivityLog = describeDomainCcActivityLogResponse_activityLog;
        
			return describeDomainCcActivityLogResponse;
        }
    }
}
