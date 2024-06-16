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
    public class DescribeAlertsCountResponseUnmarshaller
    {
        public static DescribeAlertsCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAlertsCountResponse describeAlertsCountResponse = new DescribeAlertsCountResponse();

			describeAlertsCountResponse.HttpResponse = _ctx.HttpResponse;
			describeAlertsCountResponse.Success = _ctx.BooleanValue("DescribeAlertsCount.Success");
			describeAlertsCountResponse.Code = _ctx.IntegerValue("DescribeAlertsCount.Code");
			describeAlertsCountResponse.Message = _ctx.StringValue("DescribeAlertsCount.Message");
			describeAlertsCountResponse.RequestId = _ctx.StringValue("DescribeAlertsCount.RequestId");

			DescribeAlertsCountResponse.DescribeAlertsCount_Data data = new DescribeAlertsCountResponse.DescribeAlertsCount_Data();
			data.High = _ctx.LongValue("DescribeAlertsCount.Data.High");
			data.Medium = _ctx.LongValue("DescribeAlertsCount.Data.Medium");
			data.Low = _ctx.LongValue("DescribeAlertsCount.Data.Low");
			data.All = _ctx.LongValue("DescribeAlertsCount.Data.All");
			data.ProductNum = _ctx.IntegerValue("DescribeAlertsCount.Data.ProductNum");
			describeAlertsCountResponse.Data = data;
        
			return describeAlertsCountResponse;
        }
    }
}
