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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeOmsOpenAPIProjectResponseUnmarshaller
    {
        public static DescribeOmsOpenAPIProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOmsOpenAPIProjectResponse describeOmsOpenAPIProjectResponse = new DescribeOmsOpenAPIProjectResponse();

			describeOmsOpenAPIProjectResponse.HttpResponse = _ctx.HttpResponse;
			describeOmsOpenAPIProjectResponse.Success = _ctx.BooleanValue("DescribeOmsOpenAPIProject.Success");
			describeOmsOpenAPIProjectResponse.Code = _ctx.StringValue("DescribeOmsOpenAPIProject.Code");
			describeOmsOpenAPIProjectResponse.Message = _ctx.StringValue("DescribeOmsOpenAPIProject.Message");
			describeOmsOpenAPIProjectResponse.Advice = _ctx.StringValue("DescribeOmsOpenAPIProject.Advice");
			describeOmsOpenAPIProjectResponse.RequestId = _ctx.StringValue("DescribeOmsOpenAPIProject.RequestId");
			describeOmsOpenAPIProjectResponse.PageNumber = _ctx.IntegerValue("DescribeOmsOpenAPIProject.PageNumber");
			describeOmsOpenAPIProjectResponse.PageSize = _ctx.IntegerValue("DescribeOmsOpenAPIProject.PageSize");
			describeOmsOpenAPIProjectResponse.TotalCount = _ctx.LongValue("DescribeOmsOpenAPIProject.TotalCount");
			describeOmsOpenAPIProjectResponse.Cost = _ctx.StringValue("DescribeOmsOpenAPIProject.Cost");

			DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_ErrorDetail errorDetail = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_ErrorDetail();
			errorDetail.Code = _ctx.StringValue("DescribeOmsOpenAPIProject.ErrorDetail.Code");
			errorDetail.Level = _ctx.StringValue("DescribeOmsOpenAPIProject.ErrorDetail.Level");
			errorDetail.Message = _ctx.StringValue("DescribeOmsOpenAPIProject.ErrorDetail.Message");
			errorDetail.Proposal = _ctx.StringValue("DescribeOmsOpenAPIProject.ErrorDetail.Proposal");
			describeOmsOpenAPIProjectResponse.ErrorDetail = errorDetail;

			DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data data = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data();
			data.ProjectId = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.ProjectId");
			data.ProjectName = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.ProjectName");
			data.ProjectOwner = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.ProjectOwner");
			data.BusinessName = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.BusinessName");

			DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_SourceConfig sourceConfig = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_SourceConfig();
			sourceConfig.EndpointType = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.SourceConfig.EndpointType");
			sourceConfig.EndpointId = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.SourceConfig.EndpointId");
			sourceConfig.PartitionMode = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.SourceConfig.PartitionMode");
			sourceConfig.Partition = _ctx.IntegerValue("DescribeOmsOpenAPIProject.Data.SourceConfig.Partition");
			sourceConfig.SerializerType = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.SourceConfig.SerializerType");
			sourceConfig.TopicType = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.SourceConfig.TopicType");
			sourceConfig.SequenceEnable = _ctx.BooleanValue("DescribeOmsOpenAPIProject.Data.SourceConfig.SequenceEnable");
			sourceConfig.SequenceStartTimestamp = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.SourceConfig.SequenceStartTimestamp");
			sourceConfig.ProducerGroup = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.SourceConfig.ProducerGroup");
			sourceConfig.MsgTags = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.SourceConfig.MsgTags");
			sourceConfig.EnableMsgTrace = _ctx.BooleanValue("DescribeOmsOpenAPIProject.Data.SourceConfig.EnableMsgTrace");
			sourceConfig.SendMsgTimeout = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.SourceConfig.SendMsgTimeout");
			data.SourceConfig = sourceConfig;

			DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_DestConfig destConfig = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_DestConfig();
			destConfig.EndpointType = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.DestConfig.EndpointType");
			destConfig.EndpointId = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.DestConfig.EndpointId");
			destConfig.PartitionMode = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.DestConfig.PartitionMode");
			destConfig.Partition = _ctx.IntegerValue("DescribeOmsOpenAPIProject.Data.DestConfig.Partition");
			destConfig.SerializerType = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.DestConfig.SerializerType");
			destConfig.TopicType = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.DestConfig.TopicType");
			destConfig.SequenceEnable = _ctx.BooleanValue("DescribeOmsOpenAPIProject.Data.DestConfig.SequenceEnable");
			destConfig.SequenceStartTimestamp = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.DestConfig.SequenceStartTimestamp");
			destConfig.ProducerGroup = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.DestConfig.ProducerGroup");
			destConfig.MsgTags = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.DestConfig.MsgTags");
			destConfig.EnableMsgTrace = _ctx.BooleanValue("DescribeOmsOpenAPIProject.Data.DestConfig.EnableMsgTrace");
			destConfig.SendMsgTimeout = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.DestConfig.SendMsgTimeout");
			data.DestConfig = destConfig;

			DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferMapping transferMapping = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferMapping();
			transferMapping.Mode = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Mode");

			List<DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferMapping.DescribeOmsOpenAPIProject_Database> transferMapping_databases = new List<DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferMapping.DescribeOmsOpenAPIProject_Database>();
			for (int i = 0; i < _ctx.Length("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases.Length"); i++) {
				DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferMapping.DescribeOmsOpenAPIProject_Database database = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferMapping.DescribeOmsOpenAPIProject_Database();
				database.TenantName = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].TenantName");
				database.MappedName = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].MappedName");
				database.DatabaseId = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].DatabaseId");
				database.DatabaseName = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].DatabaseName");
				database.Type = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Type");

				List<DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferMapping.DescribeOmsOpenAPIProject_Database.DescribeOmsOpenAPIProject_Table> database_tables = new List<DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferMapping.DescribeOmsOpenAPIProject_Database.DescribeOmsOpenAPIProject_Table>();
				for (int j = 0; j < _ctx.Length("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables.Length"); j++) {
					DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferMapping.DescribeOmsOpenAPIProject_Database.DescribeOmsOpenAPIProject_Table table = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferMapping.DescribeOmsOpenAPIProject_Database.DescribeOmsOpenAPIProject_Table();
					table.MappedName = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].MappedName");
					table.TableId = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].TableId");
					table.TableName = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].TableName");
					table.WhereClause = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].WhereClause");
					table.Type = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].Type");

					List<string> table_filterColumns = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].FilterColumns.Length"); k++) {
						table_filterColumns.Add(_ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].FilterColumns["+ k +"]"));
					}
					table.FilterColumns = table_filterColumns;

					List<string> table_shardColumns = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].ShardColumns.Length"); k++) {
						table_shardColumns.Add(_ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].ShardColumns["+ k +"]"));
					}
					table.ShardColumns = table_shardColumns;

					DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferMapping.DescribeOmsOpenAPIProject_Database.DescribeOmsOpenAPIProject_Table.DescribeOmsOpenAPIProject_AdbTableSchema adbTableSchema = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferMapping.DescribeOmsOpenAPIProject_Database.DescribeOmsOpenAPIProject_Table.DescribeOmsOpenAPIProject_AdbTableSchema();
					adbTableSchema.PartitionStatement = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].AdbTableSchema.PartitionStatement");
					adbTableSchema.PartitionLifeCycle = _ctx.IntegerValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].AdbTableSchema.PartitionLifeCycle");

					List<string> adbTableSchema_primaryKeys = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].AdbTableSchema.PrimaryKeys.Length"); k++) {
						adbTableSchema_primaryKeys.Add(_ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].AdbTableSchema.PrimaryKeys["+ k +"]"));
					}
					adbTableSchema.PrimaryKeys = adbTableSchema_primaryKeys;

					List<string> adbTableSchema_distributedKeys = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].AdbTableSchema.DistributedKeys.Length"); k++) {
						adbTableSchema_distributedKeys.Add(_ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferMapping.Databases["+ i +"].Tables["+ j +"].AdbTableSchema.DistributedKeys["+ k +"]"));
					}
					adbTableSchema.DistributedKeys = adbTableSchema_distributedKeys;
					table.AdbTableSchema = adbTableSchema;

					database_tables.Add(table);
				}
				database.Tables = database_tables;

				transferMapping_databases.Add(database);
			}
			transferMapping.Databases = transferMapping_databases;
			data.TransferMapping = transferMapping;

			DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferStepConfig transferStepConfig = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferStepConfig();
			transferStepConfig.EnableStructSync = _ctx.BooleanValue("DescribeOmsOpenAPIProject.Data.TransferStepConfig.EnableStructSync");
			transferStepConfig.EnableFullSync = _ctx.BooleanValue("DescribeOmsOpenAPIProject.Data.TransferStepConfig.EnableFullSync");
			transferStepConfig.EnableIncrSync = _ctx.BooleanValue("DescribeOmsOpenAPIProject.Data.TransferStepConfig.EnableIncrSync");

			DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferStepConfig.DescribeOmsOpenAPIProject_IncrSyncStepTransferConfig incrSyncStepTransferConfig = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_TransferStepConfig.DescribeOmsOpenAPIProject_IncrSyncStepTransferConfig();
			incrSyncStepTransferConfig.StartTimestamp = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.TransferStepConfig.IncrSyncStepTransferConfig.StartTimestamp");
			incrSyncStepTransferConfig.StoreLogKeptHour = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.TransferStepConfig.IncrSyncStepTransferConfig.StoreLogKeptHour");
			incrSyncStepTransferConfig.StoreTransactionEnabled = _ctx.BooleanValue("DescribeOmsOpenAPIProject.Data.TransferStepConfig.IncrSyncStepTransferConfig.StoreTransactionEnabled");
			incrSyncStepTransferConfig.TransferStepType = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferStepConfig.IncrSyncStepTransferConfig.TransferStepType");

			List<string> incrSyncStepTransferConfig_recordTypeList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOmsOpenAPIProject.Data.TransferStepConfig.IncrSyncStepTransferConfig.RecordTypeList.Length"); i++) {
				incrSyncStepTransferConfig_recordTypeList.Add(_ctx.StringValue("DescribeOmsOpenAPIProject.Data.TransferStepConfig.IncrSyncStepTransferConfig.RecordTypeList["+ i +"]"));
			}
			incrSyncStepTransferConfig.RecordTypeList = incrSyncStepTransferConfig_recordTypeList;
			transferStepConfig.IncrSyncStepTransferConfig = incrSyncStepTransferConfig;
			data.TransferStepConfig = transferStepConfig;

			List<DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Label> data_labels = new List<DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Label>();
			for (int i = 0; i < _ctx.Length("DescribeOmsOpenAPIProject.Data.Labels.Length"); i++) {
				DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Label label = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Label();
				label.Id = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Labels["+ i +"].Id");
				label.Name = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Labels["+ i +"].Name");
				label.Creator = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Labels["+ i +"].Creator");
				label.Count = _ctx.IntegerValue("DescribeOmsOpenAPIProject.Data.Labels["+ i +"].Count");

				data_labels.Add(label);
			}
			data.Labels = data_labels;

			List<DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step> data_steps = new List<DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step>();
			for (int i = 0; i < _ctx.Length("DescribeOmsOpenAPIProject.Data.Steps.Length"); i++) {
				DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step step = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step();
				step.StepOrder = _ctx.IntegerValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepOrder");
				step.StepName = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepName");
				step.StepDescription = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepDescription");
				step.StepStatus = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepStatus");
				step.StepProgress = _ctx.IntegerValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepProgress");
				step.StartTime = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StartTime");
				step.EstimatedRemainingSeconds = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].EstimatedRemainingSeconds");
				step.FinishTime = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].FinishTime");
				step.Interactive = _ctx.BooleanValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].Interactive");

				DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step.DescribeOmsOpenAPIProject_StepInfo stepInfo = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step.DescribeOmsOpenAPIProject_StepInfo();
				stepInfo.JobId = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.JobId");
				stepInfo.IncrTimestampCheckpoint = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.IncrTimestampCheckpoint");
				stepInfo.Checkpoint = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.Checkpoint");
				stepInfo.Gmt = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.Gmt");
				stepInfo.Validated = _ctx.BooleanValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.Validated");
				stepInfo.Skipped = _ctx.BooleanValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.Skipped");
				stepInfo.Inconsistencies = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.Inconsistencies");
				stepInfo.DeployId = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.DeployId");
				stepInfo.ProcessedRecords = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.ProcessedRecords");
				stepInfo.Capacity = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.Capacity");
				stepInfo.SrcRps = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.SrcRps");
				stepInfo.SrcRt = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.SrcRt");
				stepInfo.SrcIops = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.SrcIops");
				stepInfo.DstRps = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.DstRps");
				stepInfo.DstRt = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.DstRt");
				stepInfo.DstIops = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.DstIops");
				stepInfo.SrcRpsRef = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.SrcRpsRef");
				stepInfo.SrcRtRef = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.SrcRtRef");
				stepInfo.DstRpsRef = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.DstRpsRef");
				stepInfo.DstRtRef = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.DstRtRef");
				stepInfo.SrcIopsRef = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.SrcIopsRef");

				DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step.DescribeOmsOpenAPIProject_StepInfo.DescribeOmsOpenAPIProject_ConnectorFullProgressOverview connectorFullProgressOverview = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step.DescribeOmsOpenAPIProject_StepInfo.DescribeOmsOpenAPIProject_ConnectorFullProgressOverview();
				connectorFullProgressOverview.EstimatedTotalCount = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.ConnectorFullProgressOverview.EstimatedTotalCount");
				connectorFullProgressOverview.FinishedCount = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.ConnectorFullProgressOverview.FinishedCount");
				connectorFullProgressOverview.Progress = _ctx.IntegerValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.ConnectorFullProgressOverview.Progress");
				connectorFullProgressOverview.EstimatedRemainingTimeOfSec = _ctx.LongValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].StepInfo.ConnectorFullProgressOverview.EstimatedRemainingTimeOfSec");
				stepInfo.ConnectorFullProgressOverview = connectorFullProgressOverview;
				step.StepInfo = stepInfo;

				DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step.DescribeOmsOpenAPIProject_ExtraInfo extraInfo = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step.DescribeOmsOpenAPIProject_ExtraInfo();
				extraInfo.ErrorCode = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].ExtraInfo.ErrorCode");
				extraInfo.ErrorMsg = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].ExtraInfo.ErrorMsg");
				extraInfo.ErrorParam = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].ExtraInfo.ErrorParam");
				extraInfo.FailedTime = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].ExtraInfo.FailedTime");

				List<DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step.DescribeOmsOpenAPIProject_ExtraInfo.DescribeOmsOpenAPIProject_ErrorDetail1> extraInfo_errorDetails = new List<DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step.DescribeOmsOpenAPIProject_ExtraInfo.DescribeOmsOpenAPIProject_ErrorDetail1>();
				for (int j = 0; j < _ctx.Length("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].ExtraInfo.ErrorDetails.Length"); j++) {
					DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step.DescribeOmsOpenAPIProject_ExtraInfo.DescribeOmsOpenAPIProject_ErrorDetail1 errorDetail1 = new DescribeOmsOpenAPIProjectResponse.DescribeOmsOpenAPIProject_Data.DescribeOmsOpenAPIProject_Step.DescribeOmsOpenAPIProject_ExtraInfo.DescribeOmsOpenAPIProject_ErrorDetail1();
					errorDetail1.Code = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].ExtraInfo.ErrorDetails["+ j +"].Code");
					errorDetail1.Level = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].ExtraInfo.ErrorDetails["+ j +"].Level");
					errorDetail1.Message = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].ExtraInfo.ErrorDetails["+ j +"].Message");
					errorDetail1.Proposal = _ctx.StringValue("DescribeOmsOpenAPIProject.Data.Steps["+ i +"].ExtraInfo.ErrorDetails["+ j +"].Proposal");

					extraInfo_errorDetails.Add(errorDetail1);
				}
				extraInfo.ErrorDetails = extraInfo_errorDetails;
				step.ExtraInfo = extraInfo;

				data_steps.Add(step);
			}
			data.Steps = data_steps;
			describeOmsOpenAPIProjectResponse.Data = data;
        
			return describeOmsOpenAPIProjectResponse;
        }
    }
}
