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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeSystemLogResponseUnmarshaller
    {
        public static DescribeSystemLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSystemLogResponse describeSystemLogResponse = new DescribeSystemLogResponse();

			describeSystemLogResponse.HttpResponse = _ctx.HttpResponse;
			describeSystemLogResponse.Total = _ctx.LongValue("DescribeSystemLog.Total");
			describeSystemLogResponse.RequestId = _ctx.StringValue("DescribeSystemLog.RequestId");

			List<DescribeSystemLogResponse.DescribeSystemLog_SystemLogItem> describeSystemLogResponse_systemLog = new List<DescribeSystemLogResponse.DescribeSystemLog_SystemLogItem>();
			for (int i = 0; i < _ctx.Length("DescribeSystemLog.SystemLog.Length"); i++) {
				DescribeSystemLogResponse.DescribeSystemLog_SystemLogItem systemLogItem = new DescribeSystemLogResponse.DescribeSystemLog_SystemLogItem();
				systemLogItem.Status = _ctx.IntegerValue("DescribeSystemLog.SystemLog["+ i +"].Status");
				systemLogItem.EntityType = _ctx.IntegerValue("DescribeSystemLog.SystemLog["+ i +"].EntityType");
				systemLogItem.EntityObject = _ctx.StringValue("DescribeSystemLog.SystemLog["+ i +"].EntityObject");
				systemLogItem.GmtCreate = _ctx.LongValue("DescribeSystemLog.SystemLog["+ i +"].GmtCreate");
				systemLogItem.OpAction = _ctx.IntegerValue("DescribeSystemLog.SystemLog["+ i +"].OpAction");
				systemLogItem.GmtModified = _ctx.LongValue("DescribeSystemLog.SystemLog["+ i +"].GmtModified");
				systemLogItem.OpAccount = _ctx.StringValue("DescribeSystemLog.SystemLog["+ i +"].OpAccount");
				systemLogItem.OpDesc = _ctx.StringValue("DescribeSystemLog.SystemLog["+ i +"].OpDesc");

				describeSystemLogResponse_systemLog.Add(systemLogItem);
			}
			describeSystemLogResponse.SystemLog = describeSystemLogResponse_systemLog;
        
			return describeSystemLogResponse;
        }
    }
}
