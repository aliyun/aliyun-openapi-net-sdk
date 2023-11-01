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
    public class DescribeLogFieldsResponseUnmarshaller
    {
        public static DescribeLogFieldsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLogFieldsResponse describeLogFieldsResponse = new DescribeLogFieldsResponse();

			describeLogFieldsResponse.HttpResponse = _ctx.HttpResponse;
			describeLogFieldsResponse.Success = _ctx.BooleanValue("DescribeLogFields.Success");
			describeLogFieldsResponse.Code = _ctx.IntegerValue("DescribeLogFields.Code");
			describeLogFieldsResponse.Message = _ctx.StringValue("DescribeLogFields.Message");
			describeLogFieldsResponse.RequestId = _ctx.StringValue("DescribeLogFields.RequestId");

			List<DescribeLogFieldsResponse.DescribeLogFields_DataItem> describeLogFieldsResponse_data = new List<DescribeLogFieldsResponse.DescribeLogFields_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeLogFields.Data.Length"); i++) {
				DescribeLogFieldsResponse.DescribeLogFields_DataItem dataItem = new DescribeLogFieldsResponse.DescribeLogFields_DataItem();
				dataItem.FieldName = _ctx.StringValue("DescribeLogFields.Data["+ i +"].FieldName");
				dataItem.FieldDesc = _ctx.StringValue("DescribeLogFields.Data["+ i +"].FieldDesc");
				dataItem.LogCode = _ctx.StringValue("DescribeLogFields.Data["+ i +"].LogCode");
				dataItem.ActivityName = _ctx.StringValue("DescribeLogFields.Data["+ i +"].ActivityName");
				dataItem.FieldType = _ctx.StringValue("DescribeLogFields.Data["+ i +"].FieldType");

				describeLogFieldsResponse_data.Add(dataItem);
			}
			describeLogFieldsResponse.Data = describeLogFieldsResponse_data;
        
			return describeLogFieldsResponse;
        }
    }
}
