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
    public class DeleteElasticNetworkInterfaceResponseUnmarshaller
    {
        public static DeleteElasticNetworkInterfaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteElasticNetworkInterfaceResponse deleteElasticNetworkInterfaceResponse = new DeleteElasticNetworkInterfaceResponse();

			deleteElasticNetworkInterfaceResponse.HttpResponse = _ctx.HttpResponse;
			deleteElasticNetworkInterfaceResponse.Code = _ctx.IntegerValue("DeleteElasticNetworkInterface.Code");
			deleteElasticNetworkInterfaceResponse.Message = _ctx.StringValue("DeleteElasticNetworkInterface.Message");
			deleteElasticNetworkInterfaceResponse.RequestId = _ctx.StringValue("DeleteElasticNetworkInterface.RequestId");

			DeleteElasticNetworkInterfaceResponse.DeleteElasticNetworkInterface_Content content = new DeleteElasticNetworkInterfaceResponse.DeleteElasticNetworkInterface_Content();
			content.NodeId = _ctx.StringValue("DeleteElasticNetworkInterface.Content.NodeId");
			content.ElasticNetworkInterfaceId = _ctx.StringValue("DeleteElasticNetworkInterface.Content.ElasticNetworkInterfaceId");
			deleteElasticNetworkInterfaceResponse.Content = content;
        
			return deleteElasticNetworkInterfaceResponse;
        }
    }
}
