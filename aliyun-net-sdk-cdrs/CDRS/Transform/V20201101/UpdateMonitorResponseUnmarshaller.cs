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
    public class UpdateMonitorResponseUnmarshaller
    {
        public static UpdateMonitorResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateMonitorResponse updateMonitorResponse = new UpdateMonitorResponse();

			updateMonitorResponse.HttpResponse = _ctx.HttpResponse;
			updateMonitorResponse.Code = _ctx.StringValue("UpdateMonitor.Code");
			updateMonitorResponse.Data = _ctx.StringValue("UpdateMonitor.Data");
			updateMonitorResponse.Message = _ctx.StringValue("UpdateMonitor.Message");
			updateMonitorResponse.RequestId = _ctx.StringValue("UpdateMonitor.RequestId");
        
			return updateMonitorResponse;
        }
    }
}
