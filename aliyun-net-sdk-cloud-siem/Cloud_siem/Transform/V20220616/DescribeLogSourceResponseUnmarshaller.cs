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
    public class DescribeLogSourceResponseUnmarshaller
    {
        public static DescribeLogSourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLogSourceResponse describeLogSourceResponse = new DescribeLogSourceResponse();

			describeLogSourceResponse.HttpResponse = _ctx.HttpResponse;
			describeLogSourceResponse.Success = _ctx.BooleanValue("DescribeLogSource.Success");
			describeLogSourceResponse.Code = _ctx.IntegerValue("DescribeLogSource.Code");
			describeLogSourceResponse.Message = _ctx.StringValue("DescribeLogSource.Message");
			describeLogSourceResponse.RequestId = _ctx.StringValue("DescribeLogSource.RequestId");

			List<DescribeLogSourceResponse.DescribeLogSource_DataItem> describeLogSourceResponse_data = new List<DescribeLogSourceResponse.DescribeLogSource_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeLogSource.Data.Length"); i++) {
				DescribeLogSourceResponse.DescribeLogSource_DataItem dataItem = new DescribeLogSourceResponse.DescribeLogSource_DataItem();
				dataItem.LogSource = _ctx.StringValue("DescribeLogSource.Data["+ i +"].LogSource");
				dataItem.LogSourceName = _ctx.StringValue("DescribeLogSource.Data["+ i +"].LogSourceName");

				describeLogSourceResponse_data.Add(dataItem);
			}
			describeLogSourceResponse.Data = describeLogSourceResponse_data;
        
			return describeLogSourceResponse;
        }
    }
}
