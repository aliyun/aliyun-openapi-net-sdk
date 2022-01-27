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
    public class BindK8sSlbResponseUnmarshaller
    {
        public static BindK8sSlbResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BindK8sSlbResponse bindK8sSlbResponse = new BindK8sSlbResponse();

			bindK8sSlbResponse.HttpResponse = _ctx.HttpResponse;
			bindK8sSlbResponse.ChangeOrderId = _ctx.StringValue("BindK8sSlb.ChangeOrderId");
			bindK8sSlbResponse.Code = _ctx.IntegerValue("BindK8sSlb.Code");
			bindK8sSlbResponse.Message = _ctx.StringValue("BindK8sSlb.Message");
			bindK8sSlbResponse.RequestId = _ctx.StringValue("BindK8sSlb.RequestId");
        
			return bindK8sSlbResponse;
        }
    }
}
