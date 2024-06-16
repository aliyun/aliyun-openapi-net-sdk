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
    public class UpdateElasticNetworkInterfaceResponseUnmarshaller
    {
        public static UpdateElasticNetworkInterfaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateElasticNetworkInterfaceResponse updateElasticNetworkInterfaceResponse = new UpdateElasticNetworkInterfaceResponse();

			updateElasticNetworkInterfaceResponse.HttpResponse = _ctx.HttpResponse;
			updateElasticNetworkInterfaceResponse.Code = _ctx.IntegerValue("UpdateElasticNetworkInterface.Code");
			updateElasticNetworkInterfaceResponse.Message = _ctx.StringValue("UpdateElasticNetworkInterface.Message");
			updateElasticNetworkInterfaceResponse.RequestId = _ctx.StringValue("UpdateElasticNetworkInterface.RequestId");

			UpdateElasticNetworkInterfaceResponse.UpdateElasticNetworkInterface_Content content = new UpdateElasticNetworkInterfaceResponse.UpdateElasticNetworkInterface_Content();
			content.NodeId = _ctx.StringValue("UpdateElasticNetworkInterface.Content.NodeId");
			content.ElasticNetworkInterfaceId = _ctx.StringValue("UpdateElasticNetworkInterface.Content.ElasticNetworkInterfaceId");
			updateElasticNetworkInterfaceResponse.Content = content;
        
			return updateElasticNetworkInterfaceResponse;
        }
    }
}
