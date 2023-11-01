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
    public class DescribeEntityInfoResponseUnmarshaller
    {
        public static DescribeEntityInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEntityInfoResponse describeEntityInfoResponse = new DescribeEntityInfoResponse();

			describeEntityInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeEntityInfoResponse.Success = _ctx.BooleanValue("DescribeEntityInfo.Success");
			describeEntityInfoResponse.Code = _ctx.IntegerValue("DescribeEntityInfo.Code");
			describeEntityInfoResponse.Message = _ctx.StringValue("DescribeEntityInfo.Message");
			describeEntityInfoResponse.RequestId = _ctx.StringValue("DescribeEntityInfo.RequestId");

			DescribeEntityInfoResponse.DescribeEntityInfo_Data data = new DescribeEntityInfoResponse.DescribeEntityInfo_Data();
			data.EntityId = _ctx.LongValue("DescribeEntityInfo.Data.EntityId");
			data.EntityType = _ctx.StringValue("DescribeEntityInfo.Data.EntityType");
			data.EntityInfo = _ctx.StringValue("DescribeEntityInfo.Data.EntityInfo");
			data.TipInfo = _ctx.StringValue("DescribeEntityInfo.Data.TipInfo");
			describeEntityInfoResponse.Data = data;
        
			return describeEntityInfoResponse;
        }
    }
}
