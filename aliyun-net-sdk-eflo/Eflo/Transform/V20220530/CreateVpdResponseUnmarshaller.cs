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
    public class CreateVpdResponseUnmarshaller
    {
        public static CreateVpdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateVpdResponse createVpdResponse = new CreateVpdResponse();

			createVpdResponse.HttpResponse = _ctx.HttpResponse;
			createVpdResponse.Code = _ctx.IntegerValue("CreateVpd.Code");
			createVpdResponse.Message = _ctx.StringValue("CreateVpd.Message");
			createVpdResponse.RequestId = _ctx.StringValue("CreateVpd.RequestId");

			CreateVpdResponse.CreateVpd_Content content = new CreateVpdResponse.CreateVpd_Content();
			content.VpdId = _ctx.StringValue("CreateVpd.Content.VpdId");

			List<string> content_subnetIds = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateVpd.Content.SubnetIds.Length"); i++) {
				content_subnetIds.Add(_ctx.StringValue("CreateVpd.Content.SubnetIds["+ i +"]"));
			}
			content.SubnetIds = content_subnetIds;
			createVpdResponse.Content = content;
        
			return createVpdResponse;
        }
    }
}
