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
			getFileResponse.HttpStatusCode = _ctx.IntegerValue("GetFile.HttpStatusCode");
			getFileResponse.ErrorMessage = _ctx.StringValue("GetFile.ErrorMessage");
			getFileResponse.RequestId = _ctx.StringValue("GetFile.RequestId");
			getFileResponse.ErrorCode = _ctx.StringValue("GetFile.ErrorCode");
			getFileResponse.Success = _ctx.BooleanValue("GetFile.Success");

			GetFileResponse.GetFile_Data data = new GetFileResponse.GetFile_Data();

			GetFileResponse.GetFile_Data.GetFile_File file = new GetFileResponse.GetFile_Data.GetFile_File();
			file.CommitStatus = _ctx.IntegerValue("GetFile.Data.File.CommitStatus");
			file.AutoParsing = _ctx.BooleanValue("GetFile.Data.File.AutoParsing");
			file.Owner = _ctx.StringValue("GetFile.Data.File.Owner");
			file.CreateTime = _ctx.LongValue("GetFile.Data.File.CreateTime");
			file.FileType = _ctx.IntegerValue("GetFile.Data.File.FileType");
			file.CurrentVersion = _ctx.IntegerValue("GetFile.Data.File.CurrentVersion");
			file.BizId = _ctx.LongValue("GetFile.Data.File.BizId");
			file.LastEditUser = _ctx.StringValue("GetFile.Data.File.LastEditUser");
			file.FileName = _ctx.StringValue("GetFile.Data.File.FileName");
			file.ConnectionName = _ctx.StringValue("GetFile.Data.File.ConnectionName");
			file.UseType = _ctx.StringValue("GetFile.Data.File.UseType");
			file.FileFolderId = _ctx.StringValue("GetFile.Data.File.FileFolderId");
			file.ParentId = _ctx.LongValue("GetFile.Data.File.ParentId");
			file.CreateUser = _ctx.StringValue("GetFile.Data.File.CreateUser");
			file.IsMaxCompute = _ctx.BooleanValue("GetFile.Data.File.IsMaxCompute");
			file.BusinessId = _ctx.LongValue("GetFile.Data.File.BusinessId");
			file.FileDescription = _ctx.StringValue("GetFile.Data.File.FileDescription");
			file.DeletedStatus = _ctx.StringValue("GetFile.Data.File.DeletedStatus");
			file.LastEditTime = _ctx.LongValue("GetFile.Data.File.LastEditTime");
			file.Content = _ctx.StringValue("GetFile.Data.File.Content");
			file.NodeId = _ctx.LongValue("GetFile.Data.File.NodeId");
			file.AdvancedSettings = _ctx.StringValue("GetFile.Data.File.AdvancedSettings");
			data.File = file;

			GetFileResponse.GetFile_Data.GetFile_NodeConfiguration nodeConfiguration = new GetFileResponse.GetFile_Data.GetFile_NodeConfiguration();
			nodeConfiguration.RerunMode = _ctx.StringValue("GetFile.Data.NodeConfiguration.RerunMode");
			nodeConfiguration.SchedulerType = _ctx.StringValue("GetFile.Data.NodeConfiguration.SchedulerType");
			nodeConfiguration.Stop = _ctx.BooleanValue("GetFile.Data.NodeConfiguration.Stop");
			nodeConfiguration.ParaValue = _ctx.StringValue("GetFile.Data.NodeConfiguration.ParaValue");
			nodeConfiguration.StartEffectDate = _ctx.LongValue("GetFile.Data.NodeConfiguration.StartEffectDate");
			nodeConfiguration.EndEffectDate = _ctx.LongValue("GetFile.Data.NodeConfiguration.EndEffectDate");
			nodeConfiguration.CycleType = _ctx.StringValue("GetFile.Data.NodeConfiguration.CycleType");
			nodeConfiguration.DependentNodeIdList = _ctx.StringValue("GetFile.Data.NodeConfiguration.DependentNodeIdList");
			nodeConfiguration.ResourceGroupId = _ctx.LongValue("GetFile.Data.NodeConfiguration.ResourceGroupId");
			nodeConfiguration.DependentType = _ctx.StringValue("GetFile.Data.NodeConfiguration.DependentType");
			nodeConfiguration.AutoRerunTimes = _ctx.IntegerValue("GetFile.Data.NodeConfiguration.AutoRerunTimes");
			nodeConfiguration.AutoRerunIntervalMillis = _ctx.IntegerValue("GetFile.Data.NodeConfiguration.AutoRerunIntervalMillis");
			nodeConfiguration.CronExpress = _ctx.StringValue("GetFile.Data.NodeConfiguration.CronExpress");
			nodeConfiguration.StartImmediately = _ctx.BooleanValue("GetFile.Data.NodeConfiguration.StartImmediately");

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
				nodeInputOutput1.RefTableName = _ctx.StringValue("GetFile.Data.NodeConfiguration.OutputList["+ i +"].RefTableName");
				nodeInputOutput1.Output = _ctx.StringValue("GetFile.Data.NodeConfiguration.OutputList["+ i +"].Output");

				nodeConfiguration_outputList.Add(nodeInputOutput1);
			}
			nodeConfiguration.OutputList = nodeConfiguration_outputList;

			List<GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_InputContextParameter> nodeConfiguration_inputParameters = new List<GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_InputContextParameter>();
			for (int i = 0; i < _ctx.Length("GetFile.Data.NodeConfiguration.InputParameters.Length"); i++) {
				GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_InputContextParameter inputContextParameter = new GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_InputContextParameter();
				inputContextParameter.ParameterName = _ctx.StringValue("GetFile.Data.NodeConfiguration.InputParameters["+ i +"].ParameterName");
				inputContextParameter.ValueSource = _ctx.StringValue("GetFile.Data.NodeConfiguration.InputParameters["+ i +"].ValueSource");

				nodeConfiguration_inputParameters.Add(inputContextParameter);
			}
			nodeConfiguration.InputParameters = nodeConfiguration_inputParameters;

			List<GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_OutputContextParameter> nodeConfiguration_outputParameters = new List<GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_OutputContextParameter>();
			for (int i = 0; i < _ctx.Length("GetFile.Data.NodeConfiguration.OutputParameters.Length"); i++) {
				GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_OutputContextParameter outputContextParameter = new GetFileResponse.GetFile_Data.GetFile_NodeConfiguration.GetFile_OutputContextParameter();
				outputContextParameter.ParameterName = _ctx.StringValue("GetFile.Data.NodeConfiguration.OutputParameters["+ i +"].ParameterName");
				outputContextParameter._Value = _ctx.StringValue("GetFile.Data.NodeConfiguration.OutputParameters["+ i +"].Value");
				outputContextParameter.Type = _ctx.StringValue("GetFile.Data.NodeConfiguration.OutputParameters["+ i +"].Type");
				outputContextParameter.Description = _ctx.StringValue("GetFile.Data.NodeConfiguration.OutputParameters["+ i +"].Description");

				nodeConfiguration_outputParameters.Add(outputContextParameter);
			}
			nodeConfiguration.OutputParameters = nodeConfiguration_outputParameters;
			data.NodeConfiguration = nodeConfiguration;
			getFileResponse.Data = data;
        
			return getFileResponse;
        }
    }
}
