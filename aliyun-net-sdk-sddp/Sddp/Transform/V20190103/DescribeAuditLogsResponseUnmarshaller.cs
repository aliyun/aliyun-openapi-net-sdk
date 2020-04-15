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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeAuditLogsResponseUnmarshaller
    {
        public static DescribeAuditLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAuditLogsResponse describeAuditLogsResponse = new DescribeAuditLogsResponse();

			describeAuditLogsResponse.HttpResponse = context.HttpResponse;
			describeAuditLogsResponse.RequestId = context.StringValue("DescribeAuditLogs.RequestId");
			describeAuditLogsResponse.PageSize = context.IntegerValue("DescribeAuditLogs.PageSize");
			describeAuditLogsResponse.CurrentPage = context.IntegerValue("DescribeAuditLogs.CurrentPage");
			describeAuditLogsResponse.TotalCount = context.IntegerValue("DescribeAuditLogs.TotalCount");

			List<DescribeAuditLogsResponse.DescribeAuditLogs_Log> describeAuditLogsResponse_items = new List<DescribeAuditLogsResponse.DescribeAuditLogs_Log>();
			for (int i = 0; i < context.Length("DescribeAuditLogs.Items.Length"); i++) {
				DescribeAuditLogsResponse.DescribeAuditLogs_Log log = new DescribeAuditLogsResponse.DescribeAuditLogs_Log();
				log.Id = context.LongValue("DescribeAuditLogs.Items["+ i +"].Id");
				log.ProductCode = context.StringValue("DescribeAuditLogs.Items["+ i +"].ProductCode");
				log.ProductId = context.LongValue("DescribeAuditLogs.Items["+ i +"].ProductId");
				log.LogTime = context.LongValue("DescribeAuditLogs.Items["+ i +"].LogTime");
				log.UserId = context.StringValue("DescribeAuditLogs.Items["+ i +"].UserId");
				log.UserName = context.StringValue("DescribeAuditLogs.Items["+ i +"].UserName");
				log.ClientIp = context.StringValue("DescribeAuditLogs.Items["+ i +"].ClientIp");
				log.ClientPort = context.StringValue("DescribeAuditLogs.Items["+ i +"].ClientPort");
				log.ClientUa = context.StringValue("DescribeAuditLogs.Items["+ i +"].ClientUa");
				log.InstanceName = context.StringValue("DescribeAuditLogs.Items["+ i +"].InstanceName");
				log.CreationTime = context.LongValue("DescribeAuditLogs.Items["+ i +"].CreationTime");
				log.DatabaseName = context.StringValue("DescribeAuditLogs.Items["+ i +"].DatabaseName");
				log.TableName = context.StringValue("DescribeAuditLogs.Items["+ i +"].TableName");
				log.ColumnName = context.StringValue("DescribeAuditLogs.Items["+ i +"].ColumnName");
				log.PackageName = context.StringValue("DescribeAuditLogs.Items["+ i +"].PackageName");
				log.OssObjectKey = context.StringValue("DescribeAuditLogs.Items["+ i +"].OssObjectKey");
				log.ExecuteTime = context.LongValue("DescribeAuditLogs.Items["+ i +"].ExecuteTime");
				log.EffectRow = context.LongValue("DescribeAuditLogs.Items["+ i +"].EffectRow");
				log.OperateType = context.StringValue("DescribeAuditLogs.Items["+ i +"].OperateType");
				log.RuleId = context.StringValue("DescribeAuditLogs.Items["+ i +"].RuleId");
				log.RuleName = context.StringValue("DescribeAuditLogs.Items["+ i +"].RuleName");
				log.WarnLevel = context.StringValue("DescribeAuditLogs.Items["+ i +"].WarnLevel");
				log.ExecuteStatus = context.IntegerValue("DescribeAuditLogs.Items["+ i +"].ExecuteStatus");

				describeAuditLogsResponse_items.Add(log);
			}
			describeAuditLogsResponse.Items = describeAuditLogsResponse_items;
        
			return describeAuditLogsResponse;
        }
    }
}
