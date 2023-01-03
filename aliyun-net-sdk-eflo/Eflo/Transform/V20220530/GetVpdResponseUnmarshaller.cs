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
    public class GetVpdResponseUnmarshaller
    {
        public static GetVpdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVpdResponse getVpdResponse = new GetVpdResponse();

			getVpdResponse.HttpResponse = _ctx.HttpResponse;
			getVpdResponse.Code = _ctx.IntegerValue("GetVpd.Code");
			getVpdResponse.Message = _ctx.StringValue("GetVpd.Message");
			getVpdResponse.RequestId = _ctx.StringValue("GetVpd.RequestId");

			GetVpdResponse.GetVpd_Content content = new GetVpdResponse.GetVpd_Content();
			content.RegionId = _ctx.StringValue("GetVpd.Content.RegionId");
			content.VpdId = _ctx.StringValue("GetVpd.Content.VpdId");
			content.Name = _ctx.StringValue("GetVpd.Content.Name");
			content.Cidr = _ctx.StringValue("GetVpd.Content.Cidr");
			content.ServiceCidr = _ctx.StringValue("GetVpd.Content.ServiceCidr");
			content.Status = _ctx.StringValue("GetVpd.Content.Status");
			content.Description = _ctx.StringValue("GetVpd.Content.Description");
			content.Message = _ctx.StringValue("GetVpd.Content.Message");
			content.Route = _ctx.IntegerValue("GetVpd.Content.Route");
			content.NcCount = _ctx.LongValue("GetVpd.Content.NcCount");
			content.SubnetCount = _ctx.LongValue("GetVpd.Content.SubnetCount");
			content.LbCount = _ctx.LongValue("GetVpd.Content.LbCount");
			content.VccCount = _ctx.LongValue("GetVpd.Content.VccCount");
			content.GmtCreate = _ctx.StringValue("GetVpd.Content.GmtCreate");
			content.GmtModified = _ctx.StringValue("GetVpd.Content.GmtModified");
			getVpdResponse.Content = content;
        
			return getVpdResponse;
        }
    }
}
