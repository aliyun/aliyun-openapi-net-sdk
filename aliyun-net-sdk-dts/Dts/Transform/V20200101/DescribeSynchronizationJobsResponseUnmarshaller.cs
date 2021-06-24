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
    public class DescribeSynchronizationJobsResponseUnmarshaller
    {
        public static DescribeSynchronizationJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSynchronizationJobsResponse describeSynchronizationJobsResponse = new DescribeSynchronizationJobsResponse();

			describeSynchronizationJobsResponse.HttpResponse = _ctx.HttpResponse;
			describeSynchronizationJobsResponse.PageNumber = _ctx.IntegerValue("DescribeSynchronizationJobs.PageNumber");
			describeSynchronizationJobsResponse.PageRecordCount = _ctx.IntegerValue("DescribeSynchronizationJobs.PageRecordCount");
			describeSynchronizationJobsResponse.RequestId = _ctx.StringValue("DescribeSynchronizationJobs.RequestId");
			describeSynchronizationJobsResponse.TotalRecordCount = _ctx.LongValue("DescribeSynchronizationJobs.TotalRecordCount");

			List<DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance> describeSynchronizationJobsResponse_synchronizationInstances = new List<DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance>();
			for (int i = 0; i < _ctx.Length("DescribeSynchronizationJobs.SynchronizationInstances.Length"); i++) {
				DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance synchronizationInstance = new DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance();
				synchronizationInstance.CreateTime = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].CreateTime");
				synchronizationInstance.DataInitialization = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DataInitialization");
				synchronizationInstance.Delay = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].Delay");
				synchronizationInstance.ErrorMessage = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].ErrorMessage");
				synchronizationInstance.ExpireTime = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].ExpireTime");
				synchronizationInstance.PayType = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].PayType");
				synchronizationInstance.Status = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].Status");
				synchronizationInstance.StructureInitialization = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].StructureInitialization");
				synchronizationInstance.SynchronizationDirection = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SynchronizationDirection");
				synchronizationInstance.SynchronizationJobClass = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SynchronizationJobClass");
				synchronizationInstance.SynchronizationJobId = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SynchronizationJobId");
				synchronizationInstance.SynchronizationJobName = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SynchronizationJobName");
				synchronizationInstance.JobCreateTime = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].JobCreateTime");
				synchronizationInstance.InstanceCreateTime = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].InstanceCreateTime");

				DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_DataInitializationStatus dataInitializationStatus = new DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_DataInitializationStatus();
				dataInitializationStatus.ErrorMessage = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DataInitializationStatus.ErrorMessage");
				dataInitializationStatus.Percent = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DataInitializationStatus.Percent");
				dataInitializationStatus.Progress = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DataInitializationStatus.Progress");
				dataInitializationStatus.Status = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DataInitializationStatus.Status");
				synchronizationInstance.DataInitializationStatus = dataInitializationStatus;

				DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_DataSynchronizationStatus dataSynchronizationStatus = new DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_DataSynchronizationStatus();
				dataSynchronizationStatus.Delay = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DataSynchronizationStatus.Delay");
				dataSynchronizationStatus.ErrorMessage = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DataSynchronizationStatus.ErrorMessage");
				dataSynchronizationStatus.Percent = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DataSynchronizationStatus.Percent");
				dataSynchronizationStatus.Status = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DataSynchronizationStatus.Status");
				synchronizationInstance.DataSynchronizationStatus = dataSynchronizationStatus;

				DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_DestinationEndpoint destinationEndpoint = new DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_DestinationEndpoint();
				destinationEndpoint.EngineName = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DestinationEndpoint.EngineName");
				destinationEndpoint.IP = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DestinationEndpoint.IP");
				destinationEndpoint.InstanceId = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DestinationEndpoint.InstanceId");
				destinationEndpoint.InstanceType = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DestinationEndpoint.InstanceType");
				destinationEndpoint.Port = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DestinationEndpoint.Port");
				destinationEndpoint.UserName = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].DestinationEndpoint.UserName");
				synchronizationInstance.DestinationEndpoint = destinationEndpoint;

				DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_Performance performance = new DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_Performance();
				performance.FLOW = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].Performance.FLOW");
				performance.RPS = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].Performance.RPS");
				synchronizationInstance.Performance = performance;

				DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_PrecheckStatus precheckStatus = new DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_PrecheckStatus();
				precheckStatus.Percent = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].PrecheckStatus.Percent");
				precheckStatus.Status = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].PrecheckStatus.Status");

				List<DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_PrecheckStatus.DescribeSynchronizationJobs_CheckItem> precheckStatus_detail = new List<DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_PrecheckStatus.DescribeSynchronizationJobs_CheckItem>();
				for (int j = 0; j < _ctx.Length("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].PrecheckStatus.Detail.Length"); j++) {
					DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_PrecheckStatus.DescribeSynchronizationJobs_CheckItem checkItem = new DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_PrecheckStatus.DescribeSynchronizationJobs_CheckItem();
					checkItem.CheckStatus = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].PrecheckStatus.Detail["+ j +"].CheckStatus");
					checkItem.ErrorMessage = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].PrecheckStatus.Detail["+ j +"].ErrorMessage");
					checkItem.ItemName = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].PrecheckStatus.Detail["+ j +"].ItemName");
					checkItem.RepairMethod = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].PrecheckStatus.Detail["+ j +"].RepairMethod");

					precheckStatus_detail.Add(checkItem);
				}
				precheckStatus.Detail = precheckStatus_detail;
				synchronizationInstance.PrecheckStatus = precheckStatus;

				DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SourceEndpoint sourceEndpoint = new DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SourceEndpoint();
				sourceEndpoint.EngineName = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SourceEndpoint.EngineName");
				sourceEndpoint.IP = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SourceEndpoint.IP");
				sourceEndpoint.InstanceId = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SourceEndpoint.InstanceId");
				sourceEndpoint.InstanceType = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SourceEndpoint.InstanceType");
				sourceEndpoint.Port = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SourceEndpoint.Port");
				sourceEndpoint.UserName = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SourceEndpoint.UserName");
				synchronizationInstance.SourceEndpoint = sourceEndpoint;

				DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_StructureInitializationStatus structureInitializationStatus = new DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_StructureInitializationStatus();
				structureInitializationStatus.ErrorMessage = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].StructureInitializationStatus.ErrorMessage");
				structureInitializationStatus.Percent = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].StructureInitializationStatus.Percent");
				structureInitializationStatus.Progress = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].StructureInitializationStatus.Progress");
				structureInitializationStatus.Status = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].StructureInitializationStatus.Status");
				synchronizationInstance.StructureInitializationStatus = structureInitializationStatus;

				List<DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_Tag> synchronizationInstance_tags = new List<DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].Tags.Length"); j++) {
					DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_Tag tag = new DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_Tag();
					tag.Key = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].Tags["+ j +"].Value");

					synchronizationInstance_tags.Add(tag);
				}
				synchronizationInstance.Tags = synchronizationInstance_tags;

				List<DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SynchronizationObject> synchronizationInstance_synchronizationObjects = new List<DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SynchronizationObject>();
				for (int j = 0; j < _ctx.Length("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SynchronizationObjects.Length"); j++) {
					DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SynchronizationObject synchronizationObject = new DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SynchronizationObject();
					synchronizationObject.NewSchemaName = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SynchronizationObjects["+ j +"].NewSchemaName");
					synchronizationObject.SchemaName = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SynchronizationObjects["+ j +"].SchemaName");

					List<DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SynchronizationObject.DescribeSynchronizationJobs_TableExclude> synchronizationObject_tableExcludes = new List<DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SynchronizationObject.DescribeSynchronizationJobs_TableExclude>();
					for (int k = 0; k < _ctx.Length("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SynchronizationObjects["+ j +"].TableExcludes.Length"); k++) {
						DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SynchronizationObject.DescribeSynchronizationJobs_TableExclude tableExclude = new DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SynchronizationObject.DescribeSynchronizationJobs_TableExclude();
						tableExclude.TableName = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SynchronizationObjects["+ j +"].TableExcludes["+ k +"].TableName");

						synchronizationObject_tableExcludes.Add(tableExclude);
					}
					synchronizationObject.TableExcludes = synchronizationObject_tableExcludes;

					List<DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SynchronizationObject.DescribeSynchronizationJobs_TableInclude> synchronizationObject_tableIncludes = new List<DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SynchronizationObject.DescribeSynchronizationJobs_TableInclude>();
					for (int k = 0; k < _ctx.Length("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SynchronizationObjects["+ j +"].TableIncludes.Length"); k++) {
						DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SynchronizationObject.DescribeSynchronizationJobs_TableInclude tableInclude = new DescribeSynchronizationJobsResponse.DescribeSynchronizationJobs_SynchronizationInstance.DescribeSynchronizationJobs_SynchronizationObject.DescribeSynchronizationJobs_TableInclude();
						tableInclude.TableName = _ctx.StringValue("DescribeSynchronizationJobs.SynchronizationInstances["+ i +"].SynchronizationObjects["+ j +"].TableIncludes["+ k +"].TableName");

						synchronizationObject_tableIncludes.Add(tableInclude);
					}
					synchronizationObject.TableIncludes = synchronizationObject_tableIncludes;

					synchronizationInstance_synchronizationObjects.Add(synchronizationObject);
				}
				synchronizationInstance.SynchronizationObjects = synchronizationInstance_synchronizationObjects;

				describeSynchronizationJobsResponse_synchronizationInstances.Add(synchronizationInstance);
			}
			describeSynchronizationJobsResponse.SynchronizationInstances = describeSynchronizationJobsResponse_synchronizationInstances;
        
			return describeSynchronizationJobsResponse;
        }
    }
}
