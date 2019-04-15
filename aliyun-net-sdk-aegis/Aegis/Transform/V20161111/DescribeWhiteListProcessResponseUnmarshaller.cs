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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeWhiteListProcessResponseUnmarshaller
    {
        public static DescribeWhiteListProcessResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeWhiteListProcessResponse describeWhiteListProcessResponse = new DescribeWhiteListProcessResponse();

			describeWhiteListProcessResponse.HttpResponse = context.HttpResponse;
			describeWhiteListProcessResponse.RequestId = context.StringValue("DescribeWhiteListProcess.RequestId");
			describeWhiteListProcessResponse.Count = context.IntegerValue("DescribeWhiteListProcess.Count");
			describeWhiteListProcessResponse.PageSize = context.IntegerValue("DescribeWhiteListProcess.PageSize");
			describeWhiteListProcessResponse.TotalCount = context.IntegerValue("DescribeWhiteListProcess.TotalCount");
			describeWhiteListProcessResponse.CurrentPage = context.IntegerValue("DescribeWhiteListProcess.CurrentPage");

			List<DescribeWhiteListProcessResponse.DescribeWhiteListProcess_Process> describeWhiteListProcessResponse_processes = new List<DescribeWhiteListProcessResponse.DescribeWhiteListProcess_Process>();
			for (int i = 0; i < context.Length("DescribeWhiteListProcess.Processes.Length"); i++) {
				DescribeWhiteListProcessResponse.DescribeWhiteListProcess_Process process = new DescribeWhiteListProcessResponse.DescribeWhiteListProcess_Process();
				process.Id = context.LongValue("DescribeWhiteListProcess.Processes["+ i +"].Id");
				process.ProcessId = context.IntegerValue("DescribeWhiteListProcess.Processes["+ i +"].ProcessId");
				process.ProcessName = context.StringValue("DescribeWhiteListProcess.Processes["+ i +"].ProcessName");
				process.FilePath = context.StringValue("DescribeWhiteListProcess.Processes["+ i +"].FilePath");
				process.Md5 = context.StringValue("DescribeWhiteListProcess.Processes["+ i +"].Md5");
				process.Level = context.IntegerValue("DescribeWhiteListProcess.Processes["+ i +"].Level");
				process.ProcessType = context.IntegerValue("DescribeWhiteListProcess.Processes["+ i +"].ProcessType");
				process.Status = context.IntegerValue("DescribeWhiteListProcess.Processes["+ i +"].Status");

				describeWhiteListProcessResponse_processes.Add(process);
			}
			describeWhiteListProcessResponse.Processes = describeWhiteListProcessResponse_processes;
        
			return describeWhiteListProcessResponse;
        }
    }
}
