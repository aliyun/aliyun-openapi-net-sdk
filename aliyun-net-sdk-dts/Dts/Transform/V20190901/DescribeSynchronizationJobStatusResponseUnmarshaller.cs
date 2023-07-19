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
using Aliyun.Acs.Dts.Model.V20190901;

namespace Aliyun.Acs.Dts.Transform.V20190901
{
    public class DescribeSynchronizationJobStatusResponseUnmarshaller
    {
        public static DescribeSynchronizationJobStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSynchronizationJobStatusResponse describeSynchronizationJobStatusResponse = new DescribeSynchronizationJobStatusResponse();

			describeSynchronizationJobStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeSynchronizationJobStatusResponse.SynchronizationJobName = _ctx.StringValue("DescribeSynchronizationJobStatus.SynchronizationJobName");
			describeSynchronizationJobStatusResponse.DataInitialization = _ctx.StringValue("DescribeSynchronizationJobStatus.DataInitialization");
			describeSynchronizationJobStatusResponse.Status = _ctx.StringValue("DescribeSynchronizationJobStatus.Status");
			describeSynchronizationJobStatusResponse.Delay = _ctx.StringValue("DescribeSynchronizationJobStatus.Delay");
			describeSynchronizationJobStatusResponse.ErrorMessage = _ctx.StringValue("DescribeSynchronizationJobStatus.ErrorMessage");
			describeSynchronizationJobStatusResponse.ExpireTime = _ctx.StringValue("DescribeSynchronizationJobStatus.ExpireTime");
			describeSynchronizationJobStatusResponse.PayType = _ctx.StringValue("DescribeSynchronizationJobStatus.PayType");
			describeSynchronizationJobStatusResponse.StructureInitialization = _ctx.StringValue("DescribeSynchronizationJobStatus.StructureInitialization");
			describeSynchronizationJobStatusResponse.SynchronizationJobClass = _ctx.StringValue("DescribeSynchronizationJobStatus.SynchronizationJobClass");
			describeSynchronizationJobStatusResponse.RequestId = _ctx.StringValue("DescribeSynchronizationJobStatus.RequestId");
			describeSynchronizationJobStatusResponse.SynchronizationJobId = _ctx.StringValue("DescribeSynchronizationJobStatus.SynchronizationJobId");
			describeSynchronizationJobStatusResponse.SynchronizationDirection = _ctx.StringValue("DescribeSynchronizationJobStatus.SynchronizationDirection");
			describeSynchronizationJobStatusResponse.Checkpoint = _ctx.StringValue("DescribeSynchronizationJobStatus.Checkpoint");

			DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SourceEndpoint sourceEndpoint = new DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SourceEndpoint();
			sourceEndpoint.InstanceId = _ctx.StringValue("DescribeSynchronizationJobStatus.SourceEndpoint.InstanceId");
			sourceEndpoint.InstanceType = _ctx.StringValue("DescribeSynchronizationJobStatus.SourceEndpoint.InstanceType");
			sourceEndpoint.IP = _ctx.StringValue("DescribeSynchronizationJobStatus.SourceEndpoint.IP");
			sourceEndpoint.Port = _ctx.StringValue("DescribeSynchronizationJobStatus.SourceEndpoint.Port");
			sourceEndpoint.UserName = _ctx.StringValue("DescribeSynchronizationJobStatus.SourceEndpoint.UserName");
			sourceEndpoint.EngineName = _ctx.StringValue("DescribeSynchronizationJobStatus.SourceEndpoint.EngineName");
			describeSynchronizationJobStatusResponse.SourceEndpoint = sourceEndpoint;

			DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_DestinationEndpoint destinationEndpoint = new DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_DestinationEndpoint();
			destinationEndpoint.InstanceId = _ctx.StringValue("DescribeSynchronizationJobStatus.DestinationEndpoint.InstanceId");
			destinationEndpoint.InstanceType = _ctx.StringValue("DescribeSynchronizationJobStatus.DestinationEndpoint.InstanceType");
			destinationEndpoint.IP = _ctx.StringValue("DescribeSynchronizationJobStatus.DestinationEndpoint.IP");
			destinationEndpoint.Port = _ctx.StringValue("DescribeSynchronizationJobStatus.DestinationEndpoint.Port");
			destinationEndpoint.UserName = _ctx.StringValue("DescribeSynchronizationJobStatus.DestinationEndpoint.UserName");
			destinationEndpoint.EngineName = _ctx.StringValue("DescribeSynchronizationJobStatus.DestinationEndpoint.EngineName");
			describeSynchronizationJobStatusResponse.DestinationEndpoint = destinationEndpoint;

			DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_PrecheckStatus precheckStatus = new DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_PrecheckStatus();
			precheckStatus.Status = _ctx.StringValue("DescribeSynchronizationJobStatus.PrecheckStatus.Status");
			precheckStatus.Percent = _ctx.StringValue("DescribeSynchronizationJobStatus.PrecheckStatus.Percent");

			List<DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_PrecheckStatus.DescribeSynchronizationJobStatus_CheckItem> precheckStatus_detail = new List<DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_PrecheckStatus.DescribeSynchronizationJobStatus_CheckItem>();
			for (int i = 0; i < _ctx.Length("DescribeSynchronizationJobStatus.PrecheckStatus.Detail.Length"); i++) {
				DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_PrecheckStatus.DescribeSynchronizationJobStatus_CheckItem checkItem = new DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_PrecheckStatus.DescribeSynchronizationJobStatus_CheckItem();
				checkItem.CheckStatus = _ctx.StringValue("DescribeSynchronizationJobStatus.PrecheckStatus.Detail["+ i +"].CheckStatus");
				checkItem.ErrorMessage = _ctx.StringValue("DescribeSynchronizationJobStatus.PrecheckStatus.Detail["+ i +"].ErrorMessage");
				checkItem.ItemName = _ctx.StringValue("DescribeSynchronizationJobStatus.PrecheckStatus.Detail["+ i +"].ItemName");
				checkItem.RepairMethod = _ctx.StringValue("DescribeSynchronizationJobStatus.PrecheckStatus.Detail["+ i +"].RepairMethod");

				precheckStatus_detail.Add(checkItem);
			}
			precheckStatus.Detail = precheckStatus_detail;
			describeSynchronizationJobStatusResponse.PrecheckStatus = precheckStatus;

			DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_StructureInitializationStatus structureInitializationStatus = new DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_StructureInitializationStatus();
			structureInitializationStatus.Status = _ctx.StringValue("DescribeSynchronizationJobStatus.StructureInitializationStatus.Status");
			structureInitializationStatus.Percent = _ctx.StringValue("DescribeSynchronizationJobStatus.StructureInitializationStatus.Percent");
			structureInitializationStatus.Progress = _ctx.StringValue("DescribeSynchronizationJobStatus.StructureInitializationStatus.Progress");
			structureInitializationStatus.ErrorMessage = _ctx.StringValue("DescribeSynchronizationJobStatus.StructureInitializationStatus.ErrorMessage");
			describeSynchronizationJobStatusResponse.StructureInitializationStatus = structureInitializationStatus;

			DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_DataInitializationStatus dataInitializationStatus = new DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_DataInitializationStatus();
			dataInitializationStatus.Status = _ctx.StringValue("DescribeSynchronizationJobStatus.DataInitializationStatus.Status");
			dataInitializationStatus.Percent = _ctx.StringValue("DescribeSynchronizationJobStatus.DataInitializationStatus.Percent");
			dataInitializationStatus.Progress = _ctx.StringValue("DescribeSynchronizationJobStatus.DataInitializationStatus.Progress");
			dataInitializationStatus.ErrorMessage = _ctx.StringValue("DescribeSynchronizationJobStatus.DataInitializationStatus.ErrorMessage");
			describeSynchronizationJobStatusResponse.DataInitializationStatus = dataInitializationStatus;

			DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_DataSynchronizationStatus dataSynchronizationStatus = new DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_DataSynchronizationStatus();
			dataSynchronizationStatus.Status = _ctx.StringValue("DescribeSynchronizationJobStatus.DataSynchronizationStatus.Status");
			dataSynchronizationStatus.Delay = _ctx.StringValue("DescribeSynchronizationJobStatus.DataSynchronizationStatus.Delay");
			dataSynchronizationStatus.Percent = _ctx.StringValue("DescribeSynchronizationJobStatus.DataSynchronizationStatus.Percent");
			dataSynchronizationStatus.ErrorMessage = _ctx.StringValue("DescribeSynchronizationJobStatus.DataSynchronizationStatus.ErrorMessage");
			dataSynchronizationStatus.Checkpoint = _ctx.StringValue("DescribeSynchronizationJobStatus.DataSynchronizationStatus.Checkpoint");
			describeSynchronizationJobStatusResponse.DataSynchronizationStatus = dataSynchronizationStatus;

			DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_Performance performance = new DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_Performance();
			performance.RPS = _ctx.StringValue("DescribeSynchronizationJobStatus.Performance.RPS");
			performance.FLOW = _ctx.StringValue("DescribeSynchronizationJobStatus.Performance.FLOW");
			describeSynchronizationJobStatusResponse.Performance = performance;

			List<DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SynchronizationObject> describeSynchronizationJobStatusResponse_synchronizationObjects = new List<DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SynchronizationObject>();
			for (int i = 0; i < _ctx.Length("DescribeSynchronizationJobStatus.SynchronizationObjects.Length"); i++) {
				DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SynchronizationObject synchronizationObject = new DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SynchronizationObject();
				synchronizationObject.NewSchemaName = _ctx.StringValue("DescribeSynchronizationJobStatus.SynchronizationObjects["+ i +"].NewSchemaName");
				synchronizationObject.SchemaName = _ctx.StringValue("DescribeSynchronizationJobStatus.SynchronizationObjects["+ i +"].SchemaName");

				List<DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SynchronizationObject.DescribeSynchronizationJobStatus_TableInclude> synchronizationObject_tableIncludes = new List<DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SynchronizationObject.DescribeSynchronizationJobStatus_TableInclude>();
				for (int j = 0; j < _ctx.Length("DescribeSynchronizationJobStatus.SynchronizationObjects["+ i +"].TableIncludes.Length"); j++) {
					DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SynchronizationObject.DescribeSynchronizationJobStatus_TableInclude tableInclude = new DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SynchronizationObject.DescribeSynchronizationJobStatus_TableInclude();
					tableInclude.TableName = _ctx.StringValue("DescribeSynchronizationJobStatus.SynchronizationObjects["+ i +"].TableIncludes["+ j +"].TableName");

					synchronizationObject_tableIncludes.Add(tableInclude);
				}
				synchronizationObject.TableIncludes = synchronizationObject_tableIncludes;

				List<DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SynchronizationObject.DescribeSynchronizationJobStatus_TableExclude> synchronizationObject_tableExcludes = new List<DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SynchronizationObject.DescribeSynchronizationJobStatus_TableExclude>();
				for (int j = 0; j < _ctx.Length("DescribeSynchronizationJobStatus.SynchronizationObjects["+ i +"].TableExcludes.Length"); j++) {
					DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SynchronizationObject.DescribeSynchronizationJobStatus_TableExclude tableExclude = new DescribeSynchronizationJobStatusResponse.DescribeSynchronizationJobStatus_SynchronizationObject.DescribeSynchronizationJobStatus_TableExclude();
					tableExclude.TableName = _ctx.StringValue("DescribeSynchronizationJobStatus.SynchronizationObjects["+ i +"].TableExcludes["+ j +"].TableName");

					synchronizationObject_tableExcludes.Add(tableExclude);
				}
				synchronizationObject.TableExcludes = synchronizationObject_tableExcludes;

				describeSynchronizationJobStatusResponse_synchronizationObjects.Add(synchronizationObject);
			}
			describeSynchronizationJobStatusResponse.SynchronizationObjects = describeSynchronizationJobStatusResponse_synchronizationObjects;
        
			return describeSynchronizationJobStatusResponse;
        }
    }
}
