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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeDBInstanceSwitchLogResponseUnmarshaller
    {
        public static DescribeDBInstanceSwitchLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceSwitchLogResponse describeDBInstanceSwitchLogResponse = new DescribeDBInstanceSwitchLogResponse();

			describeDBInstanceSwitchLogResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceSwitchLogResponse.RequestId = _ctx.StringValue("DescribeDBInstanceSwitchLog.RequestId");
			describeDBInstanceSwitchLogResponse.DBInstanceId = _ctx.StringValue("DescribeDBInstanceSwitchLog.DBInstanceId");
			describeDBInstanceSwitchLogResponse.TotalCount = _ctx.LongValue("DescribeDBInstanceSwitchLog.TotalCount");
			describeDBInstanceSwitchLogResponse.PageSize = _ctx.LongValue("DescribeDBInstanceSwitchLog.PageSize");
			describeDBInstanceSwitchLogResponse.PageNumber = _ctx.LongValue("DescribeDBInstanceSwitchLog.PageNumber");

			List<DescribeDBInstanceSwitchLogResponse.DescribeDBInstanceSwitchLog_LogItemsItem> describeDBInstanceSwitchLogResponse_logItems = new List<DescribeDBInstanceSwitchLogResponse.DescribeDBInstanceSwitchLog_LogItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceSwitchLog.LogItems.Length"); i++) {
				DescribeDBInstanceSwitchLogResponse.DescribeDBInstanceSwitchLog_LogItemsItem logItemsItem = new DescribeDBInstanceSwitchLogResponse.DescribeDBInstanceSwitchLog_LogItemsItem();
				logItemsItem.SwitchStatus = _ctx.StringValue("DescribeDBInstanceSwitchLog.LogItems["+ i +"].SwitchStatus");
				logItemsItem.SwitchTime = _ctx.StringValue("DescribeDBInstanceSwitchLog.LogItems["+ i +"].SwitchTime");
				logItemsItem.SwitchCode = _ctx.StringValue("DescribeDBInstanceSwitchLog.LogItems["+ i +"].SwitchCode");
				logItemsItem.NodeId = _ctx.StringValue("DescribeDBInstanceSwitchLog.LogItems["+ i +"].NodeId");

				describeDBInstanceSwitchLogResponse_logItems.Add(logItemsItem);
			}
			describeDBInstanceSwitchLogResponse.LogItems = describeDBInstanceSwitchLogResponse_logItems;
        
			return describeDBInstanceSwitchLogResponse;
        }
    }
}
