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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DetachWhitelistTemplateToInstanceResponseUnmarshaller
    {
        public static DetachWhitelistTemplateToInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetachWhitelistTemplateToInstanceResponse detachWhitelistTemplateToInstanceResponse = new DetachWhitelistTemplateToInstanceResponse();

			detachWhitelistTemplateToInstanceResponse.HttpResponse = _ctx.HttpResponse;
			detachWhitelistTemplateToInstanceResponse.RequestId = _ctx.StringValue("DetachWhitelistTemplateToInstance.RequestId");
			detachWhitelistTemplateToInstanceResponse.Success = _ctx.BooleanValue("DetachWhitelistTemplateToInstance.Success");
			detachWhitelistTemplateToInstanceResponse.Code = _ctx.StringValue("DetachWhitelistTemplateToInstance.Code");
			detachWhitelistTemplateToInstanceResponse.Message = _ctx.StringValue("DetachWhitelistTemplateToInstance.Message");
			detachWhitelistTemplateToInstanceResponse.HttpStatusCode = _ctx.IntegerValue("DetachWhitelistTemplateToInstance.HttpStatusCode");

			DetachWhitelistTemplateToInstanceResponse.DetachWhitelistTemplateToInstance_Data data = new DetachWhitelistTemplateToInstanceResponse.DetachWhitelistTemplateToInstance_Data();
			data.Status = _ctx.StringValue("DetachWhitelistTemplateToInstance.Data.Status");
			detachWhitelistTemplateToInstanceResponse.Data = data;
        
			return detachWhitelistTemplateToInstanceResponse;
        }
    }
}
