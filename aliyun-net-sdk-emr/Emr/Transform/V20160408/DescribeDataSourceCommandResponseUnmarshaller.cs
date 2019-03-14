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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeDataSourceCommandResponseUnmarshaller
    {
        public static DescribeDataSourceCommandResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataSourceCommandResponse describeDataSourceCommandResponse = new DescribeDataSourceCommandResponse();

			describeDataSourceCommandResponse.HttpResponse = context.HttpResponse;
			describeDataSourceCommandResponse.RequestId = context.StringValue("DescribeDataSourceCommand.RequestId");
			describeDataSourceCommandResponse.CommandId = context.StringValue("DescribeDataSourceCommand.CommandId");
			describeDataSourceCommandResponse.HostName = context.StringValue("DescribeDataSourceCommand.HostName");
			describeDataSourceCommandResponse.State = context.StringValue("DescribeDataSourceCommand.State");
			describeDataSourceCommandResponse.StartTime = context.LongValue("DescribeDataSourceCommand.StartTime");
			describeDataSourceCommandResponse.EndTime = context.LongValue("DescribeDataSourceCommand.EndTime");
			describeDataSourceCommandResponse.Message = context.StringValue("DescribeDataSourceCommand.Message");
			describeDataSourceCommandResponse.Data = context.StringValue("DescribeDataSourceCommand.Data");

			List<DescribeDataSourceCommandResponse.DescribeDataSourceCommand_Host> describeDataSourceCommandResponse_hostList = new List<DescribeDataSourceCommandResponse.DescribeDataSourceCommand_Host>();
			for (int i = 0; i < context.Length("DescribeDataSourceCommand.HostList.Length"); i++) {
				DescribeDataSourceCommandResponse.DescribeDataSourceCommand_Host host = new DescribeDataSourceCommandResponse.DescribeDataSourceCommand_Host();
				host.HostName = context.StringValue("DescribeDataSourceCommand.HostList["+ i +"].HostName");
				host.State = context.StringValue("DescribeDataSourceCommand.HostList["+ i +"].State");
				host.StartTime = context.LongValue("DescribeDataSourceCommand.HostList["+ i +"].StartTime");
				host.EndTime = context.LongValue("DescribeDataSourceCommand.HostList["+ i +"].EndTime");
				host.Message = context.StringValue("DescribeDataSourceCommand.HostList["+ i +"].Message");
				host.Data = context.StringValue("DescribeDataSourceCommand.HostList["+ i +"].Data");

				describeDataSourceCommandResponse_hostList.Add(host);
			}
			describeDataSourceCommandResponse.HostList = describeDataSourceCommandResponse_hostList;
        
			return describeDataSourceCommandResponse;
        }
    }
}
