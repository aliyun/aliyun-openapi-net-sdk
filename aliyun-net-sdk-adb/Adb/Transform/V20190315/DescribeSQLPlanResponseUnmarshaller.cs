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
    public class DescribeSQLPlanResponseUnmarshaller
    {
        public static DescribeSQLPlanResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLPlanResponse describeSQLPlanResponse = new DescribeSQLPlanResponse();

			describeSQLPlanResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLPlanResponse.RequestId = _ctx.StringValue("DescribeSQLPlan.RequestId");
			describeSQLPlanResponse.OriginInfo = _ctx.StringValue("DescribeSQLPlan.OriginInfo");

			DescribeSQLPlanResponse.DescribeSQLPlan_Detail detail = new DescribeSQLPlanResponse.DescribeSQLPlan_Detail();
			detail.SQL = _ctx.StringValue("DescribeSQLPlan.Detail.SQL");
			detail.State = _ctx.StringValue("DescribeSQLPlan.Detail.State");
			detail.User = _ctx.StringValue("DescribeSQLPlan.Detail.User");
			detail.ClientIP = _ctx.StringValue("DescribeSQLPlan.Detail.ClientIP");
			detail.Database = _ctx.StringValue("DescribeSQLPlan.Detail.Database");
			detail.TotalStage = _ctx.LongValue("DescribeSQLPlan.Detail.TotalStage");
			detail.TotalTask = _ctx.LongValue("DescribeSQLPlan.Detail.TotalTask");
			detail.OutputRows = _ctx.LongValue("DescribeSQLPlan.Detail.OutputRows");
			detail.OutputSize = _ctx.LongValue("DescribeSQLPlan.Detail.OutputSize");
			detail.StartTime = _ctx.StringValue("DescribeSQLPlan.Detail.StartTime");
			detail.TotalTime = _ctx.LongValue("DescribeSQLPlan.Detail.TotalTime");
			detail.QueuedTime = _ctx.LongValue("DescribeSQLPlan.Detail.QueuedTime");
			detail.PlanningTime = _ctx.LongValue("DescribeSQLPlan.Detail.PlanningTime");
			detail.CPUTime = _ctx.LongValue("DescribeSQLPlan.Detail.CPUTime");
			detail.PeakMemory = _ctx.LongValue("DescribeSQLPlan.Detail.PeakMemory");
			describeSQLPlanResponse.Detail = detail;

			List<DescribeSQLPlanResponse.DescribeSQLPlan_SqlPlanStage> describeSQLPlanResponse_stageList = new List<DescribeSQLPlanResponse.DescribeSQLPlan_SqlPlanStage>();
			for (int i = 0; i < _ctx.Length("DescribeSQLPlan.StageList.Length"); i++) {
				DescribeSQLPlanResponse.DescribeSQLPlan_SqlPlanStage sqlPlanStage = new DescribeSQLPlanResponse.DescribeSQLPlan_SqlPlanStage();
				sqlPlanStage.StageId = _ctx.IntegerValue("DescribeSQLPlan.StageList["+ i +"].StageId");
				sqlPlanStage.State = _ctx.StringValue("DescribeSQLPlan.StageList["+ i +"].State");
				sqlPlanStage.OperatorCost = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].OperatorCost");
				sqlPlanStage.PeakMemory = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].PeakMemory");
				sqlPlanStage.CPUTimeMin = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].CPUTimeMin");
				sqlPlanStage.CPUTimeMax = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].CPUTimeMax");
				sqlPlanStage.CPUTimeAvg = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].CPUTimeAvg");
				sqlPlanStage.InputSizeMin = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].InputSizeMin");
				sqlPlanStage.InputSizeMax = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].InputSizeMax");
				sqlPlanStage.InputSizeAvg = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].InputSizeAvg");
				sqlPlanStage.ScanSizeMin = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].ScanSizeMin");
				sqlPlanStage.ScanSizeMax = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].ScanSizeMax");
				sqlPlanStage.ScanSizeAvg = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].ScanSizeAvg");
				sqlPlanStage.ScanTimeMin = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].ScanTimeMin");
				sqlPlanStage.ScanTimeMax = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].ScanTimeMax");
				sqlPlanStage.ScanTimeAvg = _ctx.LongValue("DescribeSQLPlan.StageList["+ i +"].ScanTimeAvg");

				describeSQLPlanResponse_stageList.Add(sqlPlanStage);
			}
			describeSQLPlanResponse.StageList = describeSQLPlanResponse_stageList;
        
			return describeSQLPlanResponse;
        }
    }
}
