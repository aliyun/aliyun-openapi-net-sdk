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
        public static DescribeGeoipInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGeoipInstanceResponse describeGeoipInstanceResponse = new DescribeGeoipInstanceResponse();

			describeGeoipInstanceResponse.HttpResponse = context.HttpResponse;
			describeGeoipInstanceResponse.RequestId = context.StringValue("DescribeGeoipInstance.RequestId");
			describeGeoipInstanceResponse.ProductCode = context.StringValue("DescribeGeoipInstance.ProductCode");
			describeGeoipInstanceResponse.InstanceId = context.StringValue("DescribeGeoipInstance.InstanceId");
			describeGeoipInstanceResponse.VersionCode = context.StringValue("DescribeGeoipInstance.VersionCode");
			describeGeoipInstanceResponse.MaxQps = context.LongValue("DescribeGeoipInstance.MaxQps");
			describeGeoipInstanceResponse.MaxQpd = context.LongValue("DescribeGeoipInstance.MaxQpd");
			describeGeoipInstanceResponse.QueryCount = context.LongValue("DescribeGeoipInstance.QueryCount");
			describeGeoipInstanceResponse.CreateTime = context.StringValue("DescribeGeoipInstance.CreateTime");
			describeGeoipInstanceResponse.CreateTimestamp = context.LongValue("DescribeGeoipInstance.CreateTimestamp");
			describeGeoipInstanceResponse.ExpireTime = context.StringValue("DescribeGeoipInstance.ExpireTime");
			describeGeoipInstanceResponse.ExpireTimestamp = context.LongValue("DescribeGeoipInstance.ExpireTimestamp");
        
			return describeGeoipInstanceResponse;
        }
    }
}
