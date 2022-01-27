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
    public class DescribeMigrationJobStatusResponseUnmarshaller
    {
        public static DescribeMigrationJobStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMigrationJobStatusResponse describeMigrationJobStatusResponse = new DescribeMigrationJobStatusResponse();

			describeMigrationJobStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeMigrationJobStatusResponse.ErrCode = _ctx.StringValue("DescribeMigrationJobStatus.ErrCode");
			describeMigrationJobStatusResponse.ErrMessage = _ctx.StringValue("DescribeMigrationJobStatus.ErrMessage");
			describeMigrationJobStatusResponse.MigrationJobClass = _ctx.StringValue("DescribeMigrationJobStatus.MigrationJobClass");
			describeMigrationJobStatusResponse.MigrationJobId = _ctx.StringValue("DescribeMigrationJobStatus.MigrationJobId");
			describeMigrationJobStatusResponse.MigrationJobName = _ctx.StringValue("DescribeMigrationJobStatus.MigrationJobName");
			describeMigrationJobStatusResponse.MigrationJobStatus = _ctx.StringValue("DescribeMigrationJobStatus.MigrationJobStatus");
			describeMigrationJobStatusResponse.MigrationObject = _ctx.StringValue("DescribeMigrationJobStatus.MigrationObject");
			describeMigrationJobStatusResponse.PayType = _ctx.StringValue("DescribeMigrationJobStatus.PayType");
			describeMigrationJobStatusResponse.RequestId = _ctx.StringValue("DescribeMigrationJobStatus.RequestId");
			describeMigrationJobStatusResponse.Success = _ctx.StringValue("DescribeMigrationJobStatus.Success");
			describeMigrationJobStatusResponse.TaskId = _ctx.StringValue("DescribeMigrationJobStatus.TaskId");

			DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_DataInitializationStatus dataInitializationStatus = new DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_DataInitializationStatus();
			dataInitializationStatus.ErrorMessage = _ctx.StringValue("DescribeMigrationJobStatus.DataInitializationStatus.ErrorMessage");
			dataInitializationStatus.Percent = _ctx.StringValue("DescribeMigrationJobStatus.DataInitializationStatus.Percent");
			dataInitializationStatus.Progress = _ctx.StringValue("DescribeMigrationJobStatus.DataInitializationStatus.Progress");
			dataInitializationStatus.Status = _ctx.StringValue("DescribeMigrationJobStatus.DataInitializationStatus.Status");
			describeMigrationJobStatusResponse.DataInitializationStatus = dataInitializationStatus;

			DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_DataSynchronizationStatus dataSynchronizationStatus = new DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_DataSynchronizationStatus();
			dataSynchronizationStatus.Checkpoint = _ctx.StringValue("DescribeMigrationJobStatus.DataSynchronizationStatus.Checkpoint");
			dataSynchronizationStatus.Delay = _ctx.StringValue("DescribeMigrationJobStatus.DataSynchronizationStatus.Delay");
			dataSynchronizationStatus.ErrorMessage = _ctx.StringValue("DescribeMigrationJobStatus.DataSynchronizationStatus.ErrorMessage");
			dataSynchronizationStatus.Percent = _ctx.StringValue("DescribeMigrationJobStatus.DataSynchronizationStatus.Percent");
			dataSynchronizationStatus.Status = _ctx.StringValue("DescribeMigrationJobStatus.DataSynchronizationStatus.Status");
			describeMigrationJobStatusResponse.DataSynchronizationStatus = dataSynchronizationStatus;

			DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_DestinationEndpoint destinationEndpoint = new DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_DestinationEndpoint();
			destinationEndpoint.DatabaseName = _ctx.StringValue("DescribeMigrationJobStatus.DestinationEndpoint.DatabaseName");
			destinationEndpoint.EngineName = _ctx.StringValue("DescribeMigrationJobStatus.DestinationEndpoint.EngineName");
			destinationEndpoint.IP = _ctx.StringValue("DescribeMigrationJobStatus.DestinationEndpoint.IP");
			destinationEndpoint.InstanceId = _ctx.StringValue("DescribeMigrationJobStatus.DestinationEndpoint.InstanceId");
			destinationEndpoint.InstanceType = _ctx.StringValue("DescribeMigrationJobStatus.DestinationEndpoint.InstanceType");
			destinationEndpoint.Port = _ctx.StringValue("DescribeMigrationJobStatus.DestinationEndpoint.Port");
			destinationEndpoint.UserName = _ctx.StringValue("DescribeMigrationJobStatus.DestinationEndpoint.UserName");
			destinationEndpoint.OracleSID = _ctx.StringValue("DescribeMigrationJobStatus.DestinationEndpoint.oracleSID");
			describeMigrationJobStatusResponse.DestinationEndpoint = destinationEndpoint;

			DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_MigrationMode migrationMode = new DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_MigrationMode();
			migrationMode.DataInitialization = _ctx.BooleanValue("DescribeMigrationJobStatus.MigrationMode.dataInitialization");
			migrationMode.DataSynchronization = _ctx.BooleanValue("DescribeMigrationJobStatus.MigrationMode.dataSynchronization");
			migrationMode.StructureInitialization = _ctx.BooleanValue("DescribeMigrationJobStatus.MigrationMode.structureInitialization");
			describeMigrationJobStatusResponse.MigrationMode = migrationMode;

			DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_PrecheckStatus precheckStatus = new DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_PrecheckStatus();
			precheckStatus.Percent = _ctx.StringValue("DescribeMigrationJobStatus.PrecheckStatus.Percent");
			precheckStatus.Status = _ctx.StringValue("DescribeMigrationJobStatus.PrecheckStatus.Status");

			List<DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_PrecheckStatus.DescribeMigrationJobStatus_CheckItem> precheckStatus_detail = new List<DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_PrecheckStatus.DescribeMigrationJobStatus_CheckItem>();
			for (int i = 0; i < _ctx.Length("DescribeMigrationJobStatus.PrecheckStatus.Detail.Length"); i++) {
				DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_PrecheckStatus.DescribeMigrationJobStatus_CheckItem checkItem = new DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_PrecheckStatus.DescribeMigrationJobStatus_CheckItem();
				checkItem.CheckStatus = _ctx.StringValue("DescribeMigrationJobStatus.PrecheckStatus.Detail["+ i +"].CheckStatus");
				checkItem.ErrorMessage = _ctx.StringValue("DescribeMigrationJobStatus.PrecheckStatus.Detail["+ i +"].ErrorMessage");
				checkItem.ItemName = _ctx.StringValue("DescribeMigrationJobStatus.PrecheckStatus.Detail["+ i +"].ItemName");
				checkItem.RepairMethod = _ctx.StringValue("DescribeMigrationJobStatus.PrecheckStatus.Detail["+ i +"].RepairMethod");

				precheckStatus_detail.Add(checkItem);
			}
			precheckStatus.Detail = precheckStatus_detail;
			describeMigrationJobStatusResponse.PrecheckStatus = precheckStatus;

			DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_SourceEndpoint sourceEndpoint = new DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_SourceEndpoint();
			sourceEndpoint.DatabaseName = _ctx.StringValue("DescribeMigrationJobStatus.SourceEndpoint.DatabaseName");
			sourceEndpoint.EngineName = _ctx.StringValue("DescribeMigrationJobStatus.SourceEndpoint.EngineName");
			sourceEndpoint.IP = _ctx.StringValue("DescribeMigrationJobStatus.SourceEndpoint.IP");
			sourceEndpoint.InstanceId = _ctx.StringValue("DescribeMigrationJobStatus.SourceEndpoint.InstanceId");
			sourceEndpoint.InstanceType = _ctx.StringValue("DescribeMigrationJobStatus.SourceEndpoint.InstanceType");
			sourceEndpoint.Port = _ctx.StringValue("DescribeMigrationJobStatus.SourceEndpoint.Port");
			sourceEndpoint.UserName = _ctx.StringValue("DescribeMigrationJobStatus.SourceEndpoint.UserName");
			sourceEndpoint.OracleSID = _ctx.StringValue("DescribeMigrationJobStatus.SourceEndpoint.oracleSID");
			describeMigrationJobStatusResponse.SourceEndpoint = sourceEndpoint;

			DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_StructureInitializationStatus structureInitializationStatus = new DescribeMigrationJobStatusResponse.DescribeMigrationJobStatus_StructureInitializationStatus();
			structureInitializationStatus.ErrorMessage = _ctx.StringValue("DescribeMigrationJobStatus.StructureInitializationStatus.ErrorMessage");
			structureInitializationStatus.Percent = _ctx.StringValue("DescribeMigrationJobStatus.StructureInitializationStatus.Percent");
			structureInitializationStatus.Progress = _ctx.StringValue("DescribeMigrationJobStatus.StructureInitializationStatus.Progress");
			structureInitializationStatus.Status = _ctx.StringValue("DescribeMigrationJobStatus.StructureInitializationStatus.Status");
			describeMigrationJobStatusResponse.StructureInitializationStatus = structureInitializationStatus;
        
			return describeMigrationJobStatusResponse;
        }
    }
}
