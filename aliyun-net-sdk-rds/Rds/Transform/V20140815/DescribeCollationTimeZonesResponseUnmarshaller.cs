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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeCollationTimeZonesResponseUnmarshaller
    {
        public static DescribeCollationTimeZonesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCollationTimeZonesResponse describeCollationTimeZonesResponse = new DescribeCollationTimeZonesResponse();

			describeCollationTimeZonesResponse.HttpResponse = _ctx.HttpResponse;
			describeCollationTimeZonesResponse.RequestId = _ctx.StringValue("DescribeCollationTimeZones.RequestId");

			List<DescribeCollationTimeZonesResponse.DescribeCollationTimeZones_CollationTimeZone> describeCollationTimeZonesResponse_collationTimeZones = new List<DescribeCollationTimeZonesResponse.DescribeCollationTimeZones_CollationTimeZone>();
			for (int i = 0; i < _ctx.Length("DescribeCollationTimeZones.CollationTimeZones.Length"); i++) {
				DescribeCollationTimeZonesResponse.DescribeCollationTimeZones_CollationTimeZone collationTimeZone = new DescribeCollationTimeZonesResponse.DescribeCollationTimeZones_CollationTimeZone();
				collationTimeZone.TimeZone = _ctx.StringValue("DescribeCollationTimeZones.CollationTimeZones["+ i +"].TimeZone");
				collationTimeZone.StandardTimeOffset = _ctx.StringValue("DescribeCollationTimeZones.CollationTimeZones["+ i +"].StandardTimeOffset");
				collationTimeZone.Description = _ctx.StringValue("DescribeCollationTimeZones.CollationTimeZones["+ i +"].Description");

				describeCollationTimeZonesResponse_collationTimeZones.Add(collationTimeZone);
			}
			describeCollationTimeZonesResponse.CollationTimeZones = describeCollationTimeZonesResponse_collationTimeZones;
        
			return describeCollationTimeZonesResponse;
        }
    }
}
