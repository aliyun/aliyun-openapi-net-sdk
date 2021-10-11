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
using Aliyun.Acs.Dytnsapi.Model.V20200217;

namespace Aliyun.Acs.Dytnsapi.Transform.V20200217
{
    public class DescribeEmptyNumberDetectResponseUnmarshaller
    {
        public static DescribeEmptyNumberDetectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEmptyNumberDetectResponse describeEmptyNumberDetectResponse = new DescribeEmptyNumberDetectResponse();

			describeEmptyNumberDetectResponse.HttpResponse = _ctx.HttpResponse;
			describeEmptyNumberDetectResponse.RequestId = _ctx.StringValue("DescribeEmptyNumberDetect.RequestId");
			describeEmptyNumberDetectResponse.Code = _ctx.StringValue("DescribeEmptyNumberDetect.Code");
			describeEmptyNumberDetectResponse.Message = _ctx.StringValue("DescribeEmptyNumberDetect.Message");

			List<DescribeEmptyNumberDetectResponse.DescribeEmptyNumberDetect_DataList> describeEmptyNumberDetectResponse_data = new List<DescribeEmptyNumberDetectResponse.DescribeEmptyNumberDetect_DataList>();
			for (int i = 0; i < _ctx.Length("DescribeEmptyNumberDetect.Data.Length"); i++) {
				DescribeEmptyNumberDetectResponse.DescribeEmptyNumberDetect_DataList dataList = new DescribeEmptyNumberDetectResponse.DescribeEmptyNumberDetect_DataList();
				dataList.Number = _ctx.StringValue("DescribeEmptyNumberDetect.Data["+ i +"].Number");
				dataList.Status = _ctx.StringValue("DescribeEmptyNumberDetect.Data["+ i +"].Status");

				describeEmptyNumberDetectResponse_data.Add(dataList);
			}
			describeEmptyNumberDetectResponse.Data = describeEmptyNumberDetectResponse_data;
        
			return describeEmptyNumberDetectResponse;
        }
    }
}
