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
        public static DescribeCommandsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCommandsResponse describeCommandsResponse = new DescribeCommandsResponse();

			describeCommandsResponse.HttpResponse = context.HttpResponse;
			describeCommandsResponse.RequestId = context.StringValue("DescribeCommands.RequestId");
			describeCommandsResponse.TotalCount = context.LongValue("DescribeCommands.TotalCount");
			describeCommandsResponse.PageNumber = context.LongValue("DescribeCommands.PageNumber");
			describeCommandsResponse.PageSize = context.LongValue("DescribeCommands.PageSize");

			List<DescribeCommandsResponse.DescribeCommands_Command> describeCommandsResponse_commands = new List<DescribeCommandsResponse.DescribeCommands_Command>();
			for (int i = 0; i < context.Length("DescribeCommands.Commands.Length"); i++) {
				DescribeCommandsResponse.DescribeCommands_Command command = new DescribeCommandsResponse.DescribeCommands_Command();
				command.CommandId = context.StringValue("DescribeCommands.Commands["+ i +"].CommandId");
				command.Name = context.StringValue("DescribeCommands.Commands["+ i +"].Name");
				command.Type = context.StringValue("DescribeCommands.Commands["+ i +"].Type");
				command.Description = context.StringValue("DescribeCommands.Commands["+ i +"].Description");
				command.CommandContent = context.StringValue("DescribeCommands.Commands["+ i +"].CommandContent");
				command.WorkingDir = context.StringValue("DescribeCommands.Commands["+ i +"].WorkingDir");
				command.Timeout = context.LongValue("DescribeCommands.Commands["+ i +"].Timeout");
				command.InvokeTimes = context.IntegerValue("DescribeCommands.Commands["+ i +"].InvokeTimes");
				command.CreationTime = context.StringValue("DescribeCommands.Commands["+ i +"].CreationTime");
				command.EnableParameter = context.BooleanValue("DescribeCommands.Commands["+ i +"].EnableParameter");

				List<string> command_parameterNames = new List<string>();
				for (int j = 0; j < context.Length("DescribeCommands.Commands["+ i +"].ParameterNames.Length"); j++) {
					command_parameterNames.Add(context.StringValue("DescribeCommands.Commands["+ i +"].ParameterNames["+ j +"]"));
				}
				command.ParameterNames = command_parameterNames;

				describeCommandsResponse_commands.Add(command);
			}
			describeCommandsResponse.Commands = describeCommandsResponse_commands;
        
			return describeCommandsResponse;
        }
    }
}
