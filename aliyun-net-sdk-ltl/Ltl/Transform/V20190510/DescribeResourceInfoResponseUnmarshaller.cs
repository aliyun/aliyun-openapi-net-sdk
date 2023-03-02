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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class DescribeResourceInfoResponseUnmarshaller
    {
        public static DescribeResourceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeResourceInfoResponse describeResourceInfoResponse = new DescribeResourceInfoResponse();

			describeResourceInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeResourceInfoResponse.Code = _ctx.IntegerValue("DescribeResourceInfo.Code");
			describeResourceInfoResponse.Message = _ctx.StringValue("DescribeResourceInfo.Message");
			describeResourceInfoResponse.RequestId = _ctx.StringValue("DescribeResourceInfo.RequestId");
			describeResourceInfoResponse.Success = _ctx.BooleanValue("DescribeResourceInfo.Success");

			DescribeResourceInfoResponse.DescribeResourceInfo_Data data = new DescribeResourceInfoResponse.DescribeResourceInfo_Data();
			data.Status = _ctx.StringValue("DescribeResourceInfo.Data.Status");
			data.EffectiveTime = _ctx.LongValue("DescribeResourceInfo.Data.EffectiveTime");
			data.AuthorizeType = _ctx.StringValue("DescribeResourceInfo.Data.AuthorizeType");
			data.ExpiredTime = _ctx.LongValue("DescribeResourceInfo.Data.ExpiredTime");
			data.Region = _ctx.StringValue("DescribeResourceInfo.Data.Region");
			describeResourceInfoResponse.Data = data;
        
			return describeResourceInfoResponse;
        }
    }
}
