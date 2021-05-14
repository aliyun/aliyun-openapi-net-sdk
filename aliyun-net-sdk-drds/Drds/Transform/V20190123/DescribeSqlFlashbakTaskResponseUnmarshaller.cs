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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeSqlFlashbakTaskResponseUnmarshaller
    {
        public static DescribeSqlFlashbakTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSqlFlashbakTaskResponse describeSqlFlashbakTaskResponse = new DescribeSqlFlashbakTaskResponse();

			describeSqlFlashbakTaskResponse.HttpResponse = _ctx.HttpResponse;
			describeSqlFlashbakTaskResponse.RequestId = _ctx.StringValue("DescribeSqlFlashbakTask.RequestId");
			describeSqlFlashbakTaskResponse.Success = _ctx.BooleanValue("DescribeSqlFlashbakTask.Success");

			List<DescribeSqlFlashbakTaskResponse.DescribeSqlFlashbakTask_SqlFlashbackTask> describeSqlFlashbakTaskResponse_sqlFlashbackTasks = new List<DescribeSqlFlashbakTaskResponse.DescribeSqlFlashbakTask_SqlFlashbackTask>();
			for (int i = 0; i < _ctx.Length("DescribeSqlFlashbakTask.SqlFlashbackTasks.Length"); i++) {
				DescribeSqlFlashbakTaskResponse.DescribeSqlFlashbakTask_SqlFlashbackTask sqlFlashbackTask = new DescribeSqlFlashbakTaskResponse.DescribeSqlFlashbakTask_SqlFlashbackTask();
				sqlFlashbackTask.Id = _ctx.LongValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].Id");
				sqlFlashbackTask.GmtCreate = _ctx.LongValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].GmtCreate");
				sqlFlashbackTask.GmtModified = _ctx.LongValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].GmtModified");
				sqlFlashbackTask.InstId = _ctx.StringValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].InstId");
				sqlFlashbackTask.DbName = _ctx.StringValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].DbName");
				sqlFlashbackTask.SearchStartTime = _ctx.LongValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].SearchStartTime");
				sqlFlashbackTask.SearchEndTime = _ctx.LongValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].SearchEndTime");
				sqlFlashbackTask.TableName = _ctx.StringValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].TableName");
				sqlFlashbackTask.TraceId = _ctx.StringValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].TraceId");
				sqlFlashbackTask.SqlType = _ctx.StringValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].SqlType");
				sqlFlashbackTask.SqlPk = _ctx.StringValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].SqlPk");
				sqlFlashbackTask.RecallType = _ctx.IntegerValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].RecallType");
				sqlFlashbackTask.RecallStatus = _ctx.IntegerValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].RecallStatus");
				sqlFlashbackTask.RecallProgress = _ctx.IntegerValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].RecallProgress");
				sqlFlashbackTask.RecallRestoreType = _ctx.IntegerValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].RecallRestoreType");
				sqlFlashbackTask.DownloadUrl = _ctx.StringValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].DownloadUrl");
				sqlFlashbackTask.ExpireTime = _ctx.LongValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].ExpireTime");
				sqlFlashbackTask.SqlCounter = _ctx.LongValue("DescribeSqlFlashbakTask.SqlFlashbackTasks["+ i +"].SqlCounter");

				describeSqlFlashbakTaskResponse_sqlFlashbackTasks.Add(sqlFlashbackTask);
			}
			describeSqlFlashbakTaskResponse.SqlFlashbackTasks = describeSqlFlashbakTaskResponse_sqlFlashbackTasks;
        
			return describeSqlFlashbakTaskResponse;
        }
    }
}
