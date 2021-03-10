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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListDBTaskSQLJobResponseUnmarshaller
    {
        public static ListDBTaskSQLJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDBTaskSQLJobResponse listDBTaskSQLJobResponse = new ListDBTaskSQLJobResponse();

			listDBTaskSQLJobResponse.HttpResponse = _ctx.HttpResponse;
			listDBTaskSQLJobResponse.TotalCount = _ctx.LongValue("ListDBTaskSQLJob.TotalCount");
			listDBTaskSQLJobResponse.RequestId = _ctx.StringValue("ListDBTaskSQLJob.RequestId");
			listDBTaskSQLJobResponse.ErrorCode = _ctx.StringValue("ListDBTaskSQLJob.ErrorCode");
			listDBTaskSQLJobResponse.ErrorMessage = _ctx.StringValue("ListDBTaskSQLJob.ErrorMessage");
			listDBTaskSQLJobResponse.Success = _ctx.BooleanValue("ListDBTaskSQLJob.Success");

			List<ListDBTaskSQLJobResponse.ListDBTaskSQLJob_DBTaskSQLJob> listDBTaskSQLJobResponse_dBTaskSQLJobList = new List<ListDBTaskSQLJobResponse.ListDBTaskSQLJob_DBTaskSQLJob>();
			for (int i = 0; i < _ctx.Length("ListDBTaskSQLJob.DBTaskSQLJobList.Length"); i++) {
				ListDBTaskSQLJobResponse.ListDBTaskSQLJob_DBTaskSQLJob dBTaskSQLJob = new ListDBTaskSQLJobResponse.ListDBTaskSQLJob_DBTaskSQLJob();
				dBTaskSQLJob.Status = _ctx.StringValue("ListDBTaskSQLJob.DBTaskSQLJobList["+ i +"].Status");
				dBTaskSQLJob.Comment = _ctx.StringValue("ListDBTaskSQLJob.DBTaskSQLJobList["+ i +"].Comment");
				dBTaskSQLJob.LastExecTime = _ctx.StringValue("ListDBTaskSQLJob.DBTaskSQLJobList["+ i +"].LastExecTime");
				dBTaskSQLJob.DbSearchName = _ctx.StringValue("ListDBTaskSQLJob.DBTaskSQLJobList["+ i +"].DbSearchName");
				dBTaskSQLJob.JobType = _ctx.StringValue("ListDBTaskSQLJob.DBTaskSQLJobList["+ i +"].JobType");
				dBTaskSQLJob.CreateTime = _ctx.StringValue("ListDBTaskSQLJob.DBTaskSQLJobList["+ i +"].CreateTime");
				dBTaskSQLJob.DbTaskGroupId = _ctx.LongValue("ListDBTaskSQLJob.DBTaskSQLJobList["+ i +"].DbTaskGroupId");
				dBTaskSQLJob.DbId = _ctx.LongValue("ListDBTaskSQLJob.DBTaskSQLJobList["+ i +"].DbId");
				dBTaskSQLJob.Logic = _ctx.BooleanValue("ListDBTaskSQLJob.DBTaskSQLJobList["+ i +"].Logic");
				dBTaskSQLJob.JobId = _ctx.LongValue("ListDBTaskSQLJob.DBTaskSQLJobList["+ i +"].JobId");
				dBTaskSQLJob.Transactional = _ctx.BooleanValue("ListDBTaskSQLJob.DBTaskSQLJobList["+ i +"].Transactional");

				listDBTaskSQLJobResponse_dBTaskSQLJobList.Add(dBTaskSQLJob);
			}
			listDBTaskSQLJobResponse.DBTaskSQLJobList = listDBTaskSQLJobResponse_dBTaskSQLJobList;
        
			return listDBTaskSQLJobResponse;
        }
    }
}
