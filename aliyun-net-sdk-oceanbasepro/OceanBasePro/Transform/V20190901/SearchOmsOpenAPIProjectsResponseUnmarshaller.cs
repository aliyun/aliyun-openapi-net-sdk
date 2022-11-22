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
    public class SearchOmsOpenAPIProjectsResponseUnmarshaller
    {
        public static SearchOmsOpenAPIProjectsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchOmsOpenAPIProjectsResponse searchOmsOpenAPIProjectsResponse = new SearchOmsOpenAPIProjectsResponse();

			searchOmsOpenAPIProjectsResponse.HttpResponse = _ctx.HttpResponse;
			searchOmsOpenAPIProjectsResponse.Success = _ctx.BooleanValue("SearchOmsOpenAPIProjects.Success");
			searchOmsOpenAPIProjectsResponse.Code = _ctx.StringValue("SearchOmsOpenAPIProjects.Code");
			searchOmsOpenAPIProjectsResponse.Message = _ctx.StringValue("SearchOmsOpenAPIProjects.Message");
			searchOmsOpenAPIProjectsResponse.Advice = _ctx.StringValue("SearchOmsOpenAPIProjects.Advice");
			searchOmsOpenAPIProjectsResponse.RequestId = _ctx.StringValue("SearchOmsOpenAPIProjects.RequestId");
			searchOmsOpenAPIProjectsResponse.PageNumber = _ctx.IntegerValue("SearchOmsOpenAPIProjects.PageNumber");
			searchOmsOpenAPIProjectsResponse.PageSize = _ctx.IntegerValue("SearchOmsOpenAPIProjects.PageSize");
			searchOmsOpenAPIProjectsResponse.TotalCount = _ctx.LongValue("SearchOmsOpenAPIProjects.TotalCount");
			searchOmsOpenAPIProjectsResponse.Cost = _ctx.StringValue("SearchOmsOpenAPIProjects.Cost");

			SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_ErrorDetail1 errorDetail1 = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_ErrorDetail1();
			errorDetail1.Code = _ctx.StringValue("SearchOmsOpenAPIProjects.ErrorDetail.Code");
			errorDetail1.Level = _ctx.StringValue("SearchOmsOpenAPIProjects.ErrorDetail.Level");
			errorDetail1.Message = _ctx.StringValue("SearchOmsOpenAPIProjects.ErrorDetail.Message");
			errorDetail1.Proposal = _ctx.StringValue("SearchOmsOpenAPIProjects.ErrorDetail.Proposal");
			searchOmsOpenAPIProjectsResponse.ErrorDetail1 = errorDetail1;

			List<SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem> searchOmsOpenAPIProjectsResponse_data = new List<SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem>();
			for (int i = 0; i < _ctx.Length("SearchOmsOpenAPIProjects.Data.Length"); i++) {
				SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem dataItem = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem();
				dataItem.ProjectId = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].ProjectId");
				dataItem.ProjectName = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].ProjectName");
				dataItem.ProjectOwner = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].ProjectOwner");
				dataItem.BusinessName = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].BusinessName");

				SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_SourceConfig sourceConfig = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_SourceConfig();
				sourceConfig.EndpointType = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].SourceConfig.EndpointType");
				sourceConfig.EndpointId = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].SourceConfig.EndpointId");
				sourceConfig.PartitionMode = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].SourceConfig.PartitionMode");
				sourceConfig.Partition = _ctx.IntegerValue("SearchOmsOpenAPIProjects.Data["+ i +"].SourceConfig.Partition");
				sourceConfig.SerializerType = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].SourceConfig.SerializerType");
				sourceConfig.TopicType = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].SourceConfig.TopicType");
				sourceConfig.SequenceEnable = _ctx.BooleanValue("SearchOmsOpenAPIProjects.Data["+ i +"].SourceConfig.SequenceEnable");
				sourceConfig.SequenceStartTimestamp = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].SourceConfig.SequenceStartTimestamp");
				sourceConfig.ProducerGroup = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].SourceConfig.ProducerGroup");
				sourceConfig.MsgTags = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].SourceConfig.MsgTags");
				sourceConfig.EnableMsgTrace = _ctx.BooleanValue("SearchOmsOpenAPIProjects.Data["+ i +"].SourceConfig.EnableMsgTrace");
				sourceConfig.SendMsgTimeout = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].SourceConfig.SendMsgTimeout");
				dataItem.SourceConfig = sourceConfig;

				SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_DestConfig destConfig = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_DestConfig();
				destConfig.EndpointType = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].DestConfig.EndpointType");
				destConfig.EndpointId = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].DestConfig.EndpointId");
				destConfig.PartitionMode = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].DestConfig.PartitionMode");
				destConfig.Partition = _ctx.IntegerValue("SearchOmsOpenAPIProjects.Data["+ i +"].DestConfig.Partition");
				destConfig.SerializerType = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].DestConfig.SerializerType");
				destConfig.TopicType = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].DestConfig.TopicType");
				destConfig.SequenceEnable = _ctx.BooleanValue("SearchOmsOpenAPIProjects.Data["+ i +"].DestConfig.SequenceEnable");
				destConfig.SequenceStartTimestamp = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].DestConfig.SequenceStartTimestamp");
				destConfig.ProducerGroup = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].DestConfig.ProducerGroup");
				destConfig.MsgTags = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].DestConfig.MsgTags");
				destConfig.EnableMsgTrace = _ctx.BooleanValue("SearchOmsOpenAPIProjects.Data["+ i +"].DestConfig.EnableMsgTrace");
				destConfig.SendMsgTimeout = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].DestConfig.SendMsgTimeout");
				dataItem.DestConfig = destConfig;

				SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferMapping transferMapping = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferMapping();
				transferMapping.Mode = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Mode");

				List<SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferMapping.SearchOmsOpenAPIProjects_Database> transferMapping_databases = new List<SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferMapping.SearchOmsOpenAPIProjects_Database>();
				for (int j = 0; j < _ctx.Length("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases.Length"); j++) {
					SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferMapping.SearchOmsOpenAPIProjects_Database database = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferMapping.SearchOmsOpenAPIProjects_Database();
					database.TenantName = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].TenantName");
					database.MappedName = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].MappedName");
					database.DatabaseId = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].DatabaseId");
					database.DatabaseName = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].DatabaseName");
					database.Type = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Type");

					List<SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferMapping.SearchOmsOpenAPIProjects_Database.SearchOmsOpenAPIProjects_Table> database_tables = new List<SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferMapping.SearchOmsOpenAPIProjects_Database.SearchOmsOpenAPIProjects_Table>();
					for (int k = 0; k < _ctx.Length("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables.Length"); k++) {
						SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferMapping.SearchOmsOpenAPIProjects_Database.SearchOmsOpenAPIProjects_Table table = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferMapping.SearchOmsOpenAPIProjects_Database.SearchOmsOpenAPIProjects_Table();
						table.MappedName = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].MappedName");
						table.TableId = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].TableId");
						table.TableName = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].TableName");
						table.WhereClause = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].WhereClause");
						table.Type = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].Type");

						List<string> table_filterColumns = new List<string>();
						for (int l = 0; l < _ctx.Length("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].FilterColumns.Length"); l++) {
							table_filterColumns.Add(_ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].FilterColumns["+ l +"]"));
						}
						table.FilterColumns = table_filterColumns;

						List<string> table_shardColumns = new List<string>();
						for (int l = 0; l < _ctx.Length("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].ShardColumns.Length"); l++) {
							table_shardColumns.Add(_ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].ShardColumns["+ l +"]"));
						}
						table.ShardColumns = table_shardColumns;

						SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferMapping.SearchOmsOpenAPIProjects_Database.SearchOmsOpenAPIProjects_Table.SearchOmsOpenAPIProjects_AdbTableSchema adbTableSchema = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferMapping.SearchOmsOpenAPIProjects_Database.SearchOmsOpenAPIProjects_Table.SearchOmsOpenAPIProjects_AdbTableSchema();
						adbTableSchema.PartitionStatement = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].AdbTableSchema.PartitionStatement");
						adbTableSchema.PartitionLifeCycle = _ctx.IntegerValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].AdbTableSchema.PartitionLifeCycle");

						List<string> adbTableSchema_primaryKeys = new List<string>();
						for (int l = 0; l < _ctx.Length("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].AdbTableSchema.PrimaryKeys.Length"); l++) {
							adbTableSchema_primaryKeys.Add(_ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].AdbTableSchema.PrimaryKeys["+ l +"]"));
						}
						adbTableSchema.PrimaryKeys = adbTableSchema_primaryKeys;

						List<string> adbTableSchema_distributedKeys = new List<string>();
						for (int l = 0; l < _ctx.Length("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].AdbTableSchema.DistributedKeys.Length"); l++) {
							adbTableSchema_distributedKeys.Add(_ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferMapping.Databases["+ j +"].Tables["+ k +"].AdbTableSchema.DistributedKeys["+ l +"]"));
						}
						adbTableSchema.DistributedKeys = adbTableSchema_distributedKeys;
						table.AdbTableSchema = adbTableSchema;

						database_tables.Add(table);
					}
					database.Tables = database_tables;

					transferMapping_databases.Add(database);
				}
				transferMapping.Databases = transferMapping_databases;
				dataItem.TransferMapping = transferMapping;

				SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferStepConfig transferStepConfig = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferStepConfig();
				transferStepConfig.EnableStructSync = _ctx.BooleanValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferStepConfig.EnableStructSync");
				transferStepConfig.EnableFullSync = _ctx.BooleanValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferStepConfig.EnableFullSync");
				transferStepConfig.EnableIncrSync = _ctx.BooleanValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferStepConfig.EnableIncrSync");

				SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferStepConfig.SearchOmsOpenAPIProjects_IncrSyncStepTransferConfig incrSyncStepTransferConfig = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_TransferStepConfig.SearchOmsOpenAPIProjects_IncrSyncStepTransferConfig();
				incrSyncStepTransferConfig.StartTimestamp = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferStepConfig.IncrSyncStepTransferConfig.StartTimestamp");
				incrSyncStepTransferConfig.StoreLogKeptHour = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferStepConfig.IncrSyncStepTransferConfig.StoreLogKeptHour");
				incrSyncStepTransferConfig.StoreTransactionEnabled = _ctx.BooleanValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferStepConfig.IncrSyncStepTransferConfig.StoreTransactionEnabled");
				incrSyncStepTransferConfig.TransferStepType = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferStepConfig.IncrSyncStepTransferConfig.TransferStepType");

				List<string> incrSyncStepTransferConfig_recordTypeList = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchOmsOpenAPIProjects.Data["+ i +"].TransferStepConfig.IncrSyncStepTransferConfig.RecordTypeList.Length"); j++) {
					incrSyncStepTransferConfig_recordTypeList.Add(_ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].TransferStepConfig.IncrSyncStepTransferConfig.RecordTypeList["+ j +"]"));
				}
				incrSyncStepTransferConfig.RecordTypeList = incrSyncStepTransferConfig_recordTypeList;
				transferStepConfig.IncrSyncStepTransferConfig = incrSyncStepTransferConfig;
				dataItem.TransferStepConfig = transferStepConfig;

				List<SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Label> dataItem_labels = new List<SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Label>();
				for (int j = 0; j < _ctx.Length("SearchOmsOpenAPIProjects.Data["+ i +"].Labels.Length"); j++) {
					SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Label label = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Label();
					label.Id = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Labels["+ j +"].Id");
					label.Name = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Labels["+ j +"].Name");
					label.Creator = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Labels["+ j +"].Creator");
					label.Count = _ctx.IntegerValue("SearchOmsOpenAPIProjects.Data["+ i +"].Labels["+ j +"].Count");

					dataItem_labels.Add(label);
				}
				dataItem.Labels = dataItem_labels;

				List<SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step> dataItem_steps = new List<SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step>();
				for (int j = 0; j < _ctx.Length("SearchOmsOpenAPIProjects.Data["+ i +"].Steps.Length"); j++) {
					SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step step = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step();
					step.StepOrder = _ctx.IntegerValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepOrder");
					step.StepName = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepName");
					step.StepDescription = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepDescription");
					step.StepStatus = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepStatus");
					step.StepProgress = _ctx.IntegerValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepProgress");
					step.StartTime = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StartTime");
					step.EstimatedRemainingSeconds = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].EstimatedRemainingSeconds");
					step.FinishTime = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].FinishTime");
					step.Interactive = _ctx.BooleanValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].Interactive");

					SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step.SearchOmsOpenAPIProjects_StepInfo stepInfo = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step.SearchOmsOpenAPIProjects_StepInfo();
					stepInfo.JobId = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.JobId");
					stepInfo.IncrTimestampCheckpoint = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.IncrTimestampCheckpoint");
					stepInfo.Checkpoint = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.Checkpoint");
					stepInfo.Gmt = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.Gmt");
					stepInfo.Validated = _ctx.BooleanValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.Validated");
					stepInfo.Skipped = _ctx.BooleanValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.Skipped");
					stepInfo.Inconsistencies = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.Inconsistencies");
					stepInfo.DeployId = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.DeployId");
					stepInfo.ProcessedRecords = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.ProcessedRecords");
					stepInfo.Capacity = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.Capacity");
					stepInfo.SrcRps = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.SrcRps");
					stepInfo.SrcRt = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.SrcRt");
					stepInfo.SrcIops = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.SrcIops");
					stepInfo.DstRps = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.DstRps");
					stepInfo.DstRt = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.DstRt");
					stepInfo.DstIops = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.DstIops");
					stepInfo.SrcRpsRef = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.SrcRpsRef");
					stepInfo.SrcRtRef = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.SrcRtRef");
					stepInfo.DstRpsRef = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.DstRpsRef");
					stepInfo.DstRtRef = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.DstRtRef");
					stepInfo.SrcIopsRef = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.SrcIopsRef");

					SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step.SearchOmsOpenAPIProjects_StepInfo.SearchOmsOpenAPIProjects_ConnectorFullProgressOverview connectorFullProgressOverview = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step.SearchOmsOpenAPIProjects_StepInfo.SearchOmsOpenAPIProjects_ConnectorFullProgressOverview();
					connectorFullProgressOverview.EstimatedTotalCount = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.ConnectorFullProgressOverview.EstimatedTotalCount");
					connectorFullProgressOverview.FinishedCount = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.ConnectorFullProgressOverview.FinishedCount");
					connectorFullProgressOverview.Progress = _ctx.IntegerValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.ConnectorFullProgressOverview.Progress");
					connectorFullProgressOverview.EstimatedRemainingTimeOfSec = _ctx.LongValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].StepInfo.ConnectorFullProgressOverview.EstimatedRemainingTimeOfSec");
					stepInfo.ConnectorFullProgressOverview = connectorFullProgressOverview;
					step.StepInfo = stepInfo;

					SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step.SearchOmsOpenAPIProjects_ExtraInfo extraInfo = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step.SearchOmsOpenAPIProjects_ExtraInfo();
					extraInfo.ErrorCode = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].ExtraInfo.ErrorCode");
					extraInfo.ErrorMsg = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].ExtraInfo.ErrorMsg");
					extraInfo.ErrorParam = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].ExtraInfo.ErrorParam");
					extraInfo.FailedTime = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].ExtraInfo.FailedTime");

					List<SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step.SearchOmsOpenAPIProjects_ExtraInfo.SearchOmsOpenAPIProjects_ErrorDetail> extraInfo_errorDetails = new List<SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step.SearchOmsOpenAPIProjects_ExtraInfo.SearchOmsOpenAPIProjects_ErrorDetail>();
					for (int k = 0; k < _ctx.Length("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].ExtraInfo.ErrorDetails.Length"); k++) {
						SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step.SearchOmsOpenAPIProjects_ExtraInfo.SearchOmsOpenAPIProjects_ErrorDetail errorDetail = new SearchOmsOpenAPIProjectsResponse.SearchOmsOpenAPIProjects_DataItem.SearchOmsOpenAPIProjects_Step.SearchOmsOpenAPIProjects_ExtraInfo.SearchOmsOpenAPIProjects_ErrorDetail();
						errorDetail.Code = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].ExtraInfo.ErrorDetails["+ k +"].Code");
						errorDetail.Level = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].ExtraInfo.ErrorDetails["+ k +"].Level");
						errorDetail.Message = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].ExtraInfo.ErrorDetails["+ k +"].Message");
						errorDetail.Proposal = _ctx.StringValue("SearchOmsOpenAPIProjects.Data["+ i +"].Steps["+ j +"].ExtraInfo.ErrorDetails["+ k +"].Proposal");

						extraInfo_errorDetails.Add(errorDetail);
					}
					extraInfo.ErrorDetails = extraInfo_errorDetails;
					step.ExtraInfo = extraInfo;

					dataItem_steps.Add(step);
				}
				dataItem.Steps = dataItem_steps;

				searchOmsOpenAPIProjectsResponse_data.Add(dataItem);
			}
			searchOmsOpenAPIProjectsResponse.Data = searchOmsOpenAPIProjectsResponse_data;
        
			return searchOmsOpenAPIProjectsResponse;
        }
    }
}
