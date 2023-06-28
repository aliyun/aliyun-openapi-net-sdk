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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class BatchUploadMPCoSPhaseTextInfoByDeviceResponseUnmarshaller
    {
        public static BatchUploadMPCoSPhaseTextInfoByDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchUploadMPCoSPhaseTextInfoByDeviceResponse batchUploadMPCoSPhaseTextInfoByDeviceResponse = new BatchUploadMPCoSPhaseTextInfoByDeviceResponse();

			batchUploadMPCoSPhaseTextInfoByDeviceResponse.HttpResponse = _ctx.HttpResponse;
			batchUploadMPCoSPhaseTextInfoByDeviceResponse.Code = _ctx.IntegerValue("BatchUploadMPCoSPhaseTextInfoByDevice.Code");
			batchUploadMPCoSPhaseTextInfoByDeviceResponse.Message = _ctx.StringValue("BatchUploadMPCoSPhaseTextInfoByDevice.Message");
			batchUploadMPCoSPhaseTextInfoByDeviceResponse.Data = _ctx.StringValue("BatchUploadMPCoSPhaseTextInfoByDevice.Data");
			batchUploadMPCoSPhaseTextInfoByDeviceResponse.RequestId = _ctx.StringValue("BatchUploadMPCoSPhaseTextInfoByDevice.RequestId");
			batchUploadMPCoSPhaseTextInfoByDeviceResponse.Success = _ctx.BooleanValue("BatchUploadMPCoSPhaseTextInfoByDevice.Success");
        
			return batchUploadMPCoSPhaseTextInfoByDeviceResponse;
        }
    }
}
