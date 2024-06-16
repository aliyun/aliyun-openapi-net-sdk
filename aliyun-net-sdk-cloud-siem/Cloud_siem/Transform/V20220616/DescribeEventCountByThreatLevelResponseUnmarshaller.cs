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
    public class DescribeEventCountByThreatLevelResponseUnmarshaller
    {
        public static DescribeEventCountByThreatLevelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEventCountByThreatLevelResponse describeEventCountByThreatLevelResponse = new DescribeEventCountByThreatLevelResponse();

			describeEventCountByThreatLevelResponse.HttpResponse = _ctx.HttpResponse;
			describeEventCountByThreatLevelResponse.Success = _ctx.BooleanValue("DescribeEventCountByThreatLevel.Success");
			describeEventCountByThreatLevelResponse.Code = _ctx.IntegerValue("DescribeEventCountByThreatLevel.Code");
			describeEventCountByThreatLevelResponse.Message = _ctx.StringValue("DescribeEventCountByThreatLevel.Message");
			describeEventCountByThreatLevelResponse.RequestId = _ctx.StringValue("DescribeEventCountByThreatLevel.RequestId");

			DescribeEventCountByThreatLevelResponse.DescribeEventCountByThreatLevel_Data data = new DescribeEventCountByThreatLevelResponse.DescribeEventCountByThreatLevel_Data();
			data.EventNum = _ctx.LongValue("DescribeEventCountByThreatLevel.Data.EventNum");
			data.UndealEventNum = _ctx.LongValue("DescribeEventCountByThreatLevel.Data.UndealEventNum");
			data.HighLevelEventNum = _ctx.LongValue("DescribeEventCountByThreatLevel.Data.HighLevelEventNum");
			data.MediumLevelEventNum = _ctx.LongValue("DescribeEventCountByThreatLevel.Data.MediumLevelEventNum");
			data.LowLevelEventNum = _ctx.LongValue("DescribeEventCountByThreatLevel.Data.LowLevelEventNum");
			describeEventCountByThreatLevelResponse.Data = data;
        
			return describeEventCountByThreatLevelResponse;
        }
    }
}
