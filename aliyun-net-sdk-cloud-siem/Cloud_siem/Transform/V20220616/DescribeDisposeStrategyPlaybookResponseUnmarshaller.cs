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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeDisposeStrategyPlaybookResponseUnmarshaller
    {
        public static DescribeDisposeStrategyPlaybookResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDisposeStrategyPlaybookResponse describeDisposeStrategyPlaybookResponse = new DescribeDisposeStrategyPlaybookResponse();

			describeDisposeStrategyPlaybookResponse.HttpResponse = _ctx.HttpResponse;
			describeDisposeStrategyPlaybookResponse.Success = _ctx.BooleanValue("DescribeDisposeStrategyPlaybook.Success");
			describeDisposeStrategyPlaybookResponse.Code = _ctx.IntegerValue("DescribeDisposeStrategyPlaybook.Code");
			describeDisposeStrategyPlaybookResponse.Message = _ctx.StringValue("DescribeDisposeStrategyPlaybook.Message");
			describeDisposeStrategyPlaybookResponse.RequestId = _ctx.StringValue("DescribeDisposeStrategyPlaybook.RequestId");

			List<DescribeDisposeStrategyPlaybookResponse.DescribeDisposeStrategyPlaybook_DataItem> describeDisposeStrategyPlaybookResponse_data = new List<DescribeDisposeStrategyPlaybookResponse.DescribeDisposeStrategyPlaybook_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeDisposeStrategyPlaybook.Data.Length"); i++) {
				DescribeDisposeStrategyPlaybookResponse.DescribeDisposeStrategyPlaybook_DataItem dataItem = new DescribeDisposeStrategyPlaybookResponse.DescribeDisposeStrategyPlaybook_DataItem();
				dataItem.PlaybookName = _ctx.StringValue("DescribeDisposeStrategyPlaybook.Data["+ i +"].PlaybookName");
				dataItem.PlaybookUuid = _ctx.StringValue("DescribeDisposeStrategyPlaybook.Data["+ i +"].PlaybookUuid");

				describeDisposeStrategyPlaybookResponse_data.Add(dataItem);
			}
			describeDisposeStrategyPlaybookResponse.Data = describeDisposeStrategyPlaybookResponse_data;
        
			return describeDisposeStrategyPlaybookResponse;
        }
    }
}
