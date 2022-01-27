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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class StopMonitorResponseUnmarshaller
    {
        public static StopMonitorResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StopMonitorResponse stopMonitorResponse = new StopMonitorResponse();

			stopMonitorResponse.HttpResponse = _ctx.HttpResponse;
			stopMonitorResponse.Code = _ctx.StringValue("StopMonitor.Code");
			stopMonitorResponse.Data = _ctx.StringValue("StopMonitor.Data");
			stopMonitorResponse.Message = _ctx.StringValue("StopMonitor.Message");
			stopMonitorResponse.RequestId = _ctx.StringValue("StopMonitor.RequestId");
        
			return stopMonitorResponse;
        }
    }
}
