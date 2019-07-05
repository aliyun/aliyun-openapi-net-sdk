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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class UpgradeCdiBaseBagResponseUnmarshaller
    {
        public static UpgradeCdiBaseBagResponse Unmarshall(UnmarshallerContext context)
        {
			UpgradeCdiBaseBagResponse upgradeCdiBaseBagResponse = new UpgradeCdiBaseBagResponse();

			upgradeCdiBaseBagResponse.HttpResponse = context.HttpResponse;
			upgradeCdiBaseBagResponse.Code = context.StringValue("UpgradeCdiBaseBag.Code");
			upgradeCdiBaseBagResponse.Message = context.StringValue("UpgradeCdiBaseBag.Message");
			upgradeCdiBaseBagResponse.OrderId = context.StringValue("UpgradeCdiBaseBag.OrderId");
			upgradeCdiBaseBagResponse.InstanceId = context.StringValue("UpgradeCdiBaseBag.InstanceId");
			upgradeCdiBaseBagResponse.RequestId = context.StringValue("UpgradeCdiBaseBag.RequestId");
        
			return upgradeCdiBaseBagResponse;
        }
    }
}
