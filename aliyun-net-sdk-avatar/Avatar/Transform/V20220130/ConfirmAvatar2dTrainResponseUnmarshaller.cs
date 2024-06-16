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
using Aliyun.Acs.avatar.Model.V20220130;

namespace Aliyun.Acs.avatar.Transform.V20220130
{
    public class ConfirmAvatar2dTrainResponseUnmarshaller
    {
        public static ConfirmAvatar2dTrainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ConfirmAvatar2dTrainResponse confirmAvatar2dTrainResponse = new ConfirmAvatar2dTrainResponse();

			confirmAvatar2dTrainResponse.HttpResponse = _ctx.HttpResponse;
			confirmAvatar2dTrainResponse.RequestId = _ctx.StringValue("ConfirmAvatar2dTrain.RequestId");
			confirmAvatar2dTrainResponse.Code = _ctx.StringValue("ConfirmAvatar2dTrain.Code");
			confirmAvatar2dTrainResponse.Message = _ctx.StringValue("ConfirmAvatar2dTrain.Message");
			confirmAvatar2dTrainResponse.Success = _ctx.BooleanValue("ConfirmAvatar2dTrain.Success");
        
			return confirmAvatar2dTrainResponse;
        }
    }
}
