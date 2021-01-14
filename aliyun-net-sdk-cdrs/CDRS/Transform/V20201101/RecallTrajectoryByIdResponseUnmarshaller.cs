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
    public class RecallTrajectoryByIdResponseUnmarshaller
    {
        public static RecallTrajectoryByIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecallTrajectoryByIdResponse recallTrajectoryByIdResponse = new RecallTrajectoryByIdResponse();

			recallTrajectoryByIdResponse.HttpResponse = _ctx.HttpResponse;
			recallTrajectoryByIdResponse.Code = _ctx.IntegerValue("RecallTrajectoryById.Code");
			recallTrajectoryByIdResponse.Data = _ctx.StringValue("RecallTrajectoryById.Data");
			recallTrajectoryByIdResponse.Message = _ctx.StringValue("RecallTrajectoryById.Message");
			recallTrajectoryByIdResponse.RequestId = _ctx.StringValue("RecallTrajectoryById.RequestId");
			recallTrajectoryByIdResponse.Success = _ctx.BooleanValue("RecallTrajectoryById.Success");
        
			return recallTrajectoryByIdResponse;
        }
    }
}
