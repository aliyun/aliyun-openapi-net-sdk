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
        public static DescribeModifyParameterLogResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeModifyParameterLogResponse describeModifyParameterLogResponse = new DescribeModifyParameterLogResponse();

			describeModifyParameterLogResponse.HttpResponse = context.HttpResponse;
			describeModifyParameterLogResponse.RequestId = context.StringValue("DescribeModifyParameterLog.RequestId");
			describeModifyParameterLogResponse.Engine = context.StringValue("DescribeModifyParameterLog.Engine");
			describeModifyParameterLogResponse.DBInstanceId = context.StringValue("DescribeModifyParameterLog.DBInstanceId");
			describeModifyParameterLogResponse.EngineVersion = context.StringValue("DescribeModifyParameterLog.EngineVersion");
			describeModifyParameterLogResponse.TotalRecordCount = context.IntegerValue("DescribeModifyParameterLog.TotalRecordCount");
			describeModifyParameterLogResponse.PageNumber = context.IntegerValue("DescribeModifyParameterLog.PageNumber");
			describeModifyParameterLogResponse.PageRecordCount = context.IntegerValue("DescribeModifyParameterLog.PageRecordCount");

			List<DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ParameterChangeLog> describeModifyParameterLogResponse_items = new List<DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ParameterChangeLog>();
			for (int i = 0; i < context.Length("DescribeModifyParameterLog.Items.Length"); i++) {
				DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ParameterChangeLog parameterChangeLog = new DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ParameterChangeLog();
				parameterChangeLog.ModifyTime = context.StringValue("DescribeModifyParameterLog.Items["+ i +"].ModifyTime");
				parameterChangeLog.OldParameterValue = context.StringValue("DescribeModifyParameterLog.Items["+ i +"].OldParameterValue");
				parameterChangeLog.NewParameterValue = context.StringValue("DescribeModifyParameterLog.Items["+ i +"].NewParameterValue");
				parameterChangeLog.ParameterName = context.StringValue("DescribeModifyParameterLog.Items["+ i +"].ParameterName");
				parameterChangeLog.Status = context.StringValue("DescribeModifyParameterLog.Items["+ i +"].Status");

				describeModifyParameterLogResponse_items.Add(parameterChangeLog);
			}
			describeModifyParameterLogResponse.Items = describeModifyParameterLogResponse_items;
        
			return describeModifyParameterLogResponse;
        }
    }
}
