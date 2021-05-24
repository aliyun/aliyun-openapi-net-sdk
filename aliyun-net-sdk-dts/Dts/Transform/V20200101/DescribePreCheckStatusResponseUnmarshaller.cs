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
			describePreCheckStatusResponse.JobId = _ctx.StringValue("DescribePreCheckStatus.JobId");

			List<DescribePreCheckStatusResponse.DescribePreCheckStatus_ProgressInfo> describePreCheckStatusResponse_jobProgress = new List<DescribePreCheckStatusResponse.DescribePreCheckStatus_ProgressInfo>();
			for (int i = 0; i < _ctx.Length("DescribePreCheckStatus.JobProgress.Length"); i++) {
				DescribePreCheckStatusResponse.DescribePreCheckStatus_ProgressInfo progressInfo = new DescribePreCheckStatusResponse.DescribePreCheckStatus_ProgressInfo();
				progressInfo.Skip = _ctx.BooleanValue("DescribePreCheckStatus.JobProgress["+ i +"].Skip");
				progressInfo.CanSkip = _ctx.BooleanValue("DescribePreCheckStatus.JobProgress["+ i +"].CanSkip");
				progressInfo.ErrMsg = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].ErrMsg");
				progressInfo.BootTime = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].BootTime");
				progressInfo.DelaySeconds = _ctx.IntegerValue("DescribePreCheckStatus.JobProgress["+ i +"].DelaySeconds");
				progressInfo.FinishTime = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].FinishTime");
				progressInfo.IgnoreFlag = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].IgnoreFlag");
				progressInfo.Item = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].Item");
				progressInfo.JobId = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].JobId");
				progressInfo.Names = _ctx.StringValue("DescribePreCheckStatus.JobProgress["+ i +"].Names");
				progressInfo.OrderNum = _ctx.IntegerValue("DescribePreCheckStatus.JobProgress["+ i +"].OrderNum");
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

			List<DescribePreCheckStatusResponse.DescribePreCheckStatus_SubDistributedJobStatusItem> describePreCheckStatusResponse_subDistributedJobStatus = new List<DescribePreCheckStatusResponse.DescribePreCheckStatus_SubDistributedJobStatusItem>();
			for (int i = 0; i < _ctx.Length("DescribePreCheckStatus.SubDistributedJobStatus.Length"); i++) {
				DescribePreCheckStatusResponse.DescribePreCheckStatus_SubDistributedJobStatusItem subDistributedJobStatusItem = new DescribePreCheckStatusResponse.DescribePreCheckStatus_SubDistributedJobStatusItem();
				subDistributedJobStatusItem.State = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].State");
				subDistributedJobStatusItem.ErrorItem = _ctx.IntegerValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].ErrorItem");
				subDistributedJobStatusItem.JobName = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobName");
				subDistributedJobStatusItem.JobId = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobId");
				subDistributedJobStatusItem.Code = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].Code");
				subDistributedJobStatusItem.Total = _ctx.IntegerValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].Total");

				List<DescribePreCheckStatusResponse.DescribePreCheckStatus_SubDistributedJobStatusItem.DescribePreCheckStatus_ProgressInfo2> subDistributedJobStatusItem_jobProgress1 = new List<DescribePreCheckStatusResponse.DescribePreCheckStatus_SubDistributedJobStatusItem.DescribePreCheckStatus_ProgressInfo2>();
				for (int j = 0; j < _ctx.Length("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress.Length"); j++) {
					DescribePreCheckStatusResponse.DescribePreCheckStatus_SubDistributedJobStatusItem.DescribePreCheckStatus_ProgressInfo2 progressInfo2 = new DescribePreCheckStatusResponse.DescribePreCheckStatus_SubDistributedJobStatusItem.DescribePreCheckStatus_ProgressInfo2();
					progressInfo2.Skip = _ctx.BooleanValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].Skip");
					progressInfo2.CanSkip = _ctx.BooleanValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].CanSkip");
					progressInfo2.ErrMsg = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].ErrMsg");
					progressInfo2.BootTime = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].BootTime");
					progressInfo2.DelaySeconds = _ctx.IntegerValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].DelaySeconds");
					progressInfo2.FinishTime = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].FinishTime");
					progressInfo2.IgnoreFlag = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].IgnoreFlag");
					progressInfo2.Item = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].Item");
					progressInfo2.JobId = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].JobId");
					progressInfo2.Names = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].Names");
					progressInfo2.OrderNum = _ctx.IntegerValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].OrderNum");
					progressInfo2.State = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].State");
					progressInfo2.Sub = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].Sub");
					progressInfo2.RepairMethod = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].RepairMethod");
					progressInfo2.TargetNames = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].TargetNames");
					progressInfo2.Total = _ctx.IntegerValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].Total");
					progressInfo2.SourceSchema = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].SourceSchema");
					progressInfo2.ParentObj = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].ParentObj");
					progressInfo2.DiffRow = _ctx.LongValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].DiffRow");
					progressInfo2.DestSchema = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].DestSchema");
					progressInfo2.ErrDetail = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].ErrDetail");
					progressInfo2.DdlSql = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].DdlSql");

					List<DescribePreCheckStatusResponse.DescribePreCheckStatus_SubDistributedJobStatusItem.DescribePreCheckStatus_ProgressInfo2.DescribePreCheckStatus_JobLog4> progressInfo2_logs3 = new List<DescribePreCheckStatusResponse.DescribePreCheckStatus_SubDistributedJobStatusItem.DescribePreCheckStatus_ProgressInfo2.DescribePreCheckStatus_JobLog4>();
					for (int k = 0; k < _ctx.Length("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].Logs.Length"); k++) {
						DescribePreCheckStatusResponse.DescribePreCheckStatus_SubDistributedJobStatusItem.DescribePreCheckStatus_ProgressInfo2.DescribePreCheckStatus_JobLog4 jobLog4 = new DescribePreCheckStatusResponse.DescribePreCheckStatus_SubDistributedJobStatusItem.DescribePreCheckStatus_ProgressInfo2.DescribePreCheckStatus_JobLog4();
						jobLog4.ErrData = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].Logs["+ k +"].ErrData");
						jobLog4.ErrMsg = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].Logs["+ k +"].ErrMsg");
						jobLog4.ErrType = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].Logs["+ k +"].ErrType");
						jobLog4.LogLevel = _ctx.StringValue("DescribePreCheckStatus.SubDistributedJobStatus["+ i +"].JobProgress["+ j +"].Logs["+ k +"].LogLevel");

						progressInfo2_logs3.Add(jobLog4);
					}
					progressInfo2.Logs3 = progressInfo2_logs3;

					subDistributedJobStatusItem_jobProgress1.Add(progressInfo2);
				}
				subDistributedJobStatusItem.JobProgress1 = subDistributedJobStatusItem_jobProgress1;

				describePreCheckStatusResponse_subDistributedJobStatus.Add(subDistributedJobStatusItem);
			}
			describePreCheckStatusResponse.SubDistributedJobStatus = describePreCheckStatusResponse_subDistributedJobStatus;
        
			return describePreCheckStatusResponse;
        }
    }
}
