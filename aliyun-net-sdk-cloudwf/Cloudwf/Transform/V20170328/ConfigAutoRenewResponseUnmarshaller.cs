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
using Aliyun.Acs.cloudwf.Model.V20170328;

namespace Aliyun.Acs.cloudwf.Transform.V20170328
{
    public class ConfigAutoRenewResponseUnmarshaller
    {
        public static ConfigAutoRenewResponse Unmarshall(UnmarshallerContext context)
        {
			ConfigAutoRenewResponse configAutoRenewResponse = new ConfigAutoRenewResponse();

			configAutoRenewResponse.HttpResponse = context.HttpResponse;
			configAutoRenewResponse.RequestId = context.StringValue("ConfigAutoRenew.RequestId");
			configAutoRenewResponse.Success = context.BooleanValue("ConfigAutoRenew.Success");
			configAutoRenewResponse.Message = context.StringValue("ConfigAutoRenew.Message");
			configAutoRenewResponse.Code = context.StringValue("ConfigAutoRenew.Code");
			configAutoRenewResponse.Data = context.StringValue("ConfigAutoRenew.Data");
        
			return configAutoRenewResponse;
        }
    }
}
