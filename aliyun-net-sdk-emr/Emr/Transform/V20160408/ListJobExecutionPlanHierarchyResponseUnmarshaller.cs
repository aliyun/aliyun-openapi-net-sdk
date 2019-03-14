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
    public class ListJobExecutionPlanHierarchyResponseUnmarshaller
    {
        public static ListJobExecutionPlanHierarchyResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobExecutionPlanHierarchyResponse listJobExecutionPlanHierarchyResponse = new ListJobExecutionPlanHierarchyResponse();

			listJobExecutionPlanHierarchyResponse.HttpResponse = context.HttpResponse;
			listJobExecutionPlanHierarchyResponse.RequestId = context.StringValue("ListJobExecutionPlanHierarchy.RequestId");
			listJobExecutionPlanHierarchyResponse.Success = context.StringValue("ListJobExecutionPlanHierarchy.Success");
			listJobExecutionPlanHierarchyResponse.ErrCode = context.StringValue("ListJobExecutionPlanHierarchy.ErrCode");
			listJobExecutionPlanHierarchyResponse.ErrMsg = context.StringValue("ListJobExecutionPlanHierarchy.ErrMsg");
			listJobExecutionPlanHierarchyResponse.TotalCount = context.IntegerValue("ListJobExecutionPlanHierarchy.TotalCount");
			listJobExecutionPlanHierarchyResponse.PageSize = context.IntegerValue("ListJobExecutionPlanHierarchy.PageSize");
			listJobExecutionPlanHierarchyResponse.PageNumber = context.IntegerValue("ListJobExecutionPlanHierarchy.PageNumber");

			List<ListJobExecutionPlanHierarchyResponse.ListJobExecutionPlanHierarchy_HierarchyInfo> listJobExecutionPlanHierarchyResponse_hierarchyInfos = new List<ListJobExecutionPlanHierarchyResponse.ListJobExecutionPlanHierarchy_HierarchyInfo>();
			for (int i = 0; i < context.Length("ListJobExecutionPlanHierarchy.HierarchyInfos.Length"); i++) {
				ListJobExecutionPlanHierarchyResponse.ListJobExecutionPlanHierarchy_HierarchyInfo hierarchyInfo = new ListJobExecutionPlanHierarchyResponse.ListJobExecutionPlanHierarchy_HierarchyInfo();
				hierarchyInfo.Id = context.LongValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].Id");
				hierarchyInfo.NodeBizType = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].NodeBizType");
				hierarchyInfo.NodeType = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].NodeType");
				hierarchyInfo.RelateId = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].RelateId");
				hierarchyInfo.Name = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].Name");
				hierarchyInfo.ParentId = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ParentId");
				hierarchyInfo.ResourceOwnerId = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ResourceOwnerId");
				hierarchyInfo.UtcCreateTimestamp = context.LongValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].UtcCreateTimestamp");
				hierarchyInfo.UtcModifiedTimestamp = context.LongValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].UtcModifiedTimestamp");
				hierarchyInfo.NodeStatus = context.IntegerValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].NodeStatus");

				ListJobExecutionPlanHierarchyResponse.ListJobExecutionPlanHierarchy_HierarchyInfo.ListJobExecutionPlanHierarchy_ExecutionPlan executionPlan = new ListJobExecutionPlanHierarchyResponse.ListJobExecutionPlanHierarchy_HierarchyInfo.ListJobExecutionPlanHierarchy_ExecutionPlan();
				executionPlan.BizId = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.BizId");
				executionPlan.Name = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.Name");
				executionPlan.Status = context.IntegerValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.Status");
				executionPlan.LastExeStatus = context.IntegerValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.LastExeStatus");
				executionPlan.IsCreateCluster = context.BooleanValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.IsCreateCluster");
				executionPlan.IsInterruptWhenError = context.BooleanValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.IsInterruptWhenError");
				executionPlan.IsCycle = context.BooleanValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.IsCycle");
				executionPlan.ScheduleCycle = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.ScheduleCycle");
				executionPlan.RegionId = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.RegionId");
				executionPlan.CronExpr = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.CronExpr");
				executionPlan.UtcCreateTimestamp = context.LongValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.UtcCreateTimestamp");
				executionPlan.UtcModifiedTimestamp = context.LongValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.UtcModifiedTimestamp");
				executionPlan.Version = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.Version");
				executionPlan.ClusterTemplateId = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].ExecutionPlan.ClusterTemplateId");
				hierarchyInfo.ExecutionPlan = executionPlan;

				ListJobExecutionPlanHierarchyResponse.ListJobExecutionPlanHierarchy_HierarchyInfo.ListJobExecutionPlanHierarchy_Job job = new ListJobExecutionPlanHierarchyResponse.ListJobExecutionPlanHierarchy_HierarchyInfo.ListJobExecutionPlanHierarchy_Job();
				job.BizId = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].Job.BizId");
				job.Name = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].Job.Name");
				job.JobFailAct = context.IntegerValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].Job.JobFailAct");
				job.JobType = context.IntegerValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].Job.JobType");
				job.EnvParam = context.StringValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].Job.EnvParam");
				job.MaxRetry = context.IntegerValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].Job.MaxRetry");
				job.RetryInterval = context.IntegerValue("ListJobExecutionPlanHierarchy.HierarchyInfos["+ i +"].Job.RetryInterval");
				hierarchyInfo.Job = job;

				listJobExecutionPlanHierarchyResponse_hierarchyInfos.Add(hierarchyInfo);
			}
			listJobExecutionPlanHierarchyResponse.HierarchyInfos = listJobExecutionPlanHierarchyResponse_hierarchyInfos;
        
			return listJobExecutionPlanHierarchyResponse;
        }
    }
}
