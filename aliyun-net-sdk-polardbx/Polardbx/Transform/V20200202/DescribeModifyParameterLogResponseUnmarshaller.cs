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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeModifyParameterLogResponseUnmarshaller
    {
        public static DescribeModifyParameterLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeModifyParameterLogResponse describeModifyParameterLogResponse = new DescribeModifyParameterLogResponse();

			describeModifyParameterLogResponse.HttpResponse = _ctx.HttpResponse;
			describeModifyParameterLogResponse.RequestId = _ctx.StringValue("DescribeModifyParameterLog.RequestId");
			describeModifyParameterLogResponse.PageNumber = _ctx.IntegerValue("DescribeModifyParameterLog.PageNumber");
			describeModifyParameterLogResponse.PageSize = _ctx.IntegerValue("DescribeModifyParameterLog.PageSize");

			List<DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ChangeLog> describeModifyParameterLogResponse_changeLogs = new List<DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ChangeLog>();
			for (int i = 0; i < _ctx.Length("DescribeModifyParameterLog.ChangeLogs.Length"); i++) {
				DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ChangeLog changeLog = new DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ChangeLog();
				changeLog.ParameterName = _ctx.StringValue("DescribeModifyParameterLog.ChangeLogs["+ i +"].ParameterName");
				changeLog.OldParameterValue = _ctx.StringValue("DescribeModifyParameterLog.ChangeLogs["+ i +"].OldParameterValue");
				changeLog.NewParameterValue = _ctx.StringValue("DescribeModifyParameterLog.ChangeLogs["+ i +"].NewParameterValue");
				changeLog.Synced = _ctx.IntegerValue("DescribeModifyParameterLog.ChangeLogs["+ i +"].Synced");
				changeLog.ChangeTime = _ctx.StringValue("DescribeModifyParameterLog.ChangeLogs["+ i +"].ChangeTime");

				describeModifyParameterLogResponse_changeLogs.Add(changeLog);
			}
			describeModifyParameterLogResponse.ChangeLogs = describeModifyParameterLogResponse_changeLogs;
        
			return describeModifyParameterLogResponse;
        }
    }
}
