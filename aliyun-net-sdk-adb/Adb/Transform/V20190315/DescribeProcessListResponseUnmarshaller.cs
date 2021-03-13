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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeProcessListResponseUnmarshaller
    {
        public static DescribeProcessListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProcessListResponse describeProcessListResponse = new DescribeProcessListResponse();

			describeProcessListResponse.HttpResponse = _ctx.HttpResponse;
			describeProcessListResponse.RequestId = _ctx.StringValue("DescribeProcessList.RequestId");
			describeProcessListResponse.TotalCount = _ctx.StringValue("DescribeProcessList.TotalCount");
			describeProcessListResponse.PageNumber = _ctx.StringValue("DescribeProcessList.PageNumber");
			describeProcessListResponse.PageSize = _ctx.StringValue("DescribeProcessList.PageSize");

			List<DescribeProcessListResponse.DescribeProcessList_Process> describeProcessListResponse_items = new List<DescribeProcessListResponse.DescribeProcessList_Process>();
			for (int i = 0; i < _ctx.Length("DescribeProcessList.Items.Length"); i++) {
				DescribeProcessListResponse.DescribeProcessList_Process process = new DescribeProcessListResponse.DescribeProcessList_Process();
				process.Id = _ctx.IntegerValue("DescribeProcessList.Items["+ i +"].Id");
				process.ProcessId = _ctx.StringValue("DescribeProcessList.Items["+ i +"].ProcessId");
				process.User = _ctx.StringValue("DescribeProcessList.Items["+ i +"].User");
				process.Host = _ctx.StringValue("DescribeProcessList.Items["+ i +"].Host");
				process.DB = _ctx.StringValue("DescribeProcessList.Items["+ i +"].DB");
				process.Command = _ctx.StringValue("DescribeProcessList.Items["+ i +"].Command");
				process.Time = _ctx.IntegerValue("DescribeProcessList.Items["+ i +"].Time");
				process.StartTime = _ctx.StringValue("DescribeProcessList.Items["+ i +"].StartTime");
				process.Info = _ctx.StringValue("DescribeProcessList.Items["+ i +"].Info");

				describeProcessListResponse_items.Add(process);
			}
			describeProcessListResponse.Items = describeProcessListResponse_items;
        
			return describeProcessListResponse;
        }
    }
}
