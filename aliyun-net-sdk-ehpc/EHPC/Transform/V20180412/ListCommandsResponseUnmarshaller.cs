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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EHPC.Model.V20180412;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListCommandsResponseUnmarshaller
    {
        public static ListCommandsResponse Unmarshall(UnmarshallerContext context)
        {
			ListCommandsResponse listCommandsResponse = new ListCommandsResponse();

			listCommandsResponse.HttpResponse = context.HttpResponse;
			listCommandsResponse.RequestId = context.StringValue("ListCommands.RequestId");
			listCommandsResponse.TotalCount = context.IntegerValue("ListCommands.TotalCount");
			listCommandsResponse.PageNumber = context.IntegerValue("ListCommands.PageNumber");
			listCommandsResponse.PageSize = context.IntegerValue("ListCommands.PageSize");

			List<ListCommandsResponse.ListCommands_Command> listCommandsResponse_commands = new List<ListCommandsResponse.ListCommands_Command>();
			for (int i = 0; i < context.Length("ListCommands.Commands.Length"); i++) {
				ListCommandsResponse.ListCommands_Command command = new ListCommandsResponse.ListCommands_Command();
				command.CommandId = context.StringValue("ListCommands.Commands["+ i +"].CommandId");
				command.CommandContent = context.StringValue("ListCommands.Commands["+ i +"].CommandContent");
				command.WorkingDir = context.StringValue("ListCommands.Commands["+ i +"].WorkingDir");
				command.Timeout = context.StringValue("ListCommands.Commands["+ i +"].Timeout");

				listCommandsResponse_commands.Add(command);
			}
			listCommandsResponse.Commands = listCommandsResponse_commands;
        
			return listCommandsResponse;
        }
    }
}