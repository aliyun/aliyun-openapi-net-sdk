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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class ModifySynchronizationObjectResponseUnmarshaller
    {
        public static ModifySynchronizationObjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifySynchronizationObjectResponse modifySynchronizationObjectResponse = new ModifySynchronizationObjectResponse();

			modifySynchronizationObjectResponse.HttpResponse = _ctx.HttpResponse;
			modifySynchronizationObjectResponse.ErrCode = _ctx.StringValue("ModifySynchronizationObject.ErrCode");
			modifySynchronizationObjectResponse.ErrMessage = _ctx.StringValue("ModifySynchronizationObject.ErrMessage");
			modifySynchronizationObjectResponse.RequestId = _ctx.StringValue("ModifySynchronizationObject.RequestId");
			modifySynchronizationObjectResponse.Success = _ctx.StringValue("ModifySynchronizationObject.Success");
			modifySynchronizationObjectResponse.TaskId = _ctx.StringValue("ModifySynchronizationObject.TaskId");
        
			return modifySynchronizationObjectResponse;
        }
    }
}
