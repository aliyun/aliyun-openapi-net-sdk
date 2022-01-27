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
    public class DescribeMigrationJobsResponseUnmarshaller
    {
        public static DescribeMigrationJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMigrationJobsResponse describeMigrationJobsResponse = new DescribeMigrationJobsResponse();

			describeMigrationJobsResponse.HttpResponse = _ctx.HttpResponse;
			describeMigrationJobsResponse.ErrCode = _ctx.StringValue("DescribeMigrationJobs.ErrCode");
			describeMigrationJobsResponse.ErrMessage = _ctx.StringValue("DescribeMigrationJobs.ErrMessage");
			describeMigrationJobsResponse.PageNumber = _ctx.IntegerValue("DescribeMigrationJobs.PageNumber");
			describeMigrationJobsResponse.PageRecordCount = _ctx.IntegerValue("DescribeMigrationJobs.PageRecordCount");
			describeMigrationJobsResponse.RequestId = _ctx.StringValue("DescribeMigrationJobs.RequestId");
			describeMigrationJobsResponse.Success = _ctx.StringValue("DescribeMigrationJobs.Success");
			describeMigrationJobsResponse.TotalRecordCount = _ctx.LongValue("DescribeMigrationJobs.TotalRecordCount");

			List<DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob> describeMigrationJobsResponse_migrationJobs = new List<DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob>();
			for (int i = 0; i < _ctx.Length("DescribeMigrationJobs.MigrationJobs.Length"); i++) {
				DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob migrationJob = new DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob();
				migrationJob.MigrationJobClass = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].MigrationJobClass");
				migrationJob.MigrationJobID = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].MigrationJobID");
				migrationJob.MigrationJobName = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].MigrationJobName");
				migrationJob.MigrationJobStatus = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].MigrationJobStatus");
				migrationJob.PayType = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].PayType");
				migrationJob.JobCreateTime = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].JobCreateTime");
				migrationJob.InstanceCreateTime = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].InstanceCreateTime");

				DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_DataInitialization dataInitialization = new DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_DataInitialization();
				dataInitialization.ErrorMessage = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DataInitialization.ErrorMessage");
				dataInitialization.Percent = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DataInitialization.Percent");
				dataInitialization.Progress = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DataInitialization.Progress");
				dataInitialization.Status = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DataInitialization.status");
				migrationJob.DataInitialization = dataInitialization;

				DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_DataSynchronization dataSynchronization = new DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_DataSynchronization();
				dataSynchronization.Delay = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DataSynchronization.Delay");
				dataSynchronization.ErrorMessage = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DataSynchronization.ErrorMessage");
				dataSynchronization.Percent = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DataSynchronization.Percent");
				dataSynchronization.Status = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DataSynchronization.status");
				migrationJob.DataSynchronization = dataSynchronization;

				DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_DestinationEndpoint destinationEndpoint = new DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_DestinationEndpoint();
				destinationEndpoint.DatabaseName = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DestinationEndpoint.DatabaseName");
				destinationEndpoint.EngineName = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DestinationEndpoint.EngineName");
				destinationEndpoint.IP = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DestinationEndpoint.IP");
				destinationEndpoint.InstanceID = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DestinationEndpoint.InstanceID");
				destinationEndpoint.InstanceType = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DestinationEndpoint.InstanceType");
				destinationEndpoint.OracleSID = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DestinationEndpoint.OracleSID");
				destinationEndpoint.Port = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DestinationEndpoint.Port");
				destinationEndpoint.UserName = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].DestinationEndpoint.UserName");
				migrationJob.DestinationEndpoint = destinationEndpoint;

				DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_MigrationMode migrationMode = new DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_MigrationMode();
				migrationMode.DataInitialization = _ctx.BooleanValue("DescribeMigrationJobs.MigrationJobs["+ i +"].MigrationMode.DataInitialization");
				migrationMode.DataSynchronization = _ctx.BooleanValue("DescribeMigrationJobs.MigrationJobs["+ i +"].MigrationMode.DataSynchronization");
				migrationMode.StructureInitialization = _ctx.BooleanValue("DescribeMigrationJobs.MigrationJobs["+ i +"].MigrationMode.StructureInitialization");
				migrationJob.MigrationMode = migrationMode;

				DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_Precheck precheck = new DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_Precheck();
				precheck.Percent = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].Precheck.Percent");
				precheck.Status = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].Precheck.Status");
				migrationJob.Precheck = precheck;

				DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_SourceEndpoint sourceEndpoint = new DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_SourceEndpoint();
				sourceEndpoint.DatabaseName = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].SourceEndpoint.DatabaseName");
				sourceEndpoint.EngineName = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].SourceEndpoint.EngineName");
				sourceEndpoint.IP = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].SourceEndpoint.IP");
				sourceEndpoint.InstanceID = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].SourceEndpoint.InstanceID");
				sourceEndpoint.InstanceType = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].SourceEndpoint.InstanceType");
				sourceEndpoint.OracleSID = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].SourceEndpoint.OracleSID");
				sourceEndpoint.Port = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].SourceEndpoint.Port");
				sourceEndpoint.UserName = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].SourceEndpoint.UserName");
				migrationJob.SourceEndpoint = sourceEndpoint;

				DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_StructureInitialization structureInitialization = new DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_StructureInitialization();
				structureInitialization.ErrorMessage = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].StructureInitialization.ErrorMessage");
				structureInitialization.Percent = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].StructureInitialization.Percent");
				structureInitialization.Progress = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].StructureInitialization.Progress");
				structureInitialization.Status = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].StructureInitialization.status");
				migrationJob.StructureInitialization = structureInitialization;

				List<DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_SynchronousObject> migrationJob_migrationObject = new List<DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_SynchronousObject>();
				for (int j = 0; j < _ctx.Length("DescribeMigrationJobs.MigrationJobs["+ i +"].MigrationObject.Length"); j++) {
					DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_SynchronousObject synchronousObject = new DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_SynchronousObject();
					synchronousObject.DatabaseName = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].MigrationObject["+ j +"].DatabaseName");
					synchronousObject.WholeDatabase = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].MigrationObject["+ j +"].WholeDatabase");

					List<string> synchronousObject_tableList = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeMigrationJobs.MigrationJobs["+ i +"].MigrationObject["+ j +"].TableList.Length"); k++) {
						synchronousObject_tableList.Add(_ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].MigrationObject["+ j +"].TableList["+ k +"]"));
					}
					synchronousObject.TableList = synchronousObject_tableList;

					migrationJob_migrationObject.Add(synchronousObject);
				}
				migrationJob.MigrationObject = migrationJob_migrationObject;

				List<DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_Tag> migrationJob_tags = new List<DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeMigrationJobs.MigrationJobs["+ i +"].Tags.Length"); j++) {
					DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_Tag tag = new DescribeMigrationJobsResponse.DescribeMigrationJobs_MigrationJob.DescribeMigrationJobs_Tag();
					tag.Key = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeMigrationJobs.MigrationJobs["+ i +"].Tags["+ j +"].Value");

					migrationJob_tags.Add(tag);
				}
				migrationJob.Tags = migrationJob_tags;

				describeMigrationJobsResponse_migrationJobs.Add(migrationJob);
			}
			describeMigrationJobsResponse.MigrationJobs = describeMigrationJobsResponse_migrationJobs;
        
			return describeMigrationJobsResponse;
        }
    }
}
