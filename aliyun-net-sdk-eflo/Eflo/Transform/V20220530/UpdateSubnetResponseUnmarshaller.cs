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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class UpdateSubnetResponseUnmarshaller
    {
        public static UpdateSubnetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateSubnetResponse updateSubnetResponse = new UpdateSubnetResponse();

			updateSubnetResponse.HttpResponse = _ctx.HttpResponse;
			updateSubnetResponse.Code = _ctx.IntegerValue("UpdateSubnet.Code");
			updateSubnetResponse.Message = _ctx.StringValue("UpdateSubnet.Message");
			updateSubnetResponse.RequestId = _ctx.StringValue("UpdateSubnet.RequestId");

			UpdateSubnetResponse.UpdateSubnet_Content content = new UpdateSubnetResponse.UpdateSubnet_Content();
			content.SubnetId = _ctx.StringValue("UpdateSubnet.Content.SubnetId");
			updateSubnetResponse.Content = content;
        
			return updateSubnetResponse;
        }
    }
}
