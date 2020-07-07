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
        public static GetFileResponse Unmarshall(UnmarshallerContext context)
        {
			GetFileResponse getFileResponse = new GetFileResponse();

			getFileResponse.HttpResponse = context.HttpResponse;
			getFileResponse.RequestId = context.StringValue("GetFile.RequestId");
			getFileResponse.Success = context.BooleanValue("GetFile.Success");
			getFileResponse.ErrorCode = context.StringValue("GetFile.ErrorCode");
			getFileResponse.ErrorMessage = context.StringValue("GetFile.ErrorMessage");
			getFileResponse.HttpStatusCode = context.IntegerValue("GetFile.HttpStatusCode");

			GetFileResponse.GetFile_Data data = new GetFileResponse.GetFile_Data();

			GetFileResponse.GetFile_Data.GetFile_File file = new GetFileResponse.GetFile_Data.GetFile_File();
			file.ConnectionName = context.StringValue("GetFile.Data.File.ConnectionName");
			file.ParentId = context.LongValue("GetFile.Data.File.ParentId");
			file.IsMaxCompute = context.BooleanValue("GetFile.Data.File.IsMaxCompute");
			file.CreateTime = context.LongValue("GetFile.Data.File.CreateTime");
			file.CreateUser = context.StringValue("GetFile.Data.File.CreateUser");
			file.BizId = context.LongValue("GetFile.Data.File.BizId");
			file.FileFolderId = context.StringValue("GetFile.Data.File.FileFolderId");
			file.FileName = context.StringValue("GetFile.Data.File.FileName");
			file.FileType = context.IntegerValue("GetFile.Data.File.FileType");
			file.UseType = context.StringValue("GetFile.Data.File.UseType");
			file.FileDescription = context.StringValue("GetFile.Data.File.FileDescription");
			file.Content = context.StringValue("GetFile.Data.File.Content");
			file.NodeId = context.LongValue("GetFile.Data.File.NodeId");
			file.CurrentVersion = context.IntegerValue("GetFile.Data.File.CurrentVersion");
			file.Owner = context.StringValue("GetFile.Data.File.Owner");
			file.LastEditUser = context.StringValue("GetFile.Data.File.LastEditUser");
			file.LastEditTime = context.LongValue("GetFile.Data.File.LastEditTime");
			file.CommitStatus = context.IntegerValue("GetFile.Data.File.CommitStatus");
			data.File = file;

			GetFileResponse.GetFile_Data.GetFile_NodeConfiguration nodeConfiguration = new GetFileResponse.GetFile_Data.GetFile_NodeConfiguration();
			nodeConfiguration.AutoRerunTimes = context.IntegerValue("GetFile.Data.NodeConfiguration.AutoRerunTimes");
			nodeConfiguration.AutoRerunIntervalMillis = context.IntegerValue("GetFile.Data.NodeConfiguration.AutoRerunIntervalMillis");
			nodeConfiguration.RerunMode = context.StringValue("GetFile.Data.NodeConfiguration.RerunMode");
			nodeConfiguration.Stop = context.BooleanValue("GetFile.Data.NodeConfiguration.Stop");
			nodeConfiguration.ParaValue = context.StringValue("GetFile.Data.NodeConfiguration.ParaValue");
			nodeConfiguration.StartEffectDate = context.LongValue("GetFile.Data.NodeConfiguration.StartEffectDate");
			nodeConfiguration.EndEffectDate = context.LongValue("GetFile.Data.NodeConfiguration.EndEffectDate");
			nodeConfiguration.CronExpress = context.StringValue("GetFile.Data.NodeConfiguration.CronExpress");
			nodeConfiguration.CycleType = context.StringValue("GetFile.Data.NodeConfiguration.CycleType");
			nodeConfiguration.DependentType = context.StringValue("GetFile.Data.NodeConfiguration.DependentType");
			nodeConfiguration.DependentNodeIdList = context.StringValue("GetFile.Data.NodeConfiguration.DependentNodeIdList");

			List<GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput> nodeConfiguration_inputList = new List<GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput>();
			for (int i = 0; i < context.Length("GetFile.Data.NodeConfiguration.InputList.Length"); i++) {
				GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput nodeInputOutput = new GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput();
				nodeInputOutput.Input = context.StringValue("GetFile.Data.NodeConfiguration.InputList["+ i +"].Input");

				nodeConfiguration_inputList.Add(nodeInputOutput);
			}
			nodeConfiguration.InputList = nodeConfiguration_inputList;

			List<GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput1> nodeConfiguration_outputList = new List<GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput1>();
			for (int i = 0; i < context.Length("GetFile.Data.NodeConfiguration.OutputList.Length"); i++) {
				GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput1 nodeInputOutput1 = new GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_NodeInputOutput1();
				nodeInputOutput1.Output = context.StringValue("GetFile.Data.NodeConfiguration.OutputList["+ i +"].Output");
				nodeInputOutput1.RefTableName = context.StringValue("GetFile.Data.NodeConfiguration.OutputList["+ i +"].RefTableName");

				nodeConfiguration_outputList.Add(nodeInputOutput1);
			}
			nodeConfiguration.OutputList = nodeConfiguration_outputList;
			data.NodeConfiguration = nodeConfiguration;
			getFileResponse.Data = data;
        
			return getFileResponse;
        }
    }
}
