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
    public class AddMonitorResponseUnmarshaller
    {
        public static AddMonitorResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddMonitorResponse addMonitorResponse = new AddMonitorResponse();

			addMonitorResponse.HttpResponse = _ctx.HttpResponse;
			addMonitorResponse.RequestId = _ctx.StringValue("AddMonitor.RequestId");
			addMonitorResponse.Code = _ctx.StringValue("AddMonitor.Code");
			addMonitorResponse.Message = _ctx.StringValue("AddMonitor.Message");

			AddMonitorResponse.AddMonitor_Data data = new AddMonitorResponse.AddMonitor_Data();
			data.TaskId = _ctx.StringValue("AddMonitor.Data.TaskId");
			addMonitorResponse.Data = data;
        
			return addMonitorResponse;
        }
    }
}
