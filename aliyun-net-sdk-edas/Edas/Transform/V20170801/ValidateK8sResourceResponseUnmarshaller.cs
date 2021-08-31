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
    public class ValidateK8sResourceResponseUnmarshaller
    {
        public static ValidateK8sResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ValidateK8sResourceResponse validateK8sResourceResponse = new ValidateK8sResourceResponse();

			validateK8sResourceResponse.HttpResponse = _ctx.HttpResponse;
			validateK8sResourceResponse.RequestId = _ctx.StringValue("ValidateK8sResource.RequestId");
			validateK8sResourceResponse.Code = _ctx.IntegerValue("ValidateK8sResource.Code");
			validateK8sResourceResponse.Message = _ctx.StringValue("ValidateK8sResource.Message");
        
			return validateK8sResourceResponse;
        }
    }
}
