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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DecribeSqlLogDumpStatusResponseUnmarshaller
    {
        public static DecribeSqlLogDumpStatusResponse Unmarshall(UnmarshallerContext context)
        {
			DecribeSqlLogDumpStatusResponse decribeSqlLogDumpStatusResponse = new DecribeSqlLogDumpStatusResponse();

			decribeSqlLogDumpStatusResponse.HttpResponse = context.HttpResponse;
			decribeSqlLogDumpStatusResponse.RequestId = context.StringValue("DecribeSqlLogDumpStatus.RequestId");
			decribeSqlLogDumpStatusResponse.DBInstanceID = context.IntegerValue("DecribeSqlLogDumpStatus.DBInstanceID");
			decribeSqlLogDumpStatusResponse.DBInstanceName = context.StringValue("DecribeSqlLogDumpStatus.DBInstanceName");
			decribeSqlLogDumpStatusResponse.IsEnableSqlLogDump = context.StringValue("DecribeSqlLogDumpStatus.IsEnableSqlLogDump");

			List<DecribeSqlLogDumpStatusResponse.DecribeSqlLogDumpStatus_SqlLogDumpStatus> decribeSqlLogDumpStatusResponse_items = new List<DecribeSqlLogDumpStatusResponse.DecribeSqlLogDumpStatus_SqlLogDumpStatus>();
			for (int i = 0; i < context.Length("DecribeSqlLogDumpStatus.Items.Length"); i++) {
				DecribeSqlLogDumpStatusResponse.DecribeSqlLogDumpStatus_SqlLogDumpStatus sqlLogDumpStatus = new DecribeSqlLogDumpStatusResponse.DecribeSqlLogDumpStatus_SqlLogDumpStatus();
				sqlLogDumpStatus.DumpStartTime = context.StringValue("DecribeSqlLogDumpStatus.Items["+ i +"].DumpStartTime");
				sqlLogDumpStatus.JobName = context.StringValue("DecribeSqlLogDumpStatus.Items["+ i +"].JobName");
				sqlLogDumpStatus.CreateTime = context.StringValue("DecribeSqlLogDumpStatus.Items["+ i +"].CreateTime");
				sqlLogDumpStatus.UpdateTime = context.StringValue("DecribeSqlLogDumpStatus.Items["+ i +"].UpdateTime");
				sqlLogDumpStatus.ProcessRows = context.LongValue("DecribeSqlLogDumpStatus.Items["+ i +"].ProcessRows");
				sqlLogDumpStatus.TotalRows = context.LongValue("DecribeSqlLogDumpStatus.Items["+ i +"].TotalRows");
				sqlLogDumpStatus.JobStatus = context.StringValue("DecribeSqlLogDumpStatus.Items["+ i +"].JobStatus");
				sqlLogDumpStatus.FailMsg = context.StringValue("DecribeSqlLogDumpStatus.Items["+ i +"].FailMsg");
				sqlLogDumpStatus.Status = context.IntegerValue("DecribeSqlLogDumpStatus.Items["+ i +"].Status");
				sqlLogDumpStatus.ErrorCode = context.StringValue("DecribeSqlLogDumpStatus.Items["+ i +"].ErrorCode");

				decribeSqlLogDumpStatusResponse_items.Add(sqlLogDumpStatus);
			}
			decribeSqlLogDumpStatusResponse.Items = decribeSqlLogDumpStatusResponse_items;
        
			return decribeSqlLogDumpStatusResponse;
        }
    }
}