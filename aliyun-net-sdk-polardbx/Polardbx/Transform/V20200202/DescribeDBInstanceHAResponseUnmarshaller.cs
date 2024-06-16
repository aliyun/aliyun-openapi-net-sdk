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
    public class DescribeDBInstanceHAResponseUnmarshaller
    {
        public static DescribeDBInstanceHAResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceHAResponse describeDBInstanceHAResponse = new DescribeDBInstanceHAResponse();

			describeDBInstanceHAResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceHAResponse.Message = _ctx.StringValue("DescribeDBInstanceHA.Message");
			describeDBInstanceHAResponse.RequestId = _ctx.StringValue("DescribeDBInstanceHA.RequestId");
			describeDBInstanceHAResponse.Success = _ctx.BooleanValue("DescribeDBInstanceHA.Success");

			DescribeDBInstanceHAResponse.DescribeDBInstanceHA_Data data = new DescribeDBInstanceHAResponse.DescribeDBInstanceHA_Data();
			data.TopologyType = _ctx.StringValue("DescribeDBInstanceHA.Data.TopologyType");
			data.PrimaryRegionId = _ctx.StringValue("DescribeDBInstanceHA.Data.PrimaryRegionId");
			data.PrimaryAzoneId = _ctx.StringValue("DescribeDBInstanceHA.Data.PrimaryAzoneId");
			data.SecondaryRegionId = _ctx.StringValue("DescribeDBInstanceHA.Data.SecondaryRegionId");
			data.SecondaryAzoneId = _ctx.StringValue("DescribeDBInstanceHA.Data.SecondaryAzoneId");
			describeDBInstanceHAResponse.Data = data;
        
			return describeDBInstanceHAResponse;
        }
    }
}
