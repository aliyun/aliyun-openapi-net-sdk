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
    public class DescribeLogTypeResponseUnmarshaller
    {
        public static DescribeLogTypeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLogTypeResponse describeLogTypeResponse = new DescribeLogTypeResponse();

			describeLogTypeResponse.HttpResponse = _ctx.HttpResponse;
			describeLogTypeResponse.Success = _ctx.BooleanValue("DescribeLogType.Success");
			describeLogTypeResponse.Code = _ctx.IntegerValue("DescribeLogType.Code");
			describeLogTypeResponse.Message = _ctx.StringValue("DescribeLogType.Message");
			describeLogTypeResponse.RequestId = _ctx.StringValue("DescribeLogType.RequestId");

			List<DescribeLogTypeResponse.DescribeLogType_DataItem> describeLogTypeResponse_data = new List<DescribeLogTypeResponse.DescribeLogType_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeLogType.Data.Length"); i++) {
				DescribeLogTypeResponse.DescribeLogType_DataItem dataItem = new DescribeLogTypeResponse.DescribeLogType_DataItem();
				dataItem.LogType = _ctx.StringValue("DescribeLogType.Data["+ i +"].LogType");
				dataItem.LogTypeName = _ctx.StringValue("DescribeLogType.Data["+ i +"].LogTypeName");

				describeLogTypeResponse_data.Add(dataItem);
			}
			describeLogTypeResponse.Data = describeLogTypeResponse_data;
        
			return describeLogTypeResponse;
        }
    }
}
