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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class StopK8sApplicationResponseUnmarshaller
    {
        public static StopK8sApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StopK8sApplicationResponse stopK8sApplicationResponse = new StopK8sApplicationResponse();

			stopK8sApplicationResponse.HttpResponse = _ctx.HttpResponse;
			stopK8sApplicationResponse.RequestId = _ctx.StringValue("StopK8sApplication.RequestId");
			stopK8sApplicationResponse.Code = _ctx.IntegerValue("StopK8sApplication.Code");
			stopK8sApplicationResponse.Message = _ctx.StringValue("StopK8sApplication.Message");
			stopK8sApplicationResponse.ChangeOrderId = _ctx.StringValue("StopK8sApplication.ChangeOrderId");
        
			return stopK8sApplicationResponse;
        }
    }
}
