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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeModifyParameterLogResponseUnmarshaller
    {
        public static DescribeModifyParameterLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeModifyParameterLogResponse describeModifyParameterLogResponse = new DescribeModifyParameterLogResponse();

			describeModifyParameterLogResponse.HttpResponse = _ctx.HttpResponse;
			describeModifyParameterLogResponse.RequestId = _ctx.StringValue("DescribeModifyParameterLog.RequestId");
			describeModifyParameterLogResponse.Engine = _ctx.StringValue("DescribeModifyParameterLog.Engine");
			describeModifyParameterLogResponse.DBInstanceId = _ctx.StringValue("DescribeModifyParameterLog.DBInstanceId");
			describeModifyParameterLogResponse.EngineVersion = _ctx.StringValue("DescribeModifyParameterLog.EngineVersion");
			describeModifyParameterLogResponse.TotalRecordCount = _ctx.IntegerValue("DescribeModifyParameterLog.TotalRecordCount");
			describeModifyParameterLogResponse.PageNumber = _ctx.IntegerValue("DescribeModifyParameterLog.PageNumber");
			describeModifyParameterLogResponse.PageRecordCount = _ctx.IntegerValue("DescribeModifyParameterLog.PageRecordCount");

			List<DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ParameterChangeLog> describeModifyParameterLogResponse_items = new List<DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ParameterChangeLog>();
			for (int i = 0; i < _ctx.Length("DescribeModifyParameterLog.Items.Length"); i++) {
				DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ParameterChangeLog parameterChangeLog = new DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ParameterChangeLog();
				parameterChangeLog.ModifyTime = _ctx.StringValue("DescribeModifyParameterLog.Items["+ i +"].ModifyTime");
				parameterChangeLog.OldParameterValue = _ctx.StringValue("DescribeModifyParameterLog.Items["+ i +"].OldParameterValue");
				parameterChangeLog.NewParameterValue = _ctx.StringValue("DescribeModifyParameterLog.Items["+ i +"].NewParameterValue");
				parameterChangeLog.ParameterName = _ctx.StringValue("DescribeModifyParameterLog.Items["+ i +"].ParameterName");
				parameterChangeLog.Status = _ctx.StringValue("DescribeModifyParameterLog.Items["+ i +"].Status");

				describeModifyParameterLogResponse_items.Add(parameterChangeLog);
			}
			describeModifyParameterLogResponse.Items = describeModifyParameterLogResponse_items;
        
			return describeModifyParameterLogResponse;
        }
    }
}
