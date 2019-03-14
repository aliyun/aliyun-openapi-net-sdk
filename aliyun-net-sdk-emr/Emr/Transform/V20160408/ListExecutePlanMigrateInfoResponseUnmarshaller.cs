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
    public class ListExecutePlanMigrateInfoResponseUnmarshaller
    {
        public static ListExecutePlanMigrateInfoResponse Unmarshall(UnmarshallerContext context)
        {
			ListExecutePlanMigrateInfoResponse listExecutePlanMigrateInfoResponse = new ListExecutePlanMigrateInfoResponse();

			listExecutePlanMigrateInfoResponse.HttpResponse = context.HttpResponse;
			listExecutePlanMigrateInfoResponse.Total = context.LongValue("ListExecutePlanMigrateInfo.Total");

			List<ListExecutePlanMigrateInfoResponse.ListExecutePlanMigrateInfo_ExecutePlanMigrateInfo> listExecutePlanMigrateInfoResponse_executePlanMigrateInfoList = new List<ListExecutePlanMigrateInfoResponse.ListExecutePlanMigrateInfo_ExecutePlanMigrateInfo>();
			for (int i = 0; i < context.Length("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList.Length"); i++) {
				ListExecutePlanMigrateInfoResponse.ListExecutePlanMigrateInfo_ExecutePlanMigrateInfo executePlanMigrateInfo = new ListExecutePlanMigrateInfoResponse.ListExecutePlanMigrateInfo_ExecutePlanMigrateInfo();
				executePlanMigrateInfo.Id = context.LongValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].Id");
				executePlanMigrateInfo.BizId = context.StringValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].BizId");
				executePlanMigrateInfo.CreateTime = context.StringValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].CreateTime");
				executePlanMigrateInfo.Name = context.StringValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].Name");
				executePlanMigrateInfo.Status = context.LongValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].Status");
				executePlanMigrateInfo.CronExpr = context.StringValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].CronExpr");
				executePlanMigrateInfo.StartScheduleTime = context.StringValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].StartScheduleTime");
				executePlanMigrateInfo.IsCycle = context.LongValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].IsCycle");
				executePlanMigrateInfo.BuildClusterCondition = context.StringValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].BuildClusterCondition");

				List<ListExecutePlanMigrateInfoResponse.ListExecutePlanMigrateInfo_ExecutePlanMigrateInfo.ListExecutePlanMigrateInfo_JobInfo> executePlanMigrateInfo_jobList = new List<ListExecutePlanMigrateInfoResponse.ListExecutePlanMigrateInfo_ExecutePlanMigrateInfo.ListExecutePlanMigrateInfo_JobInfo>();
				for (int j = 0; j < context.Length("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].JobList.Length"); j++) {
					ListExecutePlanMigrateInfoResponse.ListExecutePlanMigrateInfo_ExecutePlanMigrateInfo.ListExecutePlanMigrateInfo_JobInfo jobInfo = new ListExecutePlanMigrateInfoResponse.ListExecutePlanMigrateInfo_ExecutePlanMigrateInfo.ListExecutePlanMigrateInfo_JobInfo();
					jobInfo.ClusterId = context.StringValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].JobList["+ j +"].ClusterId");
					jobInfo.JobId = context.StringValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].JobList["+ j +"].JobId");
					jobInfo.Description = context.StringValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].JobList["+ j +"].Description");
					jobInfo.IndexNO = context.LongValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].JobList["+ j +"].IndexNO");
					jobInfo.Status = context.LongValue("ListExecutePlanMigrateInfo.ExecutePlanMigrateInfoList["+ i +"].JobList["+ j +"].Status");

					executePlanMigrateInfo_jobList.Add(jobInfo);
				}
				executePlanMigrateInfo.JobList = executePlanMigrateInfo_jobList;

				listExecutePlanMigrateInfoResponse_executePlanMigrateInfoList.Add(executePlanMigrateInfo);
			}
			listExecutePlanMigrateInfoResponse.ExecutePlanMigrateInfoList = listExecutePlanMigrateInfoResponse_executePlanMigrateInfoList;
        
			return listExecutePlanMigrateInfoResponse;
        }
    }
}
