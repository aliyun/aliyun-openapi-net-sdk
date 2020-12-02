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
    public class DeleteSynchronizationJobResponseUnmarshaller
    {
        public static DeleteSynchronizationJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteSynchronizationJobResponse deleteSynchronizationJobResponse = new DeleteSynchronizationJobResponse();

			deleteSynchronizationJobResponse.HttpResponse = _ctx.HttpResponse;
			deleteSynchronizationJobResponse.ErrCode = _ctx.StringValue("DeleteSynchronizationJob.ErrCode");
			deleteSynchronizationJobResponse.ErrMessage = _ctx.StringValue("DeleteSynchronizationJob.ErrMessage");
			deleteSynchronizationJobResponse.RequestId = _ctx.StringValue("DeleteSynchronizationJob.RequestId");
			deleteSynchronizationJobResponse.Success = _ctx.StringValue("DeleteSynchronizationJob.Success");
        
			return deleteSynchronizationJobResponse;
        }
    }
}
