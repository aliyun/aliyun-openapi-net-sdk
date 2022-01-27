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
			describeDtsJobsResponse.DynamicCode = _ctx.StringValue("DescribeDtsJobs.DynamicCode");
			describeDtsJobsResponse.DynamicMessage = _ctx.StringValue("DescribeDtsJobs.DynamicMessage");
			describeDtsJobsResponse.ErrCode = _ctx.StringValue("DescribeDtsJobs.ErrCode");
			describeDtsJobsResponse.ErrMessage = _ctx.StringValue("DescribeDtsJobs.ErrMessage");
			describeDtsJobsResponse.HttpStatusCode = _ctx.IntegerValue("DescribeDtsJobs.HttpStatusCode");
			describeDtsJobsResponse.PageNumber = _ctx.IntegerValue("DescribeDtsJobs.PageNumber");
			describeDtsJobsResponse.PageRecordCount = _ctx.IntegerValue("DescribeDtsJobs.PageRecordCount");
			describeDtsJobsResponse.RequestId = _ctx.StringValue("DescribeDtsJobs.RequestId");
			describeDtsJobsResponse.Success = _ctx.BooleanValue("DescribeDtsJobs.Success");
			describeDtsJobsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeDtsJobs.TotalRecordCount");

			List<DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus> describeDtsJobsResponse_dtsJobList = new List<DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus>();
			for (int i = 0; i < _ctx.Length("DescribeDtsJobs.DtsJobList.Length"); i++) {
				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus dtsJobStatus = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus();
				dtsJobStatus.Checkpoint = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].Checkpoint");
				dtsJobStatus.CreateTime = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].CreateTime");
				dtsJobStatus.DbObject = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DbObject");
				dtsJobStatus.Delay = _ctx.IntegerValue("DescribeDtsJobs.DtsJobList["+ i +"].Delay");
				dtsJobStatus.DtsInstanceID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DtsInstanceID");
				dtsJobStatus.DtsJobClass = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DtsJobClass");
				dtsJobStatus.DtsJobDirection = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DtsJobDirection");
				dtsJobStatus.DtsJobId = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DtsJobId");
				dtsJobStatus.DtsJobName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DtsJobName");
				dtsJobStatus.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ErrorMessage");
				dtsJobStatus.ExpireTime = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ExpireTime");
				dtsJobStatus.PayType = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].PayType");
				dtsJobStatus.Reserved = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].Reserved");
				dtsJobStatus.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].Status");
				dtsJobStatus.ConsumptionClient = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ConsumptionClient");
				dtsJobStatus.BeginTimestamp = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].BeginTimestamp");
				dtsJobStatus.EndTimestamp = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].EndTimestamp");
				dtsJobStatus.ConsumptionCheckpoint = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ConsumptionCheckpoint");
				dtsJobStatus.AppName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].AppName");

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DataInitializationStatus dataInitializationStatus = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DataInitializationStatus();
				dataInitializationStatus.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataInitializationStatus.ErrorMessage");
				dataInitializationStatus.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataInitializationStatus.Percent");
				dataInitializationStatus.Progress = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataInitializationStatus.Progress");
				dataInitializationStatus.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataInitializationStatus.Status");
				dtsJobStatus.DataInitializationStatus = dataInitializationStatus;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DataSynchronizationStatus dataSynchronizationStatus = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DataSynchronizationStatus();
				dataSynchronizationStatus.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataSynchronizationStatus.ErrorMessage");
				dataSynchronizationStatus.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataSynchronizationStatus.Percent");
				dataSynchronizationStatus.Progress = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataSynchronizationStatus.Progress");
				dataSynchronizationStatus.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataSynchronizationStatus.Status");
				dtsJobStatus.DataSynchronizationStatus = dataSynchronizationStatus;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DataEtlStatus dataEtlStatus = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DataEtlStatus();
				dataEtlStatus.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataEtlStatus.ErrorMessage");
				dataEtlStatus.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataEtlStatus.Percent");
				dataEtlStatus.Progress = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataEtlStatus.Progress");
				dataEtlStatus.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DataEtlStatus.Status");
				dtsJobStatus.DataEtlStatus = dataEtlStatus;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DestinationEndpoint destinationEndpoint = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_DestinationEndpoint();
				destinationEndpoint.DatabaseName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.DatabaseName");
				destinationEndpoint.EngineName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.EngineName");
				destinationEndpoint.InstanceID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.InstanceID");
				destinationEndpoint.InstanceType = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.InstanceType");
				destinationEndpoint.Ip = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.Ip");
				destinationEndpoint.OracleSID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.OracleSID");
				destinationEndpoint.Port = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.Port");
				destinationEndpoint.Region = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.Region");
				destinationEndpoint.SslSolutionEnum = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.SslSolutionEnum");
				destinationEndpoint.UserName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].DestinationEndpoint.UserName");
				dtsJobStatus.DestinationEndpoint = destinationEndpoint;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_MigrationMode migrationMode = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_MigrationMode();
				migrationMode.DataInitialization = _ctx.BooleanValue("DescribeDtsJobs.DtsJobList["+ i +"].MigrationMode.DataInitialization");
				migrationMode.DataSynchronization = _ctx.BooleanValue("DescribeDtsJobs.DtsJobList["+ i +"].MigrationMode.DataSynchronization");
				migrationMode.StructureInitialization = _ctx.BooleanValue("DescribeDtsJobs.DtsJobList["+ i +"].MigrationMode.StructureInitialization");
				dtsJobStatus.MigrationMode = migrationMode;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_Performance performance = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_Performance();
				performance.Flow = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].Performance.Flow");
				performance.Rps = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].Performance.Rps");
				dtsJobStatus.Performance = performance;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_PrecheckStatus precheckStatus = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_PrecheckStatus();
				precheckStatus.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].PrecheckStatus.ErrorMessage");
				precheckStatus.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].PrecheckStatus.Percent");
				precheckStatus.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].PrecheckStatus.Status");

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

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob reverseJob = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob();
				reverseJob.Checkpoint = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.Checkpoint");
				reverseJob.CreateTime = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.CreateTime");
				reverseJob.DbObject = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DbObject");
				reverseJob.Delay = _ctx.IntegerValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.Delay");
				reverseJob.DtsInstanceID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DtsInstanceID");
				reverseJob.DtsJobClass = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DtsJobClass");
				reverseJob.DtsJobDirection = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DtsJobDirection");
				reverseJob.DtsJobId = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DtsJobId");
				reverseJob.DtsJobName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DtsJobName");
				reverseJob.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.ErrorMessage");
				reverseJob.ExpireTime = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.ExpireTime");
				reverseJob.PayType = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PayType");
				reverseJob.Reserved = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.Reserved");
				reverseJob.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.Status");

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_DataInitializationStatus1 dataInitializationStatus1 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_DataInitializationStatus1();
				dataInitializationStatus1.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataInitializationStatus.ErrorMessage");
				dataInitializationStatus1.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataInitializationStatus.Percent");
				dataInitializationStatus1.Progress = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataInitializationStatus.Progress");
				dataInitializationStatus1.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataInitializationStatus.Status");
				reverseJob.DataInitializationStatus1 = dataInitializationStatus1;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_DataSynchronizationStatus2 dataSynchronizationStatus2 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_DataSynchronizationStatus2();
				dataSynchronizationStatus2.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataSynchronizationStatus.ErrorMessage");
				dataSynchronizationStatus2.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataSynchronizationStatus.Percent");
				dataSynchronizationStatus2.Progress = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataSynchronizationStatus.Progress");
				dataSynchronizationStatus2.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DataSynchronizationStatus.Status");
				reverseJob.DataSynchronizationStatus2 = dataSynchronizationStatus2;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_DestinationEndpoint3 destinationEndpoint3 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_DestinationEndpoint3();
				destinationEndpoint3.DatabaseName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.DatabaseName");
				destinationEndpoint3.EngineName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.EngineName");
				destinationEndpoint3.InstanceID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.InstanceID");
				destinationEndpoint3.InstanceType = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.InstanceType");
				destinationEndpoint3.Ip = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.Ip");
				destinationEndpoint3.OracleSID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.OracleSID");
				destinationEndpoint3.Port = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.Port");
				destinationEndpoint3.Region = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.Region");
				destinationEndpoint3.SslSolutionEnum = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.SslSolutionEnum");
				destinationEndpoint3.UserName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.DestinationEndpoint.UserName");
				reverseJob.DestinationEndpoint3 = destinationEndpoint3;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_MigrationMode4 migrationMode4 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_MigrationMode4();
				migrationMode4.DataInitialization = _ctx.BooleanValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.MigrationMode.DataInitialization");
				migrationMode4.DataSynchronization = _ctx.BooleanValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.MigrationMode.DataSynchronization");
				migrationMode4.StructureInitialization = _ctx.BooleanValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.MigrationMode.StructureInitialization");
				reverseJob.MigrationMode4 = migrationMode4;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_Performance5 performance5 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_Performance5();
				performance5.Flow = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.Performance.Flow");
				performance5.Rps = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.Performance.Rps");
				reverseJob.Performance5 = performance5;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_PrecheckStatus6 precheckStatus6 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_PrecheckStatus6();
				precheckStatus6.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.ErrorMessage");
				precheckStatus6.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Percent");
				precheckStatus6.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Status");

				List<DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_PrecheckStatus6.DescribeDtsJobs_PrecheckDetail10> precheckStatus6_detail9 = new List<DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_PrecheckStatus6.DescribeDtsJobs_PrecheckDetail10>();
				for (int j = 0; j < _ctx.Length("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Detail.Length"); j++) {
					DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_PrecheckStatus6.DescribeDtsJobs_PrecheckDetail10 precheckDetail10 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_PrecheckStatus6.DescribeDtsJobs_PrecheckDetail10();
					precheckDetail10.CheckItem = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Detail["+ j +"].CheckItem");
					precheckDetail10.CheckItemDescription = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Detail["+ j +"].CheckItemDescription");
					precheckDetail10.CheckResult = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Detail["+ j +"].CheckResult");
					precheckDetail10.FailedReason = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Detail["+ j +"].FailedReason");
					precheckDetail10.RepairMethod = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.PrecheckStatus.Detail["+ j +"].RepairMethod");

					precheckStatus6_detail9.Add(precheckDetail10);
				}
				precheckStatus6.Detail9 = precheckStatus6_detail9;
				reverseJob.PrecheckStatus6 = precheckStatus6;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_SourceEndpoint7 sourceEndpoint7 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_SourceEndpoint7();
				sourceEndpoint7.DatabaseName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.DatabaseName");
				sourceEndpoint7.EngineName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.EngineName");
				sourceEndpoint7.InstanceID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.InstanceID");
				sourceEndpoint7.InstanceType = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.InstanceType");
				sourceEndpoint7.Ip = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.Ip");
				sourceEndpoint7.OracleSID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.OracleSID");
				sourceEndpoint7.Port = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.Port");
				sourceEndpoint7.Region = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.Region");
				sourceEndpoint7.SslSolutionEnum = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.SslSolutionEnum");
				sourceEndpoint7.UserName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.SourceEndpoint.UserName");
				reverseJob.SourceEndpoint7 = sourceEndpoint7;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_StructureInitializationStatus8 structureInitializationStatus8 = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_ReverseJob.DescribeDtsJobs_StructureInitializationStatus8();
				structureInitializationStatus8.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.StructureInitializationStatus.ErrorMessage");
				structureInitializationStatus8.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.StructureInitializationStatus.Percent");
				structureInitializationStatus8.Progress = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.StructureInitializationStatus.Progress");
				structureInitializationStatus8.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].ReverseJob.StructureInitializationStatus.Status");
				reverseJob.StructureInitializationStatus8 = structureInitializationStatus8;
				dtsJobStatus.ReverseJob = reverseJob;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_SourceEndpoint sourceEndpoint = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_SourceEndpoint();
				sourceEndpoint.DatabaseName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.DatabaseName");
				sourceEndpoint.EngineName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.EngineName");
				sourceEndpoint.InstanceID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.InstanceID");
				sourceEndpoint.InstanceType = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.InstanceType");
				sourceEndpoint.Ip = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.Ip");
				sourceEndpoint.OracleSID = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.OracleSID");
				sourceEndpoint.Port = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.Port");
				sourceEndpoint.Region = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.Region");
				sourceEndpoint.SslSolutionEnum = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.SslSolutionEnum");
				sourceEndpoint.UserName = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].SourceEndpoint.UserName");
				dtsJobStatus.SourceEndpoint = sourceEndpoint;

				DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_StructureInitializationStatus structureInitializationStatus = new DescribeDtsJobsResponse.DescribeDtsJobs_DtsJobStatus.DescribeDtsJobs_StructureInitializationStatus();
				structureInitializationStatus.ErrorMessage = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].StructureInitializationStatus.ErrorMessage");
				structureInitializationStatus.Percent = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].StructureInitializationStatus.Percent");
				structureInitializationStatus.Progress = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].StructureInitializationStatus.Progress");
				structureInitializationStatus.Status = _ctx.StringValue("DescribeDtsJobs.DtsJobList["+ i +"].StructureInitializationStatus.Status");
				dtsJobStatus.StructureInitializationStatus = structureInitializationStatus;

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
