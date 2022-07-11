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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeCommandsResponseUnmarshaller
    {
        public static DescribeCommandsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCommandsResponse describeCommandsResponse = new DescribeCommandsResponse();

			describeCommandsResponse.HttpResponse = _ctx.HttpResponse;
			describeCommandsResponse.PageSize = _ctx.LongValue("DescribeCommands.PageSize");
			describeCommandsResponse.RequestId = _ctx.StringValue("DescribeCommands.RequestId");
			describeCommandsResponse.PageNumber = _ctx.LongValue("DescribeCommands.PageNumber");
			describeCommandsResponse.TotalCount = _ctx.LongValue("DescribeCommands.TotalCount");

			List<DescribeCommandsResponse.DescribeCommands_Command> describeCommandsResponse_commands = new List<DescribeCommandsResponse.DescribeCommands_Command>();
			for (int i = 0; i < _ctx.Length("DescribeCommands.Commands.Length"); i++) {
				DescribeCommandsResponse.DescribeCommands_Command command = new DescribeCommandsResponse.DescribeCommands_Command();
				command.CreationTime = _ctx.StringValue("DescribeCommands.Commands["+ i +"].CreationTime");
				command.Type = _ctx.StringValue("DescribeCommands.Commands["+ i +"].Type");
				command.Timeout = _ctx.LongValue("DescribeCommands.Commands["+ i +"].Timeout");
				command.InvokeTimes = _ctx.IntegerValue("DescribeCommands.Commands["+ i +"].InvokeTimes");
				command.CommandId = _ctx.StringValue("DescribeCommands.Commands["+ i +"].CommandId");
				command.WorkingDir = _ctx.StringValue("DescribeCommands.Commands["+ i +"].WorkingDir");
				command.Description = _ctx.StringValue("DescribeCommands.Commands["+ i +"].Description");
				command.Version = _ctx.IntegerValue("DescribeCommands.Commands["+ i +"].Version");
				command.Provider = _ctx.StringValue("DescribeCommands.Commands["+ i +"].Provider");
				command.CommandContent = _ctx.StringValue("DescribeCommands.Commands["+ i +"].CommandContent");
				command.Category = _ctx.StringValue("DescribeCommands.Commands["+ i +"].Category");
				command.Latest = _ctx.BooleanValue("DescribeCommands.Commands["+ i +"].Latest");
				command.Name = _ctx.StringValue("DescribeCommands.Commands["+ i +"].Name");
				command.EnableParameter = _ctx.BooleanValue("DescribeCommands.Commands["+ i +"].EnableParameter");

				List<string> command_parameterNames = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCommands.Commands["+ i +"].ParameterNames.Length"); j++) {
					command_parameterNames.Add(_ctx.StringValue("DescribeCommands.Commands["+ i +"].ParameterNames["+ j +"]"));
				}
				command.ParameterNames = command_parameterNames;

				List<DescribeCommandsResponse.DescribeCommands_Command.DescribeCommands_ParameterDefinition> command_parameterDefinitions = new List<DescribeCommandsResponse.DescribeCommands_Command.DescribeCommands_ParameterDefinition>();
				for (int j = 0; j < _ctx.Length("DescribeCommands.Commands["+ i +"].ParameterDefinitions.Length"); j++) {
					DescribeCommandsResponse.DescribeCommands_Command.DescribeCommands_ParameterDefinition parameterDefinition = new DescribeCommandsResponse.DescribeCommands_Command.DescribeCommands_ParameterDefinition();
					parameterDefinition.Required = _ctx.BooleanValue("DescribeCommands.Commands["+ i +"].ParameterDefinitions["+ j +"].Required");
					parameterDefinition.Description = _ctx.StringValue("DescribeCommands.Commands["+ i +"].ParameterDefinitions["+ j +"].Description");
					parameterDefinition.DefaultValue = _ctx.StringValue("DescribeCommands.Commands["+ i +"].ParameterDefinitions["+ j +"].DefaultValue");
					parameterDefinition.ParameterName = _ctx.StringValue("DescribeCommands.Commands["+ i +"].ParameterDefinitions["+ j +"].ParameterName");

					List<string> parameterDefinition_possibleValues = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeCommands.Commands["+ i +"].ParameterDefinitions["+ j +"].PossibleValues.Length"); k++) {
						parameterDefinition_possibleValues.Add(_ctx.StringValue("DescribeCommands.Commands["+ i +"].ParameterDefinitions["+ j +"].PossibleValues["+ k +"]"));
					}
					parameterDefinition.PossibleValues = parameterDefinition_possibleValues;

					command_parameterDefinitions.Add(parameterDefinition);
				}
				command.ParameterDefinitions = command_parameterDefinitions;

				describeCommandsResponse_commands.Add(command);
			}
			describeCommandsResponse.Commands = describeCommandsResponse_commands;
        
			return describeCommandsResponse;
        }
    }
}
