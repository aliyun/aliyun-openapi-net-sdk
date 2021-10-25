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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeDiskOpsActivityResponseUnmarshaller
    {
        public static DescribeDiskOpsActivityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDiskOpsActivityResponse describeDiskOpsActivityResponse = new DescribeDiskOpsActivityResponse();

			describeDiskOpsActivityResponse.HttpResponse = _ctx.HttpResponse;
			describeDiskOpsActivityResponse.RequestId = _ctx.StringValue("DescribeDiskOpsActivity.RequestId");
			describeDiskOpsActivityResponse.ClusterType = _ctx.StringValue("DescribeDiskOpsActivity.ClusterType");
			describeDiskOpsActivityResponse.CurrentActivity = _ctx.StringValue("DescribeDiskOpsActivity.CurrentActivity");
			describeDiskOpsActivityResponse.ActivityState = _ctx.StringValue("DescribeDiskOpsActivity.ActivityState");
			describeDiskOpsActivityResponse.ErrorMessage = _ctx.StringValue("DescribeDiskOpsActivity.ErrorMessage");
			describeDiskOpsActivityResponse.NeedReboot = _ctx.BooleanValue("DescribeDiskOpsActivity.NeedReboot");
        
			return describeDiskOpsActivityResponse;
        }
    }
}
