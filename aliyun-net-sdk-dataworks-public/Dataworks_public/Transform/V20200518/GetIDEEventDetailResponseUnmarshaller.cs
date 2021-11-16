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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetIDEEventDetailResponseUnmarshaller
    {
        public static GetIDEEventDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetIDEEventDetailResponse getIDEEventDetailResponse = new GetIDEEventDetailResponse();

			getIDEEventDetailResponse.HttpResponse = _ctx.HttpResponse;
			getIDEEventDetailResponse.RequestId = _ctx.StringValue("GetIDEEventDetail.RequestId");

			GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail eventDetail = new GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail();

			GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_FileExecutionCommand fileExecutionCommand = new GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_FileExecutionCommand();
			fileExecutionCommand.FileId = _ctx.LongValue("GetIDEEventDetail.EventDetail.FileExecutionCommand.FileId");
			fileExecutionCommand.DataSourceName = _ctx.StringValue("GetIDEEventDetail.EventDetail.FileExecutionCommand.DataSourceName");
			fileExecutionCommand.Content = _ctx.StringValue("GetIDEEventDetail.EventDetail.FileExecutionCommand.Content");
			fileExecutionCommand.FileType = _ctx.LongValue("GetIDEEventDetail.EventDetail.FileExecutionCommand.FileType");
			eventDetail.FileExecutionCommand = fileExecutionCommand;

			GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_DeletedFile deletedFile = new GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_DeletedFile();
			deletedFile.Owner = _ctx.StringValue("GetIDEEventDetail.EventDetail.DeletedFile.Owner");
			deletedFile.FileType = _ctx.LongValue("GetIDEEventDetail.EventDetail.DeletedFile.FileType");
			deletedFile.CurrentVersion = _ctx.LongValue("GetIDEEventDetail.EventDetail.DeletedFile.CurrentVersion");
			deletedFile.BusinessId = _ctx.LongValue("GetIDEEventDetail.EventDetail.DeletedFile.BusinessId");
			deletedFile.FileName = _ctx.StringValue("GetIDEEventDetail.EventDetail.DeletedFile.FileName");
			deletedFile.DataSourceName = _ctx.StringValue("GetIDEEventDetail.EventDetail.DeletedFile.DataSourceName");
			deletedFile.UseType = _ctx.StringValue("GetIDEEventDetail.EventDetail.DeletedFile.UseType");
			deletedFile.FolderId = _ctx.StringValue("GetIDEEventDetail.EventDetail.DeletedFile.FolderId");
			deletedFile.ParentFileId = _ctx.LongValue("GetIDEEventDetail.EventDetail.DeletedFile.ParentFileId");
			deletedFile.Content = _ctx.StringValue("GetIDEEventDetail.EventDetail.DeletedFile.Content");
			deletedFile.NodeId = _ctx.LongValue("GetIDEEventDetail.EventDetail.DeletedFile.NodeId");
			deletedFile.FileId = _ctx.LongValue("GetIDEEventDetail.EventDetail.DeletedFile.FileId");
			eventDetail.DeletedFile = deletedFile;

			GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile committedFile = new GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile();
			committedFile.FileId = _ctx.LongValue("GetIDEEventDetail.EventDetail.CommittedFile.FileId");
			committedFile.Content = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.Content");
			committedFile.Committor = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.Committor");
			committedFile.FileType = _ctx.LongValue("GetIDEEventDetail.EventDetail.CommittedFile.FileType");
			committedFile.ChangeType = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.ChangeType");
			committedFile.FileName = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.FileName");
			committedFile.NodeId = _ctx.LongValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeId");
			committedFile.Comment = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.Comment");
			committedFile.UseType = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.UseType");

			GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile.GetIDEEventDetail_FilePropertyContent filePropertyContent = new GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile.GetIDEEventDetail_FilePropertyContent();
			filePropertyContent.DataSourceName = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.FilePropertyContent.DataSourceName");
			filePropertyContent.ParentFileId = _ctx.LongValue("GetIDEEventDetail.EventDetail.CommittedFile.FilePropertyContent.ParentFileId");
			filePropertyContent.BusinessId = _ctx.LongValue("GetIDEEventDetail.EventDetail.CommittedFile.FilePropertyContent.BusinessId");
			filePropertyContent.CurrentVersion = _ctx.LongValue("GetIDEEventDetail.EventDetail.CommittedFile.FilePropertyContent.CurrentVersion");
			filePropertyContent.Owner = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.FilePropertyContent.Owner");
			filePropertyContent.FolderId = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.FilePropertyContent.FolderId");
			committedFile.FilePropertyContent = filePropertyContent;

			GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile.GetIDEEventDetail_NodeConfiguration nodeConfiguration = new GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile.GetIDEEventDetail_NodeConfiguration();
			nodeConfiguration.RerunMode = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.RerunMode");
			nodeConfiguration.SchedulerType = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.SchedulerType");
			nodeConfiguration.ParaValue = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.ParaValue");
			nodeConfiguration.CycleType = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.CycleType");
			nodeConfiguration.DependentNodeIdList = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.DependentNodeIdList");
			nodeConfiguration.ResourceGroupId = _ctx.LongValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.ResourceGroupId");
			nodeConfiguration.AutoRerunTimes = _ctx.LongValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.AutoRerunTimes");
			nodeConfiguration.AutoRerunIntervalMillis = _ctx.LongValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.AutoRerunIntervalMillis");
			nodeConfiguration.CronExpress = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.CronExpress");
			nodeConfiguration.DependentType = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.DependentType");

			List<GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile.GetIDEEventDetail_NodeConfiguration.GetIDEEventDetail_Input> nodeConfiguration_inputList = new List<GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile.GetIDEEventDetail_NodeConfiguration.GetIDEEventDetail_Input>();
			for (int i = 0; i < _ctx.Length("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.InputList.Length"); i++) {
				GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile.GetIDEEventDetail_NodeConfiguration.GetIDEEventDetail_Input input = new GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile.GetIDEEventDetail_NodeConfiguration.GetIDEEventDetail_Input();
				input.Input = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.InputList["+ i +"].Input");
				input.ParseType = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.InputList["+ i +"].ParseType");

				nodeConfiguration_inputList.Add(input);
			}
			nodeConfiguration.InputList = nodeConfiguration_inputList;

			List<GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile.GetIDEEventDetail_NodeConfiguration.GetIDEEventDetail_Output> nodeConfiguration_outputList = new List<GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile.GetIDEEventDetail_NodeConfiguration.GetIDEEventDetail_Output>();
			for (int i = 0; i < _ctx.Length("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.OutputList.Length"); i++) {
				GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile.GetIDEEventDetail_NodeConfiguration.GetIDEEventDetail_Output output = new GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_CommittedFile.GetIDEEventDetail_NodeConfiguration.GetIDEEventDetail_Output();
				output.RefTableName = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.OutputList["+ i +"].RefTableName");
				output.Output = _ctx.StringValue("GetIDEEventDetail.EventDetail.CommittedFile.NodeConfiguration.OutputList["+ i +"].Output");

				nodeConfiguration_outputList.Add(output);
			}
			nodeConfiguration.OutputList = nodeConfiguration_outputList;
			committedFile.NodeConfiguration = nodeConfiguration;
			eventDetail.CommittedFile = committedFile;

			GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_TableModel tableModel = new GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_TableModel();
			tableModel.Env = _ctx.StringValue("GetIDEEventDetail.EventDetail.TableModel.Env");
			tableModel.LifeCycle = _ctx.LongValue("GetIDEEventDetail.EventDetail.TableModel.LifeCycle");
			tableModel.TableName = _ctx.StringValue("GetIDEEventDetail.EventDetail.TableModel.TableName");
			tableModel.DataSourceName = _ctx.StringValue("GetIDEEventDetail.EventDetail.TableModel.DataSourceName");
			tableModel.Comment = _ctx.StringValue("GetIDEEventDetail.EventDetail.TableModel.Comment");
			tableModel.Location = _ctx.StringValue("GetIDEEventDetail.EventDetail.TableModel.Location");

			List<GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_TableModel.GetIDEEventDetail_Column> tableModel_columns = new List<GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_TableModel.GetIDEEventDetail_Column>();
			for (int i = 0; i < _ctx.Length("GetIDEEventDetail.EventDetail.TableModel.Columns.Length"); i++) {
				GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_TableModel.GetIDEEventDetail_Column column = new GetIDEEventDetailResponse.GetIDEEventDetail_EventDetail.GetIDEEventDetail_TableModel.GetIDEEventDetail_Column();
				column.ColumnName = _ctx.StringValue("GetIDEEventDetail.EventDetail.TableModel.Columns["+ i +"].ColumnName");
				column.ColumnType = _ctx.StringValue("GetIDEEventDetail.EventDetail.TableModel.Columns["+ i +"].ColumnType");
				column.IsPartitionColumn = _ctx.BooleanValue("GetIDEEventDetail.EventDetail.TableModel.Columns["+ i +"].IsPartitionColumn");
				column.Comment = _ctx.StringValue("GetIDEEventDetail.EventDetail.TableModel.Columns["+ i +"].Comment");

				tableModel_columns.Add(column);
			}
			tableModel.Columns = tableModel_columns;
			eventDetail.TableModel = tableModel;
			getIDEEventDetailResponse.EventDetail = eventDetail;
        
			return getIDEEventDetailResponse;
        }
    }
}
