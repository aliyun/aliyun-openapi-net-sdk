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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeLoadTasksRecordsResponseUnmarshaller
    {
        public static DescribeLoadTasksRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLoadTasksRecordsResponse describeLoadTasksRecordsResponse = new DescribeLoadTasksRecordsResponse();

			describeLoadTasksRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeLoadTasksRecordsResponse.TotalCount = _ctx.StringValue("DescribeLoadTasksRecords.TotalCount");
			describeLoadTasksRecordsResponse.RequestId = _ctx.StringValue("DescribeLoadTasksRecords.RequestId");
			describeLoadTasksRecordsResponse.PageSize = _ctx.StringValue("DescribeLoadTasksRecords.PageSize");
			describeLoadTasksRecordsResponse.PageNumber = _ctx.StringValue("DescribeLoadTasksRecords.PageNumber");
			describeLoadTasksRecordsResponse.DBClusterId = _ctx.StringValue("DescribeLoadTasksRecords.DBClusterId");

			List<DescribeLoadTasksRecordsResponse.DescribeLoadTasksRecords_LoadTaskRecord> describeLoadTasksRecordsResponse_loadTasksRecords = new List<DescribeLoadTasksRecordsResponse.DescribeLoadTasksRecords_LoadTaskRecord>();
			for (int i = 0; i < _ctx.Length("DescribeLoadTasksRecords.LoadTasksRecords.Length"); i++) {
				DescribeLoadTasksRecordsResponse.DescribeLoadTasksRecords_LoadTaskRecord loadTaskRecord = new DescribeLoadTasksRecordsResponse.DescribeLoadTasksRecords_LoadTaskRecord();
				loadTaskRecord.ProcessRows = _ctx.LongValue("DescribeLoadTasksRecords.LoadTasksRecords["+ i +"].ProcessRows");
				loadTaskRecord.State = _ctx.StringValue("DescribeLoadTasksRecords.LoadTasksRecords["+ i +"].State");
				loadTaskRecord.CreateTime = _ctx.StringValue("DescribeLoadTasksRecords.LoadTasksRecords["+ i +"].CreateTime");
				loadTaskRecord.JobName = _ctx.StringValue("DescribeLoadTasksRecords.LoadTasksRecords["+ i +"].JobName");
				loadTaskRecord.UpdateTime = _ctx.StringValue("DescribeLoadTasksRecords.LoadTasksRecords["+ i +"].UpdateTime");
				loadTaskRecord.DBName = _ctx.StringValue("DescribeLoadTasksRecords.LoadTasksRecords["+ i +"].DBName");
				loadTaskRecord.ProcessID = _ctx.StringValue("DescribeLoadTasksRecords.LoadTasksRecords["+ i +"].ProcessID");
				loadTaskRecord.Sql = _ctx.StringValue("DescribeLoadTasksRecords.LoadTasksRecords["+ i +"].Sql");

				describeLoadTasksRecordsResponse_loadTasksRecords.Add(loadTaskRecord);
			}
			describeLoadTasksRecordsResponse.LoadTasksRecords = describeLoadTasksRecordsResponse_loadTasksRecords;
        
			return describeLoadTasksRecordsResponse;
        }
    }
}
