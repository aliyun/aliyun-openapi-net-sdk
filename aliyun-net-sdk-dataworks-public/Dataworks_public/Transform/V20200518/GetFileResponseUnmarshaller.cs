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
    public class GetFileResponseUnmarshaller
    {
        public static GetFileResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFileResponse getFileResponse = new GetFileResponse();

			getFileResponse.HttpResponse = _ctx.HttpResponse;
			getFileResponse.RequestId = _ctx.StringValue("GetFile.RequestId");
			getFileResponse.Success = _ctx.BooleanValue("GetFile.Success");
			getFileResponse.ErrorCode = _ctx.StringValue("GetFile.ErrorCode");
			getFileResponse.ErrorMessage = _ctx.StringValue("GetFile.ErrorMessage");
			getFileResponse.HttpStatusCode = _ctx.IntegerValue("GetFile.HttpStatusCode");

			GetFileResponse.GetFile_Data data = new GetFileResponse.GetFile_Data();

			GetFileResponse.GetFile_Data.GetFile_File file = new GetFileResponse.GetFile_Data.GetFile_File();
			file.ConnectionName = _ctx.StringValue("GetFile.Data.File.ConnectionName");
			file.ParentId = _ctx.LongValue("GetFile.Data.File.ParentId");
			file.IsMaxCompute = _ctx.BooleanValue("GetFile.Data.File.IsMaxCompute");
			file.CreateTime = _ctx.LongValue("GetFile.Data.File.CreateTime");
			file.CreateUser = _ctx.StringValue("GetFile.Data.File.CreateUser");
			file.BizId = _ctx.LongValue("GetFile.Data.File.BizId");
			file.FileFolderId = _ctx.StringValue("GetFile.Data.File.FileFolderId");
			file.FileName = _ctx.StringValue("GetFile.Data.File.FileName");
			file.FileType = _ctx.IntegerValue("GetFile.Data.File.FileType");
			file.UseType = _ctx.StringValue("GetFile.Data.File.UseType");
			file.FileDescription = _ctx.StringValue("GetFile.Data.File.FileDescription");
			file.Content = _ctx.StringValue("GetFile.Data.File.Content");
			file.NodeId = _ctx.LongValue("GetFile.Data.File.NodeId");
			file.CurrentVersion = _ctx.IntegerValue("GetFile.Data.File.CurrentVersion");
			file.Owner = _ctx.StringValue("GetFile.Data.File.Owner");
			file.LastEditUser = _ctx.StringValue("GetFile.Data.File.LastEditUser");
			file.LastEditTime = _ctx.LongValue("GetFile.Data.File.LastEditTime");
			file.CommitStatus = _ctx.IntegerValue("GetFile.Data.File.CommitStatus");
			file.DeletedStatus = _ctx.StringValue("GetFile.Data.File.DeletedStatus");
			file.BusinessId = _ctx.LongValue("GetFile.Data.File.BusinessId");
			file.AutoParsing = _ctx.BooleanValue("GetFile.Data.File.AutoParsing");
			data.File = file;

			GetFileResponse.GetFile_Data.GetFile_NodeConfiguration nodeConfiguration = new GetFileResponse.GetFile_Data.GetFile_NodeConfiguration();
			nodeConfiguration.AutoRerunTimes = _ctx.IntegerValue("GetFile.Data.NodeConfiguration.AutoRerunTimes");
			nodeConfiguration.AutoRerunIntervalMillis = _ctx.IntegerValue("GetFile.Data.NodeConfiguration.AutoRerunIntervalMillis");
			nodeConfiguration.RerunMode = _ctx.StringValue("GetFile.Data.NodeConfiguration.RerunMode");
			nodeConfiguration.Stop = _ctx.BooleanValue("GetFile.Data.NodeConfiguration.Stop");
			nodeConfiguration.ParaValue = _ctx.StringValue("GetFile.Data.NodeConfiguration.ParaValue");
			nodeConfiguration.StartEffectDate = _ctx.LongValue("GetFile.Data.NodeConfiguration.StartEffectDate");
			nodeConfiguration.EndEffectDate = _ctx.LongValue("GetFile.Data.NodeConfiguration.EndEffectDate");
			nodeConfiguration.CronExpress = _ctx.StringValue("GetFile.Data.NodeConfiguration.CronExpress");
			nodeConfiguration.CycleType = _ctx.StringValue("GetFile.Data.NodeConfiguration.CycleType");
			nodeConfiguration.DependentType = _ctx.StringValue("GetFile.Data.NodeConfiguration.DependentType");
			nodeConfiguration.DependentNodeIdList = _ctx.StringValue("GetFile.Data.NodeConfiguration.DependentNodeIdList");
			nodeConfiguration.ResourceGroupId = _ctx.LongValue("GetFile.Data.NodeConfiguration.ResourceGroupId");

			List<GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput> nodeConfiguration_inputList = new List<GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput>();
			for (int i = 0; i < _ctx.Length("GetFile.Data.NodeConfiguration.InputList.Length"); i++) {
				GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput nodeInputOutput = new GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput();
				nodeInputOutput.Input = _ctx.StringValue("GetFile.Data.NodeConfiguration.InputList["+ i +"].Input");
				nodeInputOutput.ParseType = _ctx.StringValue("GetFile.Data.NodeConfiguration.InputList["+ i +"].ParseType");

				nodeConfiguration_inputList.Add(nodeInputOutput);
			}
			nodeConfiguration.InputList = nodeConfiguration_inputList;

			List<GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput1> nodeConfiguration_outputList = new List<GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput1>();
			for (int i = 0; i < _ctx.Length("GetFile.Data.NodeConfiguration.OutputList.Length"); i++) {
				GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput1 nodeInputOutput1 = new GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput1();
				nodeInputOutput1.Output = _ctx.StringValue("GetFile.Data.NodeConfiguration.OutputList["+ i +"].Output");
				nodeInputOutput1.RefTableName = _ctx.StringValue("GetFile.Data.NodeConfiguration.OutputList["+ i +"].RefTableName");

				nodeConfiguration_outputList.Add(nodeInputOutput1);
			}
			nodeConfiguration.OutputList = nodeConfiguration_outputList;
			data.NodeConfiguration = nodeConfiguration;
			getFileResponse.Data = data;
        
			return getFileResponse;
        }
    }
}
