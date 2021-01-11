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
    public class DescribeDtsJobsResponseUnmarshaller
    {
        public static DescribeDtsJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDtsJobsResponse describeDtsJobsResponse = new DescribeDtsJobsResponse();

			describeDtsJobsResponse.HttpResponse = _ctx.HttpResponse;
			describeDtsJobsResponse.RequestId = _ctx.StringValue("DescribeDtsJobs.RequestId");
			describeDtsJobsResponse.Success = _ctx.BooleanValue("DescribeDtsJobs.Success");
			describeDtsJobsResponse.ErrCode = _ctx.StringValue("DescribeDtsJobs.ErrCode");
			describeDtsJobsResponse.ErrMessage = _ctx.StringValue("DescribeDtsJobs.ErrMessage");
			describeDtsJobsResponse.DynamicCode = _ctx.StringValue("DescribeDtsJobs.DynamicCode");
			describeDtsJobsResponse.DynamicMessage = _ctx.StringValue("DescribeDtsJobs.DynamicMessage");
			describeDtsJobsResponse.HttpStatusCode = _ctx.IntegerValue("DescribeDtsJobs.HttpStatusCode");
			describeDtsJobsResponse.PageNumber = _ctx.IntegerValue("DescribeDtsJobs.PageNumber");
			describeDtsJobsResponse.PageRecordCount = _ctx.IntegerValue("DescribeDtsJobs.PageRecordCount");
			describeDtsJobsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeDtsJobs.TotalRecordCount");

			List<DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus> describeDtsJobsResponse_dtsJobList = new List<DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus>();
			for (int i = 0; i < _ctx.Length("DescribeDtsJobs.DtsJobList.Length"); i++) {
				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus dtsJobStatus = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus();
				dtsJobStatus.DtsInstanceID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DtsInstanceID");
				dtsJobStatus.DtsJobId = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DtsJobId");
				dtsJobStatus.DtsJobName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DtsJobName");
				dtsJobStatus.DtsJobClass = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DtsJobClass");
				dtsJobStatus.DtsJobDirection = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DtsJobDirection");
				dtsJobStatus.PayType = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].PayType");
				dtsJobStatus.ExpireTime = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ExpireTime");
				dtsJobStatus.CreateTime = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].CreateTime");
				dtsJobStatus.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].Status");
				dtsJobStatus.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ErrorMessage");
				dtsJobStatus.Delay = _ctx.IntegerValue("DescribeDtsJobs.DtsJobList["+ i +"].Delay");
				dtsJobStatus.Checkpoint = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].Checkpoint");
				dtsJobStatus.DbObject = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DbObject");
				dtsJobStatus.Reserved = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].Reserved");

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_SourceEndpoint sourceEndpoint = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_SourceEndpoint();
				sourceEndpoint.InstanceID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.InstanceID");
				sourceEndpoint.InstanceType = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.InstanceType");
				sourceEndpoint.EngineName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.EngineName");
				sourceEndpoint.Ip = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.Ip");
				sourceEndpoint.Port = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.Port");
				sourceEndpoint.DatabaseName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.DatabaseName");
				sourceEndpoint.OracleSID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.OracleSID");
				sourceEndpoint.UserName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.UserName");
				sourceEndpoint.SslSolutionEnum = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.SslSolutionEnum");
				sourceEndpoint.Region = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.Region");
				dtsJobStatus.SourceEndpoint = sourceEndpoint;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DestinationEndpoint destinationEndpoint = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DestinationEndpoint();
				destinationEndpoint.InstanceID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.InstanceID");
				destinationEndpoint.InstanceType = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.InstanceType");
				destinationEndpoint.EngineName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.EngineName");
				destinationEndpoint.Ip = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.Ip");
				destinationEndpoint.Port = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.Port");
				destinationEndpoint.DatabaseName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.DatabaseName");
				destinationEndpoint.OracleSID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.OracleSID");
				destinationEndpoint.UserName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.UserName");
				destinationEndpoint.SslSolutionEnum = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.SslSolutionEnum");
				destinationEndpoint.Region = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.Region");
				dtsJobStatus.DestinationEndpoint = destinationEndpoint;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_MigrationMode migrationMode = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_MigrationMode();
				migrationMode.StructureInitialization = _ctx.BooleanValue("DescribeDtsJobs.DtsJobList["+ i +"].MigrationMode.StructureInitialization");
				migrationMode.DataInitialization = _ctx.BooleanValue("DescribeDtsJobs.DtsJobList["+ i +"].MigrationMode.DataInitialization");
				migrationMode.DataSynchronization = _ctx.BooleanValue("DescribeDtsJobs.DtsJobList["+ i +"].MigrationMode.DataSynchronization");
				dtsJobStatus.MigrationMode = migrationMode;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_PrecheckStatus precheckStatus = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_PrecheckStatus();
				precheckStatus.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].PrecheckStatus.Status");
				precheckStatus.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].PrecheckStatus.Percent");
				precheckStatus.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].PrecheckStatus.ErrorMessage");

				List<DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_PrecheckStatus.DescribeDtsJobs_PrecheckDetail> precheckStatus_detail = new List<DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_PrecheckStatus.DescribeDtsJobs_PrecheckDetail>();
				for (int j = 0; j < _ctx.Length("DescribeDtsJobs.DtsJobList["+ i +"].PrecheckStatus.Detail.Length"); j++) {
					DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_PrecheckStatus.DescribeDtsJobs_PrecheckDetail precheckDetail = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_PrecheckStatus.DescribeDtsJobs_PrecheckDetail();
					precheckDetail.CheckItem = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].PrecheckStatus.Detail["+ j +"].CheckItem");
					precheckDetail.CheckItemDescription = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].PrecheckStatus.Detail["+ j +"].CheckItemDescription");
					precheckDetail.CheckResult = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].PrecheckStatus.Detail["+ j +"].CheckResult");
					precheckDetail.FailedReason = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].PrecheckStatus.Detail["+ j +"].FailedReason");
					precheckDetail.RepairMethod = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].PrecheckStatus.Detail["+ j +"].RepairMethod");

					precheckStatus_detail.Add(precheckDetail);
				}
				precheckStatus.Detail = precheckStatus_detail;
				dtsJobStatus.PrecheckStatus = precheckStatus;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_StructureInitializationStatus structureInitializationStatus = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_StructureInitializationStatus();
				structureInitializationStatus.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].StructureInitializationStatus.Status");
				structureInitializationStatus.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].StructureInitializationStatus.ErrorMessage");
				structureInitializationStatus.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].StructureInitializationStatus.Percent");
				structureInitializationStatus.Progress = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].StructureInitializationStatus.Progress");
				dtsJobStatus.StructureInitializationStatus = structureInitializationStatus;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DataInitializationStatus dataInitializationStatus = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DataInitializationStatus();
				dataInitializationStatus.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataInitializationStatus.Status");
				dataInitializationStatus.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataInitializationStatus.ErrorMessage");
				dataInitializationStatus.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataInitializationStatus.Percent");
				dataInitializationStatus.Progress = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataInitializationStatus.Progress");
				dtsJobStatus.DataInitializationStatus = dataInitializationStatus;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DataSynchronizationStatus dataSynchronizationStatus = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DataSynchronizationStatus();
				dataSynchronizationStatus.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataSynchronizationStatus.Status");
				dataSynchronizationStatus.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataSynchronizationStatus.ErrorMessage");
				dataSynchronizationStatus.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataSynchronizationStatus.Percent");
				dataSynchronizationStatus.Progress = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataSynchronizationStatus.Progress");
				dtsJobStatus.DataSynchronizationStatus = dataSynchronizationStatus;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_Performance performance = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_Performance();
				performance.Rps = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].Performance.Rps");
				performance.Flow = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].Performance.Flow");
				dtsJobStatus.Performance = performance;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob reverseJob = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob();
				reverseJob.DtsInstanceID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DtsInstanceID");
				reverseJob.DtsJobId = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DtsJobId");
				reverseJob.DtsJobName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DtsJobName");
				reverseJob.DtsJobClass = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DtsJobClass");
				reverseJob.DtsJobDirection = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DtsJobDirection");
				reverseJob.PayType = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PayType");
				reverseJob.ExpireTime = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.ExpireTime");
				reverseJob.CreateTime = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.CreateTime");
				reverseJob.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.Status");
				reverseJob.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.ErrorMessage");
				reverseJob.Delay = _ctx.IntegerValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.Delay");
				reverseJob.Checkpoint = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.Checkpoint");
				reverseJob.DbObject = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DbObject");
				reverseJob.Reserved = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.Reserved");

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_SourceEndpoint1 sourceEndpoint1 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_SourceEndpoint1();
				sourceEndpoint1.InstanceID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.InstanceID");
				sourceEndpoint1.InstanceType = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.InstanceType");
				sourceEndpoint1.EngineName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.EngineName");
				sourceEndpoint1.Ip = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.Ip");
				sourceEndpoint1.Port = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.Port");
				sourceEndpoint1.DatabaseName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.DatabaseName");
				sourceEndpoint1.OracleSID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.OracleSID");
				sourceEndpoint1.UserName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.UserName");
				sourceEndpoint1.SslSolutionEnum = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.SslSolutionEnum");
				sourceEndpoint1.Region = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.Region");
				reverseJob.SourceEndpoint1 = sourceEndpoint1;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_DestinationEndpoint2 destinationEndpoint2 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_DestinationEndpoint2();
				destinationEndpoint2.InstanceID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.InstanceID");
				destinationEndpoint2.InstanceType = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.InstanceType");
				destinationEndpoint2.EngineName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.EngineName");
				destinationEndpoint2.Ip = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.Ip");
				destinationEndpoint2.Port = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.Port");
				destinationEndpoint2.DatabaseName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.DatabaseName");
				destinationEndpoint2.OracleSID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.OracleSID");
				destinationEndpoint2.UserName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.UserName");
				destinationEndpoint2.SslSolutionEnum = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.SslSolutionEnum");
				destinationEndpoint2.Region = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.Region");
				reverseJob.DestinationEndpoint2 = destinationEndpoint2;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_MigrationMode3 migrationMode3 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_MigrationMode3();
				migrationMode3.StructureInitialization = _ctx.BooleanValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.MigrationMode.StructureInitialization");
				migrationMode3.DataInitialization = _ctx.BooleanValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.MigrationMode.DataInitialization");
				migrationMode3.DataSynchronization = _ctx.BooleanValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.MigrationMode.DataSynchronization");
				reverseJob.MigrationMode3 = migrationMode3;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_PrecheckStatus4 precheckStatus4 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_PrecheckStatus4();
				precheckStatus4.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Status");
				precheckStatus4.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Percent");
				precheckStatus4.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.ErrorMessage");

				List<DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_PrecheckStatus4.DescribeDtsJobs_PrecheckDetail10> precheckStatus4_detail9 = new List<DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_PrecheckStatus4.DescribeDtsJobs_PrecheckDetail10>();
				for (int j = 0; j < _ctx.Length("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Detail.Length"); j++) {
					DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_PrecheckStatus4.DescribeDtsJobs_PrecheckDetail10 precheckDetail10 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_PrecheckStatus4.DescribeDtsJobs_PrecheckDetail10();
					precheckDetail10.CheckItem = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Detail["+ j +"].CheckItem");
					precheckDetail10.CheckItemDescription = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Detail["+ j +"].CheckItemDescription");
					precheckDetail10.CheckResult = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Detail["+ j +"].CheckResult");
					precheckDetail10.FailedReason = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Detail["+ j +"].FailedReason");
					precheckDetail10.RepairMethod = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Detail["+ j +"].RepairMethod");

					precheckStatus4_detail9.Add(precheckDetail10);
				}
				precheckStatus4.Detail9 = precheckStatus4_detail9;
				reverseJob.PrecheckStatus4 = precheckStatus4;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_StructureInitializationStatus5 structureInitializationStatus5 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_StructureInitializationStatus5();
				structureInitializationStatus5.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.StructureInitializationStatus.Status");
				structureInitializationStatus5.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.StructureInitializationStatus.ErrorMessage");
				structureInitializationStatus5.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.StructureInitializationStatus.Percent");
				structureInitializationStatus5.Progress = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.StructureInitializationStatus.Progress");
				reverseJob.StructureInitializationStatus5 = structureInitializationStatus5;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_DataInitializationStatus6 dataInitializationStatus6 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_DataInitializationStatus6();
				dataInitializationStatus6.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataInitializationStatus.Status");
				dataInitializationStatus6.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataInitializationStatus.ErrorMessage");
				dataInitializationStatus6.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataInitializationStatus.Percent");
				dataInitializationStatus6.Progress = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataInitializationStatus.Progress");
				reverseJob.DataInitializationStatus6 = dataInitializationStatus6;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_DataSynchronizationStatus7 dataSynchronizationStatus7 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_DataSynchronizationStatus7();
				dataSynchronizationStatus7.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataSynchronizationStatus.Status");
				dataSynchronizationStatus7.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataSynchronizationStatus.ErrorMessage");
				dataSynchronizationStatus7.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataSynchronizationStatus.Percent");
				dataSynchronizationStatus7.Progress = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataSynchronizationStatus.Progress");
				reverseJob.DataSynchronizationStatus7 = dataSynchronizationStatus7;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_Performance8 performance8 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_Performance8();
				performance8.Rps = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.Performance.Rps");
				performance8.Flow = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.Performance.Flow");
				reverseJob.Performance8 = performance8;
				dtsJobStatus.ReverseJob = reverseJob;

				List<DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DtsTag> dtsJobStatus_tagList = new List<DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DtsTag>();
				for (int j = 0; j < _ctx.Length("DescribeDtsJobs.DtsJobList["+ i +"].TagList.Length"); j++) {
					DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DtsTag dtsTag = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DtsTag();
					dtsTag.TagKey = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].TagList["+ j +"].TagKey");
					dtsTag.TagValue = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].TagList["+ j +"].TagValue");

					dtsJobStatus_tagList.Add(dtsTag);
				}
				dtsJobStatus.TagList = dtsJobStatus_tagList;

				describeDtsJobsResponse_dtsJobList.Add(dtsJobStatus);
			}
			describeDtsJobsResponse.DtsJobList = describeDtsJobsResponse_dtsJobList;
        
			return describeDtsJobsResponse;
        }
    }
}
