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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeTableDetailResponseUnmarshaller
    {
        public static DescribeTableDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTableDetailResponse describeTableDetailResponse = new DescribeTableDetailResponse();

			describeTableDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeTableDetailResponse.RequestId = _ctx.StringValue("DescribeTableDetail.RequestId");
			describeTableDetailResponse.Success = _ctx.BooleanValue("DescribeTableDetail.Success");
			describeTableDetailResponse.Message = _ctx.StringValue("DescribeTableDetail.Message");

			DescribeTableDetailResponse.DescribeTableDetail_Data data = new DescribeTableDetailResponse.DescribeTableDetail_Data();

			List<DescribeTableDetailResponse.DescribeTableDetail_Data.DescribeTableDetail_Field> data_fields = new List<DescribeTableDetailResponse.DescribeTableDetail_Data.DescribeTableDetail_Field>();
			for (int i = 0; i < _ctx.Length("DescribeTableDetail.Data.Fields.Length"); i++) {
				DescribeTableDetailResponse.DescribeTableDetail_Data.DescribeTableDetail_Field field = new DescribeTableDetailResponse.DescribeTableDetail_Data.DescribeTableDetail_Field();
				field.Column = _ctx.StringValue("DescribeTableDetail.Data.Fields["+ i +"].Column");
				field.DataType = _ctx.StringValue("DescribeTableDetail.Data.Fields["+ i +"].DataType");
				field.Key = _ctx.StringValue("DescribeTableDetail.Data.Fields["+ i +"].Key");
				field.Extra = _ctx.StringValue("DescribeTableDetail.Data.Fields["+ i +"].Extra");

				data_fields.Add(field);
			}
			data.Fields = data_fields;
			describeTableDetailResponse.Data = data;
        
			return describeTableDetailResponse;
        }
    }
}
