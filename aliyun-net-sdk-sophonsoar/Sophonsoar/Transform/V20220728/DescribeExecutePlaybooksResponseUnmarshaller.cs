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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeExecutePlaybooksResponseUnmarshaller
    {
        public static DescribeExecutePlaybooksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeExecutePlaybooksResponse describeExecutePlaybooksResponse = new DescribeExecutePlaybooksResponse();

			describeExecutePlaybooksResponse.HttpResponse = _ctx.HttpResponse;
			describeExecutePlaybooksResponse.RequestId = _ctx.StringValue("DescribeExecutePlaybooks.RequestId");

			List<DescribeExecutePlaybooksResponse.DescribeExecutePlaybooks_Data> describeExecutePlaybooksResponse_playbookMetrics = new List<DescribeExecutePlaybooksResponse.DescribeExecutePlaybooks_Data>();
			for (int i = 0; i < _ctx.Length("DescribeExecutePlaybooks.PlaybookMetrics.Length"); i++) {
				DescribeExecutePlaybooksResponse.DescribeExecutePlaybooks_Data data = new DescribeExecutePlaybooksResponse.DescribeExecutePlaybooks_Data();
				data.Description = _ctx.StringValue("DescribeExecutePlaybooks.PlaybookMetrics["+ i +"].Description");
				data.ActionType = _ctx.StringValue("DescribeExecutePlaybooks.PlaybookMetrics["+ i +"].ActionType");
				data.DisplayName = _ctx.StringValue("DescribeExecutePlaybooks.PlaybookMetrics["+ i +"].DisplayName");
				data.Uuid = _ctx.StringValue("DescribeExecutePlaybooks.PlaybookMetrics["+ i +"].Uuid");
				data.TaskConfig = _ctx.StringValue("DescribeExecutePlaybooks.PlaybookMetrics["+ i +"].TaskConfig");
				data.ParamConfig = _ctx.StringValue("DescribeExecutePlaybooks.PlaybookMetrics["+ i +"].ParamConfig");
				data.CommandEntity = _ctx.StringValue("DescribeExecutePlaybooks.PlaybookMetrics["+ i +"].CommandEntity");
				data.ParamType = _ctx.StringValue("DescribeExecutePlaybooks.PlaybookMetrics["+ i +"].ParamType");

				describeExecutePlaybooksResponse_playbookMetrics.Add(data);
			}
			describeExecutePlaybooksResponse.PlaybookMetrics = describeExecutePlaybooksResponse_playbookMetrics;
        
			return describeExecutePlaybooksResponse;
        }
    }
}
