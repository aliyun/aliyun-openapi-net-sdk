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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribePreCheckStatusResponseUnmarshaller
    {
        public static DescribePreCheckStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePreCheckStatusResponse describePreCheckStatusResponse = new DescribePreCheckStatusResponse();

			describePreCheckStatusResponse.HttpResponse = _ctx.HttpResponse;
			describePreCheckStatusResponse.Code = _ctx.StringValue("DescribePreCheckStatus.Code");
			describePreCheckStatusResponse.ErrorItem = _ctx.IntegerValue("DescribePreCheckStatus.ErrorItem");
			describePreCheckStatusResponse.HttpStatusCode = _ctx.IntegerValue("DescribePreCheckStatus.HttpStatusCode");
			describePreCheckStatusResponse.JobName = _ctx.StringValue("DescribePreCheckStatus.JobName");
			describePreCheckStatusResponse.State = _ctx.StringValue("DescribePreCheckStatus.State");
			describePreCheckStatusResponse.Success = _ctx.BooleanValue("DescribePreCheckStatus.Success");
			describePreCheckStatusResponse.Total = _ctx.IntegerValue("DescribePreCheckStatus.Total");
			describePreCheckStatusResponse.RequestId = _ctx.StringValue("DescribePreCheckStatus.RequestId");

			List<DescribePreCheckStatusResponse.DescribePreCheckStatus_ProgressInfo> describePreCheckStatusResponse_jobProgress = new List<DescribePreCheckStatusResponse.DescribePreCheckStatus_ProgressInfo>();
			for (int i = 0; i < _ctx.Length("DescribePreCheckStatus.JobProgress.Length"); i++) {
				DescribePreCheckStatusResponse.DescribePreCheckStatus_ProgressInfo progressInfo = new DescribePreCheckStatusResponse.DescribePreCheckStatus_ProgressInfo();
				progressInfo.BootTime = _ctx.LongValue("DescribePreCheckStatus.JobProgress["+ i +"].BootTime");
				progressInfo.CanSkip = _ctx.BooleanValue("DescribePreCheckStatus.JobProgress["+ i +"].CanSkip");
				progressInfo.DelaySeconds = _ctx.IntegerValue("DescribePreCheckStatus.JobProgress["+ i +"].DelaySeconds");
				progressInfo.FinishTime = _ctx.LongValue("DescribePreCheckStatus.JobProgress["+ i +"].FinishTime");
				progressInfo.IgnoreFlag = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].IgnoreFlag");
				progressInfo.Item = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].Item");
				progressInfo.JobId = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].JobId");
				progressInfo.Names = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].Names");
				progressInfo.OrderNum = _ctx.IntegerValue("DescribePreCheckStatus.JobProgress["+ i +"].OrderNum");
				progressInfo.Skip = _ctx.BooleanValue("DescribePreCheckStatus.JobProgress["+ i +"].Skip");
				progressInfo.State = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].State");
				progressInfo.Sub = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].Sub");
				progressInfo.RepairMethod = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].RepairMethod");
				progressInfo.TargetNames = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].TargetNames");
				progressInfo.Total = _ctx.IntegerValue("DescribePreCheckStatus.JobProgress["+ i +"].Total");
				progressInfo.SourceSchema = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].SourceSchema");
				progressInfo.ParentObj = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].ParentObj");
				progressInfo.DiffRow = _ctx.LongValue("DescribePreCheckStatus.JobProgress["+ i +"].DiffRow");
				progressInfo.DestSchema = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].DestSchema");
				progressInfo.ErrDetail = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].ErrDetail");
				progressInfo.ErrMsg = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].ErrMsg");
				progressInfo.DdlSql = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].DdlSql");

				List<DescribePreCheckStatusResponse.DescribePreCheckStatus_ProgressInfo.DescribePreCheckStatus_JobLog> progressInfo_logs = new List<DescribePreCheckStatusResponse.DescribePreCheckStatus_ProgressInfo.DescribePreCheckStatus_JobLog>();
				for (int j = 0; j < _ctx.Length("DescribePreCheckStatus.JobProgress["+ i +"].Logs.Length"); j++) {
					DescribePreCheckStatusResponse.DescribePreCheckStatus_ProgressInfo.DescribePreCheckStatus_JobLog jobLog = new DescribePreCheckStatusResponse.DescribePreCheckStatus_ProgressInfo.DescribePreCheckStatus_JobLog();
					jobLog.ErrData = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].Logs["+ j +"].ErrData");
					jobLog.ErrMsg = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].Logs["+ j +"].ErrMsg");
					jobLog.ErrType = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].Logs["+ j +"].ErrType");
					jobLog.LogLevel = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].Logs["+ j +"].LogLevel");

					progressInfo_logs.Add(jobLog);
				}
				progressInfo.Logs = progressInfo_logs;

				describePreCheckStatusResponse_jobProgress.Add(progressInfo);
			}
			describePreCheckStatusResponse.JobProgress = describePreCheckStatusResponse_jobProgress;
        
			return describePreCheckStatusResponse;
        }
    }
}
