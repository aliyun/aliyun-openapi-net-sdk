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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeClusterOpLogResponseUnmarshaller
    {
        public static DescribeClusterOpLogResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeClusterOpLogResponse describeClusterOpLogResponse = new DescribeClusterOpLogResponse();

			describeClusterOpLogResponse.HttpResponse = context.HttpResponse;
			describeClusterOpLogResponse.RequestId = context.StringValue("DescribeClusterOpLog.RequestId");
			describeClusterOpLogResponse.PageNumber = context.StringValue("DescribeClusterOpLog.PageNumber");
			describeClusterOpLogResponse.PageSize = context.StringValue("DescribeClusterOpLog.PageSize");
			describeClusterOpLogResponse.Total = context.StringValue("DescribeClusterOpLog.Total");

			List<DescribeClusterOpLogResponse.DescribeClusterOpLog_ChangeLog> describeClusterOpLogResponse_changeLogList = new List<DescribeClusterOpLogResponse.DescribeClusterOpLog_ChangeLog>();
			for (int i = 0; i < context.Length("DescribeClusterOpLog.ChangeLogList.Length"); i++) {
				DescribeClusterOpLogResponse.DescribeClusterOpLog_ChangeLog changeLog = new DescribeClusterOpLogResponse.DescribeClusterOpLog_ChangeLog();
				changeLog.Id = context.LongValue("DescribeClusterOpLog.ChangeLogList["+ i +"].Id");
				changeLog.GmtCreate = context.StringValue("DescribeClusterOpLog.ChangeLogList["+ i +"].GmtCreate");
				changeLog.GmtModified = context.StringValue("DescribeClusterOpLog.ChangeLogList["+ i +"].GmtModified");
				changeLog.TargetKey = context.StringValue("DescribeClusterOpLog.ChangeLogList["+ i +"].TargetKey");
				changeLog.Status = context.StringValue("DescribeClusterOpLog.ChangeLogList["+ i +"].Status");
				changeLog.ChangeType = context.StringValue("DescribeClusterOpLog.ChangeLogList["+ i +"].ChangeType");
				changeLog.Message = context.StringValue("DescribeClusterOpLog.ChangeLogList["+ i +"].Message");
				changeLog.TargetType = context.StringValue("DescribeClusterOpLog.ChangeLogList["+ i +"].TargetType");

				describeClusterOpLogResponse_changeLogList.Add(changeLog);
			}
			describeClusterOpLogResponse.ChangeLogList = describeClusterOpLogResponse_changeLogList;
        
			return describeClusterOpLogResponse;
        }
    }
}
