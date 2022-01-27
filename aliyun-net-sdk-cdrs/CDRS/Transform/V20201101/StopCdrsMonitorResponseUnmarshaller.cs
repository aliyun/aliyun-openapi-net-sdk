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
    public class StopCdrsMonitorResponseUnmarshaller
    {
        public static StopCdrsMonitorResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StopCdrsMonitorResponse stopCdrsMonitorResponse = new StopCdrsMonitorResponse();

			stopCdrsMonitorResponse.HttpResponse = _ctx.HttpResponse;
			stopCdrsMonitorResponse.Code = _ctx.StringValue("StopCdrsMonitor.Code");
			stopCdrsMonitorResponse.Data = _ctx.StringValue("StopCdrsMonitor.Data");
			stopCdrsMonitorResponse.Message = _ctx.StringValue("StopCdrsMonitor.Message");
			stopCdrsMonitorResponse.RequestId = _ctx.StringValue("StopCdrsMonitor.RequestId");
        
			return stopCdrsMonitorResponse;
        }
    }
}
