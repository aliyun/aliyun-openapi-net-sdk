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
    public class DescribeETLJobInstanceResponseUnmarshaller
    {
        public static DescribeETLJobInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeETLJobInstanceResponse describeETLJobInstanceResponse = new DescribeETLJobInstanceResponse();

			describeETLJobInstanceResponse.HttpResponse = context.HttpResponse;
			describeETLJobInstanceResponse.RequestId = context.StringValue("DescribeETLJobInstance.RequestId");
			describeETLJobInstanceResponse.Id = context.StringValue("DescribeETLJobInstance.Id");
			describeETLJobInstanceResponse.EtlJobId = context.StringValue("DescribeETLJobInstance.EtlJobId");
			describeETLJobInstanceResponse.InstanceStatus = context.StringValue("DescribeETLJobInstance.InstanceStatus");
			describeETLJobInstanceResponse.TriggerUser = context.StringValue("DescribeETLJobInstance.TriggerUser");
			describeETLJobInstanceResponse.StartTime = context.LongValue("DescribeETLJobInstance.StartTime");
			describeETLJobInstanceResponse.EndTime = context.LongValue("DescribeETLJobInstance.EndTime");

			DescribeETLJobInstanceResponse.DescribeETLJobInstance_TriggerHistory triggerHistory = new DescribeETLJobInstanceResponse.DescribeETLJobInstance_TriggerHistory();
			triggerHistory.HistoryId = context.StringValue("DescribeETLJobInstance.TriggerHistory.HistoryId");
			triggerHistory.TriggerId = context.StringValue("DescribeETLJobInstance.TriggerHistory.TriggerId");
			triggerHistory.TriggerType = context.StringValue("DescribeETLJobInstance.TriggerHistory.TriggerType");
			triggerHistory.FireState = context.StringValue("DescribeETLJobInstance.TriggerHistory.FireState");
			triggerHistory.FireTime = context.LongValue("DescribeETLJobInstance.TriggerHistory.FireTime");
			describeETLJobInstanceResponse.TriggerHistory = triggerHistory;

			DescribeETLJobInstanceResponse.DescribeETLJobInstance_Arguments arguments = new DescribeETLJobInstanceResponse.DescribeETLJobInstance_Arguments();
			arguments.Key = context.StringValue("DescribeETLJobInstance.Arguments.Key");
			arguments._Value = context.StringValue("DescribeETLJobInstance.Arguments.Value");
			describeETLJobInstanceResponse.Arguments = arguments;

			DescribeETLJobInstanceResponse.DescribeETLJobInstance_Metrics metrics = new DescribeETLJobInstanceResponse.DescribeETLJobInstance_Metrics();
			metrics.TotalTime = context.LongValue("DescribeETLJobInstance.Metrics.TotalTime");
			metrics.RecordsIn = context.LongValue("DescribeETLJobInstance.Metrics.RecordsIn");
			metrics.RecordsOut = context.LongValue("DescribeETLJobInstance.Metrics.RecordsOut");
			metrics.RecordsError = context.LongValue("DescribeETLJobInstance.Metrics.RecordsError");
			metrics.RecordsRate = context.StringValue("DescribeETLJobInstance.Metrics.RecordsRate");
			metrics.Vcores = context.LongValue("DescribeETLJobInstance.Metrics.Vcores");
			metrics.MemSize = context.LongValue("DescribeETLJobInstance.Metrics.MemSize");
			describeETLJobInstanceResponse.Metrics = metrics;

			List<DescribeETLJobInstanceResponse.DescribeETLJobInstance_FlowRelation> describeETLJobInstanceResponse_flowRelationList = new List<DescribeETLJobInstanceResponse.DescribeETLJobInstance_FlowRelation>();
			for (int i = 0; i < context.Length("DescribeETLJobInstance.FlowRelationList.Length"); i++) {
				DescribeETLJobInstanceResponse.DescribeETLJobInstance_FlowRelation flowRelation = new DescribeETLJobInstanceResponse.DescribeETLJobInstance_FlowRelation();
				flowRelation.FlowJobId = context.StringValue("DescribeETLJobInstance.FlowRelationList["+ i +"].FlowJobId");
				flowRelation.FlowJobInstanceId = context.StringValue("DescribeETLJobInstance.FlowRelationList["+ i +"].FlowJobInstanceId");

				describeETLJobInstanceResponse_flowRelationList.Add(flowRelation);
			}
			describeETLJobInstanceResponse.FlowRelationList = describeETLJobInstanceResponse_flowRelationList;

			List<DescribeETLJobInstanceResponse.DescribeETLJobInstance_StageInstance> describeETLJobInstanceResponse_stageInstanceList = new List<DescribeETLJobInstanceResponse.DescribeETLJobInstance_StageInstance>();
			for (int i = 0; i < context.Length("DescribeETLJobInstance.StageInstanceList.Length"); i++) {
				DescribeETLJobInstanceResponse.DescribeETLJobInstance_StageInstance stageInstance = new DescribeETLJobInstanceResponse.DescribeETLJobInstance_StageInstance();
				stageInstance.Id = context.StringValue("DescribeETLJobInstance.StageInstanceList["+ i +"].Id");
				stageInstance.Name = context.StringValue("DescribeETLJobInstance.StageInstanceList["+ i +"].Name");
				stageInstance.StartTime = context.LongValue("DescribeETLJobInstance.StageInstanceList["+ i +"].StartTime");
				stageInstance.EndTime = context.LongValue("DescribeETLJobInstance.StageInstanceList["+ i +"].EndTime");

				DescribeETLJobInstanceResponse.DescribeETLJobInstance_StageInstance.DescribeETLJobInstance_Metrics1 metrics1 = new DescribeETLJobInstanceResponse.DescribeETLJobInstance_StageInstance.DescribeETLJobInstance_Metrics1();
				metrics1.TotalTime = context.LongValue("DescribeETLJobInstance.StageInstanceList["+ i +"].Metrics.TotalTime");
				metrics1.RecordsIn = context.LongValue("DescribeETLJobInstance.StageInstanceList["+ i +"].Metrics.RecordsIn");
				metrics1.RecordsOut = context.LongValue("DescribeETLJobInstance.StageInstanceList["+ i +"].Metrics.RecordsOut");
				metrics1.RecordsError = context.LongValue("DescribeETLJobInstance.StageInstanceList["+ i +"].Metrics.RecordsError");
				metrics1.RecordsRate = context.StringValue("DescribeETLJobInstance.StageInstanceList["+ i +"].Metrics.RecordsRate");
				metrics1.Vcores = context.LongValue("DescribeETLJobInstance.StageInstanceList["+ i +"].Metrics.Vcores");
				metrics1.MemSize = context.LongValue("DescribeETLJobInstance.StageInstanceList["+ i +"].Metrics.MemSize");
				stageInstance.Metrics1 = metrics1;

				describeETLJobInstanceResponse_stageInstanceList.Add(stageInstance);
			}
			describeETLJobInstanceResponse.StageInstanceList = describeETLJobInstanceResponse_stageInstanceList;
        
			return describeETLJobInstanceResponse;
        }
    }
}
