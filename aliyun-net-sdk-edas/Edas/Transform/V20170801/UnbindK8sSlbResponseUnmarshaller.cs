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
    public class UnbindK8sSlbResponseUnmarshaller
    {
        public static UnbindK8sSlbResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UnbindK8sSlbResponse unbindK8sSlbResponse = new UnbindK8sSlbResponse();

			unbindK8sSlbResponse.HttpResponse = _ctx.HttpResponse;
			unbindK8sSlbResponse.Code = _ctx.IntegerValue("UnbindK8sSlb.Code");
			unbindK8sSlbResponse.Message = _ctx.StringValue("UnbindK8sSlb.Message");
			unbindK8sSlbResponse.ChangeOrderId = _ctx.StringValue("UnbindK8sSlb.ChangeOrderId");
			unbindK8sSlbResponse.RequestId = _ctx.StringValue("UnbindK8sSlb.RequestId");
        
			return unbindK8sSlbResponse;
        }
    }
}
