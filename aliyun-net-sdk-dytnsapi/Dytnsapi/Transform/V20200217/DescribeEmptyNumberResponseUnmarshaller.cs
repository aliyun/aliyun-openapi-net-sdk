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
    public class DescribeEmptyNumberResponseUnmarshaller
    {
        public static DescribeEmptyNumberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEmptyNumberResponse describeEmptyNumberResponse = new DescribeEmptyNumberResponse();

			describeEmptyNumberResponse.HttpResponse = _ctx.HttpResponse;
			describeEmptyNumberResponse.RequestId = _ctx.StringValue("DescribeEmptyNumber.RequestId");
			describeEmptyNumberResponse.Message = _ctx.StringValue("DescribeEmptyNumber.Message");
			describeEmptyNumberResponse.Code = _ctx.StringValue("DescribeEmptyNumber.Code");

			DescribeEmptyNumberResponse.DescribeEmptyNumber_Data data = new DescribeEmptyNumberResponse.DescribeEmptyNumber_Data();
			data.Status = _ctx.StringValue("DescribeEmptyNumber.Data.Status");
			data.Number = _ctx.StringValue("DescribeEmptyNumber.Data.Number");
			describeEmptyNumberResponse.Data = data;
        
			return describeEmptyNumberResponse;
        }
    }
}
