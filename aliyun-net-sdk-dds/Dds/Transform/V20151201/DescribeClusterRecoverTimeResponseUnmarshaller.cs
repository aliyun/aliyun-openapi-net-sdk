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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeClusterRecoverTimeResponseUnmarshaller
    {
        public static DescribeClusterRecoverTimeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterRecoverTimeResponse describeClusterRecoverTimeResponse = new DescribeClusterRecoverTimeResponse();

			describeClusterRecoverTimeResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterRecoverTimeResponse.RequestId = _ctx.StringValue("DescribeClusterRecoverTime.RequestId");

			List<DescribeClusterRecoverTimeResponse.DescribeClusterRecoverTime_AvailableRestoreTime> describeClusterRecoverTimeResponse_restoreRanges = new List<DescribeClusterRecoverTimeResponse.DescribeClusterRecoverTime_AvailableRestoreTime>();
			for (int i = 0; i < _ctx.Length("DescribeClusterRecoverTime.RestoreRanges.Length"); i++) {
				DescribeClusterRecoverTimeResponse.DescribeClusterRecoverTime_AvailableRestoreTime availableRestoreTime = new DescribeClusterRecoverTimeResponse.DescribeClusterRecoverTime_AvailableRestoreTime();
				availableRestoreTime.RestoreBeginTime = _ctx.StringValue("DescribeClusterRecoverTime.RestoreRanges["+ i +"].RestoreBeginTime");
				availableRestoreTime.RestoreEndTime = _ctx.StringValue("DescribeClusterRecoverTime.RestoreRanges["+ i +"].RestoreEndTime");
				availableRestoreTime.RestoreType = _ctx.StringValue("DescribeClusterRecoverTime.RestoreRanges["+ i +"].RestoreType");

				describeClusterRecoverTimeResponse_restoreRanges.Add(availableRestoreTime);
			}
			describeClusterRecoverTimeResponse.RestoreRanges = describeClusterRecoverTimeResponse_restoreRanges;
        
			return describeClusterRecoverTimeResponse;
        }
    }
}
