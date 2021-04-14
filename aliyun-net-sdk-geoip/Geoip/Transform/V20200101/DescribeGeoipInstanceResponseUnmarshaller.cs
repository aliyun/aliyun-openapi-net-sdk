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
using Aliyun.Acs.geoip.Model.V20200101;

namespace Aliyun.Acs.geoip.Transform.V20200101
{
    public class DescribeGeoipInstanceResponseUnmarshaller
    {
        public static DescribeGeoipInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGeoipInstanceResponse describeGeoipInstanceResponse = new DescribeGeoipInstanceResponse();

			describeGeoipInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeGeoipInstanceResponse.RequestId = _ctx.StringValue("DescribeGeoipInstance.RequestId");
			describeGeoipInstanceResponse.ProductCode = _ctx.StringValue("DescribeGeoipInstance.ProductCode");
			describeGeoipInstanceResponse.InstanceId = _ctx.StringValue("DescribeGeoipInstance.InstanceId");
			describeGeoipInstanceResponse.VersionCode = _ctx.StringValue("DescribeGeoipInstance.VersionCode");
			describeGeoipInstanceResponse.MaxQps = _ctx.LongValue("DescribeGeoipInstance.MaxQps");
			describeGeoipInstanceResponse.MaxQpd = _ctx.LongValue("DescribeGeoipInstance.MaxQpd");
			describeGeoipInstanceResponse.QueryCount = _ctx.LongValue("DescribeGeoipInstance.QueryCount");
			describeGeoipInstanceResponse.CreateTime = _ctx.StringValue("DescribeGeoipInstance.CreateTime");
			describeGeoipInstanceResponse.CreateTimestamp = _ctx.LongValue("DescribeGeoipInstance.CreateTimestamp");
			describeGeoipInstanceResponse.ExpireTime = _ctx.StringValue("DescribeGeoipInstance.ExpireTime");
			describeGeoipInstanceResponse.ExpireTimestamp = _ctx.LongValue("DescribeGeoipInstance.ExpireTimestamp");
        
			return describeGeoipInstanceResponse;
        }
    }
}
