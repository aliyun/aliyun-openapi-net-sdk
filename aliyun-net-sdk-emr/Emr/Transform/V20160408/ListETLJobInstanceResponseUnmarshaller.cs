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
    public class ListETLJobInstanceResponseUnmarshaller
    {
        public static ListETLJobInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			ListETLJobInstanceResponse listETLJobInstanceResponse = new ListETLJobInstanceResponse();

			listETLJobInstanceResponse.HttpResponse = context.HttpResponse;
			listETLJobInstanceResponse.RequestId = context.StringValue("ListETLJobInstance.RequestId");
			listETLJobInstanceResponse.Total = context.IntegerValue("ListETLJobInstance.Total");
			listETLJobInstanceResponse.PageSize = context.IntegerValue("ListETLJobInstance.PageSize");
			listETLJobInstanceResponse.PageNumber = context.IntegerValue("ListETLJobInstance.PageNumber");

			List<ListETLJobInstanceResponse.ListETLJobInstance_Instance> listETLJobInstanceResponse_instanceList = new List<ListETLJobInstanceResponse.ListETLJobInstance_Instance>();
			for (int i = 0; i < context.Length("ListETLJobInstance.InstanceList.Length"); i++) {
				ListETLJobInstanceResponse.ListETLJobInstance_Instance instance = new ListETLJobInstanceResponse.ListETLJobInstance_Instance();
				instance.Id = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].Id");
				instance.Name = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].Name");
				instance.EtlJobId = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].EtlJobId");
				instance.InstanceStatus = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].InstanceStatus");
				instance.TriggerType = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].TriggerType");
				instance.TriggerUser = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].TriggerUser");
				instance.StartTime = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].StartTime");
				instance.EndTime = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].EndTime");

				ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_Arguments arguments = new ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_Arguments();
				arguments.Key = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].Arguments.Key");
				arguments._Value = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].Arguments.Value");
				instance.Arguments = arguments;

				ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_Metrics metrics = new ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_Metrics();
				metrics.TotalTime = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].Metrics.TotalTime");
				metrics.RecordsIn = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].Metrics.RecordsIn");
				metrics.RecordsOut = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].Metrics.RecordsOut");
				metrics.RecordsError = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].Metrics.RecordsError");
				metrics.RecordsRate = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].Metrics.RecordsRate");
				metrics.Vcores = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].Metrics.Vcores");
				metrics.MemSize = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].Metrics.MemSize");
				instance.Metrics = metrics;

				List<ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_FlowRelation> instance_flowRelationList = new List<ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_FlowRelation>();
				for (int j = 0; j < context.Length("ListETLJobInstance.InstanceList["+ i +"].FlowRelationList.Length"); j++) {
					ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_FlowRelation flowRelation = new ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_FlowRelation();
					flowRelation.FlowJobId = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].FlowRelationList["+ j +"].FlowJobId");
					flowRelation.FlowJobInstanceId = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].FlowRelationList["+ j +"].FlowJobInstanceId");

					instance_flowRelationList.Add(flowRelation);
				}
				instance.FlowRelationList = instance_flowRelationList;

				List<ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_StageInstance> instance_stageInstanceList = new List<ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_StageInstance>();
				for (int j = 0; j < context.Length("ListETLJobInstance.InstanceList["+ i +"].StageInstanceList.Length"); j++) {
					ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_StageInstance stageInstance = new ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_StageInstance();
					stageInstance.Id = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].StageInstanceList["+ j +"].Id");
					stageInstance.Name = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].StageInstanceList["+ j +"].Name");
					stageInstance.StartTime = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].StageInstanceList["+ j +"].StartTime");
					stageInstance.EndTime = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].StageInstanceList["+ j +"].EndTime");

					ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_StageInstance.ListETLJobInstance_Metrics1 metrics1 = new ListETLJobInstanceResponse.ListETLJobInstance_Instance.ListETLJobInstance_StageInstance.ListETLJobInstance_Metrics1();
					metrics1.TotalTime = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].StageInstanceList["+ j +"].Metrics.TotalTime");
					metrics1.RecordsIn = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].StageInstanceList["+ j +"].Metrics.RecordsIn");
					metrics1.RecordsOut = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].StageInstanceList["+ j +"].Metrics.RecordsOut");
					metrics1.RecordsError = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].StageInstanceList["+ j +"].Metrics.RecordsError");
					metrics1.RecordsRate = context.StringValue("ListETLJobInstance.InstanceList["+ i +"].StageInstanceList["+ j +"].Metrics.RecordsRate");
					metrics1.Vcores = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].StageInstanceList["+ j +"].Metrics.Vcores");
					metrics1.MemSize = context.LongValue("ListETLJobInstance.InstanceList["+ i +"].StageInstanceList["+ j +"].Metrics.MemSize");
					stageInstance.Metrics1 = metrics1;

					instance_stageInstanceList.Add(stageInstance);
				}
				instance.StageInstanceList = instance_stageInstanceList;

				listETLJobInstanceResponse_instanceList.Add(instance);
			}
			listETLJobInstanceResponse.InstanceList = listETLJobInstanceResponse_instanceList;
        
			return listETLJobInstanceResponse;
        }
    }
}
