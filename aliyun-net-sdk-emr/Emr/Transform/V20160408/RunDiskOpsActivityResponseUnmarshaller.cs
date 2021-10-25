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
    public class RunDiskOpsActivityResponseUnmarshaller
    {
        public static RunDiskOpsActivityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RunDiskOpsActivityResponse runDiskOpsActivityResponse = new RunDiskOpsActivityResponse();

			runDiskOpsActivityResponse.HttpResponse = _ctx.HttpResponse;
			runDiskOpsActivityResponse.RequestId = _ctx.StringValue("RunDiskOpsActivity.RequestId");
			runDiskOpsActivityResponse.ClusterType = _ctx.StringValue("RunDiskOpsActivity.ClusterType");
			runDiskOpsActivityResponse.CurrentActivity = _ctx.StringValue("RunDiskOpsActivity.CurrentActivity");
			runDiskOpsActivityResponse.ActivityState = _ctx.StringValue("RunDiskOpsActivity.ActivityState");
			runDiskOpsActivityResponse.ErrorMessage = _ctx.StringValue("RunDiskOpsActivity.ErrorMessage");
			runDiskOpsActivityResponse.NeedReboot = _ctx.BooleanValue("RunDiskOpsActivity.NeedReboot");
        
			return runDiskOpsActivityResponse;
        }
    }
}
